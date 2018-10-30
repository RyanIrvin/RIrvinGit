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
            this.LastPlayedChampionLabel = new System.Windows.Forms.Label();
            this.LastGameStatsLabel = new System.Windows.Forms.Label();
            this.lblSummonerName = new System.Windows.Forms.Label();
            this.lblSummonerLevel = new System.Windows.Forms.Label();
            this.lblLastPlayedChampion = new System.Windows.Forms.Label();
            this.lblLastGameStats = new System.Windows.Forms.Label();
            this.SummonerRankLabel = new System.Windows.Forms.Label();
            this.lblSummonerRank = new System.Windows.Forms.Label();
            this.KdaLabel = new System.Windows.Forms.Label();
            this.lblKda = new System.Windows.Forms.Label();
            this.VisionScoreLabel = new System.Windows.Forms.Label();
            this.lblVisionScore = new System.Windows.Forms.Label();
            this.picChampionicon = new System.Windows.Forms.PictureBox();
            this.picSummonerSpell2 = new System.Windows.Forms.PictureBox();
            this.picSummonerSpell1 = new System.Windows.Forms.PictureBox();
            this.picItem0 = new System.Windows.Forms.PictureBox();
            this.picItem3 = new System.Windows.Forms.PictureBox();
            this.picItem4 = new System.Windows.Forms.PictureBox();
            this.picItem1 = new System.Windows.Forms.PictureBox();
            this.picItem5 = new System.Windows.Forms.PictureBox();
            this.picItem2 = new System.Windows.Forms.PictureBox();
            this.picItem6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picChampionicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSummonerSpell2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSummonerSpell1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem6)).BeginInit();
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
            this.LevelLabel.TabIndex = 4;
            this.LevelLabel.Text = "Level:";
            // 
            // LastPlayedChampionLabel
            // 
            this.LastPlayedChampionLabel.AutoSize = true;
            this.LastPlayedChampionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastPlayedChampionLabel.Location = new System.Drawing.Point(12, 154);
            this.LastPlayedChampionLabel.Name = "LastPlayedChampionLabel";
            this.LastPlayedChampionLabel.Size = new System.Drawing.Size(153, 17);
            this.LastPlayedChampionLabel.TabIndex = 8;
            this.LastPlayedChampionLabel.Text = "Last Played Champion:";
            // 
            // LastGameStatsLabel
            // 
            this.LastGameStatsLabel.AutoSize = true;
            this.LastGameStatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastGameStatsLabel.Location = new System.Drawing.Point(12, 186);
            this.LastGameStatsLabel.Name = "LastGameStatsLabel";
            this.LastGameStatsLabel.Size = new System.Drawing.Size(127, 17);
            this.LastGameStatsLabel.TabIndex = 10;
            this.LastGameStatsLabel.Text = "Last Game\'s Stats:";
            // 
            // lblSummonerName
            // 
            this.lblSummonerName.AutoSize = true;
            this.lblSummonerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummonerName.Location = new System.Drawing.Point(130, 63);
            this.lblSummonerName.Name = "lblSummonerName";
            this.lblSummonerName.Size = new System.Drawing.Size(0, 17);
            this.lblSummonerName.TabIndex = 3;
            // 
            // lblSummonerLevel
            // 
            this.lblSummonerLevel.AutoSize = true;
            this.lblSummonerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummonerLevel.Location = new System.Drawing.Point(54, 91);
            this.lblSummonerLevel.Name = "lblSummonerLevel";
            this.lblSummonerLevel.Size = new System.Drawing.Size(0, 17);
            this.lblSummonerLevel.TabIndex = 5;
            // 
            // lblLastPlayedChampion
            // 
            this.lblLastPlayedChampion.AutoSize = true;
            this.lblLastPlayedChampion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastPlayedChampion.Location = new System.Drawing.Point(163, 154);
            this.lblLastPlayedChampion.Name = "lblLastPlayedChampion";
            this.lblLastPlayedChampion.Size = new System.Drawing.Size(0, 17);
            this.lblLastPlayedChampion.TabIndex = 9;
            // 
            // lblLastGameStats
            // 
            this.lblLastGameStats.AutoSize = true;
            this.lblLastGameStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastGameStats.Location = new System.Drawing.Point(137, 186);
            this.lblLastGameStats.Name = "lblLastGameStats";
            this.lblLastGameStats.Size = new System.Drawing.Size(0, 17);
            this.lblLastGameStats.TabIndex = 11;
            // 
            // SummonerRankLabel
            // 
            this.SummonerRankLabel.AutoSize = true;
            this.SummonerRankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummonerRankLabel.Location = new System.Drawing.Point(12, 123);
            this.SummonerRankLabel.Name = "SummonerRankLabel";
            this.SummonerRankLabel.Size = new System.Drawing.Size(45, 17);
            this.SummonerRankLabel.TabIndex = 6;
            this.SummonerRankLabel.Text = "Rank:";
            // 
            // lblSummonerRank
            // 
            this.lblSummonerRank.AutoSize = true;
            this.lblSummonerRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummonerRank.Location = new System.Drawing.Point(56, 123);
            this.lblSummonerRank.Name = "lblSummonerRank";
            this.lblSummonerRank.Size = new System.Drawing.Size(0, 17);
            this.lblSummonerRank.TabIndex = 7;
            // 
            // KdaLabel
            // 
            this.KdaLabel.AutoSize = true;
            this.KdaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KdaLabel.Location = new System.Drawing.Point(28, 214);
            this.KdaLabel.Name = "KdaLabel";
            this.KdaLabel.Size = new System.Drawing.Size(32, 13);
            this.KdaLabel.TabIndex = 12;
            this.KdaLabel.Text = "KDA:";
            // 
            // lblKda
            // 
            this.lblKda.AutoSize = true;
            this.lblKda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKda.Location = new System.Drawing.Point(57, 214);
            this.lblKda.Name = "lblKda";
            this.lblKda.Size = new System.Drawing.Size(0, 13);
            this.lblKda.TabIndex = 13;
            // 
            // VisionScoreLabel
            // 
            this.VisionScoreLabel.AutoSize = true;
            this.VisionScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisionScoreLabel.Location = new System.Drawing.Point(28, 235);
            this.VisionScoreLabel.Name = "VisionScoreLabel";
            this.VisionScoreLabel.Size = new System.Drawing.Size(69, 13);
            this.VisionScoreLabel.TabIndex = 14;
            this.VisionScoreLabel.Text = "Vision Score:";
            // 
            // lblVisionScore
            // 
            this.lblVisionScore.AutoSize = true;
            this.lblVisionScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisionScore.Location = new System.Drawing.Point(93, 235);
            this.lblVisionScore.Name = "lblVisionScore";
            this.lblVisionScore.Size = new System.Drawing.Size(0, 13);
            this.lblVisionScore.TabIndex = 15;
            // 
            // picProfileIcon
            // 
            this.picChampionicon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picChampionicon.Location = new System.Drawing.Point(183, 202);
            this.picChampionicon.Name = "picProfileIcon";
            this.picChampionicon.Size = new System.Drawing.Size(55, 55);
            this.picChampionicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChampionicon.TabIndex = 16;
            this.picChampionicon.TabStop = false;
            this.picChampionicon.Visible = false;
            // 
            // picSummonerSpell2
            // 
            this.picSummonerSpell2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSummonerSpell2.Location = new System.Drawing.Point(245, 233);
            this.picSummonerSpell2.Name = "picSummonerSpell2";
            this.picSummonerSpell2.Size = new System.Drawing.Size(24, 24);
            this.picSummonerSpell2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSummonerSpell2.TabIndex = 18;
            this.picSummonerSpell2.TabStop = false;
            this.picSummonerSpell2.Visible = false;
            // 
            // picSummonerSpell1
            // 
            this.picSummonerSpell1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSummonerSpell1.Location = new System.Drawing.Point(245, 202);
            this.picSummonerSpell1.Name = "picSummonerSpell1";
            this.picSummonerSpell1.Size = new System.Drawing.Size(24, 24);
            this.picSummonerSpell1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSummonerSpell1.TabIndex = 17;
            this.picSummonerSpell1.TabStop = false;
            this.picSummonerSpell1.Visible = false;
            // 
            // picItem0
            // 
            this.picItem0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picItem0.Location = new System.Drawing.Point(283, 202);
            this.picItem0.Name = "picItem0";
            this.picItem0.Size = new System.Drawing.Size(24, 24);
            this.picItem0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItem0.TabIndex = 19;
            this.picItem0.TabStop = false;
            this.picItem0.Visible = false;
            // 
            // picItem3
            // 
            this.picItem3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picItem3.Location = new System.Drawing.Point(283, 233);
            this.picItem3.Name = "picItem3";
            this.picItem3.Size = new System.Drawing.Size(24, 24);
            this.picItem3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItem3.TabIndex = 20;
            this.picItem3.TabStop = false;
            this.picItem3.Visible = false;
            // 
            // picItem4
            // 
            this.picItem4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picItem4.Location = new System.Drawing.Point(313, 233);
            this.picItem4.Name = "picItem4";
            this.picItem4.Size = new System.Drawing.Size(24, 24);
            this.picItem4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItem4.TabIndex = 22;
            this.picItem4.TabStop = false;
            this.picItem4.Visible = false;
            // 
            // picItem1
            // 
            this.picItem1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picItem1.Location = new System.Drawing.Point(313, 202);
            this.picItem1.Name = "picItem1";
            this.picItem1.Size = new System.Drawing.Size(24, 24);
            this.picItem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItem1.TabIndex = 21;
            this.picItem1.TabStop = false;
            this.picItem1.Visible = false;
            // 
            // picItem5
            // 
            this.picItem5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picItem5.Location = new System.Drawing.Point(343, 233);
            this.picItem5.Name = "picItem5";
            this.picItem5.Size = new System.Drawing.Size(24, 24);
            this.picItem5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItem5.TabIndex = 24;
            this.picItem5.TabStop = false;
            this.picItem5.Visible = false;
            // 
            // picItem2
            // 
            this.picItem2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picItem2.Location = new System.Drawing.Point(343, 202);
            this.picItem2.Name = "picItem2";
            this.picItem2.Size = new System.Drawing.Size(24, 24);
            this.picItem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItem2.TabIndex = 23;
            this.picItem2.TabStop = false;
            this.picItem2.Visible = false;
            // 
            // picItem6
            // 
            this.picItem6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picItem6.Location = new System.Drawing.Point(373, 219);
            this.picItem6.Name = "picItem6";
            this.picItem6.Size = new System.Drawing.Size(24, 24);
            this.picItem6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItem6.TabIndex = 25;
            this.picItem6.TabStop = false;
            this.picItem6.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 261);
            this.Controls.Add(this.picItem6);
            this.Controls.Add(this.picItem5);
            this.Controls.Add(this.picItem2);
            this.Controls.Add(this.picItem4);
            this.Controls.Add(this.picItem1);
            this.Controls.Add(this.picItem3);
            this.Controls.Add(this.picItem0);
            this.Controls.Add(this.picSummonerSpell2);
            this.Controls.Add(this.picSummonerSpell1);
            this.Controls.Add(this.picChampionicon);
            this.Controls.Add(this.lblVisionScore);
            this.Controls.Add(this.VisionScoreLabel);
            this.Controls.Add(this.lblKda);
            this.Controls.Add(this.KdaLabel);
            this.Controls.Add(this.lblSummonerRank);
            this.Controls.Add(this.SummonerRankLabel);
            this.Controls.Add(this.lblLastGameStats);
            this.Controls.Add(this.lblLastPlayedChampion);
            this.Controls.Add(this.lblSummonerLevel);
            this.Controls.Add(this.lblSummonerName);
            this.Controls.Add(this.LastGameStatsLabel);
            this.Controls.Add(this.LastPlayedChampionLabel);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.SummonerNameLabel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSummonerName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picChampionicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSummonerSpell2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSummonerSpell1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSummonerName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label SummonerNameLabel;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label LastPlayedChampionLabel;
        private System.Windows.Forms.Label LastGameStatsLabel;
        private System.Windows.Forms.Label lblSummonerName;
        private System.Windows.Forms.Label lblSummonerLevel;
        private System.Windows.Forms.Label lblLastPlayedChampion;
        private System.Windows.Forms.Label lblLastGameStats;
        private System.Windows.Forms.Label SummonerRankLabel;
        private System.Windows.Forms.Label lblSummonerRank;
        private System.Windows.Forms.Label KdaLabel;
        private System.Windows.Forms.Label lblKda;
        private System.Windows.Forms.Label VisionScoreLabel;
        private System.Windows.Forms.Label lblVisionScore;
        private System.Windows.Forms.PictureBox picChampionicon;
        private System.Windows.Forms.PictureBox picSummonerSpell2;
        private System.Windows.Forms.PictureBox picSummonerSpell1;
        private System.Windows.Forms.PictureBox picItem0;
        private System.Windows.Forms.PictureBox picItem3;
        private System.Windows.Forms.PictureBox picItem4;
        private System.Windows.Forms.PictureBox picItem1;
        private System.Windows.Forms.PictureBox picItem5;
        private System.Windows.Forms.PictureBox picItem2;
        private System.Windows.Forms.PictureBox picItem6;
    }
}

