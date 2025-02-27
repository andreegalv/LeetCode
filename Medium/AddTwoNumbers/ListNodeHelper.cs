namespace LeetCode.Medium.AddTwoNumbers
{
    using System.Text;

    public static class ListNodeHelper
    {
        public static string ToString(ListNode? list)
        {
            StringBuilder listNodeTextBuilder = new();
            ListNode? current = list;

            while (current != null)
            {
                if (listNodeTextBuilder.Length > 0)
                {
                    listNodeTextBuilder.Append(',');
                }

                listNodeTextBuilder.Append(current.val);

                current = current.next;
            }

            if (listNodeTextBuilder.Length <= 0)
            {
                return "[]";
            }

            listNodeTextBuilder.Insert(0, '[');
            listNodeTextBuilder.Append(']');

            return listNodeTextBuilder.ToString();
        }
    }
}