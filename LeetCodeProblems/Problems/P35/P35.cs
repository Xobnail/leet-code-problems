namespace LeetCodeProblems.Problems.P35;

/// <summary>
/// 35. Search Insert Position
/// </summary>
internal class P35
{
    public int SearchInsert(int[] nums, int target)
    {
        int l = 0;
        int r = nums.Length - 1;
        int m = 0;

        while (l <= r)
        {
            m = (l + r) / 2;

            if (nums[m] == target)
            {
                return m;
            }

            if (target < nums[m])
            {
                r = m - 1;
            }
            else
            {
                l = m + 1;
            }
        }

        return nums[m] > target ? m : m + 1;
    }
}
