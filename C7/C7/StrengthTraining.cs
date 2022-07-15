using System;
using System.Collections.Generic;
using System.Text;

namespace C7
{ 
    class StrengthTraining : ICommand
    {
        public ExerciseSelection Selection;
        public ExerciseEquipment Equipment;
        public int TheNumberOfRepetitions;
        public void Perform()
        {
            Console.WriteLine("Wykonaj ćwiczenie: " + Selection.TypeOfExercise);
            Console.WriteLine("Proszę użyć: " + Equipment.Name);
            Console.WriteLine(Selection.TypeOfExercise + ". Ilość powtórzeń: " + TheNumberOfRepetitions + ". Z wykorzystaniem: "  + Equipment.Name);
        }

        public StrengthTraining(ExerciseSelection sel, ExerciseEquipment equipment, int tnr)
        {
            Equipment = equipment;
            TheNumberOfRepetitions = tnr;
            Selection = sel;
        }
    }
}
