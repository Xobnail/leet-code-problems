namespace LeetCodeProblems.Problems._1329._Sort_the_Matrix_Diagonally;

/// <summary>
/// 1329. Sort the Matrix Diagonally
/// </summary>
internal class P1329
{
    public int[][] DiagonalSort(int[][] mat)
    {
        int m = mat.Length;
        int n = mat[0].Length;
        int minSideSize = m < n ? m : n;
        Dictionary<int, List<int>> dioganals = [];

        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat[i].Length; j++)
            {
                int diff = i - j;

                if (!dioganals.ContainsKey(diff))
                {
                    dioganals.Add(diff, new List<int>(minSideSize));
                }

                dioganals[diff].Add(mat[i][j]);
            }
        }

        foreach (List<int> dioganal in dioganals.Values)
        {
            QuickSort(dioganal);
        }

        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat[i].Length; j++)
            {
                int diff = i - j;
                int ind = diff < 0 ? i : j;

                mat[i][j] = dioganals[diff][ind];
            }
        }

        return mat;
    }

    public void QuickSort(IList<int> nums)
    {
        QuickSort(nums, 0, nums.Count - 1);
    }

    public void QuickSort(IList<int> nums, int l, int r)
    {
        if (l >= r)
        {
            return;
        }

        int pivot = nums[r];

        int i = l;
        for (int j = l; j < r; j++)
        {
            if (nums[j] < pivot)
            {
                Swap(nums, j, i);
                i++;
            }
        }

        Swap(nums, r, i);

        QuickSort(nums, l, i - 1);
        QuickSort(nums, i + 1, r);
    }

    public void Swap(IList<int> nums, int a, int b)
    {
        if (a == b)
        {
            return;
        }

        nums[b] += nums[a];
        nums[a] = nums[b] - nums[a];
        nums[b] -= nums[a];
    }
}
