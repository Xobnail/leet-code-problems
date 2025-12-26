namespace LeetCodeProblems.Problems._1365._How_Many_Numbers_Are_Smaller_Than_the_Current_Number;

/// <summary>
/// 1365. How Many Numbers Are Smaller Than the Current Number
/// </summary>
internal class P1365
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        int[] result = new int[nums.Length];
        int[,] numInd = new int[nums.Length, 2];
        Dictionary<int, int> mem = [];

        for (int i = 0; i < nums.Length; i++)
        {
            numInd[i, 0] = nums[i];
            numInd[i, 1] = i;
        }

        QuickSort(numInd);

        for (int i = 0; i < nums.Length; i++)
        {
            if (mem.TryGetValue(numInd[i, 0], out int value))
            {
                if (value < numInd[i, 1])
                {
                    mem[numInd[i, 0]] = value;
                }
            }
            else
            {
                mem.Add(numInd[i, 0], i);
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            int val = mem[numInd[i, 0]];
            result[numInd[i, 1]] = val;
        }

        return result;
    }

    public void QuickSort(int[,] nums)
    {
        QuickSort(nums, 0, nums.GetLength(0) - 1);
    }

    public void QuickSort(int[,] nums, int l, int r)
    {
        if (l >= r)
        {
            return;
        }

        int pivot = nums[r, 0];
        int i = l;

        for (int j = l; j < r; j++)
        {
            if (nums[j, 0] < pivot)
            {
                Swap(nums, i, j);
                i++;
            }
        }

        Swap(nums, i, r);

        QuickSort(nums, l, i - 1);
        QuickSort(nums, i + 1, r);
    }

    public void Swap(int[,] nums, int i, int j)
    {
        if (i == j || nums[i, 0] == nums[j, 0])
        {
            return;
        }

        nums[i, 0] += nums[j, 0];
        nums[j, 0] = nums[i, 0] - nums[j, 0];
        nums[i, 0] -= nums[j, 0];
        nums[i, 1] += nums[j, 1];
        nums[j, 1] = nums[i, 1] - nums[j, 1];
        nums[i, 1] -= nums[j, 1];
    }

    // BF
    //public int[] SmallerNumbersThanCurrent(int[] nums)
    //{
    //    int[] result = new int[nums.Length];

    //    for (int i = 0; i < nums.Length; i++)
    //    {
    //        int count = 0;

    //        for (int j = 0; j < nums.Length; j++)
    //        {
    //            if (i != j && nums[i] > nums[j])
    //            {
    //                count++;
    //            }
    //        }

    //        result[i] = count;
    //    }

    //    return result;
    //}
}
