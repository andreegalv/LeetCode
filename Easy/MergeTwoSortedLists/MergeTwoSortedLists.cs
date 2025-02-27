namespace LeetCode.Easy.MergeTwoSortedLists
{
    public class MergeTwoSortedLists
    {
        public static ListNode? Execute(ListNode? list1, ListNode? list2)
        {
            var list1Flatten = FlatNodes(list1);
            var list2Flatten = FlatNodes(list2);

            return MergeFlattenLists(list1Flatten, list2Flatten);
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

        private static ListNode? MergeFlattenLists(List<ListNode> list1, List<ListNode> list2)
        {
            if (list1.Count <= 0 && list2.Count <= 0)
            {
                return null;
            }

            var listsConcatened = list1.Concat(list2).OrderBy(l => l.val).ToList();


            ListNode? result = new ListNode(listsConcatened[0].val);
            ListNode? currentNode = result;

            foreach (var node in listsConcatened.Skip(1))
            {
                currentNode.next = new ListNode(node.val);
                currentNode = currentNode.next;
            }
            return result;
        }
    }
}
