using Game.Engine.Skills;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gra
{
    [Serializable]

    class MacheteSlashDecorator : SkillDecorator
    {
       
        public MacheteSlashDecorator(Skill skill) : base("Machete Throw", 40, 3, skill)
    {
        MinimumLevel = Math.Max(1, skill.MinimumLevel) + 1;
        PublicName = "COMBO -  Machete Slash: 0.1*Strength + 0.1*Precision damage [stab]  AND " + decoratedSkill.PublicName.Replace("COMBO: ", "");
        RequiredItem = "Machete";
    }
    public override List<StatPackage> BattleMove(Player player)
    {
        StatPackage response = new StatPackage("stab");
        response.HealthDmg = (int)(0.1 * player.Strength) + (int)(0.1 * player.Precision);
            response.CustomText = "You use Machete Slash! (" + ((int)(0.1 * player.Strength) + (int)(0.1 * player.Precision)) + " stab damage)"; 
        List<StatPackage> combo = decoratedSkill.BattleMove(player);
        combo.Add(response);
        return combo;
    }
}
}
