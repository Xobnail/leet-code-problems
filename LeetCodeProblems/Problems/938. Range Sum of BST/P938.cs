using LeetCodeProblems.Models;

namespace LeetCodeProblems.Problems._938._Range_Sum_of_BST;

/// <summary>
/// 938. Range Sum of BST
/// </summary>
internal class P938
{
    public int RangeSumBST(TreeNode root, int low, int high)
    {
        if (root == null)
        {
            return 0;
        }

        int result = 0;

        if (low <= root.val && root.val <= high)
        {
            result += root.val;
            result += RangeSumBST(root.right, low, high);
            result += RangeSumBST(root.left, low, high);
        }
        else
        {
            result += root.val < low
                ? RangeSumBST(root.right, low, high)
                : RangeSumBST(root.left, low, high);
        }

        return result;
    }
}
