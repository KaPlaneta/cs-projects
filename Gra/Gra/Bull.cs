using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra
{
    [Serializable]
    class Bull : Monster
    {

        public Bull(int bullLevel)
        {
            Health = 20 + 5 * bullLevel;
            Strength = 10 + bullLevel;
            Armor = 14;
            Precision = 40;
            MagicPower = 0;
            Stamina = 200 + 2 * bullLevel;
            XPValue = 20 + bullLevel;
            Name = "monster0880";
            BattleGreetings = "I will kick you";
        }
        public override List<StatPackage> BattleMove()
        {
            if (Stamina > 0)
            {
                Stamina = Stamina - 15;
                return new List<StatPackage>()
                {
                    new StatPackage("kick", 15 + Strength, "Bull uses hoof ("+ (15 + Strength) + "kick damage)")
                };
            }
            if (Stamina == 0)
            {
                Stamina = Stamina - 15;
                return new List<StatPackage>()
                { new StatPackage("none", 0, "Bull tries to attack but fails.")};
            }
            else
            {
                return new List<StatPackage>() { new StatPackage("none", 0, "Bull has no energy to attack anymore!") };
            }
        }
    }
}
