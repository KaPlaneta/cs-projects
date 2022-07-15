using System;
using System.Collections.Generic;
using System.Text;

namespace C7
{
    class TrainingPlan
    {
        private List<ICommand> thingsToDo;
        public TrainingPlan()
        {
            thingsToDo = new List<ICommand>();
        }
        public void Add(ICommand thing)
        {
            thingsToDo.Add(thing);
        }
        public void Run()
        {
            foreach (ICommand com in thingsToDo)
            {
                com.Perform();
            }
        }
    }
}