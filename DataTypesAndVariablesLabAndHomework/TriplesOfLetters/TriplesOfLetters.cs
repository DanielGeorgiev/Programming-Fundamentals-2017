using System;
class TriplesOfLetters
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int first = 0; first < n; first++)
        {
            for (int second = 0; second < n; second++)
            {
                for (int third = 0; third < n; third++)
                {
                    char firstChar = (char)('a' + first);
                    char secondChar = (char)('a' + second);
                    char thirdChar = (char)('a' + third);
                    Console.Write("{0}{1}{2}", firstChar, secondChar, thirdChar);
                    Console.WriteLine();
                }
            }
        }
    }
}

