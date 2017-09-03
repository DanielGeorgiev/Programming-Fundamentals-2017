using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
public class DayOfWeek
{
    public static void Main()
    {
        string date = Console.ReadLine();
        var dayMonthYear = DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine(dayMonthYear.DayOfWeek);
    }
}

