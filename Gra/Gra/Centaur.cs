using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra
{
    [Serializable]
    class Centaur : Monster
    {

        public Centaur(int centaurLevel)
        {
            Health = 50 + 5 * centaurLevel;
            Strength = 30 + centaurLevel;
            Armor = 25 + centaurLevel;
            Precision = 50;
            MagicPower = 100 + 3 * centaurLevel;
            Stamina = 220 + 2 * centaurLevel;
            XPValue = 20 + centaurLevel;
            Name = "monster0882";
            BattleGreetings = "I am furious.";
        }
        public override List<StatPackage> BattleMove()
        {
            if (Stamina > 0)
            {
                Stamina = Stamina - 15;
                return new List<StatPackage>()
                {
                    new StatPackage("bleed", 15 + MagicPower, "Centaur uses axe. ("+ (15 + MagicPower) + "bleed damage)")
                };
            }
            if (Stamina == 0)
            {
                Stamina = Stamina - 15;
                return new List<StatPackage>() { new StatPackage("none", 0, "Centaur tries to attact but he fails.") };
            }
            else
            {
                return new List<StatPackage>() { new StatPackage("none", 0, "Centaur has no energy to attack anymore.") };
            }
        }
    }
}
