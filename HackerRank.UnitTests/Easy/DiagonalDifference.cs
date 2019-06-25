using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank.UnitTests.Easy
{
    class DiagonalDifferenceResult
    {

        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int diagonalDifference(List<List<int>> arr)
        {
            int firstDiagonal = 0;
            int secondDiagonal = 0;
            int matrixSize = arr.Count - 1;

            for(int i = 0; i < arr.Count; i++)
            {
                for(int j = 0; j < arr.Count; j++)
                {
                    var element = arr.ElementAt(i).ElementAt(j);

                    if(i == j)
                    {
                        firstDiagonal += element;
                    }

                    if (j == matrixSize)
                    {
                        secondDiagonal += element;
                        matrixSize--;
                    }
                }
            }

            return Math.Abs(firstDiagonal - secondDiagonal);
        }

    }
    [TestClass]
    public class DiagonalDifference
    {
        [TestMethod]
        public void DiagonalDifferenceTest()
        {
            var matrix = new List<List<int>>
            {
                new List<int>{11, 2, 4},
                new List<int>{4, 5, 6},
                new List<int>{10, 8, -12},
            };

            int result = DiagonalDifferenceResult.diagonalDifference(matrix);

            Assert.AreEqual(15, result);
        }
    }

}
