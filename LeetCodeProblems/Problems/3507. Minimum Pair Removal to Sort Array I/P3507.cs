namespace LeetCodeProblems.Problems._3507._Minimum_Pair_Removal_to_Sort_Array_I;

/// <summary>
/// 3507. Minimum Pair Removal to Sort Array I
/// </summary>
internal class P3507
{
    public int MinimumPairRemoval(int[] nums)
    {
        List<int> list = new(nums);
        int operations = 0;

        for (; !IsSorted(list); operations++)
        {
            int min = list[0] + list[1];
            int minIndex = 0;

            for (int i = list.Count - 1; i >= 1; i--)
            {
                if (list[i] + list[i - 1] <= min)
                {
                    min = list[i] + list[i - 1];
                    minIndex = i - 1;
                }
            }

            list[minIndex] = min;
            list.RemoveAt(minIndex + 1);
        }

        return operations;
    }

    public bool IsSorted(List<int> nums)
    {
        for (int i = 0; i < nums.Count - 1; i++)
        {
            if (nums[i] > nums[i + 1]) return false;
        }

        return true;
    }
}
