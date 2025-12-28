namespace LeetCodeProblems.Problems._2367._Number_of_Arithmetic_Triplets;

/// <summary>
/// 2367. Number of Arithmetic Triplets
/// </summary>
internal class P2367
{
    public int ArithmeticTriplets(int[] nums, int diff)
    {
        HashSet<int> mem = new(nums);
        int result = 0;

        foreach (int jVal in nums)
        {
            if (mem.Contains(jVal - diff) && mem.Contains(jVal + diff))
            {
                result++;
            }
        }

        return result;
    }

    //public int ArithmeticTriplets(int[] nums, int diff)
    //{
    //    int result = 0;

    //    for (int j = 1;  j < nums.Length - 1; j++)
    //    {
    //        int target = nums[j] - diff;
    //        int targetIndex = BinarySearch(nums, target, 0, j - 1);

    //        if (target != nums[targetIndex])
    //        {
    //            continue;
    //        }

    //        target = nums[j] + diff;
    //        targetIndex = BinarySearch(nums, target, j + 1, nums.Length - 1);

    //        if (target != nums[targetIndex])
    //        {
    //            continue;
    //        }

    //        result++;
    //    }

    //    return result;
    //}

    //public int BinarySearch(int[] nums, int target, int l, int r)
    //{
    //    while (l < r)
    //    {
    //        int m = l + (r - l + 1) / 2;

    //        if (nums[m] > target)
    //        {
    //            r = m - 1;
    //        }
    //        else
    //        {
    //            l = m; 
    //        }
    //    }

    //    return l;
    //}

    //public int ArithmeticTriplets(int[] nums, int diff)
    //{
    //    int result = 0;

    //    for (int j = 1; j < nums.Length - 1; j++)
    //    {
    //        bool firstGood = false;
    //        bool secondGood = false;

    //        for (int i = 0; i < j; i++)
    //        {
    //            if (nums[j] - nums[i] == diff)
    //            {
    //                firstGood = true;
    //                break;
    //            }
    //        }

    //        for (int k = j + 1; k < nums.Length; k++)
    //        {
    //            if (nums[k] - nums[j] == diff)
    //            {
    //                secondGood = true;
    //                break;
    //            }
    //        }

    //        if (firstGood && secondGood)
    //        {
    //            result++;
    //        }
    //    }

    //    return result;
    //}
}
