using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.UnitTests.Other
{
    [TestClass]
    public class LongestPalindrom
    {

        public string GetPalindrom(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length < 0)
            {
                return "";
            }

            int start = 0;
            int end = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int lengthEven = ExpandFromTheMiddle(input, i, i + 1);
                int lengthOdd = ExpandFromTheMiddle(input, i, i);

                int maxLength = Math.Max(lengthEven, lengthOdd);

                if (maxLength > (end - start))
                {
                    start = i - ((maxLength - 1) / 2);
                    end = i + ((maxLength - 1) / 2);
                }
            }

            return input.Substring(start, end + 1);
        }

        private int ExpandFromTheMiddle(string s, int left, int right)
        {
            if (string.IsNullOrEmpty(s) || left > right)
            {
                return 0;
            }

            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }

            return right - left - 1;
        }

        [TestMethod]
        public void LongestPalidromTest()
        {
            string palindrom1 = "racecar";
            string palindrom2 = "babba";

            Assert.AreEqual("racecar", GetPalindrom(palindrom1));
            Assert.AreEqual("abba", GetPalindrom(palindrom2));

        }
    }
}
