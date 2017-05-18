using Algorithms.AlgorithmProvider;
using Contract.AlgorithmProvider;
using Contract.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCommandLine
{
    class Program
    {
        static IArrayProvider arrayProvider;
        static ILinkedListProvider llProvider;
        static void Main(string[] args)
        {
            arrayProvider = new ArrayProvider();
            llProvider = new LinkedListProvider();
            TreeGenerate();
        }

        private static void TestDutchFlagProblem()
        {
            List<int> test = new List<int>() { 1, 2, 3, 4, 5, 6, 5, 4, 3, 2, 1 };
            arrayProvider.DutchFlagPartition(1, test);

            //Console.WriteLine(test.ToList().ToString());
            test.ForEach(x => Console.Write(x + ","));
        }

        private static void TestDutchFlagProblemV1()
        {
            List<int> test = new List<int>() { 1, 1,1,2,2,3,2,2,2, 3, 3,2,1, 3, 2, 1 };
            arrayProvider.DutchFlagPartitionV1(test);

            //Console.WriteLine(test.ToList().ToString());
            test.ForEach(x => Console.Write(x + ","));
        }

        private static void TestDutchFlagProblemV3()
        {
            List<bool> test = new List<bool>() { false,  true, true, true, false };
            arrayProvider.DutchFlagPartitionV3(test);

            //Console.WriteLine(test.ToList().ToString());
            test.ForEach(x => Console.Write(x + ","));
        }

        private static void TestBigInt()
        {
            List<int> test = new List<int>() { 9,9 };
            arrayProvider.IncrementBigInt(test);

            //Console.WriteLine(test.ToList().ToString());
            test.ForEach(x => Console.Write(x + ","));
        }

        private static void TestCanReach()
        {
            List<int> test = new List<int>() { 3,0,0,1,1,2,1 };
            var result = arrayProvider.CanReachBoardGame(test);

            Console.WriteLine(result.ToString());            
        }

        private static void TestMergeList()
        {
            LinkedList a = new LinkedList();
            LinkedList b = new LinkedList();

            a.AppendList(new List<int>() { 2, 2,2, 5, 7 });
            b.AppendList(new List<int>() { 2,2, 3, 11 });

            a.PrintAllNodes();
            Console.WriteLine();
            b.PrintAllNodes();

            var result = llProvider.MergeTwoSortedLists(a.GetHead(), b.GetHead());
            LinkedList c = new LinkedList(result);
            c.PrintAllNodes();

            //Console.WriteLine(result.ToString());
        }

        private static void TestReverse()
        {
            LinkedList a = new LinkedList();
            
            a.AppendList(new List<int>() { 1,2, 3, 3, 5, 7 });
            
            a.PrintAllNodes();

            llProvider.ReverseLinkedList(a);
            
            a.PrintAllNodes();

            //Console.WriteLine(result.ToString());
        }

        private static void TreeGenerate()
        {
            //left sub tree
            TreeNode d = new TreeNode("D");
            TreeNode e = new TreeNode("E");
            TreeNode c = new TreeNode(d, e,"C");
            TreeNode h = new TreeNode("H");
            TreeNode g = new TreeNode(h, "G");
            TreeNode f = new TreeNode(g, "F", false);
            TreeNode b = new TreeNode(c, f, "B");

            //right sub tree
            TreeNode m = new TreeNode("M");
            TreeNode l = new TreeNode(m, "L", false);
            TreeNode n = new TreeNode("N");
            TreeNode k = new TreeNode(l,n, "K");
            TreeNode j = new TreeNode(k, "J", false);
            TreeNode p = new TreeNode("P");
            TreeNode o = new TreeNode(p, "O", false);
            TreeNode i = new TreeNode(j, o, "I");

            TreeNode a = new TreeNode(b,i,"A");

            Tree root = new Tree(a);
            root.InOrderRecursive(a);
            Console.WriteLine();
            root.InOrderIterative();
            Console.WriteLine();
            root.PreOrderIterative();
            Console.WriteLine();
            root.PreOrderRecursive(a);
            Console.WriteLine();
            root.PostOrderIterative();
            Console.WriteLine();
            root.PostOrderRecursive(a);
            
        }
    }
}
