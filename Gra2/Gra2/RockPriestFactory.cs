using Gra2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra2
{
    [Serializable]
    class RockPriestFactory : InteractionFactory
    {
        public List<Interaction> CreateInteractionsGroup(GameSession parentSession)
        {
            
            RockInteraction rock = new RockInteraction(parentSession);
            Priest priest Priest(parentSession, priest);
            return new List<Interaction>() { rock, priest };
        }
    }
}
