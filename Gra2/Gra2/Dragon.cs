using Game.Engine.Interactions.Built_In;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra2
{
   

    [Serializable]
    class Dragon : ConsoleInteraction
    {
        private bool visited = false; 
        public Dragon(GameSession ses) : base(ses)
        {
            Name = "interaction0004";
            
        }
        public void Execute(GameSession parentSession, bool visited)
        {
           
            parentSession.FightThisMonster();
        }
        
    }
}
