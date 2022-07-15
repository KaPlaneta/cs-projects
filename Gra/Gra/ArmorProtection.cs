using System;
using System.Collections.Generic;
using System.Text;

namespace Gra
{
    [Serializable]
    class ArmorProtection : Skill
    {

        public ArmorProtection() : base("Armor Protection", 15, 1)
        {
            PublicName = "Armor Defense: 5 + 0.3*MagicPower protection [shell]"; //powłoka
            RequiredItem = "Armor";
        }
        public override List<StatPackage> BattleMove(Player player)
        {
            StatPackage response = new StatPackage("shell");
            response.HealthDmg = 5 + (int)(0.3 * player.MagicPower);
            response.CustomText = "You are protected! (" + (5 + (int)(0.3 * player.MagicPower)) + " shell protection)";
            return new List<StatPackage>() { response };
        }
    }
}
