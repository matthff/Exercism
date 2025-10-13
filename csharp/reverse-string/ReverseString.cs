using System;
using System.Collections.Generic;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        char[] inputCharList = input.ToCharArray();
        List<char> reversedCharList = new List<char>();

        for (int i = inputCharList.Length - 1; i >= 0; i--)
        {
            reversedCharList.Add(inputCharList[i]);
        }

        char[] reversedCharArray = reversedCharList.ToArray();
        string reversedInput = new String(reversedCharArray);

        return reversedInput;
    }
}
