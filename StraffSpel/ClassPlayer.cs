using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//namespace samma för alla filer i projektet 
namespace StraffSpel
{
    public class ClassPlayer
    {
        //Skapar variabler för namn och poäng i spelet
        public string Name { get; set; }
        public int Points { get; private set; }

        //Skapa en konstruktor för att initiera klassen
        public ClassPlayer(string? name)
        {
            //Namnet sätts till name och poängen börjar på 0
            Name = name;
            Points = 0;
        }

        //För att kunna öka poängen på Points skapas metoden IncreaseScore
        public void IncreaseScore()
        {
            //Variabeln Points ökar med 1
            Points++;
        }

        //Används för att sätta poängen till 0 igen
        public void setScoreZero()
        {
            //Variabeln points sätts till 0
            Points = 0;
        }
    }
}
