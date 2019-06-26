using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.UnitTests.Easy
{
    [TestClass]
    public class DivisibleSumPairs
    {
        [TestMethod]
        public void DivisibleSumPairsTest()
        {
            int n = 6;
            int k = 3;
            int[] ar = new int[] { 1, 3, 2, 6, 1, 2, };

            var result = divisibleSumPairs(n, k, ar);

            Assert.AreEqual(5, result);
        }

        // Complete the divisibleSumPairs function below.
        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            var count = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = i + 1; j < ar.Length; j++)
                {
                    if (((ar[i] + ar[j]) % k) == 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
