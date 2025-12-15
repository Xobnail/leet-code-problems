namespace LeetCodeProblems.Problems._1351._Count_Negative_Numbers_in_a_Sorted_Matrix;

/// <summary>
/// 1351. Count Negative Numbers in a Sorted Matrix
/// </summary>
internal class P1351
{
    public int CountNegatives(int[][] grid)
    {
        if (grid.Length == 0) return 0;

        int result = 0;

        for (int i = grid.Length - 1, j = 0; i >= 0 && j < grid[0].Length;)
        {
            if (grid[i][j] < 0)
            {
                result += grid[i--].Length - j;
            }
            else
            {
                j++;
            }
        }

        return result;
    }

    //public int CountNegatives(int[][] grid)
    //{
    //    if (grid.Length == 0) return 0;

    //    int result = 0;

    //    for (int i = 0; i < grid.Length; i++)
    //    {
    //        result += CountNegatives(grid[i]);
    //    }

    //    return result;
    //}

    //public int CountNegatives(int[] row)
    //{
    //    if (row.Length == 1)
    //    {
    //        return row[0] < 0 ? 1 : 0;
    //    }

    //    int l = 0;
    //    int r = row.Length - 1;

    //    while (l < r)
    //    {
    //        int m = (l + r) / 2;

    //        if (row[m] >= 0)
    //        {
    //            l = m + 1;
    //        }

    //        if (row[m] < 0)
    //        {
    //            r = m;
    //        }
    //    }        

    //    return row[r] < 0 ? row.Length - r : 0;
    //}

    //public int CountNegatives(int[][] grid)
    //{
    //    if (grid.Length == 0) return 0;

    //    int result = 0;

    //    for (int i = 0; i < grid.Length; i++)
    //    {
    //        for (int j = 0; j < grid[i].Length; j++)
    //        {
    //            if (grid[i][j] < 0)
    //            {
    //                result += grid[i].Length - j;
    //                break;
    //            }
    //        }
    //    }

    //    return result;
    //}
}
