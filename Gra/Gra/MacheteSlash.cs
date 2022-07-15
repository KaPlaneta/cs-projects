using System;
using System.Collections.Generic;
using System.Text;

namespace Gra
{
    [Serializable]
    class MacheteSlash : Skill
    {
        public MacheteSlash() : base("Machete Slash", 40, 3)
        {
            PublicName = "Basic machete slash: 0.1*Strength + 0.1*Precision damage [stab] ";
            RequiredItem = "Machete";
        }
        public override List<StatPackage> BattleMove(Player player)
        {
            StatPackage response1 = new StatPackage("stab");
            response1.HealthDmg = (int)(0.1 * player.Strength) + (int)(0.1 * player.Precision);
            response1.CustomText = "You use Machete Slash! (" + ((int)(0.1 * player.Strength) + (int)(0.1 * player.Precision)) + " stab damage)";
            return new List<StatPackage>() { response1 };
        }
    }
}
