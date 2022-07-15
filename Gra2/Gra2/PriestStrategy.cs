using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra2
{
    

    [Serializable]
    class PriestStrategy : IJackFrostStrategy
    {
        public void Execute(GameSession parentSession, bool visited)
        {
            parentSession.SendText("\nHello adventurer. You had to choose the right door if you got here! Respect.");
            
        }
    }
}
