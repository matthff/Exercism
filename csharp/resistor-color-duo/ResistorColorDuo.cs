using System;

public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        return ResistorClassification(colors);
    }

    public static int ResistorClassification(string[] colorsList)
    {
        char[] resistorNumberCharArray = new char[2];
        for (int i = 0; i < 2; i++)
        {
            switch (colorsList[i])
            {
                case "black":
                    resistorNumberCharArray[i] = '0';
                    break;
                case "brown":
                    resistorNumberCharArray[i] = '1';
                    break;
                case "red":
                    resistorNumberCharArray[i] = '2';
                    break;
                case "orange":
                    resistorNumberCharArray[i] = '3';
                    break;
                case "yellow":
                    resistorNumberCharArray[i] = '4';
                    break;
                case "green":
                    resistorNumberCharArray[i] = '5';
                    break;
                case "blue":
                    resistorNumberCharArray[i] = '6';
                    break;
                case "violet":
                    resistorNumberCharArray[i] = '7';
                    break;
                case "grey":
                    resistorNumberCharArray[i] = '8';
                    break;
                case "white":
                    resistorNumberCharArray[i] = '9';
                    break;
            }
        }
        string resitorNumberText = new String(resistorNumberCharArray);
        int resistorNumber = int.Parse(resitorNumberText);
        return resistorNumber;
    }
}
