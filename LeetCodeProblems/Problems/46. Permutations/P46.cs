namespace LeetCodeProblems.Problems.P46;

/// <summary>
/// 46. Permutations
/// </summary>
internal class P46
{
    public IList<IList<int>> Permute(int[] nums)
    {
        var result = new HashSet<IList<int>>(GetPermutations(nums.ToList()));

        return result.ToList();
    }

    public List<List<int>> GetPermutations(List<int> nums)
    {
        if (nums.Count == 1)
        {
            return [[nums[0]]];
        }

        if (nums.Count == 2)
        {
            return [[nums[0], nums[1]], [nums[1], nums[0]]];
        }

        List<List<int>> result = [];

        foreach (var num in nums)
        {
            var permutations = GetPermutations(nums.Except([num]).ToList());

            foreach (var permutation in permutations)
            {
                permutation.Insert(0, num);

                result.Add(permutation);
            }
        }

        return result;
    }
}
