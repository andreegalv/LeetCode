namespace LeetCode.Medium.AddTwoNumbers
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Test
    {
        [TestMethod]
        [DynamicData(nameof(GetParameterCase), DynamicDataSourceType.Method)]
        public void Execute(ListNode l1, ListNode l2, string expected)
        {
            Assert.AreEqual(expected, ListNodeHelper.ToString(AddTwoNumbers.Execute(l1, l2)));
        }

        private static IEnumerable<object?[]> GetParameterCase()
        {
            return new List<object?[]>()
            {
                new object?[]
                {
                    new ListNode(2, new ListNode(4, new ListNode(3))),
                    new ListNode(5, new ListNode(6, new ListNode(4))),
                    "[7,0,8]"
                },
                new object?[]
                {
                    new ListNode(),
                    new ListNode(),
                    "[0]"
                },
                new object?[]
                {
                    new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))))))),
                    new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))),
                    "[8,9,9,9,0,0,0,1]"
                },
                new object?[]
                {
                    new ListNode(9),
                    new ListNode(1, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))))))),
                    "[0,0,0,0,0,0,0,0,0,0,1]"
                },
            };
        }
    }
}