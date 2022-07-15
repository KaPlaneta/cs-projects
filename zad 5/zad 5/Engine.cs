using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_5
{
    class Engine
    {
        private string type;
        public int Range { get; private set; } // prywatny setter
        public double FuelCost { get; private set; } // prywatny setter
        public double FuelEmission { get; private set; } // prywatny setter

        public string Type
        {
            get { return type; }
            set
            {
                if (value == "Nuclear")
                {
                    type = value;
                    Range = 10000;
                    FuelCost = 20.0;
                    FuelEmission = 0.0;
                }
                else if (value == "Hydrogen")
                {
                    type = value;
                    Range = 800;
                    FuelCost = 1.5;
                    FuelEmission = 2.0;
                }
                else
                {
                    type = "Diesel";
                    Range = 1000;
                    FuelCost = 1.0;
                    FuelEmission = 8.0;
                }
            }
        }

        public Engine()
        {
            Type = "Diesel";
            Range = 1000;
        }

        public Engine(string model)
        {
            Type = model;
        }
    }
}
