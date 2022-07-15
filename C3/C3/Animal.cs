using System;
using System.Collections.Generic;
using System.Text;

namespace C3
{
    abstract class Animal : StrangeAnimal, StrangerAnimal
    {
        public string name;
        public double age;

        public virtual string ShowData()
        {

            return "Unspecified animal";
        }

        public virtual string GetName()
        {
            return name;
        }
    }
}