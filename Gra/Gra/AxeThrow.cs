using System;
using System.Collections.Generic;
using System.Text;

namespace Gra
{
    [Serializable]
    class AxeThrow : Skill
    {
        
        public AxeThrow() : base("Axe Throw", 24, 2)
        {
            PublicName = "Basic axe throw: 0.4 * Strength damage [incised]";
            RequiredItem = "Axe";
        }
        public override List<StatPackage> BattleMove(Player player)
        {
            StatPackage response = new StatPackage("incised");
            response.HealthDmg = (int)(0.4 * player.Strength);
            response.CustomText = "You use Axe! (" + ((int)(0.4 * player.Strength)) + " incised damage)";
            return new List<StatPackage>() { response };
        }
    }
}

