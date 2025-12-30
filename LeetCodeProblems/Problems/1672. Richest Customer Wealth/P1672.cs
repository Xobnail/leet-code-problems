namespace LeetCodeProblems.Problems._1672._Richest_Customer_Wealth;

/// <summary>
/// 1672. Richest Customer Wealth
/// </summary>
internal class P1672
{
    public int MaximumWealth(int[][] accounts)
    {
        int max = 0;

        for (int i = 0; i < accounts.Length; i++)
        {
            int wealth = 0;

            for (int j = 0; j < accounts[i].Length; j++)
            {
                wealth += accounts[i][j];
            }

            max = Math.Max(max, wealth);
        }

        return max;
    }
}
