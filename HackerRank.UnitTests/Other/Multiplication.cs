using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.UnitTests.Other
{
    [TestClass]
    public class Multiplication
    {
        public long Multiply(int i1, int i2)
        {
            if (i1 == 0 || i2 == 0)
            {
                return 0;
            }

            bool hasNegativeValue = i1 < 0 ^ i2 < 0;

            i1 = GetAbsoluteValue(i1);
            i2 = GetAbsoluteValue(i2);

            int stoppingClause;
            int sumFactor;

            if (i1 < i2)
            {
                stoppingClause = i1;
                sumFactor = i2;
            }
            else
            {
                stoppingClause = i2;
                sumFactor = i1;
            }

            int multiplication = 0;

            for (int i = 0; i < stoppingClause; i++)
            {
                multiplication += sumFactor;
            }

            return hasNegativeValue ? GetInverseValue(multiplication) : multiplication;

        }

        private int GetAbsoluteValue(int input)
        {
            if (input > 0)
            {
                return input;
            }

            return GetInverseValue(input);
        }

        private int GetInverseValue(int input)
        {
            return -input;
        }

        [TestMethod]
        public void MultiplicationMethod()
        {
            Assert.AreEqual(16, Multiply(8, 2));
            Assert.AreEqual(-16, Multiply(8, -2));
            Assert.AreEqual(0, Multiply(8, 0));
            Assert.AreEqual(16, Multiply(-8, -2));
        }
    }
}
