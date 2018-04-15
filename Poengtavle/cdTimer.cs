using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Poengtavle
{
    class CdTimer : Label
    {
        private int totalSeconds;
        private string team;
        private int min;
        private int sec;

        private int locX = 100;
        private int locY = 370;

        /// <summary>
        /// Lager en label som teller ned fra antall sekunder som er satt inn
        /// </summary>
        /// <param name="s">Totalt antall sekunder</param>
        /// <param name="t">Laget som skal ha timeren</param>
        /// <param name="nr">Hvilket nr timer denne er </param>
        /// <param name="f">Formet timeren skal være i</param>
        public CdTimer(int s, string t, int nr, Form f)
        {
            totalSeconds = s;
            team = t;

            // Plaserer labelen avhengig av hvilket lag den er sin
            if (team == "hjemme")
            {
                this.Location = new Point(locX,locY + nr*(this.Height + 20));
            }
            else
            {
                this.Location = new Point(locX + 300,locY + nr*(this.Height + 20));
            }

            this.Font = new Font("Microsoft Sans Serif",16);

            // legger til labelen i formen
            f.Controls.Add(this);
        }

        /// <summary>
        /// Teller ned timeren med ett sekund
        /// </summary>
        public void Tick()
        {
            totalSeconds--;

            // regner ut minutter og sekunder fra totale antall sekunder
            min = totalSeconds / 60;
            sec = totalSeconds % 60;

            // Deaktiverer timeren om den går til 0 sekunder
            if (totalSeconds == 0)
            {
                this.Enabled = false;
            }

            this.Text = min + ":" + sec;
        }
    }
}
