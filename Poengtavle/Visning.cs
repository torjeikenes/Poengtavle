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

        public void SetScore(string team)
        {
            switch (team)
            {
                case "home":
                    home++;
                    break;
                case "away":
                    away++;
                    break;
                default:
                    break;
            }
        }

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            totSec--;
            

            if (sec == 0)
            {
                sec = 59;
            }

            min = totSec / 60;
            sec = totSec % 60;

            Tid.Text = min + ":" + sec;
        }

        public void NewAdd(string path, int nr)
        {
            AdsPanel.Visible = true;
            adTimer.Start();
        }

        public void ShowAdd(bool show)
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

        private void adTimer_Tick(object sender, EventArgs e)
        {
            string[] images = Directory.GetFiles(path + @"\reklame\");
            Ads.Image = Image.FromFile(images[adNr]);

            Console.WriteLine(adCount);
            if (adCount > adLength)
            {
                Console.WriteLine("adnr" + adNr);

                adNr++;
                adCount = 0;
                if (adNr >= images.Length)
                    adNr = 0;
            }

            adCount++;
        }

        private void Visning_SizeChanged(object sender, EventArgs e)
        {
            visningPanel.Location = new Point((this.Width / 2) - (visningPanel.Width / 2), (this.Height / 2) - (visningPanel.Height / 2));

        }
    }
}
