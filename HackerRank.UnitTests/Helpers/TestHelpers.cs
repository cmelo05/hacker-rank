using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;

namespace HackerRank.UnitTests.Helpers
{
    public static class TestHelpers
    {
        public static void AssertConsole(Action action, string expectedResult)
        {
            using(var sw = new StringWriter())
            {
                Console.SetOut(sw);
                action.Invoke();
                Assert.AreEqual(expectedResult, sw.ToString());
            }
        }

        public static int[] LoadInputFile(string path)
        {
            var file = File.ReadAllLines(path);
            return Array.ConvertAll(file[1].Split(' '), fileTemp => Convert.ToInt32(fileTemp));
        }

        public static int[] LoadResultFile(string path)
        {
            var file = File.ReadAllLines(path);
            return Array.ConvertAll(file, fileTemp => Convert.ToInt32(fileTemp));
        }
    }
}
