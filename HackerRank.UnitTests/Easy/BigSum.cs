using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank.UnitTests.Easy
{
    [TestClass]
    public class BigSum
    {
        // Complete the aVeryBigSum function below.
        static long aVeryBigSum(long[] ar)
        {
            return ar.Sum();
        }


        [TestMethod]
        public void BigSumMethod()
        {
            long[] ar = new long[] { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };

            var expectedResult = 5000000015;

            Assert.AreEqual(expectedResult, aVeryBigSum(ar));
        }
    }
}
