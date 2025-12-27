namespace LeetCodeProblems;

internal static class MatrixHelper
{
    public static void Print(this int[][] matrix,
        string separator = " ",
        bool alignRight = true,
        bool showIndices = true,
        bool colorIndices = true)
    {
        if (matrix == null || matrix.Length == 0)
        {
            Console.WriteLine(showIndices ? "   [пустая матрица]" : "[пустая матрица]");
            return;
        }

        int rowCount = matrix.Length;
        int maxColCount = matrix.Max(row => row?.Length ?? 0);
        int dataMaxWidth = GetMaxWidth(matrix);
        int indexWidth = showIndices ? Math.Max(1, (rowCount - 1).ToString().Length) : 0;

        if (showIndices)
        {
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = colorIndices ? ConsoleColor.DarkGray : originalColor;

            Console.Write("".PadLeft(indexWidth));

            for (int j = 0; j < maxColCount; j++)
            {
                string padded = (alignRight
                    ? j.ToString().PadLeft(dataMaxWidth)
                    : j.ToString().PadRight(dataMaxWidth));
                Console.Write(separator + padded);
            }
            Console.WriteLine();

            Console.ForegroundColor = originalColor;
        }

        for (int i = 0; i < rowCount; i++)
        {
            var row = matrix[i];

            if (showIndices)
            {
                var originalColor = Console.ForegroundColor;
                Console.ForegroundColor = colorIndices ? ConsoleColor.DarkGray : originalColor;
                Console.Write(i.ToString().PadLeft(indexWidth));
                Console.ForegroundColor = originalColor;
            }

            if (row == null)
            {
                Console.WriteLine(showIndices ? " [null]" : "[null]");
                continue;
            }

            for (int j = 0; j < row.Length; j++)
            {
                string s = row[j].ToString();
                string formatted = alignRight
                    ? s.PadLeft(dataMaxWidth)
                    : s.PadRight(dataMaxWidth);

                if (j == 0 && showIndices)
                    Console.Write(separator + formatted);
                else if (j == 0)
                    Console.Write(formatted);
                else
                    Console.Write(separator + formatted);
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }

    public static void Print(this int[,] matrix,
        string separator = " ",
        bool alignRight = true,
        bool showIndices = true,
        bool colorIndices = true)
    {
        if (matrix == null)
        {
            Console.WriteLine(showIndices ? "   [null]" : "[null]");
            return;
        }

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        if (rows == 0 || cols == 0)
        {
            Console.WriteLine(showIndices ? "   [пустая матрица]" : "[пустая матрица]");
            return;
        }

        int dataMaxWidth = 2;
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                dataMaxWidth = Math.Max(dataMaxWidth, matrix[i, j].ToString().Length);

        int indexWidth = showIndices ? Math.Max(1, (rows - 1).ToString().Length) : 0;

        if (showIndices)
        {
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = colorIndices ? ConsoleColor.DarkGray : originalColor;

            Console.Write("".PadLeft(indexWidth));
            for (int j = 0; j < cols; j++)
            {
                string padded = alignRight
                    ? j.ToString().PadLeft(dataMaxWidth)
                    : j.ToString().PadRight(dataMaxWidth);
                Console.Write(separator + padded);
            }
            Console.WriteLine();

            Console.ForegroundColor = originalColor;
        }

        for (int i = 0; i < rows; i++)
        {
            if (showIndices)
            {
                var originalColor = Console.ForegroundColor;
                Console.ForegroundColor = colorIndices ? ConsoleColor.DarkGray : originalColor;
                Console.Write(i.ToString().PadLeft(indexWidth));
                Console.ForegroundColor = originalColor;
            }

            for (int j = 0; j < cols; j++)
            {
                string s = matrix[i, j].ToString();
                string formatted = alignRight
                    ? s.PadLeft(dataMaxWidth)
                    : s.PadRight(dataMaxWidth);

                if (j == 0 && showIndices)
                    Console.Write(separator + formatted);
                else if (j == 0)
                    Console.Write(formatted);
                else
                    Console.Write(separator + formatted);
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }

    private static int GetMaxWidth(int[][] matrix)
    {
        int maxWidth = 2;
        foreach (var row in matrix)
        {
            if (row == null) continue;
            foreach (int x in row)
            {
                int len = x.ToString().Length;
                if (len > maxWidth) maxWidth = len;
            }
        }
        return maxWidth;
    }
}