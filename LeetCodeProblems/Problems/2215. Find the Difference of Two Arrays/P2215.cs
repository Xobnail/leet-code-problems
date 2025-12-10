namespace LeetCodeProblems.Problems.P2215;

/// <summary>
/// 2215. Find the Difference of Two Arrays
/// </summary>
internal class P2215
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        var nums1Set = new HashSet<int>(nums1);
        var nums2Set = new HashSet<int>(nums2);

        for (int i = 0; i < nums1.Length; i++)
        {
            if (nums2Set.Contains(nums1[i]))
            {
                nums1Set.Remove(nums1[i]);
                nums2Set.Remove(nums1[i]);
            }
        }

        for (int i = 0; i < nums2.Length; i++)
        {
            if (nums1Set.Contains(nums2[i]))
            {
                nums2Set.Remove(nums2[i]);
                nums1Set.Remove(nums2[i]);
            }
        }

        return [[.. nums1Set], [.. nums2Set]];
    }
}
