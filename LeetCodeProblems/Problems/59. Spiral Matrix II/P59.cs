namespace LeetCodeProblems.Problems._59._Spiral_Matrix_II;

/// <summary>
/// 59. Spiral Matrix II
/// </summary>
internal class P59
{
    public int[][] GenerateMatrix(int n)
    {
        int resultSize = n * n;
        List<int> nums = [];
        int[][] result = new int[n][];

        for(int i = 0; i < n; i++)
            result[i] = new int[n];

        for (int i = 1; i <= resultSize; i++)
            nums.Add(i);

        for (int count = 0, iteration = 0; iteration < (n + 1) / 2; iteration++)
        {
            for (int i = iteration; i < n - iteration; i++, count++)
                result[iteration][i] = nums[count];

            if (count == resultSize)
                break;

            for (int i = 1 + iteration; i < n - iteration; i++, count++)
                result[i][n - 1 - iteration] = nums[count];

            if (count == resultSize)
                break;

            for (int i = n - 2 - iteration; i >= iteration; i--, count++)
                result[n - 1 - iteration][i] = nums[count];

            if (count == resultSize)
                break;

            for (int i = n - 2 - iteration; i >= iteration + 1; i--, count++)
                result[i][iteration] = nums[count];
        }

        return result;
    }
}
