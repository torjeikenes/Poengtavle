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
    public partial class Form1 : Form
    {
        Visning visning = new Visning();
        private int home;
        private int away;
        private int totSec = 1800;
        private int min;
        private int sec;

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateScore()
        {
        }
        private void UpdateScore(object sender, EventArgs e)
        {
            visning.SetScore("home", Convert.ToInt16(homeScore.Value));
            visning.SetScore("away", Convert.ToInt16(awayScore.Value));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupPanel.Location = new Point(0, 0);
            runningPanel.Location = new Point(0, 0);
            runningPanel.Visible = false;
            SetupPanel.Dock = DockStyle.Fill;
        }

        private void startTimer_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void stopTimer_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void scoreHome_Click(object sender, EventArgs e)
        {
            homeScore.Value++;
            UpdateScore();
        }

        private void ScoreAway_Click(object sender, EventArgs e)
        {
            awayScore.Value++;
            UpdateScore();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void period_ValueChanged(object sender, EventArgs e)
        {
            visning.Period.Text = Convert.ToString(period.Value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            totSec--;
            
            if (sec == 0)
            {
                sec = 59;
            }
            if (totSec == 0)
            {
                timer1.Stop();
                period.Value++;
                totSec = Convert.ToInt16(minutes.Value * 60);
            }

            min = totSec / 60;
            sec = totSec % 60;

            visning.Tid.Text = min + ":" + sec;
            time.Text = min + ":" + sec;

        }

        private void Setup_Click(object sender, EventArgs e)
        {
            SetupPanel.Visible = false;
            runningPanel.Visible = true;
            runningPanel.Dock = DockStyle.Fill;

            totSec = Convert.ToInt16(minutes.Value) * 60;

            min = totSec / 60;
            sec = totSec % 60;

            visning.Tid.Text = min + ":" + sec;
            time.Text = min + ":" + sec;

            homeLb.Text = HomeTeam.Text;
            awayLb.Text = AwayTeam.Text;
            visning.homeLb.Text = HomeTeam.Text;
            visning.AwayLb.Text = AwayTeam.Text;

            visning.Show();
        }

        private void ResetTimer(object sender, EventArgs e)
        {
            totSec = Convert.ToInt16(minutes.Value) * 60;

            min = totSec / 60;
            sec = totSec % 60;

            visning.Tid.Text = min + ":" + sec;
            time.Text = min + ":" + sec;
        }
    }
}
