using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code
{
    class Costume
    {

        public enum CostumeOn //Miss the real costume name
        {
            Costume1,
            Costume2,
            Costume3,
            Costume4
        }

        public void SetCostume(CostumeOn costume)
        {
            costumeOn = costume;
        }

        public CostumeOn GetCostume()
        {
            return costumeOn;
        }


        private CostumeOn costumeOn { get; set; }
    }
}

