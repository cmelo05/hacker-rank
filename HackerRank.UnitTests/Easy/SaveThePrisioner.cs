using HackerRank.UnitTests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Linq;

namespace HackerRank.UnitTests.Easy
{
    [TestClass]
    public class SaveThePrisioner
    {
        // Complete the saveThePrisoner function below.
        static int saveThePrisoner(int n, int m, int s)
        {
            var number = (m + s - 1) % n;

            if(number == 0)
            {
                return n;
            }

            return number;
        }

        [TestMethod]
        public void SaveThePrisionerMethod()
        {
            int candyPosition = saveThePrisoner(5, 2, 1);
            int candyPosition1 = saveThePrisoner(5, 2, 2);
            int candyPosition2 = saveThePrisoner(7, 19, 2);
            int candyPosition3 = saveThePrisoner(3, 7, 3);
            int candyPosition4 = saveThePrisoner(352926151, 380324688, 94730870);
            int candyPosition5 = saveThePrisoner(715950220, 876882456, 195550680);
            int candyPosition6 = saveThePrisoner(499999999, 999999998, 2);
            int candyPosition7 = saveThePrisoner(208526924, 756265725, 150817879);

            var candyPositions = TestHelpers.LoadMultipleColumnFile($"{Directory.GetCurrentDirectory()}/Files/input_SaveThePrisioner.txt");
            var expectedPositions = TestHelpers.LoadResultFile($"{Directory.GetCurrentDirectory()}/Files/result_SaveThePrisioner.txt");

            Assert.AreEqual(2, candyPosition);
            Assert.AreEqual(3, candyPosition1);
            Assert.AreEqual(6, candyPosition2);
            Assert.AreEqual(3, candyPosition3);
            Assert.AreEqual(122129406, candyPosition4);
            Assert.AreEqual(356482915, candyPosition5);
            Assert.AreEqual(1, candyPosition6);
            //Assert.AreEqual(72975907, candyPosition7);
            for (int i = 0; i < candyPositions.Count; i++)
            {
                int[] elementAt = candyPositions.ElementAt(i);
                int expected = expectedPositions.ElementAt(i);
                int n = elementAt[0];
                int m = elementAt[1];
                int s = elementAt[2];
                Assert.AreEqual(expected, saveThePrisoner(n, m, s));
            }
        }
    }
}
