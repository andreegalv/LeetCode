namespace LeetCode.Medium.AddTwoNumbers
{
    using System.Numerics;
    using System.Text;

    /*
        URL: https://leetcode.com/problems/add-two-numbers/description/
    */

    public static class AddTwoNumbers
    {
        public static ListNode Execute(ListNode? l1, ListNode? l2)
        {
            var list1Flatten = FlatNodes(l1);
            var list2Flatten = FlatNodes(l2);

            BigInteger list1Sum = GetSumFromReverseNodes(list1Flatten);
            BigInteger list2Sum = GetSumFromReverseNodes(list2Flatten);

            BigInteger listResultNumber = list1Sum + list2Sum;

            return CreateListNodeFromNumberReversed(listResultNumber);
        }

        private static List<ListNode> FlatNodes(ListNode? listNode)
        {
            if (listNode == null)
            {
                return [];
            }

            ListNode? currentNode = listNode;
            List<ListNode> nodes = [];

            while (currentNode != null)
            {
                nodes.Add(currentNode);
                currentNode = currentNode.next;
            }

            return nodes;
        }

        private static BigInteger GetSumFromReverseNodes(List<ListNode> nodes)
        {
            if (nodes.Count <= 0)
            {
                return 0;
            }

            StringBuilder values = new();
            ListNode? currentNode = nodes[0];

            while (currentNode != null)
            {
                values.Insert(0, currentNode.val);
                currentNode = currentNode.next;
            }

            return BigInteger.Parse(values.ToString());
        }

        private static ListNode CreateListNodeFromNumberReversed(BigInteger value)
        {
            if (value == 0)
            {
                return new ListNode();
            }

            ListNode? currentNode = null;
            ListNode? result = null;

            foreach (char numberChar in value.ToString().Reverse())
            {
                string numberText = numberChar.ToString();

                if (currentNode == null)
                {
                    currentNode = new ListNode(int.Parse(numberText));
                    result = currentNode;

                    continue;
                }

                currentNode.next = new ListNode(int.Parse(numberText));
                currentNode = currentNode.next;
            }

            return result ?? throw new InvalidOperationException();
        }
    }
}