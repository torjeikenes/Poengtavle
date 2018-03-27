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
            this.Tid = new System.Windows.Forms.Label();
            this.homeScr = new System.Windows.Forms.Label();
            this.AwayScr = new System.Windows.Forms.Label();
            this.homeLb = new System.Windows.Forms.Label();
            this.AwayLb = new System.Windows.Forms.Label();
            this.Period = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tid
            // 
            this.Tid.AutoSize = true;
            this.Tid.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tid.Location = new System.Drawing.Point(232, 87);
            this.Tid.Name = "Tid";
            this.Tid.Size = new System.Drawing.Size(178, 108);
            this.Tid.TabIndex = 0;
            this.Tid.Text = "Tid";
            // 
            // homeScr
            // 
            this.homeScr.AutoSize = true;
            this.homeScr.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeScr.Location = new System.Drawing.Point(94, 237);
            this.homeScr.Name = "homeScr";
            this.homeScr.Size = new System.Drawing.Size(39, 42);
            this.homeScr.TabIndex = 2;
            this.homeScr.Text = "0";
            // 
            // AwayScr
            // 
            this.AwayScr.AutoSize = true;
            this.AwayScr.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AwayScr.Location = new System.Drawing.Point(405, 237);
            this.AwayScr.Name = "AwayScr";
            this.AwayScr.Size = new System.Drawing.Size(39, 42);
            this.AwayScr.TabIndex = 3;
            this.AwayScr.Text = "0";
            // 
            // homeLb
            // 
            this.homeLb.AutoSize = true;
            this.homeLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLb.Location = new System.Drawing.Point(94, 195);
            this.homeLb.Name = "homeLb";
            this.homeLb.Size = new System.Drawing.Size(155, 42);
            this.homeLb.TabIndex = 4;
            this.homeLb.Text = "Hjemme";
            // 
            // AwayLb
            // 
            this.AwayLb.AutoSize = true;
            this.AwayLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AwayLb.Location = new System.Drawing.Point(405, 195);
            this.AwayLb.Name = "AwayLb";
            this.AwayLb.Size = new System.Drawing.Size(107, 42);
            this.AwayLb.TabIndex = 5;
            this.AwayLb.Text = "Borte";
            // 
            // Period
            // 
            this.Period.AutoSize = true;
            this.Period.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Period.Location = new System.Drawing.Point(311, 54);
            this.Period.Name = "Period";
            this.Period.Size = new System.Drawing.Size(20, 24);
            this.Period.TabIndex = 6;
            this.Period.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Omgang";
            // 
            // Visning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 431);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Period);
            this.Controls.Add(this.AwayLb);
            this.Controls.Add(this.homeLb);
            this.Controls.Add(this.AwayScr);
            this.Controls.Add(this.homeScr);
            this.Controls.Add(this.Tid);
            this.Name = "Visning";
            this.Text = "Visning";
            this.Load += new System.EventHandler(this.Visning_Load);
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
    }
}