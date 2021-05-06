using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.UnitTests
{
    [TestClass]
    public class TwoSum
    {
        public int[] GetTwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new[] { i, j };
                    }
                }
            }

            return null;

        }

        [TestMethod]
        public void TwoSumMethod()
        {
            CollectionAssert.AreEquivalent(new[] { 0, 1 }, GetTwoSum(new[] { 2, 7, 11, 15 }, 9));
        }
    }
}
