using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra
{
    [Serializable]
    class MagicArmor : Item
    {
        // special passive: receive physical damage bonus after losing health

        private int armorBonus;
        public MagicArmor() : base("item0882")
        {
            HpMod = 45;
            ArMod = 20;
            StaMod = -10;
            PublicName = "Magic Armor";
            PublicTip = "When you lose X health, receive a X/2 percentage bonus to physical damage you deal in this battle";
            GoldValue = 40;
            
        }
        public override StatPackage ModifyOffensive(StatPackage pack, List<string> otherItems)
        {
            if (pack.DamageType == "kick" || pack.DamageType == "scrath")
            {
                pack.HealthDmg = (100 + armorBonus / 2) * pack.HealthDmg / 100;
            }
            return pack;
        }
    }
}
