using System;
using System.Collections.Generic;
class InstructionSet_broken
{
    static void Main()
    {
        string opCode = string.Empty;
        long result = 0;

        while (opCode != "END")
        {
            opCode = Console.ReadLine();

            string[] codeArgs = opCode.Split(' ');

            if (codeArgs[0] == "INC")
            {
                result = long.Parse(codeArgs[1]) + 1;
            }
            else if (codeArgs[0] == "DEC")
            {
                result = long.Parse(codeArgs[1]) - 1;
            }
            else if (codeArgs[0] == "ADD")
            {
                result = long.Parse(codeArgs[1]) + long.Parse(codeArgs[2]);
            }
            else if (codeArgs[0] == "MLA")
            {
                result = long.Parse(codeArgs[1]) * long.Parse(codeArgs[2]);
            }

            if (opCode != "END")
            {
                Console.WriteLine(result);
            }
        }
    }
}