using LeetCodeProblems.Models;

namespace LeetCodeProblems.Problems.P2331;

/// <summary>
/// 2331. Evaluate Boolean Binary Tree
/// </summary>
internal class P2331
{
    public bool EvaluateTree(TreeNode root)
    {
        return root.val switch
        {
            1 => true,
            2 => EvaluateTree(root.left) || EvaluateTree(root.right),
            3 => EvaluateTree(root.left) && EvaluateTree(root.right),
            _ => false,
        };
    }
}
