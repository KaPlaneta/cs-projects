using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    abstract class Decorator : IZawodnik
    {
        public virtual string DisplayInformation { get; set; }
        public virtual void Strzel() { }

        protected IZawodnik zaw;
    } 

}
