using System;

namespace zad6
{
    class Program
    {
        static void Main(string[] args)
        {


           
            //public static Dictionary<string> Object = new Dictionary<string


            StudentGradeSheet st_gr_sheet = new StudentGradeSheet();
            st_gr_sheet.AddSubject("matematyka", 4.0);
            st_gr_sheet.AddSubject("fizyka", 3.0);
            st_gr_sheet.AddSubject("biologia", 2.0);

            StudentGroup studentGroup = new StudentGroup();
            

            Console.WriteLine(st_gr_sheet.ShowGrades("matematyka"));
            Console.WriteLine(studentGroup.Średnia("matematyka"));


         
            Console.ReadKey();



        }
    }
}
