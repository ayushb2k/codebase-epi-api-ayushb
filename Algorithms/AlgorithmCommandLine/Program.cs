using Algorithms.AlgorithmProvider;
using Contract.AlgorithmProvider;
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
        static void Main(string[] args)
        {
            arrayProvider = new ArrayProvider();
            TestCanReach();
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
    }
}
