using System;
using System.Collections.Generic;
using System.Text;

namespace Gra
{
    [Serializable]
    class ScratchFactory : SkillFactory
    {  
       
        public Skill CreateSkill(Player player)
        {
            List<Skill> playerSkills = player.ListOfSkills;
            Skill known = CheckContent(playerSkills);
            if (known == null)
            {
                AxeThrow s1 = new AxeThrow();
                MacheteSlash s2 = new MacheteSlash();
                
                
                List<Skill> tmp = new List<Skill>();
                if (s1.MinimumLevel <= player.Level) tmp.Add(s1);
                if (s2.MinimumLevel <= player.Level) tmp.Add(s2);
                if (tmp.Count == 0) return null;
                return tmp[Index.RNG(0, tmp.Count)]; 
            }
            else if (known.decoratedSkill == null) 
            {
                AxeThrowDecorator s1 = new AxeThrowDecorator(known);
                MacheteSlashDecorator s2 = new MacheteSlashDecorator(known);
                List<Skill> tmp = new List<Skill>();
                if (s1.MinimumLevel <= player.Level) tmp.Add(s1); 
                if (s2.MinimumLevel <= player.Level) tmp.Add(s2);
                if (tmp.Count == 0) return null;
                return tmp[Index.RNG(0, tmp.Count)];
            }
            else return null; 
        }
        private Skill CheckContent(List<Skill> skills) 
        {
            foreach (Skill skill in skills)
            {
                if (skill is AxeThrow || skill is MacheteSlash  || skill is AxeThrowDecorator || skill is MacheteSlashDecorator) return skill;
            }
            return null;
        }       

    }
}