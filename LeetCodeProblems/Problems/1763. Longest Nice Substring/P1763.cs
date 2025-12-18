namespace LeetCodeProblems.Problems._1763._Longest_Nice_Substring;

/// <summary>
/// 1763. Longest Nice Substring
/// </summary>
internal class P1763
{
    public string LongestNiceSubstring(string s)
    {
        HashSet<char> chars = new(s);
        int m = -1;

        for (int i = 0; i < s.Length; i++)
        {
            var oppositeChar = char.IsUpper(s[i])
                ? char.ToLower(s[i])
                : char.ToUpper(s[i]);

            if (!chars.Contains(oppositeChar))
            {
                m = i;
                break;
            }
        }

        if (m == -1) return s;

        string left = LongestNiceSubstring(s.Substring(0, m));
        string right = LongestNiceSubstring(s.Substring(m + 1, s.Length - m - 1));

        return left.Length >= right.Length ? left : right;
    }

    //public string LongestNiceSubstring(string s)
    //{
    //    Queue<string>[] nices = new Queue<string>[s.Length];

    //    for (int w = 2; w <= s.Length; w++)
    //    {
    //        for (int l = 0; l < s.Length - w + 1; l++)
    //        {
    //            string sub = s.Substring(l, w);
    //            HashSet<char> chars = new(sub);
    //            bool isNice = true;

    //            for (int i = l; i < l + w; i++)
    //            {
    //                var oppositeChar = char.IsUpper(s[i]) 
    //                    ? char.ToLower(s[i]) 
    //                    : char.ToUpper(s[i]);

    //                if (!chars.Contains(oppositeChar))
    //                {
    //                    isNice = false;
    //                }
    //            }

    //            if (isNice)
    //            {
    //                if (nices[w - 1] == null)
    //                {
    //                    nices[w - 1] = new Queue<string>();
    //                }

    //                nices[w - 1].Enqueue(sub);
    //            }
    //        }
    //    }

    //    for (int i = nices.Length - 1; i >= 0; i--)
    //    {
    //        if (nices[i] != null)
    //        {
    //            return nices[i].Dequeue();
    //        }
    //    }

    //    return string.Empty;
    //}
}
