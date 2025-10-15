using System.Linq;

public static class Transpose
{
    public static string String(string input)
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;

        string[] lines = input.Split('\n');
        int linesMaxLength = lines.Max(x => x.Length);

        var tranposedString = "";

        lines = lines.Select((line, index) => line.PadRight(lines.Skip(index).Max(x => x.Length), ' ')).ToArray();

        for (var i = 0; i < linesMaxLength; i++)
        {
            foreach (var line in lines)
            {
                if (i < line.Length)
                    tranposedString += line[i];
            }

            if (i < linesMaxLength - 1)
                tranposedString += '\n';
        }

        return tranposedString;
    }
}
