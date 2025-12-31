using LeetCodeProblems.Models;

namespace LeetCodeProblems.Problems._617._Merge_Two_Binary_Trees;

/// <summary>
/// 617. Merge Two Binary Trees
/// </summary>
internal class P617
{
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
    {
        if (root1 == null && root2 != null || root1 == null && root2 == null)
        {
            return root2;
        }

        if (root1 != null && root2 == null)
        {
            return root1;
        }

        root1.val += root2.val;

        if (root2.left != null)
        {
            root1.left ??= new();
            MergeTrees(root1.left, root2.left);
        }

        if (root2.right != null)
        {
            root1.right ??= new();
            MergeTrees(root1.right, root2.right);
        }

        return root1;
    }
}
