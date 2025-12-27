namespace LeetCodeProblems.Problems._48._Rotate_Image;

/// <summary>
/// 48. Rotate Image
/// </summary>
internal class P48
{
    public void Rotate(int[][] matrix)
    {
        int n = matrix.Length;

        for (int i = 0, j = n - 1; i < j; i++, j--)
        {
            int[] temp = matrix[i];
            matrix[i] = matrix[j];
            matrix[j] = temp;
        }

        //PrintMatrix(matrix);

        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                if (i == j)
                {
                    continue;
                }

                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }

        //PrintMatrix(matrix);
    }

    //public void PrintMatrix(int[][] matrix)
    //{
    //    for(int i = 0; i < matrix.Length; i++)
    //    {
    //        for (int j =0; j < matrix[i].Length; j++)
    //        {
    //            Console.Write(matrix[i][j]);
    //        }

    //        Console.Write("\n");
    //    }

    //    Console.Write("\n");
    //}
}
