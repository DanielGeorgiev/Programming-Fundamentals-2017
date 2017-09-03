using System;
class BoatSimulator
{
    static void Main()
    {
        char firstBoat = char.Parse(Console.ReadLine());
        char secondBoat = char.Parse(Console.ReadLine());
        int firstBoatTiles = 0;
        int secondBoatTiles = 0;

        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            string command = Console.ReadLine();

            if (i % 2 != 0 && command != "UPGRADE")
            {
                firstBoatTiles += command.Length;
            }
            else if (i % 2 == 0 && command != "UPGRADE")
            {
                secondBoatTiles += command.Length;
            }

            if (command == "UPGRADE")
            {
                firstBoat += (char)3;
                secondBoat += (char)3;
            }

            if (firstBoatTiles >= 50)
            {
                Console.WriteLine(firstBoat);
                break;
            }
            else if (secondBoatTiles >= 50)
            {
                Console.WriteLine(secondBoat);
                break;
            }
            else if (i == n)
            {
                if (firstBoatTiles > secondBoatTiles)
                {
                    Console.WriteLine(firstBoat);
                }
                else
                {
                    Console.WriteLine(secondBoat);
                }
            }
        }
    }
}

