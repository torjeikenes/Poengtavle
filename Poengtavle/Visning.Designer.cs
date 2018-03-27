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
            this.SuspendLayout();
            // 
            // Tid
            // 
            this.Tid.AutoSize = true;
            this.Tid.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tid.Location = new System.Drawing.Point(234, 53);
            this.Tid.Name = "Tid";
            this.Tid.Size = new System.Drawing.Size(178, 108);
            this.Tid.TabIndex = 0;
            this.Tid.Text = "Tid";
            // 
            // Visning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 431);
            this.Controls.Add(this.Tid);
            this.Name = "Visning";
            this.Text = "Visning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tid;
    }
}