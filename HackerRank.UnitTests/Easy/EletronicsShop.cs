using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.UnitTests.Easy
{
    [TestClass]
    public class EletronicsShop
    {
        public int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int moneySpent = 0;

            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    int sum = keyboards[i] + drives[j];
                    if (sum >= moneySpent && sum <= b)
                    {
                        moneySpent = sum;
                    }
                }
            }

            return moneySpent == 0 ? -1 : moneySpent;

        }

        [TestMethod]
        public void EletronicsShopMethod()
        {
            int moneySpent = getMoneySpent(new[] { 3, 1 }, new[] { 5, 2, 8 }, 10);
            int moneySpent1 = getMoneySpent(new[] { 4 }, new[] { 5 }, 5);

            Assert.AreEqual(9, moneySpent);
            Assert.AreEqual(-1, moneySpent1);
        }
    }
}
