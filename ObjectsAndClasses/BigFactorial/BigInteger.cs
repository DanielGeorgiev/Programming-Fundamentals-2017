using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
public class FactorialBigInteger
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        BigInteger factorial = 1;

        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }

        Console.WriteLine(factorial);
    }
}
