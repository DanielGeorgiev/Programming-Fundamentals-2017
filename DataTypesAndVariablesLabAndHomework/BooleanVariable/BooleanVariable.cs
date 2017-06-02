using System;
class BooleanVariable
{
    static void Main()
    {
        string trueOrFalse = Console.ReadLine();
        bool trueOrFalseBooleanType = Convert.ToBoolean(trueOrFalse);

        if (trueOrFalseBooleanType)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

