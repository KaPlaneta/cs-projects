using System;
using System.Collections.Generic;

namespace C7
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ExerciseEquipment hantle = new ExerciseEquipment("Hantle");
            ExerciseEquipment drążek = new ExerciseEquipment("Drążek");
            ExerciseEquipment gumy = new ExerciseEquipment("Gumy");

            ExerciseSelection martwyciąg = new ExerciseSelection("Martwy ciąg");
            ExerciseSelection podciąganie = new ExerciseSelection("Podciąganie");
            ExerciseSelection abs = new ExerciseSelection("ABS");

            StrengthTraining strengthhantle = new StrengthTraining(martwyciąg, hantle, 5);
            StrengthTraining strengthdrążek = new StrengthTraining(podciąganie, drążek, 10);
            StrengthTraining strengthgumy = new StrengthTraining(abs, gumy, 15);


            AerobicExercises fatburning = new AerobicExercises(20, "Fatburning");
            AerobicExercises bodyball = new AerobicExercises(15, "BodyBall");

            Stretching rozciąganie = new Stretching();

            TrainingPlan plan = new TrainingPlan();
            plan.Add(strengthhantle);
            plan.Add(strengthdrążek);
            plan.Add(strengthgumy);
            
            plan.Add(fatburning);
            plan.Add(bodyball);

            plan.Add(rozciąganie);
            plan.Run();

            Console.WriteLine();

            TrainingPlanAdapter tpa = new TrainingPlanAdapter();
            tpa.Run(new List<ICommand>() { strengthhantle, strengthdrążek, strengthgumy });

            Console.ReadKey();

        }
    }
}
