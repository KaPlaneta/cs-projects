using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra
{
    [Serializable]
    class BasicMachete : Machete
    {
        // simple sword
        public BasicMachete() : base("item0881")
        {

            GoldValue = 10;
            PublicName = "Basic Machete";
            MgcMod = 15;

        }
    }
}
//bull