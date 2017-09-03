using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var exceptionCounter = 0;

        while (exceptionCounter != 1)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("My first exception is awesome!!!");
                exceptionCounter++;
            }
            else
            {
                Console.WriteLine(number);
            }
        }
    }
}

