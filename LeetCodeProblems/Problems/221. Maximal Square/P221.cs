namespace LeetCodeProblems.Problems._221._Maximal_Square;

/// <summary>
/// 221. Maximal Square
/// </summary>
internal class P221
{
    public int MaximalSquare(char[][] matrix)
    {
        int m = matrix.Length;
        int n = matrix[0].Length;
        int[,] mem = new int[m + 1, n + 1];
        int maxSquareSide = 0;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i][j] != '1')
                {
                    continue;
                }

                int topLeft = mem[i, j];
                int topRight = mem[i, j + 1];
                int bottomLeft = mem[i + 1, j];

                mem[i + 1, j + 1] = Min(topLeft, bottomLeft, topRight) + 1;

                if (mem[i + 1, j + 1] > maxSquareSide)
                {
                    maxSquareSide = mem[i + 1, j + 1];
                }
            }
        }

        return maxSquareSide * maxSquareSide;
    }

    public int Min(int a, int b, int c)
    {
        return Math.Min(a, Math.Min(b, c));
    }
}
