using Gra2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra2
{
    [Serializable]
    class CastleDragonFactory : InteractionFactory
    {
        public List<Interaction> CreateInteractionsGroup(GameSession parentSession)
        {

            Castle castle = new Castle(parentSession);
            Dragon dragon = new Dragon(parentSession, castle);
            return new List<Interaction>() { castle, dragon };
        }
    }
}
