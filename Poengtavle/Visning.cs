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
    public partial class Visning : Form
    {
        private int home;
        private int away;
        private int totSec = 1800;
        private int min;
        private int sec;
        private int adCount;
        private int adLength = 2;
        private int adNr = 0;
        private string path;

        public Visning()
        {
            InitializeComponent();
        }
        public Visning(string folder)
        {
            path = folder;
            InitializeComponent();
        }

        private void Visning_Load(object sender, EventArgs e)
        {
            AdsPanel.Dock = DockStyle.Fill;
            AdsPanel.Visible = false;
            adTimer.Interval = 1000;
            foreach (PictureBox pict in Controls.OfType<PictureBox>())
            {
                pict.Visible = false;
            }
        }

        public string Path
        {
            set { path = value; }
        }

        /// <summary>
        /// Setter poengsummen til et lag
        /// </summary>
        /// <param name="team">laget som får poeng</param>
        /// <param name="score">hvor mange poeng laget får</param>
        public void SetScore(string team, int score)
        {
            switch (team)
            {
                case "home":
                    home = score;
                    homeScr.Text = Convert.ToString(home);
                    break;
                case "away":
                    away = score;
                    AwayScr.Text = Convert.ToString(away);
                    break;
                default:
                    break;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            totSec--;

            if (sec == 0)
            {
                sec = 59;
            }

            // finner antal minutter og sekunder utfra totale antall sekunder
            min = totSec / 60;
            sec = totSec % 60;

            Tid.Text = min + ":" + sec;
        }


        public void NewAd(string path, int nr)
        {
            AdsPanel.Visible = true;
            adTimer.Start();
        }

        /// <summary>
        /// Viser eller gjemmer reklame. show = true viser reklame og show = false gjemmer reklame
        /// </summary>
        /// <param name="show"></param>
        public void ShowAd(bool show)
        {
            if (show)
            {
                AdsPanel.Visible = true;
                adTimer.Start();
            }
            else
            {
                AdsPanel.Visible = false;
                adTimer.Stop();
            }
        }

        // Timer for reklame
        private void AdTimer_Tick(object sender, EventArgs e)
        {
            // Setter inn alle bildene i folderen i et string array 
            // Reklamer plasseres i Documents\reklame
            string[] images = Directory.GetFiles(path + @"\reklame\");
            // setter reklamebildet til bildet med indeksen adNr
            Ads.Image = Image.FromFile(images[adNr]);

            
            // Øker adNr og reseter telleren for reklamelengde om reklamen har stått lenge nok
            if (adCount > adLength)
            {
                adNr++;
                adCount = 0;
                if (adNr >= images.Length)
                    adNr = 0;
            }

            // øker telleren for reklamelengde
            adCount++;
        }

    }
}
