using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.UnitTests.Easy
{
    [TestClass]
    public class CountingValleys
    {
        /*
         * Complete the 'countingValleys' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER steps
         *  2. STRING path
         */

        public static int countingValleys(int steps, string path)
        {
            int valleyCount = 0;
            int levelCount = 0;

            foreach(var ch in path)
            {
                if(ch == 'U')
                {
                    levelCount++;

                } else if (ch == 'D') {
                    if(levelCount == 0)
                    {
                        valleyCount++;
                    }

                    levelCount--;
                }
                
            }

            return valleyCount;
        }

        [TestMethod]
        public void CountingValleysMethod()
        {
            int steps = 8;
            string path = "UDDDUDUU";

            int count = countingValleys(steps, path);

            Assert.AreEqual(1, count);
        }
    }
}
