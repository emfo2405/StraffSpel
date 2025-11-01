using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//namespace samma för alla filer i projektet
namespace StraffSpel
{
    //Skapar en ny klass som hanterar spelval
    public class PlayerChoices
    {
        //Datorn ska få ett slumpmässigt val till sig
        Random random = new Random();

        //Skapar spelare i spelet utifrån ClassPlayer-klassen där endast PlayerChoices har rätt att ändra
        public ClassPlayer Kicker { get; private set; }
        public ClassPlayer GoalKeeper { get; private set; }

        //Skapar namn för Kicker och GoalKeeper
        public PlayerChoices()
        {
            //Kicker får namnet straffläggare och goalkeeper får namnet målvakt
            Kicker = new ClassPlayer("Straffläggare");
            GoalKeeper = new ClassPlayer("Målvakt");
        }

        //Skapa ett slumpmässigt tal för att välja vart målvakten ska gå
        private int RandomDirection()
        {
            //Returnerar ett tal mellan 1 och 3
            return random.Next(1, 4);
        }

        //Jämför användarens val med datorns slumpmässiga val
        private string WinnerMessage(int kickerDirection, int goalkeeperDirection)
        {
            //Om målvaktens val är lika med valet som användaren gör
            if (goalkeeperDirection == kickerDirection)
            {
                //Målvakten får ett till poäng och ett meddelande skrivs ut om att bollen räddades
                GoalKeeper.IncreaseScore();
                return ("Målvakten fångade bollen!");
            }
            //Om målvaktens val och valet användaren gör är olika
            else
            {
                //Användaren får ett till poäng och ett meddelande om att bollen gick in i mål skrivs ut
                Kicker.IncreaseScore();
                return ("Du gjorde mål!");
            }


        }

        //En runda i spelet hämtar ett slumpmässigt tal, returnerar vem som vinner och målvaktens val och in skickas användarens (spelarens) val
        public (int goalkeeperDirection, string message) PenaltyRound (int kickerDirection)
        {
            //Hämtar värdet för målvaktens val
            int goalkeeperDirection = RandomDirection();

            //Kör funktionen för att jämföra resultat och säga vem som vinner
            string message = WinnerMessage(goalkeeperDirection, kickerDirection);

            //returnerar resultatet från spelrundan
            return (goalkeeperDirection, message);
        }
    }
}
