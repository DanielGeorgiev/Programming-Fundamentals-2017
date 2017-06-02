using System;
class EmployeeData
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        uint age = uint.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        long personalID = long.Parse(Console.ReadLine());
        int uniqueEmployeeNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("First name: {0}", firstName);
        Console.WriteLine("Last name: {0}", lastName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("Personal ID: {0}", personalID);
        Console.WriteLine("Unique Employee number: {0}", uniqueEmployeeNumber);
    }
}

