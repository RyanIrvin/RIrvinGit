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
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.lblLevelText = new System.Windows.Forms.Label();
            this.lblLevelValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlue.Location = new System.Drawing.Point(169, 46);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(151, 98);
            this.btnBlue.TabIndex = 4;
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.BtnBlue_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGreen.Location = new System.Drawing.Point(12, 149);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(151, 98);
            this.btnGreen.TabIndex = 5;
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.BtnGreen_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYellow.Location = new System.Drawing.Point(169, 150);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(151, 98);
            this.btnYellow.TabIndex = 6;
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.BtnYellow_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRed.Location = new System.Drawing.Point(12, 45);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(151, 98);
            this.btnRed.TabIndex = 7;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.BtnRed_Click);
            // 
            // lblLevelText
            // 
            this.lblLevelText.AutoSize = true;
            this.lblLevelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelText.Location = new System.Drawing.Point(12, 9);
            this.lblLevelText.Name = "lblLevelText";
            this.lblLevelText.Size = new System.Drawing.Size(60, 24);
            this.lblLevelText.TabIndex = 8;
            this.lblLevelText.Text = "Level:";
            // 
            // lblLevelValue
            // 
            this.lblLevelValue.AutoSize = true;
            this.lblLevelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelValue.Location = new System.Drawing.Point(70, 9);
            this.lblLevelValue.Name = "lblLevelValue";
            this.lblLevelValue.Size = new System.Drawing.Size(0, 24);
            this.lblLevelValue.TabIndex = 9;
            // 
            // frmSimon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 260);
            this.Controls.Add(this.lblLevelValue);
            this.Controls.Add(this.lblLevelText);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnBlue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSimon";
            this.Text = "Simon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Label lblLevelText;
        private System.Windows.Forms.Label lblLevelValue;
    }
}

