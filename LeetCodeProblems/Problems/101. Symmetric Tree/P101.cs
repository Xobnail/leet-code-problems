using LeetCodeProblems.Models;

namespace LeetCodeProblems.Problems._101._Symmetric_Tree;

/// <summary>
/// 101. Symmetric Tree
/// </summary>
internal class P101
{
    public bool IsSymmetric(TreeNode root)
    {
        return Traverse(root.left, root.right);
    }

    public bool Traverse(TreeNode left, TreeNode right)
    {
        if (left == null && right == null)
        {
            return true;
        }

        if (left == null ^ right == null)
        {
            return false;
        }

        var r1 = Traverse(left.left, right.right);

        if (left.val != right.val)
        {
            return false;
        }

        var r2 = Traverse(left.right, right.left);

        return r1 && r2;
    }
}
