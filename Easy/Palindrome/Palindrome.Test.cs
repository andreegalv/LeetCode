namespace LeetCode.Easy.Palindrome
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Test
    {
        [TestMethod]
        [DataRow(121, true)]
        [DataRow(-121, false)]
        [DataRow(10, false)]
        public void Execute(int number, bool expected)
        {
            Assert.AreEqual(expected, Palindrome.Execute(number));
        }
    }
}