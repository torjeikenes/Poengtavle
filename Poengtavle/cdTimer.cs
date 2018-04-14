using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Poengtavle
{
    class cdTimer : Label
    {
        private int totalSeconds;
        private string team;
        private int min;
        private int sec;

        private int locX = 100;
        private int locY = 370;

        public cdTimer() { }
        public cdTimer(int s, string t, int nr, Form f)
        {
            totalSeconds = s;
            team = t;

            if (team == "hjemme")
            {
                this.Location = new Point(locX,locY + nr*(this.Height + 20));
                Console.WriteLine("Yabadedo");
            }
            else
            {
                this.Location = new Point(locX + 300,locY + nr*(this.Height + 20));
            }
            //this.Text = "02:00";
            this.Font = new Font("Microsoft Sans Serif",16);
            tick();

            f.Controls.Add(this);
            Console.WriteLine(this.Location);
        }

        public void tick()
        {
            totalSeconds--;

            min = totalSeconds / 60;
            sec = totalSeconds % 60;

            if (totalSeconds == 0)
            {
                this.Enabled = false;
            }

            this.Text = min + ":" + sec;
        }
    }
}
