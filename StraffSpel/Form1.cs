using System;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

//namespace samma för alla filer i projektet
namespace StraffSpel
{
    public partial class Form1 : Form

    {
        //penaltiesRound är antal rundor spelaren kör, startar på 0
        private int penaltiesRound = 0;
        //Gränsen för rundor under ett spel sätts till 5
        private int roundLimit = 5;
        //Variabel för att spara spelarens namn
        private string playerName;


        //Använder funktionaliteten för spelet som skapades i PlayerChoices
        private PlayerChoices penalties;
        //Initierar topplistan för spelet
        private Highscore topList = new Highscore();
        public Form1()
        {
            //Skapar automatiskt delar av det visuella i spelet som knappar, texter och bilder
            InitializeComponent();

            //Initierar ett nytt spel
            penalties = new PlayerChoices();

            //Rubriker och text sätts ut för det visuella i spelet
            topListTitle.Text = "Topplistan";
            gameDescription.Text = "I det här spelet får du lägga fem straffar mot datorn.\n Dina poäng kommer dyka upp i topplistan i slutet av din runda.";
            endMessage.Text = "Välj en riktning för din straffläggning för att starta spelet!";
            label2.Text = "Totalt resultat: \n" + "--------------------\n" + "--\n" + "--";

            //Ingen bild ska visas innan spelet startar
            pictureBox1.Image = null;

            //Spelknapparna ska inte visas innan spelet startar
            buttonLeft.Visible = false;
            buttonCenter.Visible = false;
            buttonRight.Visible = false;

            //Text som visas i bildrutan av spelet ska inte visas innan spelet startar
            endMessage.Visible = false;

            //Knappar för att starta om spelet ska inte visas innan spelet startar
            restart.Visible = false;
            newNameGameBtn.Visible = false;

            //Hämtar topplistan av de 5 bästa poängen
            var showScores = topList.GetScores();

            //Rensar boxen
            topScoreBox.Items.Clear();
            //Sätter listnumber till 0 för att sedan ha ett nummer framför varje spelares poäng i topplistan
            int listNumber = 0;

            //För varje användare och poäng i listan skrivs de ut i boxen
            foreach (var score in showScores)
            {
                //Först ökar listsiffran med 1
                listNumber++;
                //Sedan skrivs listsiffran ut tillsammans med användarens namn och poäng
                topScoreBox.Items.Add($" {listNumber}. {score.Name} - {score.Points} poäng");
            }
        }


        //Välj vilken bild som ska visas baserat på vad användaren har valt och vilket slumpmässigt tal datorn har fått
        private void DisplayImage(int kickerDirection, int goalkeeperDirection)
        {
            //Bilden väljs ut genom att de är namngivna efter spelarens och målvaktens val
            string imagePath = Path.Combine(Application.StartupPath, "images", $"{kickerDirection}.{goalkeeperDirection}.jpg");

            //Om filnamnet finns i bildmappen
            if (File.Exists(imagePath))
            {
                //Så visas den i picturebox i spelet
                pictureBox1.Image = Image.FromFile(imagePath);
            }
            //Om bilden inte finns visas ingen bild
            else
            {
                pictureBox1.Image = null;
            }
        }

        //Metod för att köra en omgång av straffläggning
        private void PenaltyGame(int kickerDirection)
        {
            //Anropar metoden penaltyround i playerchoices och skickar med användarens val för att få ut målvaktens val och ett meddelande
            var (goalkeeperDirection, message) = penalties.PenaltyRound(kickerDirection);

            //Anropar displayimage för att visa en bild baserat på användaren och målvaktens val
            DisplayImage(kickerDirection, goalkeeperDirection);

            //Ett meddelande baserat på vem som vann skrivs ut och en instruktion om hur man fortsätter spela
            endMessage.Text = $"{message} Välj en riktning för att fortsätta.";

            //Poängställningen för användaren och målvakten skrivs ut med namn och poäng
            label2.Text =
                "Totalt resultat: \n" + "--------------------\n" + $"{penalties.Kicker.Name} {penalties.Kicker.Points}\n" + $"{penalties.GoalKeeper.Name}  {penalties.GoalKeeper.Points}\n";

            //penaltiesRound ökar med 1 för att visa att en ny runda har spelats
            penaltiesRound++;

            //Om penaltiesRound är lika många som gränsvärdet satt avslutas spelet
            if (penaltiesRound >= roundLimit)
            {
                //Anropar finishgame för att avsluta spelet och skickar med message
                FinishGame(message);
            }
        }

        private void startGame()
        {
            //Spelarens namn sätts till det användaren skriver in
            playerName = nameInsert.Text.Trim();

            //Om namnet är tomt syns en varningstext
            if (string.IsNullOrEmpty(playerName))
            {
                nameWarning.Text = "Namn kan inte vara tomt, skriv in ditt namn!";
                return;
            }

            //Starta ett nytt spel, sätt spelarens namn till playerName och sätt antal rundor till 0
            penalties = new PlayerChoices();
            penalties.Kicker.Name = playerName;
            penaltiesRound = 0;

            //Resultatet för spelarna skrivs ut med namn och poäng
            label2.Text =
              "Totalt resultat: \n" + "--------------------\n" + $"{penalties.Kicker.Name} {penalties.Kicker.Points}\n" + $"{penalties.GoalKeeper.Name}  {penalties.GoalKeeper.Points}\n";

            //Visa spelknapparna
            buttonLeft.Visible = true;
            buttonCenter.Visible = true;
            buttonRight.Visible = true;
            buttonLeft.Enabled = true;
            buttonCenter.Enabled = true;
            buttonRight.Enabled = true;

            //Visa knappar för att starta om eller starta om med ny spelare
            restart.Visible = true;
            newNameGameBtn.Visible = true;

            //Dölj startknappen och textboxen
            startButton.Visible = false;
            nameInsert.Enabled = false;

            //Välj startbild
            string startImagePath = Path.Combine(Application.StartupPath, "images", $"restart.jpg");


            //Visa bild efter spelets start
            if (File.Exists(startImagePath))
            {
                pictureBox1.Image = Image.FromFile(startImagePath);
            }
            //Om bilden inte hittas visas ingen bild alls
            else
            {
                pictureBox1.Image = null;
            }

            //Dölj text och knappar från startskärmen när spelet börjar
            introductionLabel.Visible = false;
            gameDescription.Visible = false;
            writeName.Visible = false;
            nameInsert.Visible = false;
            startButton.Visible = false;
            endMessage.Visible = true;
            nameWarning.Visible = false;

        }

        //Metod för att avsluta spelet med message inskickat
        private void FinishGame(string message)
        {
            //Spelknapparna fungerar inte att klicka på längre
            buttonLeft.Enabled = false;
            buttonCenter.Enabled = false;
            buttonRight.Enabled = false;

            //Slutmeddelandet visas
            endMessage.Visible = true;
  
            //Slutmeddelandet visar resultatet från sista straffläggningen och ett meddelande om att spelet är slut
            endMessage.Text = $"{message}\n Spelet är slut! Du fick {penalties.Kicker.Points} poäng efter 5 rundor.";

            //Topplistan uppdateras med spelarens resultat
            topList.AddScore(playerName, penalties.Kicker.Points);

            //Topplistan hämtas 
            var showScores = topList.GetScores();

            //Boxen rensas för att sedan fyllas på med poängen från topplistan
            topScoreBox.Items.Clear();
            int listNumber = 0;
            foreach (var score in showScores)
            {
                listNumber++;

                topScoreBox.Items.Add($" {listNumber}. {score.Name} - {score.Points} poäng");
            }

            //Knappar och funktioner för att skriva in ett namn och starta spelet fungerar igen
            startButton.Enabled = true;
            nameInsert.Enabled = true;
        }

        //Metod för att starta om spelet
        private void RestartGame()
        {
            //Rundorna sätts till 0 igen
            penaltiesRound = 0;

            //Poängen för båda spelarna sätts till 0
            penalties.Kicker.setScoreZero();
            penalties.GoalKeeper.setScoreZero();

            //En ny bild visas som startbild
            string startImagePath = Path.Combine(Application.StartupPath, "images", $"restart.jpg");
            //Ett meddelande med information om hur man startar spelet skrivs ut
            endMessage.Text = "Välj en riktning för din straffläggning för att starta spelet!";

            //Visa bild efter spelets start om den hittas
            if (File.Exists(startImagePath))
            {
                pictureBox1.Image = Image.FromFile(startImagePath);
            }
            //Om bilden inte hittas visas ingen bild
            else
            {
                pictureBox1.Image = null;
            }

            //Meddelande visas igen
            endMessage.Visible = true;

            //Text för båda spelarnas resultat visas
            label2.Text =
               "Totalt resultat: \n" + "--------------------\n" + $"{penalties.Kicker.Name} {penalties.Kicker.Points}\n" + $"{penalties.GoalKeeper.Name}  {penalties.GoalKeeper.Points}\n";

            //Alla spelknappar fungerar igen
            buttonLeft.Enabled = true;
            buttonCenter.Enabled = true;
            buttonRight.Enabled = true;


        }



        //Metod för att skriva in ett nytt namn för spelaren innan en ny omgång
        private void startNewPlayer()
        {
            //Tar bort spelarens namn och bild vid spelets start
            playerName = null;
            pictureBox1.Image = null;

            //Uppdaterar meddelande för att ge användaren instruktioner om spelet
            endMessage.Text = "Välj en riktning för din straffläggning för att starta spelet!";

            //Visar text och knappar för att starta ett nytt spel
            introductionLabel.Visible = true;
            gameDescription.Visible = true;
            writeName.Visible = true;
            nameInsert.Enabled = true;
            nameInsert.Visible = true;
            startButton.Visible = true;
            nameWarning.Visible = true;

            nameWarning.Text = "";

            //Spelarens namn sätts till det användaren skriver in
            playerName = nameInsert.Text.Trim();

            //Om namnet är tomt syns en varningstext
            if (string.IsNullOrEmpty(playerName))
            {
                nameWarning.Text = "Namn kan inte vara tomt, skriv in ditt namn!";
                return;
            }

            //Visar inte spelets knappar innan spelet har startat
            endMessage.Visible = false;
            restart.Visible = false;
            newNameGameBtn.Visible = false;
            buttonLeft.Visible = false;
            buttonCenter.Visible = false;
            buttonRight.Visible = false;
        }


        //Knapp för att rensa topplistan
        private void clearButton_Click(object sender, EventArgs e)
        {
            topList.ClearList();
            topScoreBox.Items.Clear();
        }

        //Knapp för att starta spelet med en ny spelare
        private void newNameGameBtn_Click(object sender, EventArgs e)
        {
            startNewPlayer();
        }


        //När spelaren klickar på knappen vänster körs spelet med användarvalet 1
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            PenaltyGame(1);
        }

        //När spelaren klickar på knappen mitten körs spelet med användarvalet 2
        private void buttonCenter_Click(object sender, EventArgs e)
        {
            PenaltyGame(2);
        }

        //När spelaren klickar på knappen höger körs spelet med användarvalet 3
        private void buttonRight_Click(object sender, EventArgs e)
        {
            PenaltyGame(3);
        }

        //När spelaren klickar på starta om körs metoden restartGame
        private void restart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        //Knapp för att starta spelet
        private void startButton_Click(object sender, EventArgs e)
        {
            startGame();
        }

        //Knapp för att avsluta spelet
        private void exitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Resize(object sender, EventArgs e)
        {

        }

        private void gameDescription_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
