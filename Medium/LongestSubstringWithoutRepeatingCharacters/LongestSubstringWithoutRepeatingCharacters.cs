namespace LeetCode.Medium.LongestSubstringWithoutRepeatingCharacters
{
    using System.Text;

    /*
        URL: https://leetcode.com/problems/longest-substring-without-repeating-characters/
    */

    public class LongestSubstringWithoutRepeatingCharacters
    {
        public static int GetLongestSubstringLength(string s)
        {
            Dictionary<string, int> substrings = [];

            // Sadly, StringBuilder doesn't have methods like "Contains, StartsWith, EndsWith",
            // we need to use the common string class. I keep the solution clear and simple 
            // optimization can be used but the code could be unreadable.
            string currentSubstring = string.Empty;

            foreach (char character in s)
            {
                string letter = character.ToString();

                if (!currentSubstring.Contains(letter))
                {
                    currentSubstring += letter;
                    if (!substrings.ContainsKey(currentSubstring))
                    {
                        substrings.Add(currentSubstring, currentSubstring.Length);
                    }
                }
                else
                {
                    StringBuilder newSubstringTemp = new(letter);
                    for (int i = currentSubstring.Length - 1; i >= 0; i--)
                    {
                        if (currentSubstring[i] != character)
                        {
                            newSubstringTemp.Insert(0, currentSubstring[i]);
                        }
                        else
                        {
                            break;
                        }
                    }

                    currentSubstring = newSubstringTemp.ToString();
                    if (!substrings.ContainsKey(letter))
                    {
                        substrings.Add(letter, currentSubstring.Length);
                    }
                }
            }

            return substrings.OrderByDescending(st => st.Value).FirstOrDefault().Value;
        }
    }
}