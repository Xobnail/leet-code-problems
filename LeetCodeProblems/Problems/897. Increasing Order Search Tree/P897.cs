using LeetCodeProblems.Models;

namespace LeetCodeProblems.Problems.P897;

/// <summary>
/// 897. Increasing Order Search Tree
/// </summary>
internal class P897
{
    public TreeNode IncreasingBST(TreeNode root)
    {
        var inorder = new TreeNode();
        Traverse(root, inorder);
        DeleteLastNull(inorder);
        return inorder;
    }

    public TreeNode Traverse(TreeNode node, TreeNode inorder)
    {
        if (node.left != null)
        {
            inorder = Traverse(node.left, inorder);
        }

        inorder.val = node.val;
        inorder.right = new TreeNode();
        inorder = inorder.right;

        if (node.right != null)
        {
            inorder = Traverse(node.right, inorder);
        }

        return inorder;
    }

    public void DeleteLastNull(TreeNode node)
    {
        if (node == null)
        {
            return;
        }

        if (node.right?.right == null)
        {
            node.right = null;

            return;
        }

        DeleteLastNull(node.right);
    }

    //public TreeNode IncreasingBST(TreeNode root)
    //{
    //    var inorder = new Stack<int>();

    //    Traverse(root, inorder);

    //    TreeNode result = null;
    //    while (inorder.TryPop(out int value))
    //    {
    //        result = new TreeNode(value, null, result);
    //    }

    //    return result;
    //}

    //public void Traverse(TreeNode node, Stack<int> inorder)
    //{
    //    if (node.left != null)
    //    {
    //        Traverse(node.left, inorder);
    //    }

    //    inorder.Push(node.val);

    //    if (node.right != null)
    //    {
    //        Traverse(node.right, inorder);
    //    }
    //}
}
