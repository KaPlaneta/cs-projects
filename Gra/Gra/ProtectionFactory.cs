using System;
using System.Collections.Generic;
using System.Text;

namespace Gra
{
    [Serializable]
    class ProtectionFactory : SkillFactory
    {
        
        public Skill CreateSkill(Player player)
        {
            List<Skill> playerSkills = player.ListOfSkills;
            List<Skill> tmp = new List<Skill>();
            List<Skill> drawn = new List<Skill>();
            ArmorProtection s1 = new ArmorProtection();
            if (s1.MinimumLevel <= player.Level) tmp.Add(s1); 
            foreach (Skill skill in playerSkills) 
            {
                if (skill is ArmorProtection) tmp.Remove(s1);
            }
            if (tmp.Count == 0) return null;
            return tmp[Index.RNG(0, tmp.Count)];
        }

    }
}
