using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string phoneNumberRaw = new string(phoneNumber.ToList().Where(c => char.IsDigit(c) && char.GetNumericValue(c) != 1).ToArray());
        Regex re = new Regex(@"(^[2-9]{1}[0-9]{2}[2-9]{1}[0-9]{6}$)");

        if (!re.IsMatch(phoneNumberRaw))
            throw new ArgumentException();

        return phoneNumberRaw;
    }
}
