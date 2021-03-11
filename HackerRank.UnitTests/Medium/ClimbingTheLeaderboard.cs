using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using HackerRank.UnitTests.Helpers;
using System.IO;

namespace HackerRank.UnitTests.Medium
{
    [TestClass]
    public class ClimbingTheLeaderboard
    {
        // Complete the climbingLeaderboard function below.
        static int[] climbingLeaderboard(int[] scores, int[] alice)
        {
            var positionInLeaderboard = new int[alice.Length];
            var distinctScores = scores.Distinct().ToArray();

            for (int i = 0; i < alice.Length; i++)
            {
                var searchIndex = FindIndex(distinctScores, alice[i]);

                if (searchIndex == -1)
                {
                    // Last ranking
                    positionInLeaderboard[i] = distinctScores.Length + 1;
                }
                else
                {
                    positionInLeaderboard[i] = searchIndex + 1;
                }
            }

            return positionInLeaderboard;
        }

        //Recursive
        private static int BinarySearchRecursive(int[] scores, int compareValue, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
            {
                if (compareValue < scores[startIndex])
                {
                    // Value is smaller than current index. It should have a higher index
                    return startIndex == endIndex ? startIndex + 1 : -1;
                }
                else
                {
                    return startIndex;
                }
            }

            var midIndex = (startIndex + endIndex) / 2;

            if (compareValue > scores[midIndex])
            {
                endIndex = midIndex - 1;
                return BinarySearchRecursive(scores, compareValue, startIndex, endIndex);
            }
            else if (compareValue < scores[midIndex])
            {
                startIndex = midIndex + 1;
                return BinarySearchRecursive(scores, compareValue, startIndex, endIndex);
            }
            else
            {
                return midIndex;
            }
        }

        private static int FindIndex(int[] scores, int compareValue)
        {
            var startIndex = 0;
            var endIndex = scores.Length - 1;           

            while(startIndex < endIndex)
            {
                var midIndex = (startIndex + endIndex) / 2;

                if (compareValue > scores[midIndex])
                {
                    endIndex = midIndex - 1;
                }
                else if (compareValue < scores[midIndex])
                {
                    startIndex = midIndex + 1;
                }
                else
                {
                    return midIndex;
                }
            }

            if (compareValue < scores[startIndex])
            {
                // Value is smaller than current index. It should have a higher index
                return startIndex == endIndex ? startIndex + 1 : -1;
            }
            else
            {
                return startIndex;
            }
        }

        [TestMethod]
        public void ClimbingTheLeaderboardTest()
        {
            var scores = new int[] { 100, 50, 40, 40, 20, 10 };
            var alice = new int[] { 5, 25, 50, 120 };

            var leaderboard = climbingLeaderboard(scores, alice);

            var expectedLeaderboard = new int[] { 6, 4, 2, 1 };

            var scores2 = new int[] { 100, 90, 90, 80, 75, 60 };
            var alice2 = new int[] { 55, 65, 77, 90, 102 };

            var leaderboard2 = climbingLeaderboard(scores2, alice2);

            var expectedLeaderboard2 = new int[] { 6, 5, 4, 2, 1 };

            var scores3 = TestHelpers.LoadInputFile($"{Directory.GetCurrentDirectory()}/Files/input_ClimbingTheLeaderboard_scores.txt");
            var alice3 = TestHelpers.LoadInputFile($"{Directory.GetCurrentDirectory()}/Files/input_ClimbingTheLeaderboard_alice.txt");
            var leaderboard3 = climbingLeaderboard(scores3, alice3);
            var expectedLeaderboard3 = TestHelpers.LoadResultFile($"{Directory.GetCurrentDirectory()}/Files/result_ClimbingTheLeaderboard.txt");

            CollectionAssert.AreEqual(expectedLeaderboard, leaderboard);
            CollectionAssert.AreEqual(expectedLeaderboard2, leaderboard2);
            CollectionAssert.AreEqual(expectedLeaderboard3, leaderboard3);

        }
    }
}
