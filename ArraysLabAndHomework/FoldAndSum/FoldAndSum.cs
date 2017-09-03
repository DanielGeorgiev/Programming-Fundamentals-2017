using System;
using System.Linq;
class FoldAndSum
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        var leftSide = new int [numbers.Length / 4];
        var rightSide = new int [numbers.Length / 4];
        var middle = new int[numbers.Length / 2];

        for (int i = 0; i < middle.Length; i++)
        {
            middle[i] = numbers[numbers.Length / 4 + i];
        }

        for (int i = 0; i < leftSide.Length; i++)
        {
            leftSide[i] = numbers[i];
        }

        for (int i = numbers.Length - rightSide.Length; i < numbers.Length; i++)
        {
            rightSide[i - (numbers.Length - rightSide.Length)] = numbers[i];
        }

        Array.Reverse(leftSide);
        Array.Reverse(rightSide);

        var firstRow = new int[rightSide.Length + leftSide.Length];
        Array.Copy(leftSide, firstRow, leftSide.Length);
        Array.Copy(rightSide, 0, firstRow, leftSide.Length, rightSide.Length);

        for (int i = 0; i < middle.Length; i++)
        {
            middle[i] += firstRow[i];
        }

        Console.WriteLine(string.Join(" ", middle));
    }
}

