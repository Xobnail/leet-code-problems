namespace LeetCodeProblems.Problems._2133._Check_if_Every_Row_and_Column_Contains_All_Numbers;

/// <summary>
/// 2133. Check if Every Row and Column Contains All Numbers
/// </summary>
internal class P2133
{
    public bool CheckValid(int[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            HashSet<int> row = [];
            HashSet<int> col = [];

            for (int j = 0; j < matrix.Length; j++)
            {
                row.Add(matrix[i][j]);
                col.Add(matrix[j][i]);
            }

            for (int j = 1; j <= matrix.Length; j++)
            {
                if (!row.Contains(j) || !col.Contains(j))
                {
                    return false;
                }
            }
        }

        return true;
    }
}
