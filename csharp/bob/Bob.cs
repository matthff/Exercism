using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();

        if (IsStringQuestionOnUpperCaseNotEmpty(statement))
        {
            return "Calm down, I know what I'm doing!";
        }

        if (statement.EndsWith('?'))
        {
            return "Sure.";
        }

        if (IsStringUpperCaseNotEmpty(statement))
        {
            return "Whoa, chill out!";
        }

        if (String.IsNullOrWhiteSpace(statement))
        {
            return "Fine. Be that way!";
        }

        return "Whatever.";
    }

    public static bool IsStringUpperCaseNotEmpty(string s)
    {
        return s.Any(c => Char.IsLetter(c)) && s == s.ToUpper() && !String.IsNullOrWhiteSpace(s);
    }

    public static bool IsStringQuestionOnUpperCaseNotEmpty(string s)
    {
        return s.Any(c => Char.IsLetter(c)) && s == s.ToUpper() && s.EndsWith('?') && !String.IsNullOrWhiteSpace(s);
    }
}
