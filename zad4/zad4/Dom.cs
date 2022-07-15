using System;
using System.Collections.Generic;
using System.Text;

namespace zad4
{
    class Dom
    {

        public string meble;
        public string kuchnia;
        public static int ilość = 3; //parametr statyczny 7

        public Dom()

        {
            Console.WriteLine();
            Console.ReadKey();
        }

        //dwa inne konstruktory parametryczne 5 

        public Dom(string parametr)
        {
            meble = parametr;
        }

        public Dom(string parametr2, string parametr3)
        {
            meble = parametr2;
            kuchnia = parametr3;
        }
        public void Mieszkanie()
        {
            Console.WriteLine(meble);
            Console.WriteLine(kuchnia);
        }

        //konstruktor kopiujacy 6
        public Dom(Dom kopiuj)
        {
            meble = kopiuj.meble;
            kuchnia = kopiuj.kuchnia;
        }
    }
}
