using LeetCodeProblems.Models;

namespace LeetCodeProblems.Problems._2326._Spiral_Matrix_IV;

/// <summary>
/// 2326. Spiral Matrix IV
/// </summary>
internal class P2326
{
    public int[][] SpiralMatrix(int m, int n, ListNode head)
    {
        int minSide = m < n ? m : n;
        int resultSize = m * n;
        int[][] result = new int[m][];

        for (int i = 0; i < m; i++)
            result[i] = new int[n];

        for (int count = 0, iteration = 0; iteration < (minSide + 1) / 2; iteration++)
        {
            for (int i = iteration; i < n - iteration; i++, count++)
            {
                result[iteration][i] = head != null ? head.val : -1;
                head = head?.next;
            }                

            if (count == resultSize)
                break;

            for (int i = 1 + iteration; i < m - iteration; i++, count++)
            {
                result[i][n - 1 - iteration] = head != null ? head.val : -1;
                head = head?.next;
            }

            if (count == resultSize)
                break;

            for (int i = n - 2 - iteration; i >= iteration; i--, count++)
            {
                result[m - 1 - iteration][i] = head != null ? head.val : -1;
                head = head?.next;
            }

            if (count == resultSize)
                break;

            for (int i = m - 2 - iteration; i >= iteration + 1; i--, count++)
            {
                result[i][iteration] = head != null ? head.val : -1;
                head = head?.next;
            }
        }

        return result;
    }
}
