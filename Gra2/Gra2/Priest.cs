using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra2
{
  //ksiądz jest właścicielem kamienia i skały
                                                   

    [Serializable]
    class Priest : ConsoleInteraction
    {
        private bool visited = false; 
        public IPriestStrategy Strategy { get; set; }
        public Priest(GameSession ses) : base(ses)
        {
            Name = "interaction0881";
            Strategy = new PriestStrategy();
        }
        protected override void RunContent()
        {
            Strategy.Execute(parentSession, visited); 
            visited = true;
        }
    }
}
