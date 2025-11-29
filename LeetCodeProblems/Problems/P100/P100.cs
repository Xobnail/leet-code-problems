using LeetCodeProblems.Models;

namespace LeetCodeProblems.Problems.P100;

/// <summary>
/// 100. Same Tree
/// </summary>
internal class P100
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
        {
            return true;
        }

        return AreNodesTheSame(p, q);
    }

    public bool AreNodesTheSame(TreeNode p, TreeNode q)
    {
        if (p == null && q != null || p != null && q == null 
            || p.val != q.val
            || p.left == null && q.left != null || p.left != null && q.left == null
            || p.right == null && q.right != null || p.right != null && q.right == null)
        {
            return false;
        }

        bool l = true;
        bool r = true;

        if (p.left != null && q.left != null)
        {
            l = AreNodesTheSame(p.left, q.left);
        }

        if (p.right != null && q.right != null)
        {
            r = AreNodesTheSame(p.right, q.right);
        }
        
        return l && r;
    }
}
