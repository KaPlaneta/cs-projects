using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra2
{
    

    [Serializable]
    class HappyPriest : IPriestStrategy
    {
        public void Execute(GameSession parentSession, bool visited)
        {
            if (visited)
            {
                parentSession.SendText("\nHello again! I appoint you as my helper");
                return;
            }
            else
            {
                parentSession.SendText("\nHello adventurer. You met my favorite color. Thanks to this you are smarter but it is not over! Meet my generosity, I will give you a red sword.");

                parentSession.AddThisItem(Index.ProduceSpecificItem("item0882")); //red sword
            }
        }
    }
}
