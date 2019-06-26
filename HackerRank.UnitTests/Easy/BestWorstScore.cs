using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.UnitTests.Easy
{
    [TestClass]
    public class BestWorstScore
    {
        [TestMethod]
        public void BestWorstScoreMethod()
        {
            var firstScores = new int[] { 10, 5, 20, 20, 4, 5, 2, 25, 1 };
            var firstExpectedResult = new int[] { 2, 4 };

            var secondScores = new int[] { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 };
            var secondExpectedResult = new int[] { 4, 0 };

            var firstResult = breakingRecords(firstScores);
            var secondResult = breakingRecords(secondScores);

            CollectionAssert.AreEqual(firstExpectedResult, firstResult);
            CollectionAssert.AreEqual(secondExpectedResult, secondResult);
        }

        // Complete the breakingRecords function below.
        static int[] breakingRecords(int[] scores)
        {
            int min = scores[0];
            int minChanges = 0;
            int max = scores[0];
            int maxChanges = 0;

            for(int i = 1; i < scores.Length; i++)
            {
                var newMin = Math.Min(min, scores[i]);

                if(newMin != min) {
                    minChanges++;
                    min = newMin;
                }

                var newMax = Math.Max(max, scores[i]);

                if(newMax != max)
                {
                    maxChanges++;
                    max = newMax;
                }
            }

            return new int[] { maxChanges, minChanges };

        }
    }
}
