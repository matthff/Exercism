using System;
using System.Linq;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => new int[] { 0, 2, 5, 3, 7, 8, 4 };

    public int Today() => birdsPerDay[birdsPerDay.Length - 1];

    public void IncrementTodaysCount() => birdsPerDay[birdsPerDay.Length - 1] += 1;

    public bool HasDayWithoutBirds() => birdsPerDay.Any(b => b.Equals(0));

    public int CountForFirstDays(int numberOfDays) => Enumerable.Range(0, numberOfDays).Sum(b => birdsPerDay[b]);

    public int BusyDays() => birdsPerDay.Count(b => b >= 5);
}
