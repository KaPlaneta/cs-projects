using System;
using System.Collections.Generic;
using System.Text;

namespace Gra
{
    abstract class Machete : Item
    {
        public Machete (string name) : base(name) // same as Item class, but IsSword is set to true
        {
            IsStaff = true;
        }
    }
}
//bull