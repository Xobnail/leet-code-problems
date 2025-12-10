namespace LeetCodeProblems.Problems.P88;

/// <summary>
/// 88. Merge Sorted Array
/// </summary>
internal class P88
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        for (int i = m, j = 0; i < m + n && n > 0; i++, j++)
        {
            nums1[i] = nums2[j];
        }

        for (int l = 0; l < m + n - 1; l++)
        {
            for (int i = 0; i < m + n - l - 1; i++)
            {
                if (nums1[i] > nums1[i + 1])
                {
                    nums1[i] = nums1[i] + nums1[i + 1];
                    nums1[i + 1] = nums1[i] - nums1[i + 1];
                    nums1[i] = nums1[i] - nums1[i + 1];
                }
            }
        }
    }
}
