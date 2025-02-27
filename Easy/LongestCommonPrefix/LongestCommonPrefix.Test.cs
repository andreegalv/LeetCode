namespace LeetCode.Easy.LongestCommonPrefix
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Test
    {
        [TestMethod]
        [DataRow(new string[] { "flower", "flow", "flight" }, "fl")]
        [DataRow(new string[] { "dog", "racecar", "car" }, "")]
        [DataRow(new string[] { "a" }, "a")]
        [DataRow(new string[] { "cir", "car" }, "c")]
        [DataRow(new string[] { "aca", "cba" }, "")]
        public void Execute(string[] strs, string expected)
        {
            Assert.AreEqual(expected, LongestCommonPrefix.Execute(strs));
        }
    }
}