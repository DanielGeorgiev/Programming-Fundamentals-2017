using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main()
    {
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();

        var date1 = DateTime.ParseExact(input1, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        var date2 = DateTime.ParseExact(input2, "dd-MM-yyyy", CultureInfo.InvariantCulture);

        DateTime[] holidays = new DateTime[11];
        holidays[0] = new DateTime(4, 01, 01);
        holidays[1] = new DateTime(4, 03, 03);
        holidays[2] = new DateTime(4, 05, 01);
        holidays[3] = new DateTime(4, 05, 06);
        holidays[4] = new DateTime(4, 05, 24);
        holidays[5] = new DateTime(4, 09, 06);
        holidays[6] = new DateTime(4, 09, 22);
        holidays[7] = new DateTime(4, 11, 01);
        holidays[8] = new DateTime(4, 12, 24);
        holidays[9] = new DateTime(4, 12, 25);
        holidays[10] = new DateTime(4, 12, 26);

        var workingDays = 0;

        for (DateTime i = date1; i <= date2; i = i.AddDays(1))
        {
            DateTime tempI = new DateTime(4, i.Month, i.Day);

            if (i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday && !holidays.Contains(tempI))
            {
                workingDays++;
            }
        }

        Console.WriteLine(workingDays);
    }
}

