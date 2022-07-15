using System;
using System.Collections.Generic;
using System.Text;

namespace zad6
{
    class StudentGroup
    {
        private Dictionary<string, StudentGradeSheet> myDi;


        public StudentGroup()
        {
            myDi = new Dictionary<string, StudentGradeSheet>();
        }

        public void AddUczeń(string nazwisko, StudentGradeSheet dziennik)
        {
            myDi.Add(nazwisko, dziennik);

        }
        public double Średnia(string subject)
        {

            double sum = 0;
            int grades_num = 0; //liczba ocen

            foreach (KeyValuePair<string, StudentGradeSheet> kv in myDi)
            {
                sum += kv.Value.ShowGrades(subject);
                grades_num++;
            }
            if (grades_num == 0)
            {
                Console.WriteLine("Ten przedmiot nie ma ocen");
                return 0;
            }
            else
                return sum / myDi.Count;
        }

        public double SubAv(string s)
        {
            double suma = 0;
            foreach (KeyValuePair<string, StudentGradeSheet> el in myDi)
            {
                suma = el.Value.ShowGrades(s);
            }
            return suma / myDi.Count;
        }

        //public List<string> niezdane()
        //{
        //    List<string> studenstWhoFailed = new List<string>();
        //    foreach (KeyValuePair<string, StudentGradeSheet> el in myDi)
        //    {
        //        if (!el.Value.willPass(nazwisko))
        //        {
        //            studentsWhoFailed.Add(el.Key);
        //        }
        //    }
        //    return studentsWhoFailed;
        //}
    
        



    }
}
