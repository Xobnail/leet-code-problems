using LeetCodeProblems.Trees;

namespace LeetCodeProblems.Problems.P144;

/// <summary>
/// 144. Binary Tree Preorder Traversal
/// </summary>
internal class P144
{
    /// <summary>
    /// Прямой обход бинарного дерева.
    /// Принцип:
    /// Проходимся рекурсивно для каждого узла:
    /// 1. Смотрим сам этот узел.
    /// 2. Обходим левое поддерево (используя эти же правила).
    /// 3. Обходим правое поддерево (используя эти же правила).
    /// </summary>
    public IList<int> PreorderTraversal(TreeNode root)
    {
        var result = new List<int>();

        PreorderTraverseNode(root, result);

        return result;
    }

    public void PreorderTraverseNode(TreeNode node, IList<int> result)
    {
        if (node == null)
        {
            return;
        }

        result.Add(node.val);

        PreorderTraverseNode(node.left, result);

        PreorderTraverseNode(node.right, result);
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
