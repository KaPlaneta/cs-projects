using System;

namespace zad4
{
    class Program
    {
        static void Main()
        {
            //5
            Dom obiekt = new Dom("Konstruktor parametryczny");
            Dom obiekt2 = new Dom("Konstruktor parametryczny 2");

           
            obiekt.Mieszkanie();
            obiekt2.Mieszkanie();
            Console.ReadKey();


            //1
            Rodzina moja = new Rodzina(8, "Płaneta");
            moja.Wypisz();

            
            //6 
            Console.WriteLine("Podaj mebel");
            string fotel = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Podaj element kuchni");
            string szafka = Convert.ToString(Console.ReadLine());


            Dom domek = new Dom()
            {
                meble = fotel,
                kuchnia = szafka,
               
            };

            Console.WriteLine("Fotel i szafka");
            Console.ReadKey();

            //7 
            Console.WriteLine("Ilość mebli w kuchni:" + Dom.ilość);
            Rodzina.Napisz();


        }
    }
} //4
  //Rodzina r= new Rodzina("Mama", "Tata");
  //r.Rodzice();
  //Console.ReadKey();
  //*odzina.Rodzinka();*/
  //Rodzina rodz = new Rodzina("Mama Kasia");

//Console.WriteLine(rodz.Kasia); 
