using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.UnitTests.Easy
{
    [TestClass]
    public class BirthdayChocolate
    {

        [TestMethod]
        public void BirthdayChocolateMethod()
        {
            var firstChocolate = new List<int> { 1, 2, 1, 3, 2 };
            var secondChocolate = new List<int> { 1, 1, 1, 1, 1, 1 };
            var thirdChocolate = new List<int> { 2, 5, 1, 3, 4, 4, 3, 5, 1, 1, 2, 1, 4, 1, 3, 3, 4, 2, 1 };

            var firstResult = birthday(firstChocolate, 3, 2);
            var secondResult = birthday(secondChocolate, 3, 2);
            var thirdResult = birthday(thirdChocolate, 18, 7);

            Assert.AreEqual(2, firstResult);
            Assert.AreEqual(0, secondResult);
            Assert.AreEqual(3, thirdResult);
        }

        // Complete the birthday function below.
        static int birthday(List<int> s, int d, int m)
        {
            var ways = 0;
            var skip = 0;
            foreach(var piece in s)
            {
                var chocPieces = s.Skip(skip).Take(m);
                var sumChocPieces = chocPieces.Sum();

                if(chocPieces.Count() == m && sumChocPieces == d)
                {
                    ways++;
                }
                skip++;
            }

            return ways;
        }

    }
}
