using System;
class DayOfWeek
{
    static void Main()
    {
        var weekDays = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        
        int dayNum = int.Parse(Console.ReadLine());

        try
        {
            Console.WriteLine(weekDays[dayNum - 1]);
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid Day!");
        }
    }
}
