using LeetCodeProblems.Trees;

namespace LeetCodeProblems.Problems.P94;

/// <summary>
/// 94. Binary Tree Inorder Traversal
/// </summary>
internal class P94
{
    /// <summary>
    /// Симметричный обход бинарного дерева.
    /// Принцип:
    /// Проходимся рекурсивно для каждого узла:
    /// 1. Обходим левое поддерево (используя эти же правила).
    /// 2. Смотрим сам этот узел.
    /// 3. Обходим правое поддерево (используя эти же правила).
    /// </summary>
    public IList<int> InorderTraversal(TreeNode root)
    {
        var result = new List<int>();

        InorderTraverseNode(root, result);

        return result;
    }

    public void InorderTraverseNode(TreeNode node, IList<int> result)
    {
        if (node == null)
        {
            return;
        }

        InorderTraverseNode(node.left, result);

        result.Add(node.val);

        InorderTraverseNode(node.right, result);
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
