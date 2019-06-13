namespace FFXIV
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
            this.pbCharacter = new System.Windows.Forms.PictureBox();
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.lblCharacterTitle = new System.Windows.Forms.Label();
            this.lblClassAbbreviation = new System.Windows.Forms.Label();
            this.pbCurrentClassIcon = new System.Windows.Forms.PictureBox();
            this.lblCurrentClassName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentClassIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCharacter
            // 
            this.pbCharacter.Location = new System.Drawing.Point(484, 12);
            this.pbCharacter.Name = "pbCharacter";
            this.pbCharacter.Size = new System.Drawing.Size(304, 415);
            this.pbCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCharacter.TabIndex = 0;
            this.pbCharacter.TabStop = false;
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.Font = new System.Drawing.Font("Garamond", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterName.Location = new System.Drawing.Point(13, 13);
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(287, 39);
            this.lblCharacterName.TabIndex = 1;
            this.lblCharacterName.Text = "<Character Name>";
            // 
            // lblCharacterTitle
            // 
            this.lblCharacterTitle.AutoSize = true;
            this.lblCharacterTitle.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterTitle.Location = new System.Drawing.Point(18, 44);
            this.lblCharacterTitle.Name = "lblCharacterTitle";
            this.lblCharacterTitle.Size = new System.Drawing.Size(125, 18);
            this.lblCharacterTitle.TabIndex = 2;
            this.lblCharacterTitle.Text = "<Character Title>";
            // 
            // lblClassAbbreviation
            // 
            this.lblClassAbbreviation.AutoSize = true;
            this.lblClassAbbreviation.Font = new System.Drawing.Font("Garamond", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassAbbreviation.Location = new System.Drawing.Point(376, 13);
            this.lblClassAbbreviation.Name = "lblClassAbbreviation";
            this.lblClassAbbreviation.Size = new System.Drawing.Size(122, 39);
            this.lblClassAbbreviation.TabIndex = 3;
            this.lblClassAbbreviation.Text = "<CLS>";
            // 
            // pbCurrentClassIcon
            // 
            this.pbCurrentClassIcon.Location = new System.Drawing.Point(339, 7);
            this.pbCurrentClassIcon.Name = "pbCurrentClassIcon";
            this.pbCurrentClassIcon.Size = new System.Drawing.Size(45, 45);
            this.pbCurrentClassIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCurrentClassIcon.TabIndex = 4;
            this.pbCurrentClassIcon.TabStop = false;
            // 
            // lblCurrentClassName
            // 
            this.lblCurrentClassName.AutoSize = true;
            this.lblCurrentClassName.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentClassName.Location = new System.Drawing.Point(388, 44);
            this.lblCurrentClassName.Name = "lblCurrentClassName";
            this.lblCurrentClassName.Size = new System.Drawing.Size(105, 18);
            this.lblCurrentClassName.TabIndex = 5;
            this.lblCurrentClassName.Text = "<Class Name>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 442);
            this.Controls.Add(this.lblCurrentClassName);
            this.Controls.Add(this.pbCurrentClassIcon);
            this.Controls.Add(this.lblClassAbbreviation);
            this.Controls.Add(this.lblCharacterTitle);
            this.Controls.Add(this.lblCharacterName);
            this.Controls.Add(this.pbCharacter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentClassIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCharacter;
        private System.Windows.Forms.Label lblCharacterName;
        private System.Windows.Forms.Label lblCharacterTitle;
        private System.Windows.Forms.Label lblClassAbbreviation;
        private System.Windows.Forms.PictureBox pbCurrentClassIcon;
        private System.Windows.Forms.Label lblCurrentClassName;
    }
}

