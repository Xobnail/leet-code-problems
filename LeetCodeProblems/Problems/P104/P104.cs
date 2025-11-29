using LeetCodeProblems.Models;

namespace LeetCodeProblems.Problems.P104;

/// <summary>
/// 104. Maximum Depth of Binary Tree
/// </summary>
internal class P104
{
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        return GetMaxDepthOfNode(root);
    }

    public int GetMaxDepthOfNode(TreeNode node)
    {
        if (node.left == null && node.right == null)
        {
            return 1;
        }

        int left = 0;
        int right = 0;

        if (node.left != null)
        {
            left = GetMaxDepthOfNode(node.left);
        }

        if (node.right != null)
        {
            right = GetMaxDepthOfNode(node.right);
        }

        return 1 + (right > left ? right : left);
    }
}
