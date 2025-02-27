using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Easy.MergeTwoSortedLists
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        [DynamicData(nameof(GetParameterCase), DynamicDataSourceType.Method)]
        public void Execute(ListNode? list1, ListNode? list2, string expected)
        {
            Assert.AreEqual(expected, ListNodeHelper.ToString(MergeTwoSortedLists.Execute(list1, list2)));
        }

        private static IEnumerable<object?[]> GetParameterCase()
        {
            return new List<object?[]>()
            {
                new object?[]
                {
                    new ListNode(1, new ListNode(2, new ListNode(4))),
                    new ListNode(1, new ListNode(3, new ListNode(4))),
                    "[1,1,2,3,4,4]"
                },
                new object?[]
                {
                    null,
                    null,
                    "[]"
                },
                new object?[]
                {
                    null,
                    new ListNode(),
                    "[0]"
                }
            };
        }
    }
}