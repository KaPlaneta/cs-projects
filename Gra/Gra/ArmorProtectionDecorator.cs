using System;
using System.Collections.Generic;
using System.Text;

namespace Gra
{
    [Serializable]
    class ArmorProtectionDecorator : SkillDecorator
    {
        
        public ArmorProtectionDecorator(Skill skill) : base("Armor Protection", 15, 1, skill)
        {
            MinimumLevel = Math.Max(1, skill.MinimumLevel) + 1;
            PublicName = "COMBO - Armor Protection: protection [shell]" + decoratedSkill.PublicName.Replace("COMBO: ", "");
            RequiredItem = "Armor";
        }
        public override List<StatPackage> BattleMove(Player player)
        {
            StatPackage response = new StatPackage("protection");
            response.PrecisionDmg = 15;
            response.CustomText = "You use Armor protection!";
            List<StatPackage> combo = decoratedSkill.BattleMove(player);
            combo.Add(response);
            return combo;
        }
    }
}
