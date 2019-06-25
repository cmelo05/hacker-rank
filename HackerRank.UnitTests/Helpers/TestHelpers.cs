using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

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
    }
}
