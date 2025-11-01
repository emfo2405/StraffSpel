using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

//Ett namespace skapas för spelet
namespace StraffSpel
{
    //En klass skapas för att definiera inläggen med specifika egenskaper
    public class TopScore
    {
        //Både namn och poäng krävs för att skapa ett TopScore-objekt
        public string Name { get; set; }
        public int Points { get; set; }
    }

    public class Highscore
    {
        //Skapar en lista för poäng och en fil där poängen sparas
        private string highscoreFile = @"highscore.json";
        private List<TopScore> scores = new List<TopScore>();

        //Skapar en konstruktor
        public Highscore() 
        {
            //Om highscoreFile finns läses innehållet i den och en lista skapas av innehållet
            //Om något går fel skapar funktionen en tom lista istället
            if (File.Exists(highscoreFile))
            {
                string jsonString = File.ReadAllText(highscoreFile);
                scores = JsonSerializer.Deserialize<List<TopScore>>(jsonString) ?? new List<TopScore>();
            }
        }

        //Används för att kunna lägga till nya poäng i listan
        public TopScore AddScore(string name, int points)
        {
            //Ett objekt skapas
            var newScore = new TopScore { Name = name, Points = points };

            //Objektet läggs till i listan
            scores.Add(newScore);

            //Anropar Save() för att spara listan till filen 
            Save();

            //Returnerar den nya listan
            return newScore;
        }

        //Används för att kunna hämta listan
        public List<TopScore> GetScores()
        {
            //Sorterar listan efter poäng i fallande ordning och tar endast de fem bästa, dessa blir sedan en ny lista
            return scores.OrderByDescending(e => e.Points).Take(5).ToList();
        }

        //Används för att spara listan till en JSON-fil
        private void Save()
        {
            //Scores görs om till JSON-format
            var jsonString = JsonSerializer.Serialize(scores);

            //JSON-formaterad Scores sparas i filen highscoreFile
            File.WriteAllText(highscoreFile, jsonString);
        }

        //Används för att rensa listan
        public void ClearList()
        {
            //Tar bort alla scored från listan
            scores.Clear();

            //Sparar den nya tomma listan
            Save();
        }
    }

}
