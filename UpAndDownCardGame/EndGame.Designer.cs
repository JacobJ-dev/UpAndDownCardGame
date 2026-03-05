namespace UpAndDownCard
{
    partial class EndGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.listViewFinalResults = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxWinnerDisplay = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelWinningPlayer = new System.Windows.Forms.Label();
            this.buttonStartNewGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWinnerDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Haettenschweiler", 60F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 84);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game Finished";
            // 
            // listViewFinalResults
            // 
            this.listViewFinalResults.FullRowSelect = true;
            this.listViewFinalResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewFinalResults.HideSelection = false;
            this.listViewFinalResults.Location = new System.Drawing.Point(81, 138);
            this.listViewFinalResults.Name = "listViewFinalResults";
            this.listViewFinalResults.Size = new System.Drawing.Size(334, 171);
            this.listViewFinalResults.TabIndex = 23;
            this.listViewFinalResults.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(88, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Game Results";
            // 
            // pictureBoxWinnerDisplay
            // 
            this.pictureBoxWinnerDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxWinnerDisplay.Location = new System.Drawing.Point(600, 175);
            this.pictureBoxWinnerDisplay.Name = "pictureBoxWinnerDisplay";
            this.pictureBoxWinnerDisplay.Size = new System.Drawing.Size(101, 104);
            this.pictureBoxWinnerDisplay.TabIndex = 31;
            this.pictureBoxWinnerDisplay.TabStop = false;
            this.pictureBoxWinnerDisplay.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(576, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Game Winner";
            // 
            // labelWinningPlayer
            // 
            this.labelWinningPlayer.AutoSize = true;
            this.labelWinningPlayer.BackColor = System.Drawing.Color.DarkRed;
            this.labelWinningPlayer.Font = new System.Drawing.Font("Lucida Fax", 10.5F);
            this.labelWinningPlayer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelWinningPlayer.Location = new System.Drawing.Point(597, 282);
            this.labelWinningPlayer.Name = "labelWinningPlayer";
            this.labelWinningPlayer.Size = new System.Drawing.Size(111, 16);
            this.labelWinningPlayer.TabIndex = 33;
            this.labelWinningPlayer.Text = "Winner Winner";
            this.labelWinningPlayer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonStartNewGame
            // 
            this.buttonStartNewGame.Location = new System.Drawing.Point(299, 373);
            this.buttonStartNewGame.Name = "buttonStartNewGame";
            this.buttonStartNewGame.Size = new System.Drawing.Size(168, 50);
            this.buttonStartNewGame.TabIndex = 34;
            this.buttonStartNewGame.Text = "Start New Game?";
            this.buttonStartNewGame.UseVisualStyleBackColor = true;
            this.buttonStartNewGame.Click += new System.EventHandler(this.buttonStartNewGame_Click);
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStartNewGame);
            this.Controls.Add(this.labelWinningPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxWinnerDisplay);
            this.Controls.Add(this.listViewFinalResults);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "EndGame";
            this.Text = "EndGame";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWinnerDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewFinalResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxWinnerDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelWinningPlayer;
        private System.Windows.Forms.Button buttonStartNewGame;
    }
}