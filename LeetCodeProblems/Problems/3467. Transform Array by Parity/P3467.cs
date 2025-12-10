namespace LeetCodeProblems.Problems.P3467;

/// <summary>
/// 3467. Transform Array by Parity
/// </summary>
internal class P3467
{
    /// <summary>
    /// Одним циклом
    /// </summary>
    public int[] TransformArray(int[] nums)
    {
        int[] result = new int[nums.Length];

        for (int i = 0, j = nums.Length - 1; i < nums.Length; i++)
        {
            if (nums[i] % 2 > 0)
            {
                result[j--] = 1;
            }
        }

        return result;
    }

    /// <summary>
    /// Решение в лоб
    /// </summary>
    public int[] TransformArray1(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = nums[i] % 2 == 0 ? 0 : 1;
        }

        return BubbleSort(nums);
    }

    public int[] BubbleSort(int[] nums)
    {
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (nums[j] > nums[j + 1])
                {
                    nums[j] += nums[j + 1];
                    nums[j + 1] = nums[j] - nums[j + 1];
                    nums[j] -= nums[j + 1];
                }
            }
        }

        return nums;
    }
}
