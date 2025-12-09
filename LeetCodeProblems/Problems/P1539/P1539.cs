namespace LeetCodeProblems.Problems.P1539;

/// <summary>
/// 1539. Kth Missing Positive Number
/// </summary>
internal class P1539
{
    public int FindKthPositive(int[] arr, int k)
    {
        int l = 0;
        int r = arr.Length;

        while (l < r)
        {
            int m = (l + r) / 2;
            int val = arr[m];

            if (val - (m + 1) >= k)
            {
                r = m;
            }
            else
            {
                l = m + 1;
            }
        }

        return l + k;
    }
}
