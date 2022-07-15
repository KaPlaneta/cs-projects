using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // rekrutacja zalogi
            Human captainJones = new Human()
            {
                Rank = "Captain",
                Salary = 1.5 * Human.MedianSalary,
            };
            Human crewmateSmith = new Human()
            {
                Rank = "Crewmember",
                Salary = Human.MedianSalary,
            };
            Human crewmateNowak = new Human()
            {
                Rank = "Crewmember",
                Salary = Human.MedianSalary,
            };

            // budowa lodzi podwodnej
            Submarine purpleSubmarine = new Submarine(captainJones, crewmateSmith, crewmateNowak, "Nuclear");
            // wyznaczenie celu i wydanie polecenia podrozy
            Destination port1 = new Destination("Rotterdam", 1959);
            purpleSubmarine.Go(port1);

            // przesiadka na inna lodz podwodna
            Submarine blueSubmarine = new Submarine(captainJones, crewmateSmith, crewmateNowak, "Diesel");
            // wyznaczenie celu i wydanie polecenia podrozy
            Destination port2 = new Destination("Aarhus", 1049);
            blueSubmarine.Go(port2);

            // przesiadka na inna lodz podwodna
            Submarine orangeSubmarine = new Submarine(captainJones, crewmateSmith, crewmateNowak, "Hydrogen");
            // wyznaczenie celu i wydanie polecenia podrozy
            Destination port3 = new Destination("Bremerhaven", 563);
            orangeSubmarine.Go(port3);
            Console.ReadKey();
        }
    }
}
