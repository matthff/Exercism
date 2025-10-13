using System;
using System.Linq;
using System.Collections.Generic;

public static class TwelveDays
{
    private static readonly string[,] Lyrics = new string[,]
    {
        { "first", "a Partridge in a Pear Tree" },
        { "second", "two Turtle Doves" },
        { "third", "three French Hens" },
        { "fourth", "four Calling Birds" },
        { "fifth", "five Gold Rings" },
        { "sixth", "six Geese-a-Laying" },
        { "seventh", "seven Swans-a-Swimming" },
        { "eighth", "eight Maids-a-Milking" },
        { "ninth", "nine Ladies Dancing" },
        { "tenth", "ten Lords-a-Leaping" },
        { "eleventh", "eleven Pipers Piping" },
        { "twelfth", "twelve Drummers Drumming" },
    };

    public static string Recite(int verseNumber)
    {
        return string.Format(
            "On the {0} day of Christmas my true love gave to me: {1}.",
            TwelveDays.Lyrics[verseNumber - 1, 0],
            string.Join(
                ", ",
                Enumerable.Range(0, verseNumber)
                    .Reverse()
                    .Select(v => ((v == 0 && verseNumber != 1) ? "and " : "") + TwelveDays.Lyrics[v, 1])
            )
        );
    }

    public static string Recite(int startVerse, int endVerse)
    {
        return string.Join("\n", Enumerable.Range(startVerse, endVerse - startVerse + 1).Select(v => Recite(v)));
    }
}
