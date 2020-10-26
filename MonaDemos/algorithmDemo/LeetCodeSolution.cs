using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonaDemos.algorithmDemo
{
    /// <summary>
    /// 两数之和
    /// </summary>
    class LeetCodeSolution
    { 
        //Title: 字符串变单词数组
        // i am a student 中间有一个或多个空格，给这个字符串变成单词的数组
        //string str = "i     am   a student";
        public List<string> StringToWordAndRemoveBlank(string str)
        {
            int length = str.Length;
            List<string> arrayList = new List<string>();

            string wordOnly = "";
            for (int i = 0; i < length; i++)
            {
                if (str[i] == ' ' && !string.IsNullOrEmpty(wordOnly)) // 当遍历的当前字符是空格，且承载器不是空，向list中新加一个元素，说明是单词与单词之间的第一个空格
                {
                    arrayList.Add(wordOnly);
                    wordOnly = "";
                }
                else if (str[i] != ' ') // 当遍历的当前字符不为空，则说明当前字符为单词的一部分，直接追加到承载器里，其他情况说明是空格，且不是单词之间的第一个空格，过掉
                {
                    wordOnly = wordOnly + str[i];
                }
            }
            if (!string.IsNullOrEmpty(wordOnly)) // 当遍历完最后一个单词后，如果后面没有空格就结束，那么最后这个单词不会被加到list里，需要判断下承载器是否为空，不是空就把其中的内容加到list
            {
                arrayList.Add(wordOnly);
            }
            arrayList.ToArray();
            return arrayList;
        }


        //Title: 字符串翻转 实现1
        //hello world翻转成world hello
        public string ReverseString()
        {
            string str = "hello world";
            int length = str.Length;
            List<string> list = new List<string>();
            string word = "";
            for (int i = 0; i < length; i++)
            {
                if (str[i] == ' ')
                {
                    list.Add(word);
                    list.Add(str[i].ToString());
                    word = "";

                }
                else if (str[i] != ' ')
                {
                    word += str[i];
                }
            }
            if (!string.IsNullOrEmpty(word))
            {
                list.Add(word);
            }
            StringBuilder sb = new StringBuilder("");
            for (int i = list.Count() - 1; i > -1; i--)
            {
                sb.Append(list[i]);

            }
            return sb.ToString();
        }

        /// <summary>
        /// Title: 字符串翻转 实现2. 思路： 只需要遍历char数组中一半的元素就可以了，数组长度为奇数时中间的一个元素不需要管，而int类型除以2正好没有带上中间的元素
        /// </summary>
        /// <param name="s">char string </param>
        /// <returns>string after reversing </returns>
        public string ReverseString2(string s)
        {
            char[] chars = s.ToCharArray();
            char temp;
            int length = chars.Length;
            for (int i = 0, j = length - 1; i < length / 2; i++, j--)
            {
                temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;
            }
            return new string(chars);
        }


        //Title: 斐波那契数列 - 非递归
        //Fibonacci数列是按以下顺序排列的数字：
        //0,1,1,2,3,5,8,13,21,34,55,… 如果F0 = 0 并且 F1 = 1 那么Fn = Fn-1 + Fn-2
        public long Fib(int n) //n是数字个数
        {
            if (n < 2)
            {
                return n;
            }
            else
            {
                long[] fib = new long[n + 1];
                fib[0] = 0;
                fib[1] = 1;
                for (int i = 2; i <= n; i++)
                {
                    fib[i] = fib[i - 1] + fib[i - 2];
                    Console.WriteLine(fib[i]);
                }
                return fib[n];
            }

        }

        //Title: 斐波那契数列 - 递归实现
        //递归
        public long FibWithRecurse(int n)
        {
            if (n < 3)
            {
                return 1;
            }
            else
            {
                long result = FibWithRecurse(n - 2) + FibWithRecurse(n - 1);
                return result;
            }
        }


        //合并二叉树
        public BTreeNode<int> MergeTree(BTreeNode<int> t1, BTreeNode<int> t2)
        {
            if (t1 == null)
            {
                return t2;
            }
            if (t2 == null)
            {
                return t1;
            }

            t1.Data += t2.Data;
            t1.Lchild = MergeTree(t1.Lchild, t2.Lchild);
            t1.Rchild = MergeTree(t1.Rchild, t2.Rchild);
            return t1;
        }

        //翻转二叉树
        public BTreeNode<int> ReverseTree(BTreeNode<int> rootNode)
        {
            if (rootNode == null)
            {
                return null;
            }

            BTreeNode<int> rightPart = ReverseTree(rootNode.Rchild);
            BTreeNode<int> leftPart = ReverseTree(rootNode.Lchild);
            rootNode.Lchild = rightPart;
            rootNode.Rchild = leftPart;
            return rootNode;
        }

        //Title:两数之和
        //给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。
        //你可以假设每种输入只会对应一个答案。但是，数组中同一个元素不能使用两遍。

        //思路
        //一个简单的实现使用了两次迭代。在第一次迭代中，我们将每个元素的值和它的索引添加到表中。
        //然后，在第二次迭代中，我们将检查每个元素所对应的目标元素（target - nums[i]）是否存在于表中。注意，该目标元素不能是nums[i] 本身！
        // nums = {2,3,4,5,0,7}. target = 8
        public List<int> SumTest(int[] list, int target)
        {
            Dictionary<int, int> kvp = new Dictionary<int, int> { };
            List<int> result = new List<int> { };
            for (int i = 0; i < list.Length; i++)
            {
                kvp.Add(list[i], i);
            }
            for (int i = 0; i < list.Length; i++)
            {
                int component = target - list[i];
                int componentIndex = 0;
                if (kvp.ContainsKey(component) && kvp.TryGetValue(component, out componentIndex)) //TryGetValue: 返回dict中是否包含这个key，并且out返回key对应的value，如果没有找到key， 则返回value的数据类型的default value
                {
                    if (componentIndex != i)
                    {
                        result.Add(i);
                        result.Add(componentIndex);
                        //数组中同一个元素不能使用两遍，so找到后需要从list'中remove这两个元素
                        kvp.Remove(component);
                        kvp.Remove(list[i]);
                    }
                    else
                    {
                        Console.WriteLine("No such two element in the list!");
                    }
                }
            }
            return result;
        }

        // title: 字符串的左旋转
        //操作是把字符串前面的若干个字符转移到字符串的尾部。请定义一个函数实现字符串左旋转操作的功能。比如，输入字符串"abcdefg"和数字2，该函数将返回左旋转两位得到的结果"cdefgab"
        //思路： 1. 取当前字符串的长度。旋转的数字<= 长度，2. 添加非旋转部分到新的array中， 再添加旋转的部分到新的array尾部
        public string LeftTurnStringTest(string strOrigin, int turnAmount)
        {
            char[] charArr = strOrigin.ToCharArray();

            StringBuilder result = new StringBuilder();
            for (int i = turnAmount; i < strOrigin.Length; i++)
            {
                result.Append(charArr[i]);
            }
            for (int i = 0; i < turnAmount; i++)
            {
                result.Append(charArr[i]);
            }
            return result.ToString();
        }

        //Title: 移动0
        //给定一个数组 nums，编写一个函数将所有 0 移动到数组的末尾，同时保持非零元素的相对顺序。
        //思路： 只要有0就执行一次remove操作，同时i+1计数。最后加上i个0即可。
        //必须在原数组上操作，不能拷贝额外的数组。尽量减少操作次数。
        public void MoveZero(List<int> nums)
        {
            for (int i = 0; i < nums.Count(); i++)
            {
                if (nums[i] == 0)
                {
                    nums.Remove(nums[i]);
                    nums.Add(0);
                }
            }

            int[] numsArray = nums.ToArray();
            string res = string.Join(",", numsArray);
            Console.WriteLine(res);
        }

        //Title: 单链表删除中间节点
        //实现一种算法，删除单向链表中间的某个节点（即不是第一个或最后一个节点），假定你只能访问该节点。
        // 思路： 方法是用要删除节点的下一个位置，去替代要删除的节点
        public void DeleteMiddleNode(LinkListNode linkList, LinkListNode node)
        {
            node.Next = node.Next.Next;
            node.Data = node.Next.Data;
        }

        //Title: 有效的括号
        //给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串，判断字符串是否有效。
        //有效字符串需满足：左括号必须用相同类型的右括号闭合。左括号必须以正确的顺序闭合。注意空字符串可被认为是有效字符串。
        //思路： 栈
        //判断括号的有效性可以使用「栈」这一数据结构来解决。
        //我们对给定的字符串 ss 进行遍历，当我们遇到一个左括号时，我们会期望在后续的遍历中，有一个相同类型的右括号将其闭合。由于后遇到的左括号要先闭合，因此我们可以将这个左括号放入栈顶。
        //当我们遇到一个右括号时，我们需要将一个相同类型的左括号闭合。此时，我们可以取出栈顶的左括号并判断它们是否是相同类型的括号。如果不是相同的类型，或者栈中并没有左括号，那么字符串 ss 无效，返回 \text{False}
        //为了快速判断括号的类型，我们可以使用哈希映射（HashMap）存储每一种括号。哈希映射的键为右括号，值为相同类型的左括号。
        //在遍历结束后，如果栈中没有左括号，说明我们将字符串 ss 中的所有左括号闭合，返回 \text{True}
        //True，否则返回 \text{False}False。
        //注意到有效字符串的长度一定为偶数，因此如果字符串的长度为奇数，我们可以直接返回 \text{False}False，省去后续的遍历判断过程。
        public bool isKuoHaoValid(String s)
        {
            //只有偶数个字符才能有效
            if (s.Length % 2 == 0)
            {
                var c = s.ToCharArray();
                Stack<char> stack = new Stack<char>();
                char charItem;
                for (int i = 0; i < s.Length; i++)
                {
                    charItem = c[i];
                    if (charItem == '(' || charItem == '[' || charItem == '{')
                    {
                        //向栈顶添加
                        stack.Push(charItem);
                    }
                    else if (charItem == ')')
                    {
                        // peek: 获取栈顶数据;    Pop: 移除并返回栈顶数据
                        if (stack.Count() != 0 && stack.Peek() == '(') { stack.Pop(); }
                        else { return false; }
                    }
                    else if (charItem == '}')
                    {
                        if (stack.Count() != 0 && stack.Peek() == '{') { stack.Pop(); }
                        else { return false; }
                    }
                    else
                    {
                        if (stack.Count() != 0 && stack.Peek() == '[') { stack.Pop(); }
                        else { return false; }
                    }
                }
                //遍历结束后，栈中没有左括号，说明string中括号全部有效
                bool status = stack.Count() == 0 ? true : false;
                return status;
            }

            return false;
        }


        //Title: 记录字符出现次数
        //一个字符串，记录每个字符出现的次数，console打出 字符名- 出现次数
        // 思路：1、将输入的字符串拆分成字符数组
        // 2、创建一个键值对数组dic
        // 3、循环字符数组中的每个字符，并用键值对判断字符是否存在；如果存在，则把dic的值+1，如果不存在，则添加此字符到dic的键，并将dic的值初始化1
        public void CountCharInString(string s)
        {
            char[] charArray = s.ToCharArray();
            Dictionary<char, int> kvp = new Dictionary<char, int> { };
            int count = 0;
            for (int i = 0; i < charArray.Count(); i++)
            {
                if (kvp.ContainsKey(charArray[i]))
                {
                    kvp.TryGetValue(charArray[i], out count);
                    count += 1; //更改计数器的值 +1
                    kvp[charArray[i]] = count;
                }
                else
                {
                    kvp.Add(charArray[i], 1);
                }
            }
            foreach (var i in kvp)
            {
                Console.WriteLine("Char = " + i.Key + ", AppearTotalCount = " + i.Value);
            }
        }
    }
}
