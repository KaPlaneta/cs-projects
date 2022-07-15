using System;
using System.Collections.Generic;
using System.Text;

namespace C7
{
    class Stretching : ICommand
    {
        public void Perform()
        {
            Console.WriteLine("A Na koniec rozciąganie. ");
        }

        public Stretching() { }
    }
}

 

