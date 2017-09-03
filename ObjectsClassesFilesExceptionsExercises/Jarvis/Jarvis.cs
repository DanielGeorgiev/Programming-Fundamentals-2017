using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarvis
{
    class Arm
    {
        public int EnergyConsumption { get; set; }

        public int ReachDistance { get; set; }

        public int Fingers { get; set; }
    }

    class Leg
    {
        public int EnergyConsumption { get; set; }

        public int Strength { get; set; }

        public int Speed { get; set; }
    }

    class Torso
    {
        public int EnergyConsumption { get; set; }

        public double ProcessorSize { get; set; }

        public string HousingMaterial { get; set; }
    }

    class Head
    {
        public int EnergyConsumption { get; set; }

        public int IQ { get; set; }

        public string SkinMaterial { get; set; }
    }

    public class Jarvis
    {
        static void Main()
        {
            ulong maxEnergy = ulong.Parse(Console.ReadLine());


            var line = Console.ReadLine();

            while (line != "Assemble!")
            {
                var tokens = line
                    .Split();
            }
        }
    }
}
