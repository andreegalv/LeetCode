namespace RomanToInteger
{
    using System;
    using System.Text;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Run("III"));

            Console.WriteLine(Run("IV"));
            Console.WriteLine(Run("VII"));
            Console.WriteLine(Run("VIII"));
            Console.WriteLine(Run("IX"));
            Console.WriteLine(Run("XL"));

            Console.WriteLine(Run("LVIII"));
            Console.WriteLine(Run("MCMXCIV"));
        }

        private static Dictionary<char, int> _romanNumbers = new()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };

        private static int Run(string s)
        {
            List<(string Letter, int Value)> romanValues = s.Select(c => (c.ToString(), _romanNumbers[c])).ToList();
            int currentResult = 0;
            int previousNumber = 0;
            StringBuilder currentLetter = new();
            List<string> letters = [];

            foreach (var romanValue in romanValues)
            {
                if (currentLetter.Length == 2)
                {
                    currentLetter.Remove(0, 1);
                }

                currentLetter.Append(romanValue.Letter);

                if (IsSubstraction(currentLetter.ToString(), out int totalSubstraction))
                {
                    currentResult = currentResult - previousNumber + totalSubstraction;
                    currentLetter.Clear();
                }
                else
                {
                    currentResult += romanValue.Value;
                }

                previousNumber = romanValue.Value;
            }

            return currentResult;
        }

        private static Dictionary<string, int> _substractionRules = new()
        {
            { "IV", 4 },
            { "IX", 9 },
            { "XL", 40 },
            { "XC", 90 },
            { "CD", 400 },
            { "CM", 900 },
        };

        private static bool IsSubstraction(string letter, out int value)
        {
            value = 0;

            bool isSubstraction = _substractionRules.ContainsKey(letter);

            if (isSubstraction)
            {
                value = _substractionRules[letter];
            }

            return isSubstraction;
        }
    }
}