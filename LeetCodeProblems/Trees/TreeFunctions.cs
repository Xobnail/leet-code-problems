namespace LeetCodeProblems.Trees;

public static class TreeFunctions
{
    public static TreeNode BuildTree(this int?[] nums)
    {
        if (nums.Length == 0 || nums[0] == null)
        {
            return null;
        }

        TreeNode root = new TreeNode(nums[0].Value);
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);

        int i = 1;

        while (q.Count > 0 && i < nums.Length)
        {
            TreeNode currentNode = q.Dequeue();

            if (i < nums.Length && nums[i] != null)
            {
                currentNode.left = new TreeNode(nums[i].Value);

                q.Enqueue(currentNode.left);
            }

            i++;

            if (i < nums.Length && nums[i] != null)
            {
                currentNode.right = new TreeNode(nums[i].Value);

                q.Enqueue(currentNode.right);
            }

            i++;
        }

        return root;
    }
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
