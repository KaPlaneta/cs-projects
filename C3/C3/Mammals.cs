using System;
using System.Collections.Generic;
using System.Text;

namespace C3
{
    class Mammals : Animal
    {
        public override string ShowData()
        {
            return "Animal species: Mammals";
        }

        public Mammals(string _name, double _age)
        {
            name = _name;
            age = _age;
        }
        public override string ToString()
        {
            return "This is a mammal.\nName: " + name + "\nAge: " + age;
        }

    }
}
