using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UpAndDownCardGame;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UpAndDownCard
{
    public partial class TitleScreen : Form
    {
        public TitleScreen()
        {
            InitializeComponent();
        }

        private PictureBox? selectedIcon;

        private void pictureBoxIcon_Click(object sender, EventArgs e)
        {
            if (selectedIcon != null)
            {
                selectedIcon.BorderStyle = BorderStyle.None;
                selectedIcon.BackColor = Color.Transparent;
            }

            selectedIcon = (PictureBox)sender;
            selectedIcon.BorderStyle = BorderStyle.Fixed3D;
            selectedIcon.BackColor = Color.Gold;

        }
        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            if (selectedIcon == null || textBoxPlayerName.Text == "")
            {
                MessageBox.Show("Please enter name and select icon");
                return;
            }

            GameController controller = new GameController();

            string playerName = textBoxPlayerName.Text;
            string? tag = selectedIcon.Tag as String;
            if (tag == null)
            {
                MessageBox.Show("Selected icon has no tag set, contact developer");
                return;
            }
            string[] elements = tag.Split('.');
            string playerIcon = elements[0];
            controller.CreatePlayer(playerName, false, playerIcon);


            foreach (var icon in this.Controls)
            {
                if (icon is PictureBox p && p != selectedIcon)
                {
                    tag = p.Tag as String;
                    if (tag == null) continue;
                    elements = tag.Split('.');
                    string botName = elements[1];
                    string botIcon = elements[0];

                    controller.CreatePlayer(botName, true, botIcon);
                }
            }

            GameManager.Instance.LoadPlayers(controller.GetAllPlayers());

            controller.BeginGame();
            GamePlay gamePlayScreen = new GamePlay(controller);

            this.Hide();
            gamePlayScreen.ShowDialog();
            this.Close();

        }

        private void buttonRules_Click(object sender, EventArgs e)
        {
            RulebookForm rulebookForm = new RulebookForm();
            rulebookForm.ShowDialog();
        }
    }
}
