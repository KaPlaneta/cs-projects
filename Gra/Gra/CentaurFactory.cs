using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra
{
    [Serializable]
    class CentaurFactory : MonsterFactory
    {

        private int encounterNumber = 0; 
        public override Monster Create(int playerLevel)
        {
            if (encounterNumber == 0) 
            {
                encounterNumber++;
                return new Centaur(playerLevel);
            }
            else return null; 
        }
        public override System.Windows.Controls.Image Hint()
        {
            if (encounterNumber == 0) return new Centaur(0).GetImage();
            
            else return null;
        }
    }
}
