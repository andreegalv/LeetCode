namespace LeetCode.Medium.AddTwoNumbers
{
    public class ListNode
    {
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }

        public int val { get; set; }

        public ListNode? next { get; set; }
    }
}