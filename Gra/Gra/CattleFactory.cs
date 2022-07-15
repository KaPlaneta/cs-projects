using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra
{
    [Serializable]
    class CattleFactory : MonsterFactory
    {
        

        private int encounterNumber = 0;
        public override Monster Create(int playerLevel)
        {
            if (encounterNumber == 0) // if this is the first time, return a bull
            {
                encounterNumber++;
                return new Bull(playerLevel);
            }
            else if (encounterNumber == 1) // if this is the second time, return a minotaur
            {
                encounterNumber++;
                return new Minotaur(playerLevel);
            }
            else return null; // no more cattle to fight
        }
        public override System.Windows.Controls.Image Hint()
        {
            if (encounterNumber == 0) return new Bull(0).GetImage();
            else if (encounterNumber == 1) return new Minotaur(0).GetImage();
            else return null;
        }
    }
}
