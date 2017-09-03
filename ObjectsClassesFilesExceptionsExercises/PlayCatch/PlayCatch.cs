using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split().Select(int.Parse).ToArray();
        int exceptionCounter = 0;

        while (exceptionCounter != 3)
        {
            var commands = Console.ReadLine()
                .Split();
            var command = commands[0];


            switch (command)
            {
                case "Replace":
                    try
                    {
                        var index = int.Parse(commands[1]);
                        var element = int.Parse(commands[2]);

                        try
                        {
                            numbers[index] = element;
                        }
                        catch (Exception)
                        {
                            exceptionCounter++;
                            Console.WriteLine("The index does not exist!");
                        }
                    }
                    catch (Exception)
                    {
                        exceptionCounter++;
                        Console.WriteLine("The variable is not in the correct format!");
                    }
                    break;

                case "Show":
                    try
                    {
                        var index = int.Parse(commands[1]);
                        try
                        {
                            Console.WriteLine(numbers[index]);
                        }
                        catch (IndexOutOfRangeException)
                        {
                            exceptionCounter++;
                            Console.WriteLine("The index does not exist!");
                        }
                    }
                    catch (FormatException)
                    {
                        exceptionCounter++;
                        Console.WriteLine("The variable is not in the correct format!");
                    }
                    break;

                case "Print":
                    bool isPrintable = false;
                    var startIndex = 0;
                    var endIndex = 0;

                    try
                    {
                        startIndex = int.Parse(commands[1]);
                        endIndex = int.Parse(commands[2]);

                        try
                        {
                            for (int i = startIndex; i <= endIndex; i++)
                            {
                                numbers[i] = numbers[i];
                                isPrintable = true;
                            }
                        }
                        catch (Exception)
                        {
                            exceptionCounter++;
                            isPrintable = false;
                        }
                    }
                    catch (Exception)
                    {
                        exceptionCounter++;
                        Console.WriteLine("The variable is not in the correct format!");
                    }

                    if (isPrintable)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            if (i != endIndex)
                            {
                                Console.Write(numbers[i] + ", ");
                            }
                            else
                            {
                                Console.WriteLine(numbers[i]);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("The index does not exist!");
                    }
                    break;
            }
        }

        Console.WriteLine(string.Join(", ", numbers));
    }
}

