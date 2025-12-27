using System.Globalization;

namespace LeetCodeProblems.Problems._1277._Count_Square_Submatrices_with_All_Ones;

/// <summary>
/// 1277. Count Square Submatrices with All Ones
/// </summary>
internal class P1277
{
    public int CountSquares(int[][] matrix)
    {
        int m = matrix.Length;
        int n = matrix[0].Length;
        int[,] mem = new int[m + 1, n + 1];
        int result = 0;        

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i][j] != 1)
                {
                    continue;
                }

                int topLeft = mem[i, j];
                int topRight = mem[i, j + 1];
                int bottomLeft = mem[i + 1, j];

                mem[i + 1, j + 1] = Min(topLeft, bottomLeft, topRight) + 1;
                result += mem[i + 1, j + 1];
            }
        }

        return result;
    }

    public int Min(int a, int b, int c)
    {
        return Math.Min(a, Math.Min(b, c));
    }

    //public int CountSquares(int[][] matrix)
    //{
    //    int result = 0;
    //    int m = matrix.Length;
    //    int n = matrix[0].Length;
    //    int maxWindowWidth = m > n ? n : m;

    //    for (int w = 1; w <= maxWindowWidth; w++)
    //        for (int k = 0; k <= m - w; k++)
    //            for (int l = 0; l <= n - w; l++)
    //                result += IsGood(matrix, w, k, l);

    //    return result;
    //}

    //public int IsGood(int[][] matrix, int w, int k, int l)
    //{
    //    for (int i = k; i < k + w; i++)
    //        for (int j = l; j < l + w; j++)
    //            if (matrix[i][j] == 0) return 0;

    //    return 1;
    //}
}
