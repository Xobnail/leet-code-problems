using LeetCodeProblems.Problems.P94;

namespace LeetCodeProblems.Trees;

public static class TreePrinter
{
    public static void Print(this TreeNode root)
    {
        if (root == null)
        {
            Console.WriteLine("(empty)");
            return;
        }

        int maxLevel = MaxLevel(root);
        PrintNode(new List<TreeNode> { root }, 1, maxLevel);
    }

    private static void PrintNode(List<TreeNode> nodes, int level, int maxLevel)
    {
        if (nodes.Count == 0 || AllNull(nodes))
            return;

        int floor = maxLevel - level;
        int edgeLines = (int)Math.Pow(2, Math.Max(floor - 1, 0));
        int firstSpaces = (int)Math.Pow(2, floor) - 1;
        int betweenSpaces = (int)Math.Pow(2, floor + 1) - 1;

        PrintWhitespaces(firstSpaces);

        var newNodes = new List<TreeNode>();
        foreach (var node in nodes)
        {
            if (node != null)
            {
                Console.Write(node.val);
                newNodes.Add(node.left);
                newNodes.Add(node.right);
            }
            else
            {
                Console.Write(" ");
                newNodes.Add(null);
                newNodes.Add(null);
            }

            PrintWhitespaces(betweenSpaces);
        }
        Console.WriteLine();

        for (int i = 1; i <= edgeLines; i++)
        {
            for (int j = 0; j < nodes.Count; j++)
            {
                PrintWhitespaces(firstSpaces - i);

                if (nodes[j] == null)
                {
                    PrintWhitespaces(edgeLines * 2 + i + 1);
                    continue;
                }

                Console.Write(nodes[j].left != null ? "/" : " ");
                PrintWhitespaces(i * 2 - 1);
                Console.Write(nodes[j].right != null ? "\\" : " ");

                PrintWhitespaces(edgeLines * 2 - i);
            }
            Console.WriteLine();
        }

        PrintNode(newNodes, level + 1, maxLevel);
    }

    private static void PrintWhitespaces(int count)
    {
        for (int i = 0; i < count; i++)
            Console.Write(" ");
    }

    private static bool AllNull(List<TreeNode> list)
    {
        foreach (var n in list)
            if (n != null)
                return false;
        return true;
    }

    private static int MaxLevel(TreeNode node)
    {
        if (node == null) return 0;
        return Math.Max(MaxLevel(node.left), MaxLevel(node.right)) + 1;
    }
}
