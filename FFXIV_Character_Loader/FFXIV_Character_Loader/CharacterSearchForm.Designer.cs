namespace FFXIV_Character_Loader
{
    partial class CharacterSearchForm
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
            this.cbServerRegion = new System.Windows.Forms.ComboBox();
            this.cbServerDataCenter = new System.Windows.Forms.ComboBox();
            this.cbServerWorld = new System.Windows.Forms.ComboBox();
            this.txtCharacterName = new System.Windows.Forms.TextBox();
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.lblServerInfo = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbServerRegion
            // 
            this.cbServerRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServerRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServerRegion.FormattingEnabled = true;
            this.cbServerRegion.Location = new System.Drawing.Point(267, 44);
            this.cbServerRegion.Name = "cbServerRegion";
            this.cbServerRegion.Size = new System.Drawing.Size(154, 24);
            this.cbServerRegion.TabIndex = 1;
            this.cbServerRegion.SelectedIndexChanged += new System.EventHandler(this.CbServerRegion_SelectedIndexChanged);
            // 
            // cbServerDataCenter
            // 
            this.cbServerDataCenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServerDataCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServerDataCenter.FormattingEnabled = true;
            this.cbServerDataCenter.Location = new System.Drawing.Point(267, 74);
            this.cbServerDataCenter.Name = "cbServerDataCenter";
            this.cbServerDataCenter.Size = new System.Drawing.Size(154, 24);
            this.cbServerDataCenter.TabIndex = 2;
            this.cbServerDataCenter.SelectedIndexChanged += new System.EventHandler(this.CbServerDataCenter_SelectedIndexChanged);
            // 
            // cbServerWorld
            // 
            this.cbServerWorld.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbServerWorld.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbServerWorld.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServerWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServerWorld.FormattingEnabled = true;
            this.cbServerWorld.Location = new System.Drawing.Point(267, 104);
            this.cbServerWorld.Name = "cbServerWorld";
            this.cbServerWorld.Size = new System.Drawing.Size(154, 24);
            this.cbServerWorld.TabIndex = 3;
            // 
            // txtCharacterName
            // 
            this.txtCharacterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharacterName.Location = new System.Drawing.Point(15, 55);
            this.txtCharacterName.Name = "txtCharacterName";
            this.txtCharacterName.Size = new System.Drawing.Size(233, 26);
            this.txtCharacterName.TabIndex = 0;
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterName.Location = new System.Drawing.Point(12, 13);
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(115, 17);
            this.lblCharacterName.TabIndex = 5;
            this.lblCharacterName.Text = "Character Name:";
            // 
            // lblServerInfo
            // 
            this.lblServerInfo.AutoSize = true;
            this.lblServerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerInfo.Location = new System.Drawing.Point(264, 13);
            this.lblServerInfo.Name = "lblServerInfo";
            this.lblServerInfo.Size = new System.Drawing.Size(54, 17);
            this.lblServerInfo.TabIndex = 6;
            this.lblServerInfo.Text = "Server:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(84, 92);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 26);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // CharacterSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 144);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblServerInfo);
            this.Controls.Add(this.lblCharacterName);
            this.Controls.Add(this.txtCharacterName);
            this.Controls.Add(this.cbServerWorld);
            this.Controls.Add(this.cbServerDataCenter);
            this.Controls.Add(this.cbServerRegion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CharacterSearchForm";
            this.Text = "Character Lookup";
            this.Load += new System.EventHandler(this.CharacterSearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbServerRegion;
        private System.Windows.Forms.ComboBox cbServerDataCenter;
        private System.Windows.Forms.ComboBox cbServerWorld;
        private System.Windows.Forms.TextBox txtCharacterName;
        private System.Windows.Forms.Label lblCharacterName;
        private System.Windows.Forms.Label lblServerInfo;
        private System.Windows.Forms.Button btnSearch;
    }
}

