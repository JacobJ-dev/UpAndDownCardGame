using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UpAndDownCardGame.Properties;

namespace UpAndDownCard
{
    public partial class EndGame : Form
    {
        GameController controller;
        public EndGame(GameController gc)
        {
            InitializeComponent();
            controller = gc;


        }

        private void LoadFinalScores()
        {
            listViewFinalResults.View = View.Details;
            listViewFinalResults.Columns.Add("Player Name", 150);
            listViewFinalResults.Columns.Add("Score");

            Dictionary<string, int> playerScores = GameManager.Instance.GetPlayerScores();

            foreach (var player in playerScores)
            {
                var item = new ListViewItem(player.Key);
                item.SubItems.Add(player.Value.ToString());

                listViewFinalResults.Items.Add(item);

            }
        }

        private void LoadWinnerImage()
        {
            string filename = GameManager.Instance.GetWinningPlayer().GetPlayerIcon();
            pictureBoxWinnerDisplay.BackgroundImage = (Image)Resources.ResourceManager.GetObject(filename);
        }

        private void buttonStartNewGame_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature to be implemented");
        }

        private void EndGame_Load(object sender, EventArgs e)
        {
            LoadFinalScores();
            LoadWinnerImage();

            labelWinningPlayer.Text = GameManager.Instance.GetWinningPlayer().GetPlayerName();
        }

        
    }
}
