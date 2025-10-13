using System;
using System.Collections.Generic;
using System.Linq;

namespace crypto_square
{
    public class CryptoSquareTwo
    {
        public string NormalizePlaintext { get; private set; }
        public int Size { get; private set; }

        public CryptoSquareTwo(string message)
        {
            NormalizePlaintext = message.Where(char.IsLetterOrDigit).JoinAsString().ToLower();
            Size = (int)Math.Ceiling(Math.Sqrt(NormalizePlaintext.Length));
        }

        public IEnumerable<string> PlaintextSegments()
        {
            return NormalizePlaintext.SplitToRows(Size);
        }
        public string Ciphertext()
        {
            return NormalizePlaintext.SplitToCols(Size).JoinAsString();
        }
        public string NormalizeCiphertext()
        {
            int count = PlaintextSegments().Count();
            return Ciphertext().SplitToRows(count).JoinAsString(" ");
        }

    }

    public static class Extensions
    {
        public static string JoinAsString<T>(this IEnumerable<T> coll, string separator = "")
        {
            return String.Join(separator, coll);
        }
        public static IEnumerable<string> SplitToRows<T>(this IEnumerable<T> list, int size)
        {
            return Split(list, index => index / size);
        }
        public static IEnumerable<string> SplitToCols<T>(this IEnumerable<T> list, int size)
        {
            return Split(list, index => index % size);
        }
        public static IEnumerable<string> Split<T>(this IEnumerable<T> list, Func<int, int> groupFunc)
        {
            return list.Select((c, index) => new { Index = index, Item = c })
                       .GroupBy(indexedChar => groupFunc(indexedChar.Index))
                       .Select(grp => grp.Select(indexedChar => indexedChar.Item).JoinAsString());
        }
    }
}
