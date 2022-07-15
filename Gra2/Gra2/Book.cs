using System;
using System.Collections.Generic;
using System.Text;

namespace Gra2
{
    class Book : ListBoxInteraction
    {
        
        private int knowledge = 0;

        public Book(GameSession ses) : base(ses)
        {
            Name = "interaction0883";
        }

        protected override void RunContent()
        {
            parentSession.SendText("\nopen the book to learn more spells");
            int choice = GetListBoxChoice(new List<string>() { "I open", "I don't need it! " });
            switch (choice)
            {
                case 0:
                    knowledge = 10;
                    GetKnowledge();
                    break;
                
                default:
                    knowledge = 0;
                    break;
            }
        }
        private void GetKnowledge()
        {
            if (knowledge == 10)
            {
                parentSession.SendText("You now get some magical power."); 
                parentSession.UpdateStat(8, knowledge);
                parentSession.UpdateStat(5, 30);
            }
            if (knowledge == 0)
            {
                parentSession.SendText("You didn't receive magical power.");
                
            }
        }

    }
}

