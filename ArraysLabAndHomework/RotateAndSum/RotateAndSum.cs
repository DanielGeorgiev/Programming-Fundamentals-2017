using System;
using System.Linq;
class RotateAndSum
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        var k = int.Parse(Console.ReadLine());

        var sum = new int[numbers.Length];

        for (int i = 1; i <= k; i++)
        {
            var reversedNumbers = new int[numbers.Length];

            for (int reverseIndex = 0; reverseIndex < numbers.Length; reverseIndex++)
            {
                reversedNumbers[reverseIndex] = numbers[numbers.Length - 1 - reverseIndex];
            }

            var rotatedNumbers = reversedNumbers.ToArray();

            for (int rotateIndex = 1; rotateIndex < rotatedNumbers.Length; rotateIndex++)
            {
                rotatedNumbers[rotateIndex] = reversedNumbers[reversedNumbers.Length - rotateIndex];
            }

            for (int sumIndex = 0; sumIndex < sum.Length; sumIndex++)
            {
                sum[sumIndex] += rotatedNumbers[sumIndex];
            }

            numbers = rotatedNumbers.ToArray();
        }

        Console.WriteLine(string.Join(" ", sum));
    }
}

