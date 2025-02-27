namespace LeetCode.Easy.RomanToInteger
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Test
    {
        [TestMethod]
        [DataRow("III", 3)]
        [DataRow("IV", 4)]
        [DataRow("VII", 7)]
        [DataRow("IX", 9)]
        [DataRow("XL", 40)]
        [DataRow("LVIII", 58)]
        [DataRow("XLVIII", 48)]
        [DataRow("MCMXCIV", 1994)]
        public void Execute(string romanLetter, int expected)
        {
            Assert.AreEqual(expected, RomanToInteger.Execute(romanLetter));
        }
    }
}