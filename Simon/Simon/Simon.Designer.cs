namespace Simon
{
    partial class frmSimon
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
            this.BtnBlue = new System.Windows.Forms.Button();
            this.BtnGreen = new System.Windows.Forms.Button();
            this.BtnYellow = new System.Windows.Forms.Button();
            this.BtnRed = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnBlue
            // 
            this.BtnBlue.BackColor = System.Drawing.SystemColors.Control;
            this.BtnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBlue.Location = new System.Drawing.Point(169, 46);
            this.BtnBlue.Name = "BtnBlue";
            this.BtnBlue.Size = new System.Drawing.Size(151, 98);
            this.BtnBlue.TabIndex = 4;
            this.BtnBlue.Text = "Blue";
            this.BtnBlue.UseVisualStyleBackColor = false;
            this.BtnBlue.Click += new System.EventHandler(this.BtnBlue_Click);
            // 
            // BtnGreen
            // 
            this.BtnGreen.BackColor = System.Drawing.SystemColors.Control;
            this.BtnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGreen.Location = new System.Drawing.Point(12, 149);
            this.BtnGreen.Name = "BtnGreen";
            this.BtnGreen.Size = new System.Drawing.Size(151, 98);
            this.BtnGreen.TabIndex = 5;
            this.BtnGreen.Text = "Green";
            this.BtnGreen.UseVisualStyleBackColor = false;
            this.BtnGreen.Click += new System.EventHandler(this.BtnGreen_Click);
            // 
            // BtnYellow
            // 
            this.BtnYellow.BackColor = System.Drawing.SystemColors.Control;
            this.BtnYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnYellow.Location = new System.Drawing.Point(169, 150);
            this.BtnYellow.Name = "BtnYellow";
            this.BtnYellow.Size = new System.Drawing.Size(151, 98);
            this.BtnYellow.TabIndex = 6;
            this.BtnYellow.Text = "Yellow";
            this.BtnYellow.UseVisualStyleBackColor = false;
            this.BtnYellow.Click += new System.EventHandler(this.BtnYellow_Click);
            // 
            // BtnRed
            // 
            this.BtnRed.BackColor = System.Drawing.SystemColors.Control;
            this.BtnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRed.Location = new System.Drawing.Point(12, 45);
            this.BtnRed.Name = "BtnRed";
            this.BtnRed.Size = new System.Drawing.Size(151, 98);
            this.BtnRed.TabIndex = 7;
            this.BtnRed.Text = "Red";
            this.BtnRed.UseVisualStyleBackColor = false;
            this.BtnRed.Click += new System.EventHandler(this.BtnRed_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(12, 9);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(60, 24);
            this.lblLevel.TabIndex = 8;
            this.lblLevel.Text = "Level:";
            // 
            // BtnStart
            // 
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStart.Location = new System.Drawing.Point(185, 12);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(112, 23);
            this.BtnStart.TabIndex = 9;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // frmSimon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 260);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.BtnRed);
            this.Controls.Add(this.BtnYellow);
            this.Controls.Add(this.BtnGreen);
            this.Controls.Add(this.BtnBlue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSimon";
            this.Text = "Simon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBlue;
        private System.Windows.Forms.Button BtnGreen;
        private System.Windows.Forms.Button BtnYellow;
        private System.Windows.Forms.Button BtnRed;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Button BtnStart;
    }
}

