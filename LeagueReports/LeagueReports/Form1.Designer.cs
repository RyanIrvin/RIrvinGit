namespace LeagueReports
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
            this.txtSummonerName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SummonerNameLabel = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.PreferredRoleLabel = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.LastPlayedChampionLabel = new System.Windows.Forms.Label();
            this.LastGameStatsLabel = new System.Windows.Forms.Label();
            this.lblSummonerName = new System.Windows.Forms.Label();
            this.lblSummonerLevel = new System.Windows.Forms.Label();
            this.lblPreferredRole = new System.Windows.Forms.Label();
            this.lblLastPlayedChampion = new System.Windows.Forms.Label();
            this.lblLastGameStats = new System.Windows.Forms.Label();
            this.SummonerRankLabel = new System.Windows.Forms.Label();
            this.lblSummonerRank = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSummonerName
            // 
            this.txtSummonerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSummonerName.Location = new System.Drawing.Point(13, 13);
            this.txtSummonerName.Name = "txtSummonerName";
            this.txtSummonerName.Size = new System.Drawing.Size(150, 29);
            this.txtSummonerName.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(171, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 31);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SummonerNameLabel
            // 
            this.SummonerNameLabel.AutoSize = true;
            this.SummonerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummonerNameLabel.Location = new System.Drawing.Point(12, 63);
            this.SummonerNameLabel.Name = "SummonerNameLabel";
            this.SummonerNameLabel.Size = new System.Drawing.Size(121, 17);
            this.SummonerNameLabel.TabIndex = 2;
            this.SummonerNameLabel.Text = "Summoner Name:";
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLabel.Location = new System.Drawing.Point(12, 91);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(46, 17);
            this.LevelLabel.TabIndex = 3;
            this.LevelLabel.Text = "Level:";
            // 
            // PreferredRoleLabel
            // 
            this.PreferredRoleLabel.AutoSize = true;
            this.PreferredRoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreferredRoleLabel.Location = new System.Drawing.Point(12, 155);
            this.PreferredRoleLabel.Name = "PreferredRoleLabel";
            this.PreferredRoleLabel.Size = new System.Drawing.Size(105, 17);
            this.PreferredRoleLabel.TabIndex = 4;
            this.PreferredRoleLabel.Text = "Preferred Role:";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(306, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(166, 35);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LastPlayedChampionLabel
            // 
            this.LastPlayedChampionLabel.AutoSize = true;
            this.LastPlayedChampionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastPlayedChampionLabel.Location = new System.Drawing.Point(12, 187);
            this.LastPlayedChampionLabel.Name = "LastPlayedChampionLabel";
            this.LastPlayedChampionLabel.Size = new System.Drawing.Size(153, 17);
            this.LastPlayedChampionLabel.TabIndex = 6;
            this.LastPlayedChampionLabel.Text = "Last Played Champion:";
            // 
            // LastGameStatsLabel
            // 
            this.LastGameStatsLabel.AutoSize = true;
            this.LastGameStatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastGameStatsLabel.Location = new System.Drawing.Point(12, 219);
            this.LastGameStatsLabel.Name = "LastGameStatsLabel";
            this.LastGameStatsLabel.Size = new System.Drawing.Size(127, 17);
            this.LastGameStatsLabel.TabIndex = 8;
            this.LastGameStatsLabel.Text = "Last Game\'s Stats:";
            // 
            // lblSummonerName
            // 
            this.lblSummonerName.AutoSize = true;
            this.lblSummonerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummonerName.Location = new System.Drawing.Point(130, 63);
            this.lblSummonerName.Name = "lblSummonerName";
            this.lblSummonerName.Size = new System.Drawing.Size(0, 17);
            this.lblSummonerName.TabIndex = 9;
            // 
            // lblSummonerLevel
            // 
            this.lblSummonerLevel.AutoSize = true;
            this.lblSummonerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummonerLevel.Location = new System.Drawing.Point(54, 91);
            this.lblSummonerLevel.Name = "lblSummonerLevel";
            this.lblSummonerLevel.Size = new System.Drawing.Size(0, 17);
            this.lblSummonerLevel.TabIndex = 10;
            // 
            // lblPreferredRole
            // 
            this.lblPreferredRole.AutoSize = true;
            this.lblPreferredRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreferredRole.Location = new System.Drawing.Point(110, 123);
            this.lblPreferredRole.Name = "lblPreferredRole";
            this.lblPreferredRole.Size = new System.Drawing.Size(0, 17);
            this.lblPreferredRole.TabIndex = 11;
            // 
            // lblLastPlayedChampion
            // 
            this.lblLastPlayedChampion.AutoSize = true;
            this.lblLastPlayedChampion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastPlayedChampion.Location = new System.Drawing.Point(158, 155);
            this.lblLastPlayedChampion.Name = "lblLastPlayedChampion";
            this.lblLastPlayedChampion.Size = new System.Drawing.Size(0, 17);
            this.lblLastPlayedChampion.TabIndex = 12;
            // 
            // lblLastGameStats
            // 
            this.lblLastGameStats.AutoSize = true;
            this.lblLastGameStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastGameStats.Location = new System.Drawing.Point(133, 187);
            this.lblLastGameStats.Name = "lblLastGameStats";
            this.lblLastGameStats.Size = new System.Drawing.Size(0, 17);
            this.lblLastGameStats.TabIndex = 13;
            // 
            // SummonerRankLabel
            // 
            this.SummonerRankLabel.AutoSize = true;
            this.SummonerRankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummonerRankLabel.Location = new System.Drawing.Point(12, 123);
            this.SummonerRankLabel.Name = "SummonerRankLabel";
            this.SummonerRankLabel.Size = new System.Drawing.Size(45, 17);
            this.SummonerRankLabel.TabIndex = 14;
            this.SummonerRankLabel.Text = "Rank:";
            // 
            // lblSummonerRank
            // 
            this.lblSummonerRank.AutoSize = true;
            this.lblSummonerRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummonerRank.Location = new System.Drawing.Point(52, 123);
            this.lblSummonerRank.Name = "lblSummonerRank";
            this.lblSummonerRank.Size = new System.Drawing.Size(0, 17);
            this.lblSummonerRank.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 312);
            this.Controls.Add(this.lblSummonerRank);
            this.Controls.Add(this.SummonerRankLabel);
            this.Controls.Add(this.lblLastGameStats);
            this.Controls.Add(this.lblLastPlayedChampion);
            this.Controls.Add(this.lblPreferredRole);
            this.Controls.Add(this.lblSummonerLevel);
            this.Controls.Add(this.lblSummonerName);
            this.Controls.Add(this.LastGameStatsLabel);
            this.Controls.Add(this.LastPlayedChampionLabel);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.PreferredRoleLabel);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.SummonerNameLabel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSummonerName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSummonerName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label SummonerNameLabel;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label PreferredRoleLabel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label LastPlayedChampionLabel;
        private System.Windows.Forms.Label LastGameStatsLabel;
        private System.Windows.Forms.Label lblSummonerName;
        private System.Windows.Forms.Label lblSummonerLevel;
        private System.Windows.Forms.Label lblPreferredRole;
        private System.Windows.Forms.Label lblLastPlayedChampion;
        private System.Windows.Forms.Label lblLastGameStats;
        private System.Windows.Forms.Label SummonerRankLabel;
        private System.Windows.Forms.Label lblSummonerRank;
    }
}

