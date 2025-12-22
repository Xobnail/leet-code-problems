using LeetCodeProblems.Models;

namespace LeetCodeProblems.Problems._998._Maximum_Binary_Tree_II;

/// <summary>
/// 998. Maximum Binary Tree II
/// </summary>
internal class P998
{
    public TreeNode InsertIntoMaxTree(TreeNode root, int val)
    {
        if (root == null) return new TreeNode(val);

        if (root.val < val) return new TreeNode(val, root);

        root.right = InsertIntoMaxTree(root.right, val);

        return root;
    }
}
