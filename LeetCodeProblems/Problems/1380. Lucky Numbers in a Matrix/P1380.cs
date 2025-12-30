namespace LeetCodeProblems.Problems._1380._Lucky_Numbers_in_a_Matrix;

/// <summary>
/// 1380. Lucky Numbers in a Matrix
/// </summary>
internal class P1380
{
    public IList<int> LuckyNumbers(int[][] matrix)
    {
        int m = matrix.Length;
        int n = matrix[0].Length;
        List<int> result = [];

        for (int i = 0; i < m; i++)
        {
            int min = matrix[i][0];
            int minIndex = 0;

            for (int j = 0; j < n; j++)
            {
                if (matrix[i][j] < min)
                {
                    min = matrix[i][j];
                    minIndex = j;
                }
            }

            int max = 0;

            for (int k = 0; k < m; k++)
            {
                if (matrix[k][minIndex] > max)
                {
                    max = matrix[k][minIndex];
                }
            }

            if (min == max)
            {
                result.Add(max);
            }
        }

        return result;
    }
}
