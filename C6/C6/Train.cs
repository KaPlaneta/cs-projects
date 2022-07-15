using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    class Train : ITravel
    {

        public List<Travel> travels = new List<Travel>();


        public void Drive()
        {
            foreach (Travel travel in travels)
            {
                Console.WriteLine(travel.Destination + " (" + travel.Kilometers + " km).");
            }

        }
    
    }
}

