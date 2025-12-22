using LeetCodeProblems.Models;

namespace LeetCodeProblems.Problems._701._Insert_into_a_Binary_Search_Tree;

/// <summary>
/// 701. Insert into a Binary Search Tree
/// </summary>
internal class P701
{
    public TreeNode InsertIntoBST(TreeNode root, int val)
    {
        if (root == null) return new TreeNode(val);

        if (root.val > val && root.left == null)
        {
            root.left = new TreeNode(val);
            return root;
        }
        if (root.val < val && root.right == null)
        {
            root.right = new TreeNode(val);
            return root;
        }

        if (root.val > val)
        {
            InsertIntoBST(root.left, val);
        }
        else
        {
            InsertIntoBST(root.right, val);
        }

        return root;
    }
}
