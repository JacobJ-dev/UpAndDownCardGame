namespace UpAndDownCard
{
    partial class BettingForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxPlayerCardsDisplay = new System.Windows.Forms.ListBox();
            this.buttonBet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTrickBetOptions = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxTrumpDisplay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrumpDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(141, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 39);
            this.label3.TabIndex = 21;
            this.label3.Text = "Betting";
            // 
            // listBoxPlayerCardsDisplay
            // 
            this.listBoxPlayerCardsDisplay.FormattingEnabled = true;
            this.listBoxPlayerCardsDisplay.Location = new System.Drawing.Point(119, 116);
            this.listBoxPlayerCardsDisplay.Name = "listBoxPlayerCardsDisplay";
            this.listBoxPlayerCardsDisplay.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxPlayerCardsDisplay.Size = new System.Drawing.Size(180, 134);
            this.listBoxPlayerCardsDisplay.TabIndex = 22;
            // 
            // buttonBet
            // 
            this.buttonBet.Location = new System.Drawing.Point(176, 320);
            this.buttonBet.Name = "buttonBet";
            this.buttonBet.Size = new System.Drawing.Size(75, 23);
            this.buttonBet.TabIndex = 23;
            this.buttonBet.Text = "Bet!";
            this.buttonBet.UseVisualStyleBackColor = true;
            this.buttonBet.Click += new System.EventHandler(this.buttonBet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(116, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Your Cards";
            // 
            // comboBoxTrickBetOptions
            // 
            this.comboBoxTrickBetOptions.FormattingEnabled = true;
            this.comboBoxTrickBetOptions.Location = new System.Drawing.Point(152, 293);
            this.comboBoxTrickBetOptions.Name = "comboBoxTrickBetOptions";
            this.comboBoxTrickBetOptions.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTrickBetOptions.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(155, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tricks to Win";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(328, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Trump";
            // 
            // pictureBoxTrumpDisplay
            // 
            this.pictureBoxTrumpDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxTrumpDisplay.Location = new System.Drawing.Point(320, 131);
            this.pictureBoxTrumpDisplay.Name = "pictureBoxTrumpDisplay";
            this.pictureBoxTrumpDisplay.Size = new System.Drawing.Size(73, 102);
            this.pictureBoxTrumpDisplay.TabIndex = 27;
            this.pictureBoxTrumpDisplay.TabStop = false;
            // 
            // BettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(415, 383);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBoxTrumpDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTrickBetOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBet);
            this.Controls.Add(this.listBoxPlayerCardsDisplay);
            this.Controls.Add(this.label3);
            this.Name = "BettingForm";
            this.Text = "Betting Form";
            this.Load += new System.EventHandler(this.BettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrumpDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxPlayerCardsDisplay;
        private System.Windows.Forms.Button buttonBet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTrickBetOptions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxTrumpDisplay;
        private System.Windows.Forms.Label label4;
    }
}