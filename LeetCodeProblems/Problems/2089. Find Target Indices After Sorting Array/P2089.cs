namespace LeetCodeProblems.Problems._2089._Find_Target_Indices_After_Sorting_Array;

/// <summary>
/// 2089. Find Target Indices After Sorting Array
/// </summary>
internal class P2089
{
    public IList<int> TargetIndices(int[] nums, int target)
    {
        int lowerCount = 0;
        int targetCount = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < target)
            {
                lowerCount++;
            }

            if (nums[i] == target)
            {
                targetCount++;
            }
        }

        int[] result = new int[targetCount];

        for (int i = 0, j = lowerCount; i < targetCount; i++, j++)
        {
            result[i] = j;
        }

        return result;
    }

    // Quick sort + binary search
    //public IList<int> TargetIndices(int[] nums, int target)
    //{
    //    QuickSort(nums);

    //    int lBorder = GetLeftBorder(nums, target);
    //    int rBorder = GetRightBorder(nums, target);

    //    if (nums[lBorder] != target)
    //    {
    //        return [];
    //    }

    //    int[] result = new int[rBorder - lBorder + 1];

    //    for (int t = lBorder, i = 0; t <= rBorder; i++, t++)
    //    {
    //        result[i] = t;
    //    }

    //    return result;
    //}

    //public void QuickSort(int[] nums)
    //{
    //    QuickSort(nums, 0, nums.Length - 1);
    //}

    //public void QuickSort(int[] nums, int l, int r)
    //{
    //    if (l >= r)
    //    {
    //        return;
    //    }

    //    int pivot = nums[r];

    //    int i = l;
    //    for (int j = l; j < r; j++)
    //    {
    //        if (nums[j] < pivot)
    //        {
    //            Swap(nums, j, i);
    //            i++;
    //        }
    //    }

    //    Swap(nums, r, i);

    //    QuickSort(nums, l, i - 1);
    //    QuickSort(nums, i + 1, r);
    //}

    //public void Swap(int[] nums, int a, int b)
    //{
    //    if (a == b)
    //    {
    //        return;
    //    }

    //    nums[b] += nums[a];
    //    nums[a] = nums[b] - nums[a];
    //    nums[b] -= nums[a];
    //}

    //public int GetLeftBorder(int[] nums, int target)
    //{
    //    int l = 0;
    //    int r = nums.Length - 1;

    //    while (l < r)
    //    {
    //        int m = (l + r) / 2;

    //        if (nums[m] >= target)
    //        {
    //            r = m;
    //        }
    //        else
    //        {
    //            l = m + 1;
    //        }
    //    }

    //    return l;
    //}

    //public int GetRightBorder(int[] nums, int target)
    //{
    //    int l = 0;
    //    int r = nums.Length - 1;

    //    while (l < r)
    //    {
    //        int m = l + (r - l + 1) / 2;

    //        if (nums[m] <= target)
    //        {
    //            l = m;
    //        }
    //        else
    //        {
    //            r = m - 1;
    //        }
    //    }

    //    return r;
    //}

    // BF
    //public IList<int> TargetIndices(int[] nums, int target)
    //{
    //    List<int> result = new();
    //    int[] sNums = BubbleSort(nums);

    //    for (int i = 0; i < sNums.Length; i++)
    //    {
    //        if (sNums[i] == target)
    //        {
    //            result.Add(i);
    //        }
    //    }

    //    return result;
    //}

    //public int[] BubbleSort(int[] nums)
    //{
    //    for (int i = nums.Length - 1; i >= 0; i--)
    //    {
    //        for (int j = 0; j < i; j++)
    //        {
    //            if (nums[j] > nums[j + 1])
    //            {
    //                nums[j] += nums[j + 1];
    //                nums[j + 1] = nums[j] - nums[j + 1];
    //                nums[j] -= nums[j + 1];
    //            }
    //        }
    //    }

    //    return nums;
    //}
}
