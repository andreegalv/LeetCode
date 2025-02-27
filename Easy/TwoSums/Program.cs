
Console.WriteLine(string.Join(",", Run([3, 2, 4], 6)));


static int[] Run(int[] nums, int target)
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
