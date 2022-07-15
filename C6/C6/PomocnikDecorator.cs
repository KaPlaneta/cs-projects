using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    class PomocnikDecorator : Decorator
    {
        public override string DisplayInformation { get; set; }
        public override void Strzel()
        {
            zawpomocnik.Strzel(); Console.WriteLine("Bezpośredni strzał na bramkę.");
        }


        protected IZawodnik zawpomocnik;

        public PomocnikDecorator(IZawodnik zaw)
        {
            zawpomocnik = zaw;
        }
    }
}
