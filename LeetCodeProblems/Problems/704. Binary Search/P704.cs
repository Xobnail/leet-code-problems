namespace LeetCodeProblems.Problems.P704;

/// <summary>
/// 704. Binary Search
/// </summary>
internal class P704
{
    public int Search(int[] nums, int target)
    {
        int length = nums.Length;

        int right = length != 0 ? length - 1 : 0;
        int left = 0;

        while (left <= right)
        {
            var i = (right + left) / 2;

            if (nums[i] == target)
            {
                return i;
            }

            if (target > nums[i])
            {
                left = i + 1;
            }
            else
            {
                right = i - 1;
            }
        }

        return -1;
    }
}
