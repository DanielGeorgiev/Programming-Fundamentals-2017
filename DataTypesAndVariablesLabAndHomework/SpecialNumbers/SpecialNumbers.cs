using System;
class SpecialNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool isSpecial = false;

        for (int i = 1; i <= number; i++)
        {
            if (i / 10 + i % 10 == 5 || i / 10 + i % 10 == 7 || i / 10 + i % 10 == 11)
            {
                isSpecial = true;
            }
            else
            {
                isSpecial = false;
            }

            Console.WriteLine("{0} -> {1}", i, isSpecial);
        }
    }
}

