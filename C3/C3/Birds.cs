using System;
using System.Collections.Generic;
using System.Text;

namespace C3
{
    class Birds : Animal
    {
        public override string ShowData()
        {
            return "Animal species: Birds";
        }

        public Birds(string _name, double _age)
        {
            name = _name;
            age = _age;
        }

        public override string ToString()
        {
            return "This is a bird.\nName: " + name + "\nAge: " + age;
        }



    }
}
