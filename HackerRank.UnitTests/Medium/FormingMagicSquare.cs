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
        public int formingMagicSquare(int[][] s)
        {
            int output = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int diagonalSum = s[0][0] + s[1][1] + s[2][2];
                int diffDiag = 15 - diagonalSum;
                int rowSum = s[i][0] + s[i][1] + s[i][2];
                int diffRow = 15 - rowSum;

                for (int j = 0; j < s[i].Length; j++)
                {
                    int columnSum = s[0][j] + s[1][j] + s[2][j];
                    int diffColumn = 15 - columnSum;

                    if (i == j && diffRow == diffDiag && diffRow == diffColumn && diffDiag == diffColumn)
                    {
                        int oldValue = s[i][j];
                        s[i][j] = s[i][j] + diffRow;

                        if (checkMagicSquare(s))
                        {
                            output += Math.Abs(s[i][j] - oldValue);
                            break;
                        }
                        else
                        {
                            s[i][j] = oldValue;
                        }
                    }

                    if (diffColumn != 0)
                    {
                        int oldValue = s[i][j];
                        s[i][j] = s[i][j] + diffColumn;

                        if (checkMagicSquare(s))
                        {
                            output += Math.Abs(s[i][j] - oldValue);
                            break;
                        }
                        else
                        {
                            s[i][j] = oldValue;
                        }
                    }

                    if (diffRow != 0)
                    {
                        int oldValue = s[i][j];
                        s[i][j] = s[i][j] + diffRow;

                        if (checkMagicSquare(s))
                        {
                            output += Math.Abs(s[i][j] - oldValue);
                            break;
                        }
                        else
                        {
                            s[i][j] = oldValue;
                        }
                    }

                    if (i == j && diffDiag != 0)
                    {
                        int oldValue = s[i][j];
                        s[i][j] = s[i][j] + diffDiag;

                        if (checkMagicSquare(s))
                        {
                            output += Math.Abs(s[i][j] - oldValue);
                            break;
                        }
                        else
                        {
                            s[i][j] = oldValue;
                        }
                    }


                }
            }

            return output;
        }

        private bool testColumn(int[][] s, int i)
        {
            return (s[0][i] + s[1][i] + s[2][i]) == 15;
        }

        private bool testRow(int[][] s, int j)
        {
            return (s[j][0] + s[j][1] + s[j][2]) == 15;
        }

        private bool testDiagonal(int[][] s)
        {
            return (s[0][0] + s[1][1] + s[2][2]) == 15;
        }

        private bool checkMagicSquare(int[][] s)
        {
            return testColumn(s, 0)
                && testColumn(s, 1)
                && testColumn(s, 2)
                && testRow(s, 0)
                && testRow(s, 1)
                && testRow(s, 2)
                && testDiagonal(s);
        }

        [TestMethod]
        public void FormingMagicSquareMethod()
        {
            //            4 8 2
            //4 5 7
            //6 1 6

            //            4 9 2
            //3 5 7
            //8 1 5

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

            int count = formingMagicSquare(matrix);
            int count1 = formingMagicSquare(matrix1);

            Assert.AreEqual(1, count);
            Assert.AreEqual(4, count1);
        }
    }
}
