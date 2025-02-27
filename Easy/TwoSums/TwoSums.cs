namespace LeetCode.Easy.TwoSums
{
    public static class TwoSums
    {
        public static int[] Execute(int[] nums, int target)
        {
            var numsDictionary = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];

                if (numsDictionary.ContainsKey(diff))
                {
                    return [numsDictionary[diff], i];
                }
                else
                {
                    numsDictionary[nums[i]] = i;
                }
            }

            throw new ArgumentOutOfRangeException();
        }
    }
}