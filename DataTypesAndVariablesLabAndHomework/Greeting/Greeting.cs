using System;
class Greeting
{
    static void Main()
    {
        //Should have done this with interpolated strings but I'm using Visual Studio 2013, which doesn't support this. 
        string firstName = Console.ReadLine();
        string secondName = Console.ReadLine();
        uint age = uint.Parse(Console.ReadLine());
        Console.WriteLine("Hello, " + firstName + ' ' + secondName + ". You are " + age + " years old.");
    }
}

