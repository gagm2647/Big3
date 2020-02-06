using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code
{
    class Statistics
    {
        public void SetStats(Costume.CostumeOn costume)
        {
            switch (costume) //miss the real stats
            {
                case Costume.CostumeOn.Costume1:
                    SetWeight(1);
                    SetKickPower(1);
                    SetTotalSwing(1);
                    SetPowerEfficiency(1);
                    Console.WriteLine("C1");
                    break;
                case Costume.CostumeOn.Costume2:
                    SetWeight(2);
                    SetKickPower(2);
                    SetTotalSwing(2);
                    SetPowerEfficiency(2);
                    Console.WriteLine("C2");
                    break;
                case Costume.CostumeOn.Costume3:
                    SetWeight(3);
                    SetKickPower(3);
                    SetTotalSwing(3);
                    SetPowerEfficiency(3);
                    Console.WriteLine("C3");
                    break;
                case Costume.CostumeOn.Costume4:
                    SetWeight(4);
                    SetKickPower(4);
                    SetTotalSwing(4);
                    SetPowerEfficiency(4);
                    Console.WriteLine("C4");
                    break;
            }
        }
        public void SetWeight(int weightFromCostume)
        {
            weight = weightFromCostume;
        }

        public int GetWeight()
        {
            return weight;
        }

        public void SetKickPower(int kickPowerFromCostume)
        {
            kickPower = kickPowerFromCostume;
        }

        public int GetKickPower()
        {
            return kickPower;
        }

        public void SetTotalSwing(int totalSwingFromCostume)
        {
            totalSwing = totalSwingFromCostume;
        }

        public int GetTotalSwing()
        {
            return totalSwing;
        }

        public void SetPowerEfficiency(int powerEfficiencyFromCostume)
        {
            powerEfficiency = powerEfficiencyFromCostume;
        }

        public int GetPowerEfficiency()
        {
            return powerEfficiency;
        }

        private int weight { get; set; }
        private int kickPower { get; set; }
        private int totalSwing { get; set; }
        private int powerEfficiency { get; set; }
    }
}

