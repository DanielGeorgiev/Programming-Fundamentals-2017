using System;
class StringsAndObjects
{
    static void Main()
    {
        string string1 = "Hello";
        string string2 = "World";
        object str1str2concatination = string1 + ' ' + string2;
        string string3 = (string)str1str2concatination;

        Console.WriteLine(string3);
    }
}

