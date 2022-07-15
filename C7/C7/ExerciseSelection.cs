using System;
using System.Collections.Generic;
using System.Text;

namespace C7
{
    class ExerciseSelection : ICommand
    {
        public string TypeOfExercise;
        public void Perform() { }
        public ExerciseSelection(string toe)
        {
            TypeOfExercise = toe;
        }

    } //receiver
}

