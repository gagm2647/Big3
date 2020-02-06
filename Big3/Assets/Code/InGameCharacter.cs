using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code
{
    class InGameCharacter
    {
        public void SetSwing(int swingFromStats)
        {
            totalSwing = swingFromStats;
        }

        public void UsingSwing()
        {
            if (totalSwing > 0)
                totalSwing -= 1;
        }

        public int GetSwingLeft()
        {
            return totalSwing;
        }

        public bool TouchTheGround()
        {
            return touchGround = true;
        }

        public void SetCostume(int costumeFromCostume)
        {
            costume = costumeFromCostume;
        }


        private int totalSwing { get; set; }
        private int costume { get; set; }
        private bool touchGround { get; set; }


    }
}
