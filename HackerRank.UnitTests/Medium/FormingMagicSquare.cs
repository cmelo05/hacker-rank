using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.UnitTests.Medium
{
    [TestClass]
    public class FormingMagicSquare
    {
        private static List<int[][]> magicSquares = new List<int[][]>()
        {
            {
                new int[][]{
                    new int[]{8, 1, 6},
                    new int[]{3, 5, 7},
                    new int[]{4, 9, 2}
                }
            },
            {
                new int[][]{
                    new int[]{6, 1, 8},
                    new int[]{7, 5, 3},
                    new int[]{2, 9, 4}
                }
            },
            {
                new int[][]{
                    new int[]{4, 3, 8},
                    new int[]{9, 5, 1},
                    new int[]{2, 7, 6}
                }
            }
            ,{
                new int[][]{
                    new int[]{2, 7, 6},
                    new int[]{9, 5, 1},
                    new int[]{4, 3, 8}
                }
            },
            {
                new int[][]{
                    new int[]{2, 9, 4},
                    new int[]{7, 5, 3},
                    new int[]{6, 1, 8}
                }
            },
            {
                new int[][]{
                    new int[]{4, 9, 2},
                    new int[]{3, 5, 7},
                    new int[]{8, 1, 6}
                }
            },
            {
                new int[][]{
                    new int[]{6, 7, 2},
                    new int[]{1, 5, 9},
                    new int[]{8, 3, 4}
                }
            },
            {
                new int[][]{
                    new int[]{8, 3, 4},
                    new int[]{1, 5, 9},
                    new int[]{6, 7, 2}
                }
            }

        };

        public static int formingMagicSquare(int[][] s)
        {
            int minMoves = int.MaxValue;

            foreach (var matrix in magicSquares)
            {
                int costByMatrix = 0;
                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        int cost = Math.Abs(s[i][j] - matrix[i][j]);
                        costByMatrix += cost;
                    }
                }

                if (costByMatrix < minMoves)
                {
                    minMoves = costByMatrix;
                }
            }

            return minMoves;
        }

        [TestMethod]
        public void FormingMagicSquareMethod()
        {
            int[][] matrix = new int[][]
            {
                new[]{4, 9, 2},
                new[]{3,5,7},
                new[]{8,1,5}
            };

            int[][] matrix1 = new int[][] {
                new[]{ 4, 8, 2 },
                new[]{ 4, 5, 7 },
                new[]{ 6, 1, 6 }
            };

            int[][] matrix2 = new int[][] {
                new[]{ 4, 5, 8 },
                new[]{ 2, 4, 1 },
                new[]{ 1,9, 7 }
            };

            int count = formingMagicSquare(matrix);
            int count1 = formingMagicSquare(matrix1);
            int count2 = formingMagicSquare(matrix2);

            Assert.AreEqual(1, count);
            Assert.AreEqual(4, count1);
            Assert.AreEqual(14, count2);
        }
    }
}
