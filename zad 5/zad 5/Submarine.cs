using System;
using System.Collections.Generic;
using System.Text;

namespace zad_5
{
    class Submarine
    {

        private Engine Silnik { get; } 
        private Human Captain { get; } = new Human();
        private Human Member { get; } = new Human();
        private Human Member2 { get; } = new Human();
        private Destination Startowy { get; } = new Destination();

        public static double Sum;

        private Submarine()
        {

        }

        public Submarine(Human human, Human human2, Human human3, string j)
        {
            Captain = human;

            Member = human2;

            Member2 = human3;

            Silnik = new Engine(j);

            Startowy.City = "Gdańsk";

            Sum = Captain.Salary + Member.Salary + Member2.Salary;

        }

        public void Go (Destination endPort)
        {

            Console.WriteLine("Testing all modules...");

            if (endPort.Distance <= Silnik.Range)
            {
                Console.WriteLine("Destination accepted!");
                Console.WriteLine("Total salary cost: " + Sum);
                Console.WriteLine("Total fuel cost: " + (Silnik.FuelCost*endPort.Distance));
                Console.WriteLine("Total C02 emission: " + (endPort.Distance*Silnik.FuelEmission));
                Console.WriteLine();
               
            }

              else
            {
                Console.WriteLine("This destination is too far away! Abosrting mission");
                Console.WriteLine();
            }

        }
    }
}
