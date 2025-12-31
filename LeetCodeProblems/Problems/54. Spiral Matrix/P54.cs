namespace LeetCodeProblems.Problems._54._Spiral_Matrix;

/// <summary>
/// 54. Spiral Matrix
/// </summary>
internal class P54
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        int m = matrix.Length;
        int n = matrix[0].Length;
        int minSide = m < n ? m : n;
        int resultSize = m * n;
        List<int> result = [];

        for (int count = 0, iteration = 0; iteration < (minSide + 1) / 2; iteration++)
        {
            for (int i = iteration; i < n - iteration; i++, count++)
                result.Add(matrix[iteration][i]);

            if (count == resultSize) 
                break;

            for (int i = 1 + iteration; i < m - iteration; i++, count++)
                result.Add(matrix[i][n - 1 - iteration]);

            if (count == resultSize) 
                break;

            for (int i = n - 2 - iteration; i >= iteration; i--, count++)
                result.Add(matrix[m - 1 - iteration][i]);

            if (count == resultSize) 
                break;

            for (int i = m - 2 - iteration; i >= iteration + 1; i--, count++)
                result.Add(matrix[i][iteration]);
        }

        return result;
    }
}
