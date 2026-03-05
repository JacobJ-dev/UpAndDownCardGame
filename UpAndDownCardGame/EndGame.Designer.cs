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
            label1 = new Label();
            listViewFinalResults = new ListView();
            label3 = new Label();
            pictureBoxWinnerDisplay = new PictureBox();
            label2 = new Label();
            labelWinningPlayer = new Label();
            buttonStartNewGame = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWinnerDisplay).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Haettenschweiler", 60F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(223, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(386, 84);
            label1.TabIndex = 1;
            label1.Text = "Game Finished";
            // 
            // listViewFinalResults
            // 
            listViewFinalResults.FullRowSelect = true;
            listViewFinalResults.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewFinalResults.Location = new Point(94, 159);
            listViewFinalResults.Margin = new Padding(4, 3, 4, 3);
            listViewFinalResults.Name = "listViewFinalResults";
            listViewFinalResults.Size = new Size(389, 197);
            listViewFinalResults.TabIndex = 23;
            listViewFinalResults.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(103, 129);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(154, 23);
            label3.TabIndex = 22;
            label3.Text = "Game Results";
            // 
            // pictureBoxWinnerDisplay
            // 
            pictureBoxWinnerDisplay.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxWinnerDisplay.Location = new Point(700, 202);
            pictureBoxWinnerDisplay.Margin = new Padding(4, 3, 4, 3);
            pictureBoxWinnerDisplay.Name = "pictureBoxWinnerDisplay";
            pictureBoxWinnerDisplay.Size = new Size(118, 120);
            pictureBoxWinnerDisplay.TabIndex = 31;
            pictureBoxWinnerDisplay.TabStop = false;
            pictureBoxWinnerDisplay.Tag = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(672, 172);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(152, 23);
            label2.TabIndex = 32;
            label2.Text = "Game Winner";
            // 
            // labelWinningPlayer
            // 
            labelWinningPlayer.AutoSize = true;
            labelWinningPlayer.BackColor = Color.DarkRed;
            labelWinningPlayer.Font = new Font("Lucida Fax", 10.5F);
            labelWinningPlayer.ForeColor = SystemColors.ButtonHighlight;
            labelWinningPlayer.Location = new Point(696, 325);
            labelWinningPlayer.Margin = new Padding(4, 0, 4, 0);
            labelWinningPlayer.Name = "labelWinningPlayer";
            labelWinningPlayer.Size = new Size(111, 16);
            labelWinningPlayer.TabIndex = 33;
            labelWinningPlayer.Text = "Winner Winner";
            labelWinningPlayer.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonStartNewGame
            // 
            buttonStartNewGame.Location = new Point(349, 430);
            buttonStartNewGame.Margin = new Padding(4, 3, 4, 3);
            buttonStartNewGame.Name = "buttonStartNewGame";
            buttonStartNewGame.Size = new Size(196, 58);
            buttonStartNewGame.TabIndex = 34;
            buttonStartNewGame.Text = "Start New Game?";
            buttonStartNewGame.UseVisualStyleBackColor = true;
            buttonStartNewGame.Click += buttonStartNewGame_Click;
            // 
            // EndGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(933, 519);
            Controls.Add(buttonStartNewGame);
            Controls.Add(labelWinningPlayer);
            Controls.Add(label2);
            Controls.Add(pictureBoxWinnerDisplay);
            Controls.Add(listViewFinalResults);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "EndGame";
            Text = "EndGame";
            Load += EndGame_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxWinnerDisplay).EndInit();
            ResumeLayout(false);
            PerformLayout();
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