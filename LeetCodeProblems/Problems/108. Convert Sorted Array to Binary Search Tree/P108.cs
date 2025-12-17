using LeetCodeProblems.Models;

namespace LeetCodeProblems.Problems._108._Convert_Sorted_Array_to_Binary_Search_Tree;

/// <summary>
/// 108. Convert Sorted Array to Binary Search Tree
/// </summary>
internal class P108
{
    public TreeNode SortedArrayToBST(int[] nums)
    {
        if (nums.Length == 1) return new(nums[0]);
        if (nums.Length == 2) return new(nums[1], new(nums[0]));

        int m = nums.Length / 2;
        int[] left = new int[m];
        int[] right = new int[nums.Length - m - 1];

        for (int i = 0; i < m; i++)
        {
            left[i] = nums[i];
        }

        for (int i = m + 1, j = 0; i < nums.Length; i++, j++)
        {
            right[j] = nums[i];
        }

        return new(nums[m], SortedArrayToBST(left), SortedArrayToBST(right));
    }
}
