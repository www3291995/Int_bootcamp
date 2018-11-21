using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using int_bootcamp;
using System.Collections.Generic;
using System.Linq;

namespace int_bootcamp_test
{
    [TestClass]
    public class UnitTest1
    {
        Program p = new Program();
        [TestMethod]
        public void Test_reverse()
        {
            string a1 = "abcd";
            string a2 = "dcba";
           
            string a3 = p.reverse_string(a1);

            Assert.AreEqual(a2, a3);

            string a4 = "   abcd";
            string a5 = "dcba   ";

            string a6 = p.reverse_string(a4);

            Assert.AreEqual(a6, a5);
        }

        [TestMethod]
        public void Test_palindrome()
        {
            string s1 = "abba";
            Assert.IsTrue(p.palindorem(s1));

            string s2 = "abcdefg";
            Assert.IsFalse(p.palindorem(s2));

            Assert.IsTrue(p.palindorem("1000000001"));
        }

        [TestMethod]
        public void Test_reverseint()
        {
            int i1 = 123;
            int i2 = 321;
            Assert.AreEqual(i2, p.reverse_int(i1));

            int i3 = -541;
            int i4 = -145;
            Assert.AreEqual(i4, p.reverse_int(i3));

            Assert.AreEqual(9, p.reverse_int(90));
        }

        [TestMethod]
        public void Test_maxchar()
        {
            Assert.AreEqual('a', p.maxchar("abcdefghijklmnaaaaa"));
            Assert.AreEqual('1', p.maxchar("ab1c1d1e1f1g1"));
        }

        [TestMethod]
        public void Test_fizzbuzz()
        {
            IList<string> l = new List<string>();
            
l = p.fizzbuzz(15);
            Assert.AreEqual("1", l[0]);
            Assert.AreEqual("2", l[1]);
            Assert.AreEqual("fizz", l[2]);
            Assert.AreEqual("4", l[3]);
            Assert.AreEqual("buzz", l[4]);
            Assert.AreEqual("fizz", l[5]);
            Assert.AreEqual("7", l[6]);
            Assert.AreEqual("8", l[7]);
            Assert.AreEqual("fizz", l[8]);
            Assert.AreEqual("buzz", l[9]);
            Assert.AreEqual("11", l[10]);
            Assert.AreEqual("fizz", l[11]);
            Assert.AreEqual("13", l[12]);
            Assert.AreEqual("14", l[13]);
            Assert.AreEqual("fizzbuzz", l[14]);
        }

        [TestMethod]
        public void Test_chuck()
        {
            List<IList<int>> tmp = new List<IList<int>>();
            tmp.Add(new List<int>() { 1, 2 });
            tmp.Add(new List<int>() { 3, 4 });
            tmp.Add(new List<int>() { 5, 6 });
            tmp.Add(new List<int>() { 7, 8 });
            tmp.Add(new List<int>() { 9, 10 });
            p.chuck(new int[] { 1, 2, 3, 4, 5 }, 2);
            //CollectionAssert.AreEqual(tmp, p.chuck(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 2));

        }

        [TestMethod]
        public void Test_anagrams()
        {
            Assert.IsTrue(p.anagrams("hello", "llohe"));
            Assert.IsTrue(p.anagrams("Whoa! Hi!", "Hi! Whoa!"));
            Assert.IsFalse(p.anagrams("One One", "Two two two"));
            Assert.IsTrue(p.anagrams("RAIL! SAFETY!", "fairy tales"));
        }

        [TestMethod]
        public void Test_capitalize()
        {
            Assert.AreEqual("A Short Sentence", p.capitalize("a short sentence"));
            Assert.AreEqual("A Lazy Fox", p.capitalize("a lazy fox"));
            Assert.AreEqual("I Love Breakfast At Bill Miller Bbq", p.capitalize("i love breakfast at bill miller bbq"));
        }

        [TestMethod]
        public void Test_steps()
        {
            IList<string> lst = p.steps(4);
            Assert.AreEqual("#   ", lst[0]);
            Assert.AreEqual("##  ", lst[1]);
            Assert.AreEqual("### ", lst[2]);
            Assert.AreEqual("####", lst[3]);
            Assert.AreEqual(4, lst.Count);

            IList<string> lst1 = p.steps(1);
            Assert.AreEqual("#", lst1[0]);
            Assert.AreEqual(1, lst1.Count);
        }

        [TestMethod]
        public void Test_pyramid()
        {
            p.pyramid(10);
        }

        [TestMethod]
        public void Test_vowels()
        {
            Assert.AreEqual(5, p.vowels("aeiou"));
            Assert.AreEqual(5, p.vowels("AEIOU"));
            Assert.AreEqual(5, p.vowels("abcdefghijklmnopqrstuvwxyz"));
            Assert.AreEqual(0, p.vowels("bcdfghjkl"));
        }

        [TestMethod]
        public void Test_matrix()
        {
            int[][] res = p.matrix(4);
            CollectionAssert.AreEqual(new int[4] { 1, 2, 3, 4 }, res[0]);
            CollectionAssert.AreEqual(new int[4] { 12, 13, 14, 5 }, res[1]);
            CollectionAssert.AreEqual(new int[4] { 11, 16, 15, 6 }, res[2]);
            CollectionAssert.AreEqual(new int[4] { 10, 9, 8, 7 }, res[3]);
        }

        [TestMethod]
        public void Test_fib()
        {
            Assert.AreEqual(63245986, p.fib(39, new Dictionary<int,int>()));
        }

        [TestMethod]
        public void Test_queue()
        {
            Program.MyQueue<int> queue = new Program.MyQueue<int>();
            queue.Add(1);
            Assert.AreEqual(1, queue.Remove());

            queue.Add(1);
            queue.Add(2);
            queue.Add(3);
            Assert.AreEqual(1, queue.Remove());
            Assert.AreEqual(2, queue.Remove());
            Assert.AreEqual(3, queue.Remove());
        }

        [TestMethod]
        public void Test_weave()
        {
            Program.MyQueue<string> q1 = new Program.MyQueue<string>();
            q1.Add("1");
            q1.Add("2");
            q1.Add("3");
            q1.Add("4");

            Program.MyQueue<string> q2 = new Program.MyQueue<string>();
            q2.Add("one");
            //q2.Add("two");
            //q2.Add("three");
            //q2.Add("four");

            Program.MyQueue<string> q3 = p.weave(q1, q2);
            Assert.AreEqual("1", q3.Remove());
            Assert.AreEqual("one", q3.Remove());
            Assert.AreEqual("2", q3.Remove());
            //Assert.AreEqual("two", q3.Remove());
            Assert.AreEqual("3", q3.Remove());
            //Assert.AreEqual("three", q3.Remove());
            Assert.AreEqual("4", q3.Remove());
            //Assert.AreEqual("four", q3.Remove());
        }

        [TestMethod]
        public void Test_stack()
        {
            Program.MyStack<int> s = new Program.MyStack<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);

            Assert.AreEqual(3, s.Pop());
            Assert.AreEqual(2, s.Pop());
            Assert.AreEqual(1, s.Pop());
        }

        [TestMethod]
        public void Test_qfroms()
        {
            Program.MyQueenFromStack<string> queue = new Program.MyQueenFromStack<string>();
            queue.Add("1");
            Assert.AreEqual("1", queue.Remove());

            queue.Add("1");
            queue.Add("2");
            queue.Add("3");
            Assert.AreEqual("1", queue.Remove());
            Assert.AreEqual("2", queue.Remove());
            Assert.AreEqual("3", queue.Remove());
        }

        [TestMethod]
        public void Test_linkedlist()
        {
            Program.MyNode<string> n1 = new Program.MyNode<string>("Hi");
            Program.MyNode<string> n2 = new Program.MyNode<string>("there", n1);
            Assert.AreEqual(n1, n2.next);

            Program.MyLinkedList<string> l1 = new Program.MyLinkedList<string>();
            Assert.AreEqual(0, l1.Size());
            l1.InsertFirst("hi");
            Assert.AreEqual("hi", l1.head.data);
            l1.InsertFirst("there");
            Assert.AreEqual("there", l1.head.data);
            Assert.AreEqual(2, l1.Size());
            Assert.AreEqual("there", l1.GetFirst().data);
            Assert.AreEqual("hi", l1.GetLast().data);

            //remove
            l1.RemoveLast();
            Assert.AreEqual("there", l1.GetFirst().data);
            l1.RemoveLast();
            Assert.AreEqual(null, l1.head);

            //clear
            l1.Clear();
            Assert.AreEqual(0, l1.Size());
            Assert.AreEqual(null, l1.head);
        }

        [TestMethod]
        public void Test_linkedlist_removeFirst()
        {
            Program.MyLinkedList<string> l1 = new Program.MyLinkedList<string>();
            Assert.AreEqual(0, l1.Size());
            l1.InsertFirst("hi");
            l1.InsertFirst("there");

            l1.RemoveFirst();
            Assert.AreEqual("hi", l1.GetFirst().data);
            Assert.AreEqual(1, l1.Size());
        }

        [TestMethod]
        public void Test_linkedlist_removeLast()
        {
            Program.MyLinkedList<string> l1 = new Program.MyLinkedList<string>();
            Assert.AreEqual(0, l1.Size());
            l1.InsertFirst("hi");
            l1.InsertFirst("there");

            l1.RemoveLast();
            Assert.AreEqual("there", l1.GetFirst().data);
            Assert.AreEqual(1, l1.Size());
        }

        [TestMethod]
        public void Test_linkedlist_insertLast()
        {
            Program.MyLinkedList<string> l1 = new Program.MyLinkedList<string>();
            Assert.AreEqual(0, l1.Size());
            l1.InsertFirst("hi");
            l1.InsertLast("there");
            l1.InsertLast("what");
            l1.InsertFirst("who");

            Assert.AreEqual("what", l1.GetLast().data);
            Assert.AreEqual(4, l1.Size());

            Assert.AreEqual("who", l1.GetAt(0).data);
            Assert.AreEqual("hi", l1.GetAt(1).data);
            Assert.AreEqual("there", l1.GetAt(2).data);
            Assert.AreEqual("what", l1.GetAt(3).data);
        }

        [TestMethod]
        public void Test_linkedlist_removeAt()
        {
            Program.MyLinkedList<string> l1 = new Program.MyLinkedList<string>();
            Assert.AreEqual(0, l1.Size());
            l1.InsertFirst("hi");
            l1.InsertFirst("there");
            l1.InsertFirst("what");
            l1.InsertFirst("who");

            l1.RemoveAt(0);
            Assert.AreEqual(3, l1.Size());
            Assert.AreEqual("what", l1.head.data);

            l1.RemoveAt(1);
            Assert.AreEqual("what", l1.GetAt(0).data);
            Assert.AreEqual("hi", l1.GetAt(1).data);

            l1.RemoveAt(10);
        }

        [TestMethod]
        public void Test_linkedlist_insertAt()
        {
            Program.MyLinkedList<string> l1 = new Program.MyLinkedList<string>();
            Assert.AreEqual(0, l1.Size());
            l1.InsertFirst("hi");
            l1.InsertFirst("there");
            l1.InsertFirst("what");
            l1.InsertFirst("who");

            l1.InsertAt("hello", 0);
            Assert.AreEqual(5, l1.Size());
            Assert.AreEqual("hello", l1.head.data);

            l1.InsertAt("why", 3);
            Assert.AreEqual("why", l1.GetAt(3).data);
            Assert.AreEqual("there", l1.GetAt(4).data);

            l1.RemoveAt(10);
        }

        [TestMethod]
        public void Test_linkedlist_foreach()
        {
            Program.MyLinkedList<string> l1 = new Program.MyLinkedList<string>();
            Assert.AreEqual(0, l1.Size());
            l1.InsertLast("hi");
            l1.InsertLast("there");
            l1.InsertLast("what");
            l1.InsertLast("who");

            //l1.ForEach((l1.head,0) => { l1.head.data += 10});            
        }

        [TestMethod]
        public void Test_midpoint()
        {
            Program.MyLinkedList<string> l1 = new Program.MyLinkedList<string>();
            Assert.AreEqual(0, l1.Size());
            l1.InsertLast("hi");
            l1.InsertLast("there");
            l1.InsertLast("what");
            l1.InsertLast("who");

            Assert.AreEqual("there", p.midpoint<string>(l1).data);

            l1.InsertLast("why");
            Assert.AreEqual("what", p.midpoint<string>(l1).data);
        }

        [TestMethod]
        public void Test_circular()
        {
            Program.MyLinkedList<int> l1 = new Program.MyLinkedList<int>();
            Program.MyNode<int> n1 = new Program.MyNode<int>(1);
            Program.MyNode<int> n2 = new Program.MyNode<int>(2);
            Program.MyNode<int> n3 = new Program.MyNode<int>(3);
            l1.head = n1;
            n1.next = n2;
            n2.next = n3;
            n3.next = n1;

            Assert.AreEqual(true, p.circular<int>(l1));
        }

        [TestMethod]
        public void Test_fromlast()
        {
            Program.MyLinkedList<string> l1 = new Program.MyLinkedList<string>();
            Assert.AreEqual(0, l1.Size());
            l1.InsertLast("hi");
            l1.InsertLast("there");
            l1.InsertLast("what");
            l1.InsertLast("who");
            l1.InsertLast("why");

            Assert.AreEqual("there", p.fromlast<string>(l1, 3).data);
        }

        [TestMethod]
        public void Test_tree()
        {
            Program.MyTreeNode<string> tn1 = new Program.MyTreeNode<string>("a");
            tn1.Add("b");

            Assert.AreEqual(1, tn1.children.Count);
            Assert.AreEqual("b", tn1.children[0].data);

            tn1.remove("b");
            Assert.AreEqual(0, tn1.children.Count);

            Program.MyTree<string> t1 = new Program.MyTree<string>();
            t1.root = new Program.MyTreeNode<string>("a");
            t1.root.Add("b");
            t1.root.Add("c");
            t1.root.children[0].Add("d");
        }
    }
}
