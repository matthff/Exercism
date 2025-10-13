using System;
using System.Linq;
using System.Collections.Generic;


public enum YachtCategory
{
    Ones = 1,
    Twos = 2,
    Threes = 3,
    Fours = 4,
    Fives = 5,
    Sixes = 6,
    FullHouse = 7,
    FourOfAKind = 8,
    LittleStraight = 9,
    BigStraight = 10,
    Choice = 11,
    Yacht = 12,
}

public enum ConstantYatchesScores
{
    LittleStraight = 30,
    BigStraight = 30,
    Yacht = 50
}

public static class YachtGame
{
    public static int Score(int[] dice, YachtCategory category)
    {
        if (isPlayInValidCategory(dice, category))
            return ScoreForCategoryInAnyCombination(dice, category);
        return 0;
    }

    public static bool isPlayInValidCategory(int[] dice, YachtCategory category)
    {
        Array.Sort(dice);
        switch (category)
        {
            case YachtCategory.FullHouse:
                return dice.ToList().GroupBy(p => p).All(g => new[] { 2, 3 }.Contains(g.Count()));
            case YachtCategory.LittleStraight:
                return dice.SequenceEqual(new int[] { 1, 2, 3, 4, 5 });
            case YachtCategory.BigStraight:
                return dice.SequenceEqual(new int[] { 2, 3, 4, 5, 6 });
            case YachtCategory.Yacht:
                return dice.ToList().All(p => p == dice[0]);
            default:
                return true;
        }
    }

    public static int ScoreForCategoryInAnyCombination(int[] dice, YachtCategory category)
    {
        switch (category)
        {
            case YachtCategory.Ones:
                return dice.ToList().Where(p => p == 1).Sum();
            case YachtCategory.Twos:
                return dice.ToList().Where(p => p == 2).Sum();
            case YachtCategory.Threes:
                return dice.ToList().Where(p => p == 3).Sum();
            case YachtCategory.Fours:
                return dice.ToList().Where(p => p == 4).Sum();
            case YachtCategory.Fives:
                return dice.ToList().Where(p => p == 5).Sum();
            case YachtCategory.Sixes:
                return dice.ToList().Where(p => p == 6).Sum();
            case YachtCategory.FullHouse:
                return dice.ToList().Sum();
            case YachtCategory.FourOfAKind:
                return (dice.GroupBy(x => x).FirstOrDefault(g => g.Count() >= 4)?.First() ?? 0) * 4;
            case YachtCategory.LittleStraight:
                return (int)ConstantYatchesScores.LittleStraight;
            case YachtCategory.BigStraight:
                return (int)ConstantYatchesScores.BigStraight;
            case YachtCategory.Choice:
                return dice.ToList().Sum();
            case YachtCategory.Yacht:
                return (int)ConstantYatchesScores.Yacht;
            default:
                return 0;
        }
    }
}

