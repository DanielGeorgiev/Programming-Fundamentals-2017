using System;
class FastPrimeChecker
{
    static void Main()
    {
        int countNumber = int.Parse(Console.ReadLine());

        for (int firstNumber = 2; firstNumber <= countNumber; firstNumber++)
        {
            bool isPrime = true;
            for (int checkPrime = 2; checkPrime <= Math.Sqrt(firstNumber); checkPrime++)
            {
                if (firstNumber % checkPrime == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine("{0} -> {1}", firstNumber, isPrime);
        }
    }
}

