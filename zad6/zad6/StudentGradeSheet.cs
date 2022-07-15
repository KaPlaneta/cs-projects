using System;
using System.Collections.Generic;
using System.Text;

namespace zad6
{
    class StudentGradeSheet
    {
        private Dictionary<string, double> myDict;


        public StudentGradeSheet()
        {
            myDict = new Dictionary<string, double>();
        }

        public void AddSubject(string subject, double note)
        {
            myDict.Add(subject, note);

        }


        public double ShowGrades(string i)
        {
            return myDict[i];
        }

        //    foreach (KeyValuePair<string, double> kvp in myDict)
        //    {
        //        Console.WriteLine("Przedmiot: {0} \t Ocena:{1}", kvp.Key, kvp.Value);
        //    }
        //}

        public double CalcMean() //obliczona srednia
        {

            double sum = 0;
            int iloscprzedmiotów = 0;

            foreach (KeyValuePair<string, double> kvp in myDict)
            {
                sum += kvp.Value;
                iloscprzedmiotów++;
            }
            if (sum == 0)
            {
                Console.WriteLine("Ten przedmiot nie ma ocen");
                return 0;
            }
            else
                return sum / iloscprzedmiotów;
        }
        
        public bool willPass(string subject)
        {
            double CalcMean = myDict[subject];
            return CalcMean >= 3.0;
        }
    }

}     

