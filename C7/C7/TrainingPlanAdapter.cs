using System;
using System.Collections.Generic;
using System.Text;

namespace C7
{
    class TrainingPlanAdapter : WarmupPlan   //TripPlanAdapter, która
//zrealizuje wzorzec projektowy adapter w taki sposób, aby prawidłowo odzwierciedlać
//działanie klasy TripPlan.
    {
      public void Run(List<ICommand> items)
      {
         foreach (ICommand com in items)
         {
             com.Perform();
         }
      }
    }
}
