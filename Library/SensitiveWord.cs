using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    using System.Collections.Generic;
    using System.Linq;
    using System;
    using Library.ContentSafe.SensitiveWord;

    namespace ContentSafe.SensitiveWord
    {
        public class WordsLibrary
        {
            /// <summary>
            /// 词库树结构类
            /// </summary>
            public class ItemTree
            {
                public char Item { get; set; }
                public bool IsEnd { get; set; }
                public List<ItemTree> Child { get; set; }
            }

            /// <summary>
            /// 词库树
            /// </summary>
            public ItemTree Library { get; private set; }

            /// <summary>
            /// 敏感词组
            /// </summary>
            public string[] Words { get; protected set; }

            public WordsLibrary(string[] words)
            {
                Words = words; 
                Init();
            }

            private void Init()
            {
                if (Words == null)
                    Words = new[] { "" };

                Library = new ItemTree() { Item = 'R', IsEnd = false, Child = CreateTree(Words) };
            }

            /// <summary>
            /// 创建词库树
            /// </summary>
            /// <param name="words">敏感词组</param>
            /// <returns></returns>
            private List<ItemTree> CreateTree(string[] words)
            {
                List<ItemTree> tree = null;

                if (words != null && words.Length > 0)
                {
                    tree = new List<ItemTree>();

                    foreach (var item in words)
                        if (!string.IsNullOrEmpty(item))
                        {
                            char cha = item[0];

                            ItemTree node = tree.Find(e => e.Item == cha);
                            if (node != null)
                                AddChildTree(node, item);
                            else
                                tree.Add(CreateSingleTree(item));
                        }
                }

                return tree;
            }

            /// <summary>
            /// 创建单个完整树
            /// </summary>
            /// <param name="word">单个敏感词</param>
            /// <returns></returns>
            private ItemTree CreateSingleTree(string word)
            {
                //根节点，此节点 值为空
                ItemTree root = new ItemTree();
                //移动 游标
                ItemTree p = root;

                for (int i = 0; i < word.Length; i++)
                {
                    ItemTree child = new ItemTree() { Item = word[i], IsEnd = false, Child = null };
                    p.Child = new List<ItemTree>() { child };
                    p = child;
                }
                p.IsEnd = true;

                return root.Child.First();
            }

            /// <summary>
            /// 附加分支子树
            /// </summary>
            /// <param name="childTree">子树</param>
            /// <param name="word">单个敏感词</param>
            private void AddChildTree(ItemTree childTree, string word)
            {
                //移动 游标
                ItemTree p = childTree;

                for (int i = 1; i < word.Length; i++)
                {
                    char cha = word[i];
                    List<ItemTree> child = p.Child;

                    if (child == null)
                    {
                        ItemTree node = new ItemTree() { Item = cha, IsEnd = false, Child = null };
                        p.Child = new List<ItemTree>() { node };
                        p = node;
                    }
                    else
                    {
                        ItemTree node = child.Find(e => e.Item == cha);
                        if (node == null)
                        {
                            node = new ItemTree() { Item = cha, IsEnd = false, Child = null };
                            child.Add(node);
                            p = node;
                        }
                        else
                            p = node;
                    }
                }
                p.IsEnd = true;
            }
        }
    }

    /// <summary>
    /// 敏感词检测
    /// </summary>
    public class ContentCheck
    {
        public string Text { private get; set; }

        /// <summary>
        /// 敏感词库 词树
        /// </summary>
        public WordsLibrary.ItemTree Library { private get; set; }
        private byte JumpCharacter = 0;

        private byte CurrentJump = 0;

        /// <summary>
        /// 敏感词检测
        /// </summary>
        private ContentCheck() { }

        /// <summary>
        /// 敏感词检测
        /// </summary>
        /// <param name="library">敏感词库</param>
        public ContentCheck(WordsLibrary library)
        {
            if (library.Library == null)
                throw new Exception("敏感词库未初始化");

            Library = library.Library;
        }

        /// <summary>
        /// 敏感词检测
        /// </summary>
        /// <param name="library">敏感词库</param>
        /// <param name="text">检测文本</param>
        public ContentCheck(WordsLibrary library, string text, byte jump = 0) : this(library)
        {
            if (text == null)
                throw new Exception("检测文本不能为null");

            Text = text;
            JumpCharacter = jump;
        }

        /// <summary>
        /// 检测敏感词
        /// </summary>
        /// <param name="text">检测文本</param>
        /// <returns></returns>
        private Dictionary<int, char> WordsCheck(string text)
        {
            if (Library == null)
                throw new Exception("未设置敏感词库 词树");

            Dictionary<int, char> dic = new Dictionary<int, char>();
            WordsLibrary.ItemTree p = Library;
            List<int> indexs = new List<int>();
            CurrentJump = 0;

            for (int i = 0, j = 0; j < text.Length; j++)
            {
                char cha = text[j];
                var child = p.Child;

                var node = child.Find(e => e.Item == cha);
                if (node != null)
                {
                    CurrentJump = 0;
                    indexs.Add(j);
                    if (node.IsEnd || node.Child == null)
                    {
                        if (node.Child != null)
                        {
                            int k = j + 1;
                            if (k < text.Length && node.Child.Exists(e => e.Item == text[k]))
                            {
                                p = node;
                                continue;
                            }
                        }

                        foreach (var item in indexs)
                            dic.Add(item, text[item]);

                        indexs.Clear();
                        p = Library;
                        i = j;
                        ++i;
                    }
                    else
                        p = node;
                }
                else
                {
                    if (indexs.Count > 0)
                        CurrentJump++;

                    if (CurrentJump > JumpCharacter)
                    {
                        CurrentJump = 0;
                        indexs.Clear();
                        if (p.GetHashCode() != Library.GetHashCode())
                        {
                            j = i;
                            ++i;
                            p = Library;
                        }
                        else
                            i = j;
                    }
                }
            }

            return dic;
        }

        /// <summary>
        /// 替换敏感词
        /// </summary>
        /// <param name="library">敏感词库</param>
        /// <param name="text">检测文本</param>
        /// <param name="newChar">替换字符</param>
        /// <returns></returns>
        public static string SensitiveWordsReplace(WordsLibrary library, string text, char newChar = '*')
        {
            Dictionary<int, char> dic = new ContentCheck(library).WordsCheck(text);
            if (dic != null && dic.Keys.Count > 0)
            {
                char[] chars = text.ToCharArray();
                foreach (var item in dic)
                    chars[item.Key] = newChar;

                text = new string(chars);
            }

            return text;
        }

        /// <summary>
        /// 替换敏感词
        /// </summary>
        /// <param name="text">检测文本</param>
        /// <param name="newChar">替换字符</param>
        /// <returns></returns>
        public string SensitiveWordsReplace(string text, char newChar = '*')
        {
            Dictionary<int, char> dic = WordsCheck(text);
            if (dic != null && dic.Keys.Count > 0)
            {
                char[] chars = text.ToCharArray();
                foreach (var item in dic)
                    chars[item.Key] = newChar;

                text = new string(chars);
            }

            return text;
        }

        /// <summary>
        /// 替换敏感词
        /// </summary>
        /// <param name="newChar">替换字符</param>
        /// <returns></returns>
        public string SensitiveWordsReplace(char newChar = '*')
        {
            if (Text == null)
                throw new Exception("未设置检测文本");

            return SensitiveWordsReplace(Text, newChar);
        }

        /// <summary>
        /// 查找敏感词
        /// </summary>
        /// <param name="library">敏感词库</param>
        /// <param name="text">检测文本</param>
        /// <returns></returns>
        public static List<string> FindSensitiveWords(WordsLibrary library, string text)
        {
            ContentCheck check = new ContentCheck(library, text);
            return check.FindSensitiveWords();
        }

        /// <summary>
        /// 查找敏感词
        /// </summary>
        /// <param name="text">检测文本</param>
        /// <returns></returns>
        public List<string> FindSensitiveWords(string text)
        {
            Dictionary<int, char> dic = WordsCheck(text);
            if (dic != null && dic.Keys.Count > 0)
            {
                int i = -1;
                string str = "";
                List<string> list = new List<string>();
                foreach (var item in dic)
                {
                    if (i == -1 || i + 1 == item.Key)
                        str += item.Value;
                    else
                    {
                        list.Add(str);
                        str = "" + item.Value;
                    }

                    i = item.Key;
                }
                list.Add(str);

                return list.Distinct().ToList();
            }
            else
                return new List<string>();
        }

        /// <summary>
        /// 查找敏感词
        /// </summary>
        /// <returns></returns>
        public List<string> FindSensitiveWords()
        {
            if (Text == null)
                throw new Exception("未设置检测文本");

            return FindSensitiveWords(Text);
        }
    }
}
