using System;
using System.Collections.Generic;
using System.Text;

namespace C3
{
    class Fishes : Animal

    {
        public override string ShowData()
        {
            return " Animal species: Fishes";

        }
        public Fishes(string _name, double _age)
        {
            name = _name;
            age = _age;
        }


        public override string ToString()
        {
            return "This is a fish.\nName: " + name + "\nAge: " + age;
        }

    }
}
