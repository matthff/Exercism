using System;

static class LogLine
{
    public static string Message(string logLine) => RemoveNewLines(logLine.Split(':')[1].Trim(' '));

    public static string LogLevel(string logLine) => RemoveNewLines(logLine.Substring(logLine.IndexOf('[') + 1, logLine.IndexOf(']') - 1).ToLower());


    public static string Reformat(string logLine) => RemoveNewLines($"{Message(logLine)} ({LogLevel(logLine)})");

    public static string RemoveNewLines(string logLine) => logLine.Replace("\n", "").Replace("\t", "").Replace("\r", "").Trim();
}
