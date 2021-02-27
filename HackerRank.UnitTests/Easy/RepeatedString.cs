using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.UnitTests.Easy
{
    [TestClass]
    public class RepeatedString
    {
        // Complete the repeatedString function below.
        public static long repeatedString(string s, long n)
        {
            int aCount = 0;

            foreach(var ch in s)
            {
                if(ch == 'a')
                {
                    aCount++;
                }
            }

            long repetitions = n / s.Length;

            long total = aCount * repetitions;

            long module = n % s.Length;

            if(module != 0)
            {
                for(int i = 0; i < module; i++)
                {
                    if(s[i] == 'a')
                    {
                        total++;
                    }
                }
            }

            return total;
        }

        [TestMethod]
        public void RepeatedStringMethod()
        {
            string s = "aba";
            long n = 10;

            long aCount = repeatedString(s, n);

            Assert.AreEqual(7, aCount);
        }
    }
}
