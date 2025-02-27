using System.Text;

namespace LeetCode.Easy.LongestCommonPrefix
{
    public static class LongestCommonPrefix
    {
        public static string Execute(string[] strs)
        {
            StringBuilder commonPrefix = new();
            string commonPhrase = strs[0];

            for (int i = 0; i < commonPhrase.Length; i++)
            {
                char letter = commonPhrase[i];
                if (strs.All(s => i < s.Length && s[i] == letter))
                {
                    commonPrefix.Append(letter);
                }
                else
                {
                    break;
                }
            }

            return commonPrefix.ToString();
        }
    }
}
