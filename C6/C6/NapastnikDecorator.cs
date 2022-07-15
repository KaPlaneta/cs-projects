using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    class NapastnikDecorator : Decorator
    {

        public override string DisplayInformation { get; set; }
        public override void Strzel()
        {
            zawnapastnik.Strzel(); Console.WriteLine("Rzut karny");
        }


        protected IZawodnik zawnapastnik;

        public NapastnikDecorator(IZawodnik zaw)
        {
            zawnapastnik = zaw;
        }
    }
}
