using System;

namespace C6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz twój cel podróży:");
          
            Travel q1 = new Travel("Tarnów", 27);
            Travel q2 = new Travel("Warszawa", 315);
            Travel q3 = new Travel("Gdańsk",800);
            Train s1 = new Train();
            s1.travels.Add(q1);
            s1.travels.Add(q2);
            s1.travels.Add(q3);
            s1.Drive();
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}