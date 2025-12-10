namespace LeetCodeProblems.Problems.P1;

/// <summary>
/// 1. Two Sum
/// </summary>
internal class P1
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] result = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (j == i)
                {
                    continue;
                }

                if (nums[i] + nums[j] == target)
                {
                    result[0] = i;
                    result[1] = j;

                    return result;
                }
            }
        }

        return result;
    }
}
