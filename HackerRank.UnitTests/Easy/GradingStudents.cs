using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace HackerRank.UnitTests.Easy
{
    [TestClass]
    public class GradingStudents
    {
        [TestMethod]
        public void GradingStudentsMethod()
        {
            var input = new List<int> { 73, 67, 38, 33 };
            var expected = new List<int> { 75, 67, 40, 33 };

            var result = gradingStudents(input);

            CollectionAssert.AreEqual(expected, result);
        }

        public static List<int> gradingStudents(List<int> grades)
        {
            var roundGrade = new List<int>();

            foreach (var value in grades)
            {
                if (value >= 38)
                {
                    var localValue = value;
                    var mod = value % 5;
                    while (mod != 0)
                    {
                        localValue++;
                        mod = localValue % 5;
                    }

                    if (localValue - value < 3)
                    {
                        roundGrade.Add(localValue);
                    }
                    else
                    {
                        roundGrade.Add(value);
                    }
                } else
                {
                    roundGrade.Add(value);
                }
            }
            return roundGrade;
        }
    }
}
