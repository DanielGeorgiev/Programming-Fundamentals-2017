using System;
public class HelloName
{
    public static void Main()
    {
        string name = Console.ReadLine();
        Hello(name);
    }

    public static void Hello(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
}

