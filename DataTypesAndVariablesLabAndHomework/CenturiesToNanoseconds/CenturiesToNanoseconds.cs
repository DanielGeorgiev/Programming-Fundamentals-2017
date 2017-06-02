using System;
class CenturiesToNanoseconds
{
    static void Main()
    {
        checked
        {
            ushort centuries = ushort.Parse(Console.ReadLine());
            int years = 100 * centuries;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            ulong seconds = (ulong)minutes * 60;
            ulong milliseconds = (seconds * 1000);
            ulong microseconds = milliseconds * 1000;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8}000 nanoseconds", centuries, years, days, hours, minutes, seconds, milliseconds, microseconds, microseconds);
        }
    }
}

