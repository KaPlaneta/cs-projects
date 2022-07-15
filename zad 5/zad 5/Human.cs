using System;
using System.Collections.Generic;
using System.Text;

namespace zad_5
{
    class Human
    {
        private double salary;
        public static double MedianSalary { get; } = 4000.0;
        public double Salary

        {
            get { return salary; }
            set
            {
                if (value > 0) { salary = value; }
            }
        }
      
        public string Rank { get; set; }
        public Human()
        {
        }
    }
}
