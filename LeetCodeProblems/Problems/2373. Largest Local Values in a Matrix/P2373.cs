namespace LeetCodeProblems.Problems._2373._Largest_Local_Values_in_a_Matrix;

/// <summary>
/// 2373. Largest Local Values in a Matrix
/// </summary>
internal class P2373
{
    public int[][] LargestLocal(int[][] grid)
    {
        int n = grid.Length;
        int[][] maxLocal = new int[n - 2][];

        for (int i = 0; i < maxLocal.Length; i++)
        {
            maxLocal[i] = new int[n - 2];

            for (int j = 0; j < maxLocal[i].Length; j++)
            {
                maxLocal[i][j] = GetLargestValue(grid, i, j);
            }
        }

        return maxLocal;
    }

    public int GetLargestValue(int[][] grid, int i, int j)
    {
        int result = 1;

        for (int r = i; r < i + 3; r++)
        {
            for (int c = j; c < j + 3; c++)
            {
                if (grid[r][c] > result)
                {
                    result = grid[r][c];
                }
            }
        }

        return result;
    }
}
