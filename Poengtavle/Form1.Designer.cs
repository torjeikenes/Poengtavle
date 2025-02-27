﻿namespace Poengtavle
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startTimer = new System.Windows.Forms.Button();
            this.stopTimer = new System.Windows.Forms.Button();
            this.homeScore = new System.Windows.Forms.NumericUpDown();
            this.awayScore = new System.Windows.Forms.NumericUpDown();
            this.homeLb = new System.Windows.Forms.Label();
            this.awayLb = new System.Windows.Forms.Label();
            this.ScoreHome = new System.Windows.Forms.Button();
            this.ScoreAway = new System.Windows.Forms.Button();
            this.periods = new System.Windows.Forms.NumericUpDown();
            this.minutes = new System.Windows.Forms.NumericUpDown();
            this.period = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SetupPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.penaltyTime = new System.Windows.Forms.NumericUpDown();
            this.AwayTeam = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.HomeTeam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Setup = new System.Windows.Forms.Button();
            this.runningPanel = new System.Windows.Forms.Panel();
            this.AdsBtn = new System.Windows.Forms.Button();
            this.AutoAds = new System.Windows.Forms.CheckBox();
            this.UtvisningBorte = new System.Windows.Forms.Button();
            this.UtvisningHjemme = new System.Windows.Forms.Button();
            this.RedAway = new System.Windows.Forms.PictureBox();
            this.YellowAway = new System.Windows.Forms.PictureBox();
            this.RedHome = new System.Windows.Forms.PictureBox();
            this.YellowHome = new System.Windows.Forms.PictureBox();
            this.changeMusic = new System.Windows.Forms.Button();
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.AutoMusic = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.PointsPerGoal = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.homeScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awayScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.period)).BeginInit();
            this.SetupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penaltyTime)).BeginInit();
            this.runningPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedAway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowAway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointsPerGoal)).BeginInit();
            this.SuspendLayout();
            // 
            // startTimer
            // 
            this.startTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimer.Location = new System.Drawing.Point(3, 104);
            this.startTimer.Name = "startTimer";
            this.startTimer.Size = new System.Drawing.Size(126, 55);
            this.startTimer.TabIndex = 0;
            this.startTimer.Text = "Start Timer";
            this.startTimer.UseVisualStyleBackColor = true;
            this.startTimer.Click += new System.EventHandler(this.StartTimer_Click);
            // 
            // stopTimer
            // 
            this.stopTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopTimer.Location = new System.Drawing.Point(135, 104);
            this.stopTimer.Name = "stopTimer";
            this.stopTimer.Size = new System.Drawing.Size(134, 55);
            this.stopTimer.TabIndex = 1;
            this.stopTimer.Text = "Stopp Timer";
            this.stopTimer.UseVisualStyleBackColor = true;
            this.stopTimer.Click += new System.EventHandler(this.StopTimer_Click);
            // 
            // homeScore
            // 
            this.homeScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeScore.Location = new System.Drawing.Point(49, 216);
            this.homeScore.Name = "homeScore";
            this.homeScore.Size = new System.Drawing.Size(64, 35);
            this.homeScore.TabIndex = 2;
            this.homeScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.homeScore.ValueChanged += new System.EventHandler(this.UpdateScore);
            // 
            // awayScore
            // 
            this.awayScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awayScore.Location = new System.Drawing.Point(301, 216);
            this.awayScore.Name = "awayScore";
            this.awayScore.Size = new System.Drawing.Size(65, 35);
            this.awayScore.TabIndex = 3;
            this.awayScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.awayScore.ValueChanged += new System.EventHandler(this.UpdateScore);
            // 
            // homeLb
            // 
            this.homeLb.AutoSize = true;
            this.homeLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLb.Location = new System.Drawing.Point(47, 193);
            this.homeLb.Name = "homeLb";
            this.homeLb.Size = new System.Drawing.Size(68, 20);
            this.homeLb.TabIndex = 4;
            this.homeLb.Text = "Hjemme";
            this.homeLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // awayLb
            // 
            this.awayLb.AutoSize = true;
            this.awayLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awayLb.Location = new System.Drawing.Point(302, 193);
            this.awayLb.Name = "awayLb";
            this.awayLb.Size = new System.Drawing.Size(48, 20);
            this.awayLb.TabIndex = 5;
            this.awayLb.Text = "Borte";
            this.awayLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreHome
            // 
            this.ScoreHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreHome.Location = new System.Drawing.Point(20, 257);
            this.ScoreHome.Name = "ScoreHome";
            this.ScoreHome.Size = new System.Drawing.Size(109, 72);
            this.ScoreHome.TabIndex = 6;
            this.ScoreHome.Text = "Mål Hjemme";
            this.ScoreHome.UseVisualStyleBackColor = true;
            this.ScoreHome.Click += new System.EventHandler(this.ScoreHome_Click);
            // 
            // ScoreAway
            // 
            this.ScoreAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreAway.Location = new System.Drawing.Point(275, 257);
            this.ScoreAway.Name = "ScoreAway";
            this.ScoreAway.Size = new System.Drawing.Size(109, 72);
            this.ScoreAway.TabIndex = 7;
            this.ScoreAway.Text = "Mål Borte";
            this.ScoreAway.UseVisualStyleBackColor = true;
            this.ScoreAway.Click += new System.EventHandler(this.ScoreAway_Click);
            // 
            // periods
            // 
            this.periods.Location = new System.Drawing.Point(113, 8);
            this.periods.Name = "periods";
            this.periods.Size = new System.Drawing.Size(120, 20);
            this.periods.TabIndex = 8;
            this.periods.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // minutes
            // 
            this.minutes.Location = new System.Drawing.Point(113, 34);
            this.minutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(120, 20);
            this.minutes.TabIndex = 9;
            this.minutes.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // period
            // 
            this.period.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period.Location = new System.Drawing.Point(113, 30);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(38, 29);
            this.period.TabIndex = 10;
            this.period.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.period.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.period.ValueChanged += new System.EventHandler(this.Period_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Omgang";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(108, 72);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(49, 29);
            this.time.TabIndex = 12;
            this.time.Text = "Tid";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Minutter per omgang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "antall omganger";
            // 
            // SetupPanel
            // 
            this.SetupPanel.Controls.Add(this.label2);
            this.SetupPanel.Controls.Add(this.PointsPerGoal);
            this.SetupPanel.Controls.Add(this.label1);
            this.SetupPanel.Controls.Add(this.penaltyTime);
            this.SetupPanel.Controls.Add(this.AwayTeam);
            this.SetupPanel.Controls.Add(this.label7);
            this.SetupPanel.Controls.Add(this.HomeTeam);
            this.SetupPanel.Controls.Add(this.label6);
            this.SetupPanel.Controls.Add(this.Setup);
            this.SetupPanel.Controls.Add(this.label5);
            this.SetupPanel.Controls.Add(this.periods);
            this.SetupPanel.Controls.Add(this.label4);
            this.SetupPanel.Controls.Add(this.minutes);
            this.SetupPanel.Location = new System.Drawing.Point(12, 27);
            this.SetupPanel.Name = "SetupPanel";
            this.SetupPanel.Size = new System.Drawing.Size(371, 346);
            this.SetupPanel.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Utviselsestid";
            // 
            // penaltyTime
            // 
            this.penaltyTime.Location = new System.Drawing.Point(113, 60);
            this.penaltyTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.penaltyTime.Name = "penaltyTime";
            this.penaltyTime.Size = new System.Drawing.Size(120, 20);
            this.penaltyTime.TabIndex = 20;
            this.penaltyTime.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // AwayTeam
            // 
            this.AwayTeam.Location = new System.Drawing.Point(132, 164);
            this.AwayTeam.Name = "AwayTeam";
            this.AwayTeam.Size = new System.Drawing.Size(100, 20);
            this.AwayTeam.TabIndex = 19;
            this.AwayTeam.Text = "Borte";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Bortelag";
            // 
            // HomeTeam
            // 
            this.HomeTeam.Location = new System.Drawing.Point(5, 164);
            this.HomeTeam.Name = "HomeTeam";
            this.HomeTeam.Size = new System.Drawing.Size(100, 20);
            this.HomeTeam.TabIndex = 17;
            this.HomeTeam.Text = "Hjemme";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Hjemmelag";
            // 
            // Setup
            // 
            this.Setup.Location = new System.Drawing.Point(132, 190);
            this.Setup.Name = "Setup";
            this.Setup.Size = new System.Drawing.Size(75, 23);
            this.Setup.TabIndex = 15;
            this.Setup.Text = "Start";
            this.Setup.UseVisualStyleBackColor = true;
            this.Setup.Click += new System.EventHandler(this.Setup_Click);
            // 
            // runningPanel
            // 
            this.runningPanel.Controls.Add(this.AdsBtn);
            this.runningPanel.Controls.Add(this.AutoAds);
            this.runningPanel.Controls.Add(this.UtvisningBorte);
            this.runningPanel.Controls.Add(this.UtvisningHjemme);
            this.runningPanel.Controls.Add(this.RedAway);
            this.runningPanel.Controls.Add(this.YellowAway);
            this.runningPanel.Controls.Add(this.RedHome);
            this.runningPanel.Controls.Add(this.YellowHome);
            this.runningPanel.Controls.Add(this.changeMusic);
            this.runningPanel.Controls.Add(this.wmp);
            this.runningPanel.Controls.Add(this.AutoMusic);
            this.runningPanel.Controls.Add(this.button1);
            this.runningPanel.Controls.Add(this.stopTimer);
            this.runningPanel.Controls.Add(this.startTimer);
            this.runningPanel.Controls.Add(this.time);
            this.runningPanel.Controls.Add(this.homeScore);
            this.runningPanel.Controls.Add(this.label3);
            this.runningPanel.Controls.Add(this.awayScore);
            this.runningPanel.Controls.Add(this.period);
            this.runningPanel.Controls.Add(this.homeLb);
            this.runningPanel.Controls.Add(this.ScoreAway);
            this.runningPanel.Controls.Add(this.awayLb);
            this.runningPanel.Controls.Add(this.ScoreHome);
            this.runningPanel.Location = new System.Drawing.Point(389, 27);
            this.runningPanel.Name = "runningPanel";
            this.runningPanel.Size = new System.Drawing.Size(628, 557);
            this.runningPanel.TabIndex = 16;
            // 
            // AdsBtn
            // 
            this.AdsBtn.Location = new System.Drawing.Point(501, 81);
            this.AdsBtn.Name = "AdsBtn";
            this.AdsBtn.Size = new System.Drawing.Size(89, 23);
            this.AdsBtn.TabIndex = 0;
            this.AdsBtn.Text = "Start Reklame";
            this.AdsBtn.UseVisualStyleBackColor = true;
            this.AdsBtn.Click += new System.EventHandler(this.AdsBtn_Click);
            // 
            // AutoAds
            // 
            this.AutoAds.AutoSize = true;
            this.AutoAds.Location = new System.Drawing.Point(501, 114);
            this.AutoAds.Name = "AutoAds";
            this.AutoAds.Size = new System.Drawing.Size(110, 17);
            this.AutoAds.TabIndex = 29;
            this.AutoAds.Text = "Autospill Reklame";
            this.AutoAds.UseVisualStyleBackColor = true;
            // 
            // UtvisningBorte
            // 
            this.UtvisningBorte.Location = new System.Drawing.Point(390, 335);
            this.UtvisningBorte.Name = "UtvisningBorte";
            this.UtvisningBorte.Size = new System.Drawing.Size(65, 30);
            this.UtvisningBorte.TabIndex = 28;
            this.UtvisningBorte.Text = "Utvisning";
            this.UtvisningBorte.Click += new System.EventHandler(this.Penalty);
            // 
            // UtvisningHjemme
            // 
            this.UtvisningHjemme.Location = new System.Drawing.Point(135, 335);
            this.UtvisningHjemme.Name = "UtvisningHjemme";
            this.UtvisningHjemme.Size = new System.Drawing.Size(65, 30);
            this.UtvisningHjemme.TabIndex = 27;
            this.UtvisningHjemme.Text = "Utvisning";
            this.UtvisningHjemme.UseVisualStyleBackColor = true;
            this.UtvisningHjemme.Click += new System.EventHandler(this.Penalty);
            // 
            // RedAway
            // 
            this.RedAway.Image = ((System.Drawing.Image)(resources.GetObject("RedAway.Image")));
            this.RedAway.Location = new System.Drawing.Point(332, 335);
            this.RedAway.Name = "RedAway";
            this.RedAway.Size = new System.Drawing.Size(52, 75);
            this.RedAway.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RedAway.TabIndex = 20;
            this.RedAway.TabStop = false;
            this.RedAway.Click += new System.EventHandler(this.CardClicked);
            // 
            // YellowAway
            // 
            this.YellowAway.Image = global::Poengtavle.Properties.Resources.yellow;
            this.YellowAway.Location = new System.Drawing.Point(275, 335);
            this.YellowAway.Name = "YellowAway";
            this.YellowAway.Size = new System.Drawing.Size(52, 75);
            this.YellowAway.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YellowAway.TabIndex = 19;
            this.YellowAway.TabStop = false;
            this.YellowAway.Click += new System.EventHandler(this.CardClicked);
            // 
            // RedHome
            // 
            this.RedHome.Image = ((System.Drawing.Image)(resources.GetObject("RedHome.Image")));
            this.RedHome.Location = new System.Drawing.Point(77, 335);
            this.RedHome.Name = "RedHome";
            this.RedHome.Size = new System.Drawing.Size(52, 75);
            this.RedHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RedHome.TabIndex = 18;
            this.RedHome.TabStop = false;
            this.RedHome.Click += new System.EventHandler(this.CardClicked);
            // 
            // YellowHome
            // 
            this.YellowHome.Image = global::Poengtavle.Properties.Resources.yellow;
            this.YellowHome.Location = new System.Drawing.Point(20, 335);
            this.YellowHome.Name = "YellowHome";
            this.YellowHome.Size = new System.Drawing.Size(52, 75);
            this.YellowHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YellowHome.TabIndex = 17;
            this.YellowHome.TabStop = false;
            this.YellowHome.Click += new System.EventHandler(this.CardClicked);
            // 
            // changeMusic
            // 
            this.changeMusic.Location = new System.Drawing.Point(378, 81);
            this.changeMusic.Name = "changeMusic";
            this.changeMusic.Size = new System.Drawing.Size(67, 27);
            this.changeMusic.TabIndex = 17;
            this.changeMusic.Text = "Ny musikk";
            this.changeMusic.UseVisualStyleBackColor = true;
            this.changeMusic.Click += new System.EventHandler(this.LoadMusic);
            // 
            // wmp
            // 
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(378, 3);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(212, 62);
            this.wmp.TabIndex = 16;
            // 
            // AutoMusic
            // 
            this.AutoMusic.AutoSize = true;
            this.AutoMusic.Location = new System.Drawing.Point(378, 114);
            this.AutoMusic.Name = "AutoMusic";
            this.AutoMusic.Size = new System.Drawing.Size(101, 17);
            this.AutoMusic.TabIndex = 15;
            this.AutoMusic.Text = "Autospill musikk";
            this.AutoMusic.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "reset timer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ResetTimer);
            // 
            // ofd
            // 
            this.ofd.DefaultExt = "mp3";
            this.ofd.Multiselect = true;
            // 
            // PointsPerGoal
            // 
            this.PointsPerGoal.Location = new System.Drawing.Point(113, 86);
            this.PointsPerGoal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PointsPerGoal.Name = "PointsPerGoal";
            this.PointsPerGoal.Size = new System.Drawing.Size(120, 20);
            this.PointsPerGoal.TabIndex = 22;
            this.PointsPerGoal.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Poeng per mål";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1073, 596);
            this.Controls.Add(this.runningPanel);
            this.Controls.Add(this.SetupPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.homeScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awayScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.period)).EndInit();
            this.SetupPanel.ResumeLayout(false);
            this.SetupPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penaltyTime)).EndInit();
            this.runningPanel.ResumeLayout(false);
            this.runningPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedAway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowAway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointsPerGoal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startTimer;
        private System.Windows.Forms.Button stopTimer;
        private System.Windows.Forms.NumericUpDown homeScore;
        private System.Windows.Forms.NumericUpDown awayScore;
        private System.Windows.Forms.Label homeLb;
        private System.Windows.Forms.Label awayLb;
        private System.Windows.Forms.Button ScoreHome;
        private System.Windows.Forms.Button ScoreAway;
        private System.Windows.Forms.NumericUpDown periods;
        private System.Windows.Forms.NumericUpDown minutes;
        private System.Windows.Forms.NumericUpDown period;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel SetupPanel;
        private System.Windows.Forms.Button Setup;
        private System.Windows.Forms.Panel runningPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AwayTeam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox HomeTeam;
        private System.Windows.Forms.Label label6;
        private AxWMPLib.AxWindowsMediaPlayer wmp;
        private System.Windows.Forms.CheckBox AutoMusic;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button changeMusic;
        private System.Windows.Forms.PictureBox YellowHome;
        private System.Windows.Forms.PictureBox RedHome;
        private System.Windows.Forms.PictureBox RedAway;
        private System.Windows.Forms.PictureBox YellowAway;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown penaltyTime;
        private System.Windows.Forms.Button UtvisningBorte;
        private System.Windows.Forms.Button UtvisningHjemme;
        private System.Windows.Forms.CheckBox AutoAds;
        private System.Windows.Forms.Button AdsBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown PointsPerGoal;
    }
}

