namespace LeetCodeProblems.Problems.P1624;

/// <summary>
/// 1624. Largest Substring Between Two Equal Characters
/// </summary>
internal class P1624
{
    public int MaxLengthBetweenEqualCharacters(string s)
    {
        int result = -1;

        var buf = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (buf.TryGetValue(s[i], out int val) && result < i - val - 1)
            {
                result = i - val - 1;
            }

            buf.TryAdd(s[i], i);
        }

        return result;
    }

    //public int MaxLengthBetweenEqualCharacters(string s)
    //{
    //    int result = -1;

    //    for (int l = 0; l < s.Length - 1; l++)
    //    {
    //        for (int i = l + 1; i < s.Length; i++)
    //        {
    //            if (s[i] == s[l] && result < i - l - 1)
    //            {
    //                result = i - l - 1;
    //            }
    //        }
    //    }

    //    return result;
    //}
}
