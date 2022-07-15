using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra2
{
    // kamień należy do dziadka mroza

    [Serializable]
    class RockInteraction : ListBoxInteraction
    {
        private JackFrost ownerShip; 
        private int visited = 0; 
        private int knowledge = 0;
      



        public RockInteraction (GameSession ses, JackFrost ownerShip) : base(ses)
        {
            Name = "interaction0880";
            this.ownerShip = ownerShip;
        }

        
        protected override void RunContent() 
        {
            if (visited  == -1) // juz ty bylam i podniosłam kamień 
            {
                parentSession.SendText("\nUnfortunately, there is nothing under it. ");
                return;
            }
            if (visited > 2) //Gdy decyduję się podnieść drugi raz
            {
                parentSession.SendText("\nOh you found a secret entrance!"); //pojawia się tajemnicze wejście (do wybory dwoje drzwi)
                return;
            }
           
            parentSession.SendText("\nYou have a choice of 2 doors: red and white. Do you want open any of them or maybe none of them?");
            
            int choice = GetListBoxChoice(new List<string>() { "Warning! I choose any door.", "What will I get from it? Can you tell me which one is better?.", "I'm running away from here"  });
            switch (choice)
            {
                case 0:
                    knowledge = 0;
                    OpenTheDoor(); //otwiera drzwi i dzieje sie rzecz zalezna od tego, które drzwi wybiera.
                    break;
                case 1:
                    parentSession.SendText("Unfortunately no, you choose a trap or surprise(knowledge)."); 
                    int choice2 = GetListBoxChoice(new List<string>() { "All right, I take risks" , "Sorry, I don't want to risk." });
                    if (choice2 == 0)
                    {
                        knowledge = 10;
                        OpenTheDoor();
                    }
                    else parentSession.SendText("Your loss, go away!");
                    break;
                default:
                    parentSession.SendText( "Go away!");
                    break;
            }
        }

        
        private void OpenTheDoor()
        {
            parentSession.SendText("Great! You have to choose the door.");
            int choice = GetListBoxChoice(new List<string>() { "I choose red door", "I choose white door" });
            if (choice == 0)
            {
                if (knowledge == 0)
                {
                    parentSession.SendText("Congratulations! You have chosen the correct door. You can go through it and meet the master of the mysterious place - Jack Frost!.");
                    ownerShip.Strategy = new JackFrostStrategy(); 
                }
                else
                {
                    parentSession.SendText("You could do without my help! You already know what is favourite color the person who lives behind the mysterious doors ( it is valuable knowledge.");
                    parentSession.UpdateStat(7, knowledge); // +10 mądrości
                    ownerShip.Strategy = new HappyJackFrost(); // Dziadek mróz jest szczescliwy i ma dla ciebie niespdzianke
                }
                visited++;
            }
            else
            {
                parentSession.SendText("It is a trap! You have to run and don't show up here again.");

                visited = -1; //nie mozesz juz wiecej tu sie pokazywac i podnosic kamienia
            }
        }
    }
}
