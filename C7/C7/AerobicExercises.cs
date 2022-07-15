using System;
using System.Collections.Generic;
using System.Text;

namespace C7
{
    class AerobicExercises : ICommand
    {
        public int Time;
        public string Type;
        public void Perform()
        {
            Console.WriteLine(Time + ":00 min. " + Type + " - wykonaj dwie serie powtórzeń.");
        }

        public AerobicExercises(int time, string type)
        {
            Time = time;
            Type = type;
        }
    }
}
    

