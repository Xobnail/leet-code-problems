namespace LeetCodeProblems.Problems.P349;

/// <summary>
/// 349. Intersection of Two Arrays
/// </summary>
internal class P349
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var result = new List<int>();

        var nums1Sorted = BubbleSort(nums1);
        var nums2Sorted = BubbleSort(nums2);

        for (int i = 0; i < nums1Sorted.Length; i++)
        {
            if (Find(nums2Sorted, nums1Sorted[i]))
            {
                if (!result.Contains(nums1Sorted[i]))
                {
                    result.Add(nums1Sorted[i]);
                }                
            }
        }

        return result.ToArray();
    }

    public bool Find(int[] nums, int target)
    {
        int l = 0;
        int r = nums.Length != 0 ? nums.Length - 1 : 0;

        while (l <= r)
        {
            var m = (l + r) / 2;

            if (nums[m] == target)
            {
                return true;
            }

            if (target < nums[m])
            {
                r = m - 1;
            }
            if (nums[m] < target)
            {
                l = m + 1;
            }
        }

        return false;
    }

    public int[] BubbleSort(int[] nums)
    {
        for (int k = nums.Length - 1; k > 0; k--)
        {
            for (int i = 0; i < k; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    nums[i] = nums[i] + nums[i + 1];
                    nums[i + 1] = nums[i] - nums[i + 1];
                    nums[i] = nums[i] - nums[i + 1];
                }
            }
        }

        return nums;
    }
}
