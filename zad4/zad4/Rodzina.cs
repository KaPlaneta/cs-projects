using System;
using System.Collections.Generic;
using System.Text;

namespace zad4
{
    class Rodzina
    {

        //1  stworzenie obiektu klasy inicjalizatorem obiektow 
        //konstruktor na podstawie parametrow zainicjalizuje jego zmiennie

        int ilosc;
        string nazwisko;
   
        public Rodzina( int nowaIlosc,string noweNazwisko)
        {
            ilosc = nowaIlosc;
            nazwisko = noweNazwisko;
        }

        public void Wypisz()
        {
            Console.WriteLine("Ilosc: " + ilosc);
            Console.WriteLine("Nazwisko: " + nazwisko);
        }

        //4 
        public string Kasia { get; set; }
       
        private Rodzina(string mama)
        {
            Kasia = mama;

        }
         public Rodzina( Rodzina rodzinka)
        {
            Kasia = rodzinka.Kasia;

        }
       

         //7
        public static void Napisz()
        {
            Console.WriteLine("Szczęśliwa rodzina"); // metoda 7
        }


         //2 i 3
        private Rodzina()
        {

        }
        public static Rodzina prywatny = new Rodzina();
    }
}
//konstr uzywany przez inny 4 
// pierwszy kostrutkor z jednym parametrem przypisujacy wartosc zmiennej 
//    //drugi konstruktor ktory przypisuje wartosci obydwu zmiennym?
//string mama;
//string tata;
//public Rodzina(string parametr)
//{
//    mama = parametr;
//}
//public Rodzina(string parametr1, string parametr2) : this(parametr1)
//{
//    tata = parametr2;
//}
//public void Rodzice()
//{
//    Console.WriteLine(mama);
//    Console.WriteLine(tata);
//}