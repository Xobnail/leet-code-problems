namespace LeetCodeProblems.Problems._268._Missing_Number;

/// <summary>
/// 268. Missing Number
/// </summary>
internal class P268
{
    public int MissingNumber(int[] nums)
    {
        int sum = 0;

        for (int i = 0; i <= nums.Length; i++)
            sum += i;

        for (int i = 0; i < nums.Length; i++)
            sum -= nums[i];

        return sum;
    }

    //public int MissingNumber(int[] nums)
    //{
    //    HashSet<int> mem = new(nums);

    //    for (int i = 0; i <= nums.Length; i++)
    //        if (!mem.Contains(i))
    //            return i;

    //    throw new Exception();
    //}
}
