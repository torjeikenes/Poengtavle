using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poengtavle
{
    public partial class Visning : Form
    {
        private int home;
        private int away;
        private bool gameGoing;

        private int totSec = 1800;
        private int min;
        private int sec;


        public Visning()
        {
            InitializeComponent();
        }

        private void Visning_Load(object sender, EventArgs e)
        {

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

    }
}
