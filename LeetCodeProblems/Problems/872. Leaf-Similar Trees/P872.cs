using LeetCodeProblems.Models;

namespace LeetCodeProblems.Problems.P872;

/// <summary>
/// 872. Leaf-Similar Trees
/// </summary>
internal class P872
{
    public bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        var leafs1 = new List<int>();
        var leafs2 = new List<int>();

        Traverse(root1, leafs1);
        Traverse(root2, leafs2);

        if (leafs1.Count != leafs2.Count)
        {
            return false;
        }

        for (int i = 0; i < leafs2.Count; i++)
        {
            if (leafs1[i] != leafs2[i])
            {
                return false;
            }
        }

        return true;
    }

    public void Traverse(TreeNode node, List<int> leafs)
    {
        if (node == null)
        {
            return;
        }

        Traverse(node.left, leafs);

        if (node.left == null && node.right == null)
        {
            leafs.Add(node.val);
        }

        Traverse(node.right, leafs);
    }
}
