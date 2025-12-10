using LeetCodeProblems.Models;

namespace LeetCodeProblems.Problems.P226;

/// <summary>
/// 226. Invert Binary Tree
/// </summary>
internal class P226
{
    public TreeNode InvertTree(TreeNode root)
    {
        Traverse(root);

        return root;
    }

    public void Traverse(TreeNode node)
    {
        if (node == null)
        {
            return;
        }

        var buf = node.left;
        node.left = node.right;
        node.right = buf;

        Traverse(node.left);
        Traverse(node.right);
    }
}

//public class TreeNode
//{
//    public int val;
//    public TreeNode left;
//    public TreeNode right;
//    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
//    {
//        this.val = val;
//        this.left = left;
//        this.right = right;
//    }
//}
