using LeetCodeProblems.Models;

namespace LeetCodeProblems.Problems.P2236;

/// <summary>
/// 2236. Root Equals Sum of Children
/// </summary>
internal class P2236
{
    public bool CheckTree(TreeNode root)
    {
        return root.val == root.left.val + root.right.val;
    }
}
