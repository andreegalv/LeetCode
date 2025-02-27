namespace LeetCode.Easy.TwoSums
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Test
    {
        [TestMethod]
        [DataRow(new int[] { 2, 7, 11, 15 }, 9, "[0,1]")]
        [DataRow(new int[] { 3, 2, 4 }, 6, "[1,2]")]
        [DataRow(new int[] { 3, 3 }, 6, "[0,1]")]
        public void Execute(int[] nums, int target, string expected)
        {
            Assert.AreEqual(expected, $"[{string.Join(",", TwoSums.Execute(nums, target))}]");
        }
    }
}