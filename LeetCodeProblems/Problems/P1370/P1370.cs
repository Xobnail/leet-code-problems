using System.Text;

namespace LeetCodeProblems.Problems.P1370;

/// <summary>
/// 1370. Increasing Decreasing String
/// </summary>
internal class P1370
{
    public string SortString(string s)
    {
        List<int> result = [];
        int[] chars = new int[s.Length];

        for (int i = 0; i < s.Length; i++)
        {
            chars[i] = s[i];
        }

        List<int> sChars = BubbleSort(chars).ToList();

        while (sChars.Count > 0)
        {
            int min = 0;
            while (true)
            {
                var i = FindMinGreaterThan(sChars, min);

                if (i == null)
                {
                    break;
                }

                min = sChars[i.Value];
                result.Add(sChars[i.Value]);
                sChars.RemoveAt(i.Value);
            }

            if (sChars.Count == 0)
            {
                break;
            }

            int max = sChars.Last() + 1;
            while (true)
            {
                var i = FindMaxLessThan(sChars, max);

                if (i == null)
                {
                    break;
                }

                max = sChars[i.Value];
                result.Add(sChars[i.Value]);
                sChars.RemoveAt(i.Value);
            }
        }

        var sb = new StringBuilder();

        foreach (int c in result)
        {
            sb.Append((char)c);
        }

        return sb.ToString();
    }

    public int? FindMinGreaterThan(List<int> nums, int target)
    {
        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] > target)
            {
                return i;
            }
        }

        return null;
    }

    public int? FindMaxLessThan(List<int> nums, int target)
    {
        for (int i = nums.Count - 1; i >= 0; i--)
        {
            if (nums[i] < target)
            {
                return i;
            }
        }

        return null;
    }

    public int[] BubbleSort(int[] s)
    {
        for (int i = s.Length - 1; i >= 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (s[j] > s[j + 1])
                {
                    s[j] += s[j + 1];
                    s[j + 1] = s[j] - s[j + 1];
                    s[j] -= s[j + 1];
                }
            }
        }

        return s;
    }
}
