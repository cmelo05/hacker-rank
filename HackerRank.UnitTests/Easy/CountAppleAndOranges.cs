using HackerRank.UnitTests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HackerRank.UnitTests.Easy
{
    [TestClass]
    public class CountAppleAndOranges
    {
        // Complete the countApplesAndOranges function below.
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int countApples = countFruits(s,t,a,apples);
            int countOranges = countFruits(s,t,b,oranges);

            Console.WriteLine(countApples);
            Console.WriteLine(countOranges);
        }

        private static int countFruits(int start, int end, int location, int[] fruits)
        {
            var count = 0;

            for(int i = 0; i < fruits.Length; i++)
            {
                var position = location + fruits[i];

                if(position >= start && position <= end)
                {
                    count++;
                }
            }

            return count;
        }

        [TestMethod]
        public void CountAppleAndOrangesMethod()
        {
            int s = 7;
            int t = 11;
            int a = 5;
            int b = 15;
            int[] m = new int[] { -2, 2, 1 };
            int[] n = new int[] { 5, -6 };

            var expectedString = $"1{Environment.NewLine}1{Environment.NewLine}";

            TestHelpers.AssertConsole(() => countApplesAndOranges(s, t, a, b, m, n), expectedString);
        }
    }
}
