namespace LeetCode.Medium.LongestSubstringWithoutRepeatingCharacters
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Test
    {
        [TestMethod]
        [DataRow("abcabcbb", 3)]
        [DataRow("bbbbb", 1)]
        [DataRow("pwwkew", 3)]
        [DataRow("dvdf", 3)]
        [DataRow("tmmzuxt", 5)]
        public void Execute(string text, int lengthExpected)
        {
            Assert.AreEqual(lengthExpected, LongestSubstringWithoutRepeatingCharacters.GetLongestSubstringLength(text));
        }
    }
}