namespace UpAndDownCard
{
    partial class GamePlay
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
            listBoxPlayerDisplay = new ListBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label10 = new Label();
            label3 = new Label();
            listViewPlayersAndWins = new ListView();
            label6 = new Label();
            pictureBoxWinningCard = new PictureBox();
            pictureBoxLeadingSuit = new PictureBox();
            pictureBoxTrumpDisplay = new PictureBox();
            pictureBoxLastCard = new PictureBox();
            pictureBoxSelectedCard = new PictureBox();
            listViewLeaderboard = new ListView();
            label7 = new Label();
            groupBox1 = new GroupBox();
            buttonAction = new Button();
            pictureBoxWinnerDisplay = new PictureBox();
            panelWinnerDisplay = new Panel();
            labelWinningPlayer = new Label();
            buttonRules = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWinningCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLeadingSuit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTrumpDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLastCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSelectedCard).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWinnerDisplay).BeginInit();
            panelWinnerDisplay.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxPlayerDisplay
            // 
            listBoxPlayerDisplay.FormattingEnabled = true;
            listBoxPlayerDisplay.ItemHeight = 15;
            listBoxPlayerDisplay.Location = new Point(548, 518);
            listBoxPlayerDisplay.Margin = new Padding(4, 3, 4, 3);
            listBoxPlayerDisplay.Name = "listBoxPlayerDisplay";
            listBoxPlayerDisplay.Size = new Size(244, 94);
            listBoxPlayerDisplay.TabIndex = 2;
            listBoxPlayerDisplay.SelectedIndexChanged += listBoxPlayerDisplay_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Maroon;
            label2.Font = new Font("Lucida Fax", 10.5F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(308, 18);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 32);
            label2.TabIndex = 5;
            label2.Text = "Trump\r\nSuit";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Maroon;
            label4.Font = new Font("Lucida Fax", 10.5F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(28, 18);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 32);
            label4.TabIndex = 11;
            label4.Text = "Winning\r\nCard\r\n";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Maroon;
            label5.Font = new Font("Lucida Fax", 10.5F);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(168, 18);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 32);
            label5.TabIndex = 13;
            label5.Text = "Leading\r\nSuit";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Lucida Fax", 15F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(28, 14);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(149, 23);
            label10.TabIndex = 16;
            label10.Text = "Trick Winner";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(34, 240);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(151, 23);
            label3.TabIndex = 20;
            label3.Text = "Trick Results";
            // 
            // listViewPlayersAndWins
            // 
            listViewPlayersAndWins.FullRowSelect = true;
            listViewPlayersAndWins.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewPlayersAndWins.Location = new Point(26, 270);
            listViewPlayersAndWins.Margin = new Padding(4, 3, 4, 3);
            listViewPlayersAndWins.Name = "listViewPlayersAndWins";
            listViewPlayersAndWins.Size = new Size(389, 197);
            listViewPlayersAndWins.TabIndex = 21;
            listViewPlayersAndWins.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Fax", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(586, 488);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(145, 23);
            label6.TabIndex = 22;
            label6.Text = "Player Cards";
            // 
            // pictureBoxWinningCard
            // 
            pictureBoxWinningCard.BackColor = Color.DarkRed;
            pictureBoxWinningCard.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxWinningCard.Location = new Point(28, 55);
            pictureBoxWinningCard.Margin = new Padding(4, 3, 4, 3);
            pictureBoxWinningCard.Name = "pictureBoxWinningCard";
            pictureBoxWinningCard.Size = new Size(85, 118);
            pictureBoxWinningCard.TabIndex = 18;
            pictureBoxWinningCard.TabStop = false;
            // 
            // pictureBoxLeadingSuit
            // 
            pictureBoxLeadingSuit.BackColor = Color.DarkRed;
            pictureBoxLeadingSuit.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLeadingSuit.Location = new Point(159, 55);
            pictureBoxLeadingSuit.Margin = new Padding(4, 3, 4, 3);
            pictureBoxLeadingSuit.Name = "pictureBoxLeadingSuit";
            pictureBoxLeadingSuit.Size = new Size(85, 118);
            pictureBoxLeadingSuit.TabIndex = 17;
            pictureBoxLeadingSuit.TabStop = false;
            // 
            // pictureBoxTrumpDisplay
            // 
            pictureBoxTrumpDisplay.BackColor = Color.DarkRed;
            pictureBoxTrumpDisplay.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxTrumpDisplay.Location = new Point(299, 55);
            pictureBoxTrumpDisplay.Margin = new Padding(4, 3, 4, 3);
            pictureBoxTrumpDisplay.Name = "pictureBoxTrumpDisplay";
            pictureBoxTrumpDisplay.Size = new Size(85, 118);
            pictureBoxTrumpDisplay.TabIndex = 15;
            pictureBoxTrumpDisplay.TabStop = false;
            // 
            // pictureBoxLastCard
            // 
            pictureBoxLastCard.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLastCard.Image = UpAndDownCardGame.Properties.Resources.card_back;
            pictureBoxLastCard.Location = new Point(590, 219);
            pictureBoxLastCard.Margin = new Padding(4, 3, 4, 3);
            pictureBoxLastCard.Name = "pictureBoxLastCard";
            pictureBoxLastCard.Size = new Size(158, 227);
            pictureBoxLastCard.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLastCard.TabIndex = 1;
            pictureBoxLastCard.TabStop = false;
            // 
            // pictureBoxSelectedCard
            // 
            pictureBoxSelectedCard.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxSelectedCard.Location = new Point(800, 505);
            pictureBoxSelectedCard.Margin = new Padding(4, 3, 4, 3);
            pictureBoxSelectedCard.Name = "pictureBoxSelectedCard";
            pictureBoxSelectedCard.Size = new Size(85, 118);
            pictureBoxSelectedCard.TabIndex = 25;
            pictureBoxSelectedCard.TabStop = false;
            // 
            // listViewLeaderboard
            // 
            listViewLeaderboard.FullRowSelect = true;
            listViewLeaderboard.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewLeaderboard.Location = new Point(987, 270);
            listViewLeaderboard.Margin = new Padding(4, 3, 4, 3);
            listViewLeaderboard.Name = "listViewLeaderboard";
            listViewLeaderboard.Size = new Size(408, 197);
            listViewLeaderboard.TabIndex = 26;
            listViewLeaderboard.UseCompatibleStateImageBehavior = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Fax", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(1214, 240);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(144, 23);
            label7.TabIndex = 27;
            label7.Text = "Leaderboard";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Maroon;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(pictureBoxLeadingSuit);
            groupBox1.Controls.Add(pictureBoxTrumpDisplay);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pictureBoxWinningCard);
            groupBox1.Font = new Font("Lucida Fax", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(460, 24);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(411, 188);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Trick Info";
            // 
            // buttonAction
            // 
            buttonAction.Enabled = false;
            buttonAction.Font = new Font("Microsoft Sans Serif", 10.25F);
            buttonAction.Location = new Point(602, 637);
            buttonAction.Margin = new Padding(4, 3, 4, 3);
            buttonAction.Name = "buttonAction";
            buttonAction.Size = new Size(146, 59);
            buttonAction.TabIndex = 29;
            buttonAction.Text = "Play Card";
            buttonAction.UseVisualStyleBackColor = true;
            buttonAction.Click += buttonAction_Click;
            // 
            // pictureBoxWinnerDisplay
            // 
            pictureBoxWinnerDisplay.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxWinnerDisplay.Location = new Point(56, 44);
            pictureBoxWinnerDisplay.Margin = new Padding(4, 3, 4, 3);
            pictureBoxWinnerDisplay.Name = "pictureBoxWinnerDisplay";
            pictureBoxWinnerDisplay.Size = new Size(118, 120);
            pictureBoxWinnerDisplay.TabIndex = 30;
            pictureBoxWinnerDisplay.TabStop = false;
            pictureBoxWinnerDisplay.Tag = "";
            // 
            // panelWinnerDisplay
            // 
            panelWinnerDisplay.Controls.Add(labelWinningPlayer);
            panelWinnerDisplay.Controls.Add(label10);
            panelWinnerDisplay.Controls.Add(pictureBoxWinnerDisplay);
            panelWinnerDisplay.Location = new Point(88, 488);
            panelWinnerDisplay.Margin = new Padding(4, 3, 4, 3);
            panelWinnerDisplay.Name = "panelWinnerDisplay";
            panelWinnerDisplay.Size = new Size(233, 209);
            panelWinnerDisplay.TabIndex = 31;
            panelWinnerDisplay.Visible = false;
            // 
            // labelWinningPlayer
            // 
            labelWinningPlayer.AutoSize = true;
            labelWinningPlayer.BackColor = Color.DarkRed;
            labelWinningPlayer.Font = new Font("Lucida Fax", 10.5F);
            labelWinningPlayer.ForeColor = SystemColors.ButtonHighlight;
            labelWinningPlayer.Location = new Point(78, 167);
            labelWinningPlayer.Margin = new Padding(4, 0, 4, 0);
            labelWinningPlayer.Name = "labelWinningPlayer";
            labelWinningPlayer.Size = new Size(65, 32);
            labelWinningPlayer.TabIndex = 19;
            labelWinningPlayer.Text = "Winning\r\nCard\r\n";
            labelWinningPlayer.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonRules
            // 
            buttonRules.Location = new Point(13, 12);
            buttonRules.Margin = new Padding(4, 3, 4, 3);
            buttonRules.Name = "buttonRules";
            buttonRules.Size = new Size(108, 38);
            buttonRules.TabIndex = 34;
            buttonRules.Text = "Rules";
            buttonRules.UseVisualStyleBackColor = true;
            buttonRules.Click += buttonRules_Click;
            // 
            // GamePlay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(1409, 765);
            Controls.Add(buttonRules);
            Controls.Add(panelWinnerDisplay);
            Controls.Add(buttonAction);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(listViewLeaderboard);
            Controls.Add(pictureBoxSelectedCard);
            Controls.Add(label6);
            Controls.Add(listViewPlayersAndWins);
            Controls.Add(label3);
            Controls.Add(listBoxPlayerDisplay);
            Controls.Add(pictureBoxLastCard);
            Margin = new Padding(4, 3, 4, 3);
            Name = "GamePlay";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxWinningCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLeadingSuit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTrumpDisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLastCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSelectedCard).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWinnerDisplay).EndInit();
            panelWinnerDisplay.ResumeLayout(false);
            panelWinnerDisplay.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxLastCard;
        private System.Windows.Forms.ListBox listBoxPlayerDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxTrumpDisplay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBoxLeadingSuit;
        private System.Windows.Forms.PictureBox pictureBoxWinningCard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewPlayersAndWins;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBoxSelectedCard;
        private System.Windows.Forms.ListView listViewLeaderboard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAction;
        private System.Windows.Forms.PictureBox pictureBoxWinnerDisplay;
        private System.Windows.Forms.Panel panelWinnerDisplay;
        private System.Windows.Forms.Label labelWinningPlayer;
        private Button buttonRules;
    }
}

