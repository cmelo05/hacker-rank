using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.UnitTests.Easy
{
    [TestClass]
    public class JumpingOnClouds
    {
        // Complete the jumpingOnClouds function below.
        public static int jumpingOnClouds(int[] c)
        {
            int startIndex = 0;
            int cloudCount = 0;

            while (startIndex < c.Length)
            {
                int testIndex = startIndex + 2;

                if (testIndex > c.Length)
                {
                    return cloudCount;
                }
                else if (testIndex == c.Length)
                {
                    cloudCount++;
                    return cloudCount;
                }

                if (c[testIndex] == 0)
                {
                    startIndex = testIndex;
                }
                else
                {
                    startIndex++;
                }

                cloudCount++;
            }

            return cloudCount;
        }

        [TestMethod]
        public void JumpingOnCloudsMethod()
        {
            int[] cloudArray = new[] { 0, 0, 1, 0, 0, 1, 0 };
            int[] cloudArray1 = new[] { 0, 0, 0, 1, 0, 0 };

            int jumpedClouds = jumpingOnClouds(cloudArray);
            int jumpedClouds1 = jumpingOnClouds(cloudArray1);

            Assert.AreEqual(4, jumpedClouds);
            Assert.AreEqual(3, jumpedClouds1);
        }
    }
}
