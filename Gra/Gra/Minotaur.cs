using System;
using System.Collections.Generic;
using System.Text;

namespace Gra
{
    [Serializable]
    class Minotaur : Monster
    {
        public Minotaur(int minotaurLevel)
        {
            Health = 40 + 2 * minotaurLevel;
            Strength = 25 + minotaurLevel;
            Armor = 20;
            Precision = 50;
            MagicPower = 0;
            Stamina = 300 + 2 * minotaurLevel;
            XPValue = 20 + minotaurLevel;
            Name = "monster0881";
            BattleGreetings = "I will punch you my horn";
        }
        public override List<StatPackage> BattleMove()
        {
            if (Stamina > 0)
            {
                Stamina = Stamina - 15;
                return new List<StatPackage>()
                {
                    new StatPackage("hit", 10 + Strength, "Minotaur uses his horns ("+ (10 + Strength) + "hit damage)")
                };
            }
            if (Stamina == 0)
            {
                Stamina = Stamina - 15;
                return new List<StatPackage>() { new StatPackage("none", 0, "Minotaur tries to attack but he fails.") };
            }
            else
            {
                return new List<StatPackage>() { new StatPackage("none", 0, "MInotaur  has no energy to attack anymore!") };
            }
        }
    }
}
