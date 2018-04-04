using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Poengtavle
{
    public partial class Form1 : Form
    {
        Visning visning = new Visning();
        private int totSec = 1800;
        private int min;
        private int sec;
        private string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // flytter paneler til riktig sted
            SetupPanel.Location = new Point(0, 0);
            runningPanel.Location = new Point(0, 0);
            runningPanel.Visible = false;
            SetupPanel.Dock = DockStyle.Fill;
        }

        #region score
        private void UpdateScore(object sender, EventArgs e)
        {
            // kjører funksjonen SetScore i visningsformen for å vise riktig score. 
            visning.SetScore("home", Convert.ToInt16(homeScore.Value));
            visning.SetScore("away", Convert.ToInt16(awayScore.Value));
        }

        // Øker scoren og skriver til csv filen
        private void scoreHome_Click(object sender, EventArgs e)
        {
            homeScore.Value++;
            WriteCsv(HomeTeam.Text);
        }

        private void ScoreAway_Click(object sender, EventArgs e)
        {
            awayScore.Value++;
            WriteCsv(AwayTeam.Text);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region timer

        // Starter timeren og stopper musikk om man har krysset av på autoplay
        private void startTimer_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (AutoMusic.Checked) 
                wmp.Ctlcontrols.pause();
        }

        // Stopper timeren og starter musikk om man har krysset autoplay
        private void stopTimer_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (AutoMusic.Checked)
                wmp.Ctlcontrols.play();
        }

        // Setter tilbake timeren til tiden satt på setup
        private void ResetTimer(object sender, EventArgs e)
        {
            totSec = Convert.ToInt16(minutes.Value) * 60;

            min = totSec / 60;
            sec = totSec % 60;

            visning.Tid.Text = min + ":" + sec;
            time.Text = min + ":" + sec;
        }
        
        // trekker fra ett sekund per tick og viser tiden riktig
        private void timer1_Tick(object sender, EventArgs e)
        {
            totSec--;

            // Om timeren har gått ut stoppes den, omgangen øker og setter tilbake tiden
            if (totSec == 0)
            {
                timer1.Stop();
                period.Value++;
                totSec = Convert.ToInt16(minutes.Value * 60);
            }

            DisplayTime(totSec);

        }

        // Viser tiden riktig
        private void DisplayTime(int tot)
        {
            // Finner antal minutter og sekunder totaltiden deles opp i
            min = totSec / 60;
            sec = totSec % 60;

            // Viser tiden på vinsingskjermen og konfigurasjonskjermen
            visning.Tid.Text = min + ":" + sec;
            time.Text = min + ":" + sec;

        }
        #endregion

        #region setup

        // Viser perioden på visningsskjermen om den er endret
        private void period_ValueChanged(object sender, EventArgs e)
        {
            visning.Period.Text = Convert.ToString(period.Value);
        }

        private void Setup_Click(object sender, EventArgs e)
        {
            // Bytter panel
            SetupPanel.Visible = false;
            runningPanel.Visible = true;
            runningPanel.Dock = DockStyle.Fill;

            // setter totale sekunder for en omgang
            totSec = Convert.ToInt16(minutes.Value) * 60;

            // Finner antal minutter og sekunder totaltiden deles opp i
            min = totSec / 60;
            sec = totSec % 60;

            //         
            visning.Tid.Text = min + ":" + sec;
            time.Text = min + ":" + sec;

            // Endrer teksten til navnet på lagene
            homeLb.Text = HomeTeam.Text;
            awayLb.Text = AwayTeam.Text;
            visning.homeLb.Text = HomeTeam.Text;
            visning.AwayLb.Text = AwayTeam.Text;

            // Viser visnings formen
            visning.Show();
        }
        #endregion 

        #region csv
        // skriver ned mål i en csv fil
        private void WriteCsv(string team, string action)
        {
            using(StreamWriter sw = new StreamWriter(path + "\\" + HomeTeam.Text + "-" + AwayTeam.Text + ".csv", append: true))
            {
                Console.WriteLine(period);

                sw.WriteLine(action + "," + period.Value + "," + time.Text + "," + team);
            }
        }
        private void WriteCsv(string team)
        {
            WriteCsv(team, "mål");
        }
        #endregion

        #region music
        // setter opp en spilleliste med valgte sanger
        private void LoadMusic(object sender, EventArgs e)
        {
            // setter filter og åpner en fil dialog for å velge sanger
            ofd.Filter = "music files (*.mp3)|*.mp3";
            ofd.ShowDialog();

            // lager en spilleliste og media variabel i windows media player
            WMPLib.IWMPPlaylist playlist = wmp.playlistCollection.newPlaylist("pause");
            WMPLib.IWMPMedia media;

            // går gjennom hver valgte fil og legger den til i spillelisten
            foreach (string file in ofd.FileNames)
            {
                media = wmp.newMedia(file);
                playlist.appendItem(media);
            }

            // setter den lagde spillelisten til den gjeldende
            wmp.currentPlaylist = playlist;

            //stopper avspilling fordi den automatisk vil starte avspilling
            wmp.Ctlcontrols.stop();
        }
        #endregion

        #region cards
        private void CardClicked(object sender, EventArgs e)
        {
            PictureBox card = sender as PictureBox;
            PictureBox ShowCard = visning.YellowHome;

            string team = "";
            string action = "";

            switch (card.Name)
            {
                case "YellowHome":
                    ShowCard = visning.YellowHome;
                    team = HomeTeam.Text;
                    action = "Yellow card";
                    break;
                case "RedHome":
                    ShowCard = visning.RedHome;
                    team = HomeTeam.Text;
                    action = "Red card";
                    break;
                case "YellowAway":
                    ShowCard = visning.YellowAway;
                    team = AwayTeam.Text;
                    action = "Yellow card";
                    break;
                case "RedAway":
                    ShowCard = visning.RedAway;
                    team = AwayTeam.Text;
                    action = "Red card";
                    break;
            }

            if (card.BorderStyle == BorderStyle.None)
            {
                card.BorderStyle = BorderStyle.Fixed3D;
                ShowCard.Visible = true;
                WriteCsv(team, action);
            }
            else
            {
                card.BorderStyle = BorderStyle.None;
                ShowCard.Visible = false;
            }

        }
        #endregion
    }
}
