using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.UnitTests.Easy
{
    [TestClass]
    public class HourglassSum
    {

        public int hourglassSum(int[][] arr)
        {
            var sum = new Hourglass();

            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = 0; j < arr[i].Length - 2; j++)
                {
                    var hourglass = new Hourglass(arr, i, j);

                    if (sum.sum < hourglass.sum)
                    {
                        sum = hourglass;
                    }
                }
            }

            return sum.sum;
        }

        [TestMethod]
        public void HourglassSumMethod()
        {
            //            1 1 1 0 0 0
            //0 1 0 0 0 0
            //1 1 1 0 0 0
            //0 0 2 4 4 0
            //0 0 0 2 0 0
            //0 0 1 2 4 0
            int[][] matrix = new[]
            {
                new[]{1,1,1,0,0,0},
                new[]{0,1,0,0,0,0},
                new[]{1,1,1,0,0,0},
                new[]{0,0,2,4,4,0},
                new[]{0,0,0,2,0,0},
                new[]{0,0,1,2,4,0}
            };

            int sum = hourglassSum(matrix);

            Assert.AreEqual(19, sum);

        }

    }

    internal class Hourglass
    {
        internal int a { get; set; }
        internal int b { get; set; }
        internal int c { get; set; }
        internal int d { get; set; }
        internal int e { get; set; }
        internal int f { get; set; }
        internal int g { get; set; }
        internal int sum { get; set; }

        internal Hourglass(int[][] matrix, int aX, int aY)
        {
            a = matrix[aY][aX];
            b = matrix[aY][aX + 1];
            c = matrix[aY][aX + 2];
            d = matrix[aY + 1][aX + 1];
            e = matrix[aY + 2][aX];
            f = matrix[aY + 2][aX + 1];
            g = matrix[aY + 2][aX + 2];
            sum = a + b + c + d + e + f + g;
        }

        internal Hourglass()
        {
            sum = int.MinValue;
        }

        public override string ToString()
        {
            return $"{a} {b} {c}" +
                $"  {d}  " +
                $"{e} {f} {g}";
        }
    }
}
