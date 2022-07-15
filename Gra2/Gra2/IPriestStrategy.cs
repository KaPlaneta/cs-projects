using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra2
{
    interface IPriestStrategy
    {
        void Execute(GameSession ses, bool visited);
    }
}
