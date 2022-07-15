using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    class Pomocnik :IZawodnik
    {

        public string DisplayInformation { get; set; }
        public void Strzel()
        {
            Console.WriteLine("Bezpośredni strzal na bramkę.");
        }
    }
}
