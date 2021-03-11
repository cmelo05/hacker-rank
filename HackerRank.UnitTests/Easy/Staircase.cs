using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.UnitTests.Helpers;

namespace HackerRank.UnitTests.Easy
{
    [TestClass]
    public class Staircase
    {
        // Complete the staircase function below.
        static void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                var diff = n - i;

                for (int j = 0; j < n; j++)
                {
                    if (j < diff)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                if(i != n){
                    Console.WriteLine();
                }

            }
        }

        [TestMethod]
        public void StaircaseTest()
        {
            var expectedString = $"     #{Environment.NewLine}" +
                                $"    ##{Environment.NewLine}" +
                                $"   ###{Environment.NewLine}" +
                                $"  ####{Environment.NewLine}" +
                                $" #####{Environment.NewLine}" +
                                $"######";

            TestHelpers.AssertConsole(() => staircase(6), expectedString);
        }
    }
}
