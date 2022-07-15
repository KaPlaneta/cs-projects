using System;
using System.Collections.Generic;

namespace C3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> myAnimal = new List<Animal>();
            myAnimal.Add(new Fishes("Golden Eye", 3));
            myAnimal.Add(new Birds("Ara", 7));
            myAnimal.Add(new Mammals("Milka", 14));

            foreach (Animal a in myAnimal)
            {
                Console.WriteLine(a);
            }
        }
    }
}
