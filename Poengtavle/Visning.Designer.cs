namespace Poengtavle
{
    partial class Visning
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visning));
            this.Tid = new System.Windows.Forms.Label();
            this.homeScr = new System.Windows.Forms.Label();
            this.AwayScr = new System.Windows.Forms.Label();
            this.homeLb = new System.Windows.Forms.Label();
            this.AwayLb = new System.Windows.Forms.Label();
            this.Period = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RedAway = new System.Windows.Forms.PictureBox();
            this.YellowAway = new System.Windows.Forms.PictureBox();
            this.RedHome = new System.Windows.Forms.PictureBox();
            this.YellowHome = new System.Windows.Forms.PictureBox();
            this.AdsPanel = new System.Windows.Forms.Panel();
            this.Ads = new System.Windows.Forms.PictureBox();
            this.adTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RedAway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowAway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowHome)).BeginInit();
            this.AdsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Tid
            // 
            this.Tid.AutoSize = true;
            this.Tid.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tid.Location = new System.Drawing.Point(167, 66);
            this.Tid.Name = "Tid";
            this.Tid.Size = new System.Drawing.Size(178, 108);
            this.Tid.TabIndex = 0;
            this.Tid.Text = "Tid";
            // 
            // homeScr
            // 
            this.homeScr.AutoSize = true;
            this.homeScr.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeScr.Location = new System.Drawing.Point(29, 216);
            this.homeScr.Name = "homeScr";
            this.homeScr.Size = new System.Drawing.Size(39, 42);
            this.homeScr.TabIndex = 2;
            this.homeScr.Text = "0";
            // 
            // AwayScr
            // 
            this.AwayScr.AutoSize = true;
            this.AwayScr.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AwayScr.Location = new System.Drawing.Point(340, 216);
            this.AwayScr.Name = "AwayScr";
            this.AwayScr.Size = new System.Drawing.Size(39, 42);
            this.AwayScr.TabIndex = 3;
            this.AwayScr.Text = "0";
            // 
            // homeLb
            // 
            this.homeLb.AutoSize = true;
            this.homeLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLb.Location = new System.Drawing.Point(29, 174);
            this.homeLb.Name = "homeLb";
            this.homeLb.Size = new System.Drawing.Size(155, 42);
            this.homeLb.TabIndex = 4;
            this.homeLb.Text = "Hjemme";
            // 
            // AwayLb
            // 
            this.AwayLb.AutoSize = true;
            this.AwayLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AwayLb.Location = new System.Drawing.Point(340, 174);
            this.AwayLb.Name = "AwayLb";
            this.AwayLb.Size = new System.Drawing.Size(107, 42);
            this.AwayLb.TabIndex = 5;
            this.AwayLb.Text = "Borte";
            // 
            // Period
            // 
            this.Period.AutoSize = true;
            this.Period.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Period.Location = new System.Drawing.Point(246, 33);
            this.Period.Name = "Period";
            this.Period.Size = new System.Drawing.Size(20, 24);
            this.Period.TabIndex = 6;
            this.Period.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Omgang";
            // 
            // RedAway
            // 
            this.RedAway.Image = ((System.Drawing.Image)(resources.GetObject("RedAway.Image")));
            this.RedAway.Location = new System.Drawing.Point(404, 261);
            this.RedAway.Name = "RedAway";
            this.RedAway.Size = new System.Drawing.Size(52, 75);
            this.RedAway.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RedAway.TabIndex = 24;
            this.RedAway.TabStop = false;
            // 
            // YellowAway
            // 
            this.YellowAway.Image = global::Poengtavle.Properties.Resources.yellow;
            this.YellowAway.Location = new System.Drawing.Point(347, 261);
            this.YellowAway.Name = "YellowAway";
            this.YellowAway.Size = new System.Drawing.Size(52, 75);
            this.YellowAway.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YellowAway.TabIndex = 23;
            this.YellowAway.TabStop = false;
            // 
            // RedHome
            // 
            this.RedHome.Image = ((System.Drawing.Image)(resources.GetObject("RedHome.Image")));
            this.RedHome.Location = new System.Drawing.Point(94, 261);
            this.RedHome.Name = "RedHome";
            this.RedHome.Size = new System.Drawing.Size(52, 75);
            this.RedHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RedHome.TabIndex = 22;
            this.RedHome.TabStop = false;
            // 
            // YellowHome
            // 
            this.YellowHome.Image = global::Poengtavle.Properties.Resources.yellow;
            this.YellowHome.Location = new System.Drawing.Point(36, 261);
            this.YellowHome.Name = "YellowHome";
            this.YellowHome.Size = new System.Drawing.Size(52, 75);
            this.YellowHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YellowHome.TabIndex = 21;
            this.YellowHome.TabStop = false;
            // 
            // AdsPanel
            // 
            this.AdsPanel.Controls.Add(this.Ads);
            this.AdsPanel.Location = new System.Drawing.Point(101, 374);
            this.AdsPanel.Name = "AdsPanel";
            this.AdsPanel.Size = new System.Drawing.Size(293, 176);
            this.AdsPanel.TabIndex = 25;
            // 
            // Ads
            // 
            this.Ads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ads.Location = new System.Drawing.Point(0, 0);
            this.Ads.Name = "Ads";
            this.Ads.Size = new System.Drawing.Size(293, 176);
            this.Ads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ads.TabIndex = 0;
            this.Ads.TabStop = false;
            // 
            // adTimer
            // 
            this.adTimer.Interval = 1000;
            this.adTimer.Tick += new System.EventHandler(this.AdTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(340, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 42);
            this.label4.TabIndex = 3;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 42);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hjemme";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(340, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 42);
            this.label6.TabIndex = 5;
            this.label6.Text = "Borte";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(246, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(213, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Omgang";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Poengtavle.Properties.Resources.yellow;
            this.pictureBox1.Location = new System.Drawing.Point(36, 261);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(94, 261);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Poengtavle.Properties.Resources.yellow;
            this.pictureBox3.Location = new System.Drawing.Point(347, 261);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 75);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(404, 261);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 75);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // Visning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(950, 562);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.AdsPanel);
            this.Controls.Add(this.Tid);
            this.Controls.Add(this.homeScr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RedAway);
            this.Controls.Add(this.Period);
            this.Controls.Add(this.AwayScr);
            this.Controls.Add(this.YellowHome);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AwayLb);
            this.Controls.Add(this.YellowAway);
            this.Controls.Add(this.RedHome);
            this.Controls.Add(this.homeLb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Visning";
            this.Text = "Visning";
            this.Load += new System.EventHandler(this.Visning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RedAway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowAway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowHome)).EndInit();
            this.AdsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label homeScr;
        private System.Windows.Forms.Label AwayScr;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label Period;
        public System.Windows.Forms.Label Tid;
        public System.Windows.Forms.Label homeLb;
        public System.Windows.Forms.Label AwayLb;
        public System.Windows.Forms.PictureBox RedAway;
        public System.Windows.Forms.PictureBox YellowAway;
        public System.Windows.Forms.PictureBox RedHome;
        public System.Windows.Forms.PictureBox YellowHome;
        private System.Windows.Forms.Panel AdsPanel;
        private System.Windows.Forms.PictureBox Ads;
        private System.Windows.Forms.Timer adTimer;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.PictureBox pictureBox4;
    }
}