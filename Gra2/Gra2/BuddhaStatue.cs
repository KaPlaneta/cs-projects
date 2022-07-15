using System;
using System.Collections.Generic;
using System.Text;

namespace Gra2
{
    class BuddhaStatue : ListBoxInteraction
    {
        private int visited = 0;
        private int payment = 0;

        public BuddhaStatue( GameSession ses) : base(ses)
        {
            Name = "interaction0882";
        }

        protected override void RunContent()
        {
            parentSession.SendText("\nIf you want your request to be heard, you must give alms"); //dać jałmużne
            int choice = GetListBoxChoice(new List<string>() { "I will pay but little","I will pay a lot, I do not save on alms.", "Exit" });
            switch (choice)
            {
                case 0:
                    payment = -5;
                    ApprovePayment();
                    break;
                case 1:
                    payment = -25;
                    ApprovePayment();
                    break;
                default:
                    parentSession.SendText("Go away!");
                    break;
            }
        }
        private void ApprovePayment()
        {
            if (payment == - 12)
            {
                parentSession.SendText("You are too stingy! I take your coins but you won't get anything in return."); //co za skąpiec
                parentSession.UpdateStat(8, payment);
            }
            if (payment == -25)
            {
                parentSession.SendText("You are very generous. The Buddha will give you more gold.");
                parentSession.UpdateStat(8, payment);
                parentSession.UpdateStat(8, 100);
            }
        }

    }
 }

