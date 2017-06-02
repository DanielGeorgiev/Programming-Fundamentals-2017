using System;
class RefactorSpecialNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            bool isSpecial = false;
            int sum = 0;
            sum = i / 10 + i % 10;
            isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
            Console.WriteLine("{0} -> {1}", i, isSpecial);
        }
    }
}

