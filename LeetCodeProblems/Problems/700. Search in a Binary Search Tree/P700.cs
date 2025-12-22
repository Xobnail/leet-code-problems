using LeetCodeProblems.Models;

namespace LeetCodeProblems.Problems._700._Search_in_a_Binary_Search_Tree;

/// <summary>
/// 700. Search in a Binary Search Tree
/// </summary>
internal class P700
{
    public TreeNode SearchBST(TreeNode root, int val)
    {
        if (root == null) 
            return null;
        else if(root.val > val) 
            return SearchBST(root.left, val);
        else if (root.val < val) 
            return SearchBST(root.right, val);
        else
            return root;
    }
}
