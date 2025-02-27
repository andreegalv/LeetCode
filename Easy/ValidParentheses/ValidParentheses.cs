namespace LeetCode.Easy.ValidParentheses
{
    public static class ValidParentheses
    {
        private static Dictionary<char, char> _openedParentheses = new()
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };

        private static Dictionary<char, char> _closedParentheses = new()
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

        public static bool Execute(string s)
        {
            List<char> _parenthesesOrderedStep = [];

            for (int i = 0; i < s.Length; i++)
            {
                char parenthes = s[i];

                if (i == 0 && !_openedParentheses.ContainsKey(parenthes))
                {
                    return false;
                }

                if (_openedParentheses.ContainsKey(parenthes))
                {
                    _parenthesesOrderedStep.Add(parenthes);
                }
                else
                {
                    if (_parenthesesOrderedStep.Count <= 0)
                    {
                        return false;
                    }

                    if (_parenthesesOrderedStep.Last() == _closedParentheses[parenthes])
                    {
                        _parenthesesOrderedStep.RemoveAt(_parenthesesOrderedStep.Count - 1);
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return _parenthesesOrderedStep.Count == 0;
        }
    }
}