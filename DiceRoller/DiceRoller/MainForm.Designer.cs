namespace DiceRoller
{
    partial class DiceRoller
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNumberOfSides = new System.Windows.Forms.Label();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnTwelve = new System.Windows.Forms.Button();
            this.btnTwenty = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.lblDiceRoll = new System.Windows.Forms.Label();
            this.txtCustom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dice Roller";
            // 
            // lblNumberOfSides
            // 
            this.lblNumberOfSides.AutoSize = true;
            this.lblNumberOfSides.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfSides.Location = new System.Drawing.Point(10, 64);
            this.lblNumberOfSides.Name = "lblNumberOfSides";
            this.lblNumberOfSides.Size = new System.Drawing.Size(123, 18);
            this.lblNumberOfSides.TabIndex = 1;
            this.lblNumberOfSides.Text = "Number of Sides:";
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(20, 93);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(42, 40);
            this.btnFour.TabIndex = 2;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(68, 93);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(42, 40);
            this.btnSix.TabIndex = 3;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(20, 139);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(42, 40);
            this.btnEight.TabIndex = 4;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnTen
            // 
            this.btnTen.Location = new System.Drawing.Point(68, 139);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(42, 40);
            this.btnTen.TabIndex = 5;
            this.btnTen.Text = "10";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnTwelve
            // 
            this.btnTwelve.Location = new System.Drawing.Point(20, 185);
            this.btnTwelve.Name = "btnTwelve";
            this.btnTwelve.Size = new System.Drawing.Size(42, 40);
            this.btnTwelve.TabIndex = 6;
            this.btnTwelve.Text = "12";
            this.btnTwelve.UseVisualStyleBackColor = true;
            this.btnTwelve.Click += new System.EventHandler(this.btnTwelve_Click);
            // 
            // btnTwenty
            // 
            this.btnTwenty.Location = new System.Drawing.Point(68, 185);
            this.btnTwenty.Name = "btnTwenty";
            this.btnTwenty.Size = new System.Drawing.Size(42, 40);
            this.btnTwenty.TabIndex = 7;
            this.btnTwenty.Text = "20";
            this.btnTwenty.UseVisualStyleBackColor = true;
            this.btnTwenty.Click += new System.EventHandler(this.btnTwenty_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.Location = new System.Drawing.Point(20, 230);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(90, 40);
            this.btnCustom.TabIndex = 8;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // lblDiceRoll
            // 
            this.lblDiceRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiceRoll.Location = new System.Drawing.Point(166, 129);
            this.lblDiceRoll.Name = "lblDiceRoll";
            this.lblDiceRoll.Size = new System.Drawing.Size(102, 42);
            this.lblDiceRoll.TabIndex = 11;
            this.lblDiceRoll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCustom
            // 
            this.txtCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustom.Location = new System.Drawing.Point(125, 230);
            this.txtCustom.MaxLength = 4;
            this.txtCustom.Name = "txtCustom";
            this.txtCustom.Size = new System.Drawing.Size(75, 38);
            this.txtCustom.TabIndex = 12;
            // 
            // DiceRoller
            // 
            this.AcceptButton = this.btnCustom;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 282);
            this.Controls.Add(this.txtCustom);
            this.Controls.Add(this.lblDiceRoll);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.btnTwenty);
            this.Controls.Add(this.btnTwelve);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.lblNumberOfSides);
            this.Controls.Add(this.lblTitle);
            this.Name = "DiceRoller";
            this.Text = "Dice Roller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNumberOfSides;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnTwelve;
        private System.Windows.Forms.Button btnTwenty;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Label lblDiceRoll;
        private System.Windows.Forms.TextBox txtCustom;
    }
}

