using System;
using System.Linq;
class Program
{
    static void Main()
    {
        var arr1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var arr2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var leftLce = 0;
        var rightLce = 0;

        for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
        {
            if (arr1[i] == arr2[i])
            {
                leftLce++;
            }
            else
            {
                break;
            }
        }

        for (int i = Math.Min(arr1.Length - 1, arr2.Length - 1); i >= 0; i--)
        {
            if (Math.Min(arr1.Length, arr2.Length) == arr2.Length)
            {
                if (arr1[i + (arr1.Length - arr2.Length)] == arr2[i])
                {
                    rightLce++;
                }
                else
                {
                    break;
                }
            }
            else
            {
                if (arr1[i] == arr2[i + (arr1.Length - arr2.Length)])
                {
                    rightLce++;
                }
                else
                {
                    break;
                }
            }
        }

        if (leftLce > rightLce)
        {
            Console.WriteLine(leftLce);
        }
        else
        {
            Console.WriteLine(rightLce);
        }
    }
}

