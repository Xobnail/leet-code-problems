using LeetCodeProblems.Models;

namespace LeetCodeProblems.Problems._654._Maximum_Binary_Tree;

/// <summary>
/// 654. Maximum Binary Tree
/// </summary>
internal class P654
{
    public TreeNode ConstructMaximumBinaryTree(int[] nums)
    {
        return AddMax(nums, 0, nums.Length - 1);
    }

    public TreeNode AddMax(int[] nums, int l, int r)
    {
        if (l > r) return null;

        int m = 0;

        for (int i = l, maxVal = -1; i <= r; i++)
        {
            if (nums[i] > maxVal)
            {
                maxVal = nums[i];
                m = i;
            }
        }

        return new(nums[m], AddMax(nums, l, m - 1), AddMax(nums, m + 1, r));
    }
}
