using System;
using System.Collections.Generic;
using System.Text;

namespace zad_5
{
    class Destination
    {
        private int distance;
        public string City { get; set; }

        public int Distance

        {
            get { return distance; }
            set
            {
                if (value > 0)  distance = value; 
            }
        }

        public Destination()
        { }

        public Destination(string a)

        {
            City = a;
            distance = 0;
           
        }
         public Destination(string b, int c)
        {
            City = b;
            distance = c;
        }
    }
}
