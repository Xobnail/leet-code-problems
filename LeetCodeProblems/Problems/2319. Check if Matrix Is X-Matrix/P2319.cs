namespace LeetCodeProblems.Problems._2319._Check_if_Matrix_Is_X_Matrix;

/// <summary>
/// 2319. Check if Matrix Is X-Matrix
/// </summary>
internal class P2319
{
    public bool CheckXMatrix(int[][] grid)
    {
        int diagSum = DiagonalSum(grid);
        int sum = 0;

        if (diagSum == -1)
        {
            return false;
        }

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid.Length;  j++)
            {
                sum += grid[i][j];
            }
        }

        return sum - diagSum == 0;
    }

    public int DiagonalSum(int[][] mat)
    {
        int n = mat.Length;
        int sum = 0;

        for (int i = 0, aj = 0, bj = n - 1; i < n; i++, aj++, bj--)
        {
            if (mat[i][aj] == 0 || mat[i][bj] == 0)
            {
                return -1;
            }

            if (aj == bj && aj == i)
            {
                sum += mat[i][aj];
                continue;
            }

            if (i == aj)
            {
                sum += mat[i][aj];
            }

            if (i == n - bj - 1)
            {
                sum += mat[i][bj];
            }
        }

        return sum;
    }
}
