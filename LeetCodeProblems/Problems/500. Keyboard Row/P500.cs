namespace LeetCodeProblems.Problems._500._Keyboard_Row;

/// <summary>
/// 500. Keyboard Row
/// </summary>
internal class P500
{
    public string[] FindWords(string[] words)
    {
        HashSet<char> qwer = new([
            'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p',
            'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P']);
        HashSet<char> asdf = new([
            'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l',
            'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L']);
        HashSet<char> zxcv = new([
            'z', 'x', 'c', 'v', 'b', 'n', 'm',
            'Z', 'X', 'C', 'V', 'B', 'N', 'M']);
        List<string> result = [];

        foreach (string word in words)
        {
            bool consistsOfQwer = false;
            bool consistsOfAsdf = false;
            bool consistsOfZxcv = false;

            foreach (char c in word)
            {
                if (qwer.Contains(c))
                {
                    consistsOfQwer = true;
                    continue;
                }

                if (asdf.Contains(c))
                {
                    consistsOfAsdf = true;
                    continue;
                }

                if (zxcv.Contains(c))
                {
                    consistsOfZxcv = true;
                    continue;
                }
            }

            if (consistsOfQwer && !consistsOfAsdf && !consistsOfZxcv
                || !consistsOfQwer && consistsOfAsdf && !consistsOfZxcv
                || !consistsOfQwer && !consistsOfAsdf && consistsOfZxcv)
            {
                result.Add(word);
            }
        }

        return result.ToArray();
    }
}
