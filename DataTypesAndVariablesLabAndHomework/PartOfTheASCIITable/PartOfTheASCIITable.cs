using System;
class Program
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        try
        {
            string dataType = string.Empty;

            if (number <= sbyte.MaxValue && number >= sbyte.MinValue)
            {
                dataType += "* sbyte";
            }
            if (number <= byte.MaxValue && number >= byte.MinValue)
            {
                dataType += "\n* byte";
            }
            if (number <= short.MaxValue && number >= short.MinValue)
            {
                dataType += "\n* short";
            }
            if (number <= ushort.MaxValue && number >= ushort.MinValue)
            {
                dataType += "\n* ushort";
            }
            if (number <= int.MaxValue && number >= int.MinValue)
            {
                dataType += "\n* int";
            }
            if (number <= uint.MaxValue && number >= uint.MinValue)
            {
                dataType += "\n* uint";
            }
            if (number <= long.MaxValue && number >= long.MinValue)
            {
                dataType += "\n* long";
            }
            Console.Write("{0} can fit in: ", number);
            Console.WriteLine(dataType);
        }
        catch (OverflowException)
        {
            Console.WriteLine("{0} can't fit in any type", number);
        }
    }
}

