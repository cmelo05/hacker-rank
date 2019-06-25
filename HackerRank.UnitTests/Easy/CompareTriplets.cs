using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank.UnitTests.Easy
{
    [TestClass]
    public class CompareTriplets
    {
        // Complete the compareTriplets function below.
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int aliceScore = 0;
            int bobScore = 0;

            for (int i = 0; i < a.Count; i++)
            {
                var aliceCurrent = a.ElementAt(i);
                var bobCurrent = b.ElementAt(i);

                if (aliceCurrent > bobCurrent)
                {
                    aliceScore++;
                }
                else if (bobCurrent > aliceCurrent)
                {
                    bobScore++;
                }
            }

            return new List<int> { aliceScore, bobScore };
        }

        [TestMethod]
        public void CompareTripletsTest()
        {
            List<int> expectedResult = new List<int> { 1, 1 };
            var a = new List<int> { 5, 6, 7 };
            var b = new List<int> { 3, 6, 10 };

            List<int> result = compareTriplets(a, b);

            CollectionAssert.AreEqual(expectedResult, result);
        }
    }

}