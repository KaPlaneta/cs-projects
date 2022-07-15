using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Gra
{
    [Serializable]
    class BasicAxe : Axe
    {
        // simple axe
        public BasicAxe() : base("item0880")
        {
            StrMod = 10;
            StaMod = 12;
            PublicName = "Basic Axe";
            GoldValue = 23;
        }

        public void ApplyBuffs(Player player, List<string> items)
        {
            player.StrengthBuff += StrMod;
            player.StaminaBuff += StaMod;

        }
    }
}
