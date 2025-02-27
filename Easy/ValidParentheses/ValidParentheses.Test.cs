namespace LeetCode.Easy.ValidParentheses
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Test
    {
        [TestMethod]
        [DataRow("()", true)]
        [DataRow("()[]{}", true)]
        [DataRow("(]", false)]
        [DataRow("([])", true)]
        [DataRow("([)]", false)]
        [DataRow("([])]", false)]
        [DataRow("]", false)]
        [DataRow("([])]{}", false)]
        [DataRow("}([)", false)]
        [DataRow("([)", false)]
        public void Execute(string text, bool expected)
        {
            Assert.AreEqual(expected, ValidParentheses.Execute(text));
        }
    }
}