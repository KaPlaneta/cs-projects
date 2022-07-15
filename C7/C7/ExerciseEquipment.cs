using System;
using System.Collections.Generic;
using System.Text;

namespace C7
{
    class ExerciseEquipment :ICommand
    {
        public string Name;
        public void Perform() { }
        public ExerciseEquipment(string name)
        {
            Name = name;
        }

    } //receiver
}

