using LeetCodeProblems.Models;

namespace LeetCodeProblems.Problems.P145;

/// <summary>
/// 145. Binary Tree Postorder Traversal
/// </summary>
internal class P145
{
    /// <summary>
    /// Обход бинарного дерева в обратном порядке.
    /// Принцип:
    /// Проходимся рекурсивно для каждого узла:
    /// 1. Обходим левое поддерево (используя эти же правила).
    /// 2. Обходим правое поддерево (используя эти же правила).
    /// 3. Смотрим сам этот узел.
    /// </summary>
    public IList<int> PostorderTraversal(TreeNode root)
    {
        var result = new List<int>();

        PostorderTraverseNode(root, result);

        return result;
    }

    public void PostorderTraverseNode(TreeNode node, IList<int> result)
    {
        if (node == null)
        {
            return;
        }

        PostorderTraverseNode(node.left, result);

        PostorderTraverseNode(node.right, result);

        result.Add(node.val);
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
