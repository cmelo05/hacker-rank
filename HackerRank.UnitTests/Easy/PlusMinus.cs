using HackerRank.UnitTests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HackerRank.UnitTests.Easy
{
    [TestClass]
    public class PlusMinus
    {
        // Complete the plusMinus function below.
        static void plusMinus(int[] arr)
        {
            float positive = 0;
            float negative = 0;
            float zeros = 0;
            var length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                var value = arr[i];

                if (value > 0)
                {
                    positive++;
                }
                else if (value < 0)
                {
                    negative++;
                }
                else if (value == 0)
                {
                    zeros++;
                }
            }

            Console.WriteLine((positive / length).ToString("F6"));
            Console.WriteLine((negative / length).ToString("F6"));
            Console.WriteLine((zeros / length).ToString("F6"));
        }

        [TestMethod]
        public void PlusMinusTest()
        {
            var expectedResult = $"0.500000{Environment.NewLine}0.333333{Environment.NewLine}0.166667{Environment.NewLine}";
            int[] arr = new int[] { -4, 3, -9, 0, 4, 1 };
            TestHelpers.AssertConsole(() => plusMinus(arr), expectedResult);
        }
    }
}
