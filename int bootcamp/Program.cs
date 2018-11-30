using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace int_bootcamp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Program p = new Program();
            ////p.reverse();
        }

        #region reverse_string
        public string reverse_string(string str)
        {
            string rtn = string.Empty;
            //char[] c = str.ToCharArray();
            //Array.Reverse(c);
            //rtn = new string(c);

            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    rtn += str[i];
            //}

            foreach (char c in str)
            {
                rtn = c + rtn;
            }
            return rtn;
        }
        #endregion

        #region palindorem
        public bool palindorem(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i]) return false;
            }
            return true;
        }
        #endregion

        #region reverse_int
        public int reverse_int(int i)
        {
            int flag = Math.Sign(i);
            int val = Math.Abs(i);
            int rtn = 0;
            //if (i >= 0)
            //    flag = 1;

            //char[] c = Math.Abs(i).ToString().ToArray();
            //Array.Reverse(c);

            //return Math.Sign(i) * Convert.ToInt32(new string(c));

            while (val > 0)
            {
                int last = val % 10;
                rtn = (rtn * 10) + last;
                val = val / 10;
            }

            return flag * rtn;
        }
        #endregion

        #region maxchar
        public char maxchar(string s)
        {
            IDictionary<char, int> d = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (d.ContainsKey(c))
                    d[c]++;
                else
                    d.Add(c, 1);
            }

            return d.FirstOrDefault(x => x.Value == d.Values.Max()).Key;
        }
        #endregion

        #region fizzbuzz
        public IList<string> fizzbuzz(int i)
        {
            IList<string> rtn = new List<string>();

            for (int j = 1; j <= i; j++)
            {
                string temp = string.Empty;
                if (j % 3 == 0)
                    temp += "fizz";
                if (j % 5 == 0)
                    temp += "buzz";
                if (string.IsNullOrWhiteSpace(temp))
                    temp = j.ToString();
                rtn.Add(temp);
            }

            return rtn;
        }
        #endregion

        #region chuck
        public List<IList<int>> chuck(int[] arr, int i)
        {
            List<IList<int>> rtn = new List<IList<int>>();
            IList<int> tmp = new List<int>();

            if (i >= arr.Length)
                rtn.Add(arr);
            else
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    tmp.Add(arr[j]);
                    if ((j + 1) % i == 0)
                    {
                        rtn.Add(tmp.ToList());
                        tmp.Clear();
                    }
                }
            }
            if (tmp.Count > 0)
                rtn.Add(tmp);
            return rtn;
        }
        #endregion

        #region anagrams
        public bool anagrams(string a, string b)
        {
            String result1 = Regex.Replace(a, @"[^A-Za-z]+", "").ToLower();
            String result2 = Regex.Replace(b, @"[^A-Za-z]+", "").ToLower();
            char[] c1 = result1.ToArray();
            char[] c2 = result2.ToArray();

            Array.Sort(c1);
            Array.Sort(c2);

            return Enumerable.SequenceEqual(c1, c2);
        }
        #endregion

        #region capitalize
        public string capitalize(string str)
        {
            IList<string> rtn = new List<string>();
            //bool flag = false;
            //foreach(char c in str)
            //{
            //    if (char.IsPunctuation(c) || char.IsWhiteSpace(c))
            //    {
            //        flag = true;
            //    }
            //    else
            //    {
            //        if (flag || rtn.Length == 0)
            //        {
            //            flag = false;
            //            rtn.Append(char.ToUpper(c));
            //            continue;
            //        }
            //    }
            //    rtn.Append(c);
            //}


            foreach (string s in str.Split(' '))
            {
                rtn.Add(s[0].ToString().ToUpper() + s.Substring(1, s.Length - 1));
            }

            return String.Join(" ", rtn.ToArray());
        }
        #endregion

        #region steps
        public IList<string> steps(int i)
        {
            IList<string> rtn = new List<string>();

            for (int j = 0; j < i; j++)
            {
                string s = string.Empty;
                for (int k = 0; k < i; k++)
                {
                    if (k < j + 1)
                        s += "#";
                    else
                        s += " ";
                }
                rtn.Add(s);
            }

            return rtn;
        }
        #endregion

        #region pyramid
        public IList<string> pyramid(int i)
        {
            IList<string> rtn = new List<string>();
            int mid = Convert.ToInt32((i * 2 - 1) / 2);
            //for (int j = 0; j < i; j++)
            //{
            //    string tmp = string.Empty;
            //    for (int row = 0; row < i - j - 1; row++)
            //        tmp += "*";

            //    for (int row = 0; row < (j + 1) * 2 - 1; row++)
            //        tmp += "#";

            //    for (int row = 0; row < i - j - 1; row++)
            //        tmp += "*";

            //    rtn.Add(tmp);
            //}

            for (int j = 0; j < i; j++)
            {
                string tmp = string.Empty;
                for (int k = 0; k < i * 2 - 1; k++)
                {
                    if (mid - j <= k && mid + j >= k)
                        tmp += "#";
                    else
                        tmp += " ";
                }
                rtn.Add(tmp);
            }


            foreach (string s in rtn)
                Console.WriteLine(s);

            return rtn;
        }
        #endregion

        #region vowels
        public int vowels(string s)
        {
            int rtn = 0;
            string ss = "aeiou";
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            foreach (char c in s.ToLower())
            {
                if (ss.Contains(c))
                    rtn++;
            }

            return rtn;
        }
        #endregion

        #region matrix
        public int[][] matrix(int n)
        {
            int[][] rtn = new int[n][];

            for (int i = 0; i < n; i++)
            {
                rtn[i] = new int[n];
            }

            int counter = 1;
            int startColumn = 0;
            int endColumn = n - 1;
            int startRow = 0;
            int endRow = n - 1;
            while (startColumn <= endColumn && startRow <= endRow)
            {
                // top row
                for (int i = startColumn; i <= endColumn; i++)
                {
                    rtn[startRow][i] = counter;
                    counter++;
                }
                startRow++;

                //right column
                for (int i = startRow; i <= endRow; i++)
                {
                    rtn[i][endColumn] = counter;
                    counter++;
                }
                endColumn--;

                //bottom row
                for (int i = endColumn; i >= startColumn; i--)
                {
                    rtn[endRow][i] = counter;
                    counter++;
                }
                endRow--;

                //left column
                for (int i = endRow; i >= startRow; i--)
                {
                    rtn[i][startColumn] = counter;
                    counter++;
                }
                startColumn++;
            }
            return rtn;
        }
        #endregion

        #region fib
        public int fib(int n, IDictionary<int, int> arr)
        {
            if (n < 2)
                return n;

            if (arr.ContainsKey(n))
                return arr[n];

            int f = fib(n - 1, arr) + fib(n - 2, arr);
            arr[n] = f;

            return f;
        }
        #endregion

        #region queue
        public class MyQueue<T>
        {
            private IList<T> _queue;

            public MyQueue()
            {
                if (_queue == null) _queue = new List<T>();
            }
            public MyQueue(IList<T> queue)
            {
                if (queue != null) _queue = queue;
            }

            public void Add(T obj)
            {
                _queue.Insert(0, obj);
            }

            public T Remove()
            {
                T rtn = Peek();
                _queue.RemoveAt(_queue.Count - 1);
                return rtn;
            }

            public T Peek()
            {
                T rtn;
                if (_queue.Count > 0)
                    rtn = _queue[_queue.Count - 1];
                else
                    rtn = default(T);
                return rtn;
            }

            public int Count()
            {
                return _queue.Count;
            }
        }
        #endregion

        #region weave
        public MyQueue<string> weave(MyQueue<string> q1, MyQueue<string> q2)
        {
            MyQueue<string> rtn = new MyQueue<string>();
            while (!string.IsNullOrWhiteSpace(q1.Peek()) || !string.IsNullOrWhiteSpace(q2.Peek()))
            {
                if (!string.IsNullOrWhiteSpace(q1.Peek()))
                {
                    rtn.Add(q1.Remove());
                }
                if (!string.IsNullOrWhiteSpace(q2.Peek()))
                {
                    rtn.Add(q2.Remove());
                }
            }
            return rtn;
        }
        #endregion

        #region stack
        public class MyStack<T>
        {
            private IList<T> _stack;
            public MyStack()
            {
                if (_stack == null) _stack = new List<T>();
            }

            public void Push(T obj)
            {
                _stack.Add(obj);
            }

            public T Pop()
            {
                T rtn = Peek();
                _stack.RemoveAt(_stack.Count - 1);
                return rtn;
            }

            public T Peek()
            {
                T rtn;
                if (_stack.Count > 0)
                    rtn = _stack[_stack.Count - 1];
                else
                    rtn = default(T);
                return rtn;
            }
        }
        #endregion

        #region qfroms
        public class MyQueenFromStack<T>
        {
            private MyStack<T> s1;
            private MyStack<T> s2;

            public MyQueenFromStack()
            {
                if (s1 == null) s1 = new MyStack<T>();
                if (s2 == null) s2 = new MyStack<T>();
            }

            public void Add(T obj)
            {
                s1.Push(obj);
            }

            public T Remove()
            {
                move(s1, s2);
                T rtn = s2.Peek();
                s2.Pop();
                move(s2, s1);
                return rtn;
            }

            public T Peek()
            {
                move(s1, s2);
                T rtn = s2.Peek();
                move(s2, s1);
                return rtn;
            }

            private void move(MyStack<T> s1, MyStack<T> s2)
            {
                while (s1.Peek() != null)
                {
                    s2.Push(s1.Pop());
                }
            }
        }
        #endregion

        #region linkedlist
        public class MyNode<T>
        {
            public T data;
            public MyNode<T> next;

            public MyNode(T data, MyNode<T> n = null)
            {
                this.data = data;
                this.next = n;
            }
        }

        public class MyLinkedList<T>
        {
            public MyNode<T> head;
            private int size;
            public MyLinkedList()
            {
                head = null;
                size = 0;
            }

            public void InsertFirst(T data)
            {
                head = new MyNode<T>(data, head);
                size++;
            }

            public int Size()
            {
                return size;
            }

            public MyNode<T> GetFirst()
            {
                return head;
            }

            public MyNode<T> GetLast()
            {
                MyNode<T> tmp = this.head;
                while (tmp.next != null)
                {
                    tmp = tmp.next;
                }

                return tmp;
            }

            public void Clear()
            {
                head = null;
                size = 0;
            }

            public void RemoveFirst()
            {
                head = head.next;
                size--;
            }

            public void RemoveLast()
            {
                if (head == null || head.next == null)
                {
                    head = null;
                    return;
                }

                MyNode<T> tmp = head;
                MyNode<T> pre = tmp;
                while (tmp.next != null)
                {
                    pre = tmp;
                    tmp = tmp.next;
                }
                pre.next = null;
                //head = pre;
                size--;
            }

            public void InsertLast(T data)
            {
                MyNode<T> newNode = new MyNode<T>(data);
                if (head == null)
                {
                    head = newNode;
                    return;
                }
                MyNode<T> tmp = GetLast();
                tmp.next = newNode;
                size++;
            }

            public MyNode<T> GetAt(int index)
            {
                if (Size() - 1 < index)
                    return null;
                MyNode<T> tmp = head;
                while (index > 0)
                {
                    tmp = tmp.next;
                    index--;
                }

                return tmp;
            }

            public void RemoveAt(int index)
            {
                if (Size() - 1 < index)
                    return;
                if (index == 0)
                {
                    RemoveFirst();
                    return;
                }
                if (index == Size() - 1)
                {
                    RemoveLast();
                    return;
                }

                MyNode<T> tmp = GetAt(index);
                MyNode<T> pre = GetAt(index - 1);
                pre.next = tmp.next;
                size--;
            }

            public void InsertAt(T data, int index)
            {
                MyNode<T> node = new MyNode<T>(data);

                if (Size() - 1 < index)
                    return;
                if (index == 0)
                {
                    InsertFirst(data);
                    return;
                }
                if (index >= Size())
                {
                    InsertLast(data);
                    return;
                }

                MyNode<T> tmp = GetAt(index);
                MyNode<T> nxt = GetAt(index - 1);
                nxt.next = node;
                node.next = tmp;
                size++;
            }

            public void ForEach(Func<MyNode<T>, int, int> func)
            {
                MyNode<T> node = head;
                int counter = 0;
                while (node != null)
                {
                    func(node, counter);
                    node = node.next;
                    counter++;
                }
            }
        }
        #endregion

        #region midpoint
        public MyNode<T> midpoint<T>(MyLinkedList<T> l)
        {
            MyNode<T> slow = l.head;
            MyNode<T> fast = l.head;

            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        }
        #endregion

        #region circular
        public bool circular<T>(MyLinkedList<T> lst)
        {
            MyNode<T> slow = lst.head;
            MyNode<T> fast = lst.head;

            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow.Equals(fast))
                    return true;
            }

            return false;
        }
        #endregion

        #region fromlast
        public MyNode<T> fromlast<T>(MyLinkedList<T> lst, int index)
        {
            MyNode<T> slow = lst.GetFirst();
            MyNode<T> fast = lst.head;

            for (int i = 0; i < index; i++)
            {
                fast = fast.next;
            }
            while (fast.next != null)
            {
                slow = slow.next;
                fast = fast.next;
            }

            return slow;
        }
        #endregion

        #region tree
        public class MyTreeNode<T>
        {
            public T data;
            public List<MyTreeNode<T>> children;

            public MyTreeNode(T data)
            {
                this.data = data;
                this.children = new List<MyTreeNode<T>>();
            }

            public void Add(T data)
            {
                this.children.Add(new MyTreeNode<T>(data));
            }

            public void remove(T data)
            {
                children.RemoveAll(x => x.data.Equals(data));
            }
        }

        public class MyTree<T>
        {
            public MyTreeNode<T> root;

            public MyTree()
            {
                root = null;
            }

            public IList<T> TraverseBF()
            {
                IList<T> rtn = new List<T>();
                rtn.Add(root.data);
                Queue<MyTreeNode<T>> q = new Queue<MyTreeNode<T>>();
                q.Enqueue(root);
                while (q.Count > 0)
                {
                    var n = q.Dequeue();
                    foreach (var child in n.children)
                    {
                        q.Enqueue(child);
                        rtn.Add(child.data);
                    }
                }
                return rtn;
            }

            public IList<T> TraverseDF()
            {
                IList<T> rtn = new List<T>();
                rtn.Add(root.data);
                dfs(root, rtn);
                return rtn;
            }

            void dfs(MyTreeNode<T> node, IList<T> rtn)
            {
                foreach (var n in node.children)
                {
                    rtn.Add(n.data);
                    dfs(n, rtn);
                }
            }
        }
        #endregion

        #region levelwidth
        public int[] LevelWidth<T>(MyTreeNode<T> node)
        {
            IList<MyTreeNode<T>> lst = new List<MyTreeNode<T>>();
            MyTreeNode<T> last = new MyTreeNode<T>(default(T));
            lst.Add(node);
            lst.Insert(lst.Count, last);

            IList<int> rtn = new List<int>();
            rtn.Add(0);
            while (lst.Count > 1)
            {
                MyTreeNode<T> n = lst[0];
                lst.RemoveAt(0);

                if (n == last)
                {
                    rtn.Add(0);
                    lst.Insert(lst.Count, last);
                }
                else
                {
                    foreach (var child in n.children)
                    {
                        lst.Insert(lst.Count, child);
                    }
                    rtn[rtn.Count - 1]++;
                }
            }
            return rtn.ToArray();
        }
        #endregion

        #region bst
        public class MybstNode<T>
        {
            public T data { get; set; }
            public MybstNode<T> left { get; set; }
            public MybstNode<T> right { get; set; }

            public MybstNode(T data)
            {
                this.data = data;
                left = null;
                right = null;
            }

            public void Insert(T data)
            {
                if (Comparer<T>.Default.Compare(this.data, data) > 0 && left != null)
                {
                    left.Insert(data);
                }
                else if (Comparer<T>.Default.Compare(this.data, data) > 0)
                {
                    left = new MybstNode<T>(data);
                }
                else if (Comparer<T>.Default.Compare(this.data, data) < 0 && right != null)
                {
                    right.Insert(data);
                }
                else if (Comparer<T>.Default.Compare(this.data, data) < 0)
                {
                    right = new MybstNode<T>(data);
                }
            }

            public MybstNode<T> Contains(T data)
            {
                if (Equals(this.data, data))
                {
                    return this;
                }

                if (Comparer<T>.Default.Compare(this.data, data) > 0 && left != null)
                {
                    return left.Contains(data);
                }
                else if (Comparer<T>.Default.Compare(this.data, data) < 0 && right != null)
                {
                    return right.Contains(data);
                }
                else
                {
                    return null;
                }
            }
        }
        #endregion

        #region validate
        public bool validate(MybstNode<int> node, int? min = null, int? max = null)
        {
            if (max != null && node.data > max)
                return false;

            if (min != null && node.data < min)
                return false;

            if (node.left != null && !validate(node.left, min, node.data))
                return false;

            if (node.right != null && !validate(node.right, node.data, max))
                return false;

            return true;
        }
        #endregion

        #region sorting
        public void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = tmp;
                    }
                }
            }
        }

        public void SelectionSort(int[] arr)
        {
            Array.Sort(arr);
        }
        #endregion 
    }
}
