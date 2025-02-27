namespace LeetCode.Easy.Palindrome
{
    public static class Palindrome
    {
        public static bool Execute(int x)
        {
            return x.ToString() == string.Join(string.Empty, x.ToString().Reverse());
        }
    }
}
