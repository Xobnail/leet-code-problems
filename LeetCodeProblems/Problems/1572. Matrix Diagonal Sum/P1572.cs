namespace LeetCodeProblems.Problems._1572._Matrix_Diagonal_Sum;

/// <summary>
/// 1572. Matrix Diagonal Sum
/// </summary>
internal class P1572
{
    public int DiagonalSum(int[][] mat)
    {
        int n = mat.Length;
        int sum = 0;

        for (int i = 0, aj = 0, bj = n - 1; i < n; i++, aj++, bj--)
        {
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
