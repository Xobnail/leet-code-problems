namespace LeetCodeProblems.Problems.P36;

/// <summary>
/// 36. Valid Sudoku
/// </summary>
internal class P36
{
    public bool IsValidSudoku(char[][] board)
    {
        var boardLenght = 9;

        // rows
        for (int i = 0; i < boardLenght; i++)
        {
            if (HasRepetitions(board[i]))
            {
                return false;
            }
        }

        //cols
        for (int j = 0; j < boardLenght; j++)
        {
            char[] a = new char[boardLenght];

            for (int i = 0; i < boardLenght; i++)
            {
                a[i] = board[i][j];
            }

            if (HasRepetitions(a))
            {
                return false;
            }
        }

        //3x3 blocks
        for (int i = 0; i < boardLenght; i = i + 3)
        {
            for (int j = 0; j < boardLenght; j = j + 3)
            {
                char[] a = new char[boardLenght];

                for (int ia = 0, im = i; im < i + 3; im++)
                {
                    for (int jm = j; jm < j + 3; jm++, ia++)
                    {
                        a[ia] = board[im][jm];
                    }
                }

                if (HasRepetitions(a))
                {
                    return false;
                }
            }
        }

        return true;
    }

    public bool HasRepetitions(char[] chars)
    {
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] == '.')
            {
                continue;
            }

            var a = chars[i];

            if (i == chars.Length - 1)
            {
                continue;
            }

            for (int j = i + 1; j < chars.Length; j++)
            {
                if (a == chars[j])
                {
                    return true;
                }
            }
        }

        return false;
    }
}
