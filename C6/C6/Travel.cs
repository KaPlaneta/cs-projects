using System;
using System.Collections.Generic;

namespace C6
{
    class Travel : ITravel
    {
        public string Destination { get; private set; }
        public int Kilometers { get; private set; }
        public Travel (string d, int k)
        {
            Destination = d;
            Kilometers = k;
        }
        public void Drive()
        {
            Console.WriteLine(Destination + "( " + Kilometers + " km.)");
        }
    }
} 