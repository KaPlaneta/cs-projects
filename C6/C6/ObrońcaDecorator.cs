using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    class ObrońcaDecorator : Decorator
    {
        public override string DisplayInformation { get; set; }
        public override void Strzel()
        {
            zawobronca.Strzel(); Console.WriteLine("Gol z dystansu");
        }


        protected IZawodnik zawobronca;

        public ObrońcaDecorator(IZawodnik zaw)
        {
            zawobronca = zaw;
        }
    }
}
