using System;
using System.Linq;
using System.Collections.Generic;

public static class ResistorColorTrio
{
    private static Dictionary<string, int> _resistorLabel = new Dictionary<string, int>()
    {
        {"black", 0},
        {"brown", 1},
        {"red", 2},
        {"orange", 3},
        {"yellow", 4},
        {"green", 5},
        {"blue", 6},
        {"violet", 7},
        {"grey", 8},
        {"white", 9}
    };
    public static string Label(string[] colors)
    {
        var colorsResistances = colors.Select(c => _resistorLabel[c.ToLower()]).ToArray();
        var resistance = int.Parse($"{colorsResistances[0]}{colorsResistances[1]}") * Math.Pow(10, colorsResistances[2]);
        return resistance > 1000 ? $"{resistance / 1000} kiloohms" : $"{resistance} ohms";
    }
}
