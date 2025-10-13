using System;
using System.Collections.Generic;
using System.Linq;

public static class CryptoSquare
{
    private static string NormalizedPlaintext(string plaintext)
    {
        return new string(plaintext.Trim().Replace(" ", "").ToLower().Where(c => !char.IsPunctuation(c)).ToArray());
    }

    public static IEnumerable<string> PlaintextSegments(string plaintext)
    {
        string normalizedText = NormalizedPlaintext(plaintext);
        int[] rectangleParameters = CalculateRC(normalizedText.Length);
        int c = rectangleParameters[0];
        int r = rectangleParameters[1];
        if (normalizedText.Length < c * r)
            return Split(normalizedText.PadRight(c * r, ' '), c);

        return Split(normalizedText, c);
    }

    public static string Encoded(string plaintext)
    {
        if (plaintext.Equals(""))
            return "";
        string normalizedText = NormalizedPlaintext(plaintext);
        int[] rectangleParameters = CalculateRC(normalizedText.Length);
        int c = rectangleParameters[0];
        int r = rectangleParameters[1];
        string[] segments = PlaintextSegments(normalizedText).ToArray();
        List<string> encodedSegments = new List<string>();
        for (int i = 0; i < c; i++)
        {
            List<char> currentEncodedSegment = new List<char>();
            for (int j = 0; j < r; j++)
            {
                currentEncodedSegment.Add(segments[j].ToArray()[i]);
            }
            string encodedSegment = new string(currentEncodedSegment.ToArray());
            encodedSegments.Add(encodedSegment);
        }
        return String.Join(" ", encodedSegments.ToArray());
    }

    public static string Ciphertext(string plaintext)
    {
        return Encoded(plaintext);
    }

    private static int[] CalculateRC(int stringLenght)
    {
        int c = 0;
        int r = 0;
        while (r * c <= stringLenght)
        {
            c++;
            if (r * c <= stringLenght)
                r++;
            if (r * c >= stringLenght)
                break;

        }
        return new int[] { c, r };
    }

    private static IEnumerable<string> Split(string str, int chunkSize)
    {
        return Enumerable.Range(0, str.Length / chunkSize)
            .Select(i => str.Substring(i * chunkSize, chunkSize));
    }
}
