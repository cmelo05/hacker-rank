using HackerRank.UnitTests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;

namespace HackerRank.UnitTests.Easy
{
    [TestClass]
    public class MinMaxSum
    {

        // Complete the miniMaxSum function below.
        static void miniMaxSum(int[] arr)
        {
            var arraySum = arr.Sum(x => (long)x);
            var max = arr.Max();
            var min = arr.Min();

            Console.Write(arraySum - max);
            Console.Write(" ");
            Console.Write(arraySum - min);
        }

        [TestMethod]
        public void MinMaxSumTest()
        {
            var expectedResult = "20 20";
            int[] arr = { 5, 5, 5, 5, 5 };

            TestHelpers.AssertConsole(() => miniMaxSum(arr), expectedResult);
        }
    }
}
