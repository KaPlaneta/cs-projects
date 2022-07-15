using Game.Engine.Skills;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gra
{
    [Serializable]
    class AxeThrowDecorator : SkillDecorator
    {
        // decorator for Wind Gust class
        public AxeThrowDecorator(Skill skill) : base("Axe Throw", 24, 2, skill)
        {
            MinimumLevel = Math.Max(1, skill.MinimumLevel) + 1;
            PublicName = "COMBO -  Axe throw:  0.4 * Strength damage[incised] AND " + decoratedSkill.PublicName.Replace("COMBO: ", "");
            RequiredItem = "Axe";
        }
        public override List<StatPackage> BattleMove(Player player)
        {
            StatPackage response = new StatPackage("air");
            response.HealthDmg = 5 + (int)(0.3 * player.MagicPower);
            response.CustomText = "You use Axe! (" + ((int)(0.4 * player.Strength)) + " incised damage)";
            List<StatPackage> combo = decoratedSkill.BattleMove(player);
            combo.Add(response);
            return combo;
        }
    }
}
