using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra2
{
    

    [Serializable]
    class Castle : ListBoxInteraction
    {
        private Dragon myPet; 
        private int visited = 0; 
        

        public Castle(GameSession ses, Dragon myPet) : base(ses)
        {
            Name = "interaction0884";
            this.myPet = myPet; 
        }

        protected override void RunContent()
        {
            
            parentSession.SendText("\nIf you want to enter the castle and save the princess, you must defeat the dragon.");
            
            int choice = GetListBoxChoice(new List<string>() { "I will do everything!!", "I'm afraid of dragons." });
            switch (choice)
            {
                case 0:
                    FightThisMonster();
                    break;
                
                default:
                    parentSession.SendText("Shame on you, coward!");
                    break;
            }
        }

        public void FightThisMonster(Dragon dragon)
        {
            if (dragon != null)
            {
                Display.BattleScene newBattleScene = new Display.BattleScene(parentPage, currentPlayer, dragon);
                Battle newBattle = new Battle(this, newBattleScene, dragon, false);
                newBattle.Run();
                if (newBattle.battleResult) UpdateStat(2, 50); //+50 do siły gdy go pokonam
            }
        }

       
    }
}
