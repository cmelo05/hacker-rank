using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank.UnitTests.Easy
{
    [TestClass]
    public class Kangaroo
    {
        // Complete the kangaroo function below.
        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if (v1 > v2 && ((x2-x1)%(v1-v2) == 0))
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }


        [TestMethod]
        public void KangarooMethod()
        {
            var expectedAnswer = "NO";

            var resultString = kangaroo(21, 6, 47, 3);

            Assert.AreEqual(expectedAnswer, resultString);
        }
    }
}
