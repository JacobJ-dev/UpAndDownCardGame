namespace UpAndDownCardGame
{
    partial class RulebookForm
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
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            buttonReturn = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 87);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.Size = new Size(776, 396);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Haettenschweiler", 60F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(255, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(262, 84);
            label1.TabIndex = 2;
            label1.Text = "Rulebook";
            // 
            // buttonReturn
            // 
            buttonReturn.Location = new Point(296, 501);
            buttonReturn.Margin = new Padding(4, 3, 4, 3);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(188, 40);
            buttonReturn.TabIndex = 29;
            buttonReturn.Text = "Return";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // RulebookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(800, 553);
            Controls.Add(buttonReturn);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Name = "RulebookForm";
            Text = "RulebookForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label1;
        private Button buttonReturn;
    }
}