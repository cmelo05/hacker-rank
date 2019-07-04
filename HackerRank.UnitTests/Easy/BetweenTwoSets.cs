using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.UnitTests.Easy
{
    [TestClass]
    public class BetweenTwoSets
    {
        /*
         * Complete the 'getTotalX' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER_ARRAY b
         */

        public static int getTotalX(List<int> a, List<int> b)
        {
            var aFirstElement = a.First();
            var aLastElement = a.Last();
            var bFirstElement = b.First();
            var count = 0;

            var elementsBetween = new List<int>();

            for (int i = aLastElement; i <= bFirstElement; i++)
            {
                if (a.TrueForAll(x => Mod(i, x)) && b.TrueForAll(x => Mod(i,x)))
                {
                    count++;
                }
            }

            return count;
        }

        private static bool Mod(int i, int j) => i > j ? i % j == 0 : j % i == 0;

        [TestMethod]
        public void BetweenTwoSetsTest()
        {
            var firstSet = new List<int> { 2, 4 };
            var secondSet = new List<int> { 16, 32, 96 };

            var result = getTotalX(firstSet, secondSet);

            var thirdSet = new List<int> { 3, 4 };
            var fourthSet = new List<int> { 24, 48 };

            var result2 = getTotalX(thirdSet, fourthSet);

            Assert.AreEqual(3, result);
            Assert.AreEqual(2, result2);
        }
    }
}
