using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using UpAndDownCardGame.Properties;

namespace UpAndDownCard
{
    public partial class BettingForm : Form
    {
        GameController controller;
        public BettingForm(GameController gc)
        {
            InitializeComponent();
            controller = gc;
        }

        private void buttonBet_Click(object sender, EventArgs e)
        {
            if (!IsBetValid())
            {
                MessageBox.Show("Selected bet of: " + comboBoxTrickBetOptions.Text + " is invalid, try again");
                return;
            }
            Hand player = controller.GetPlayerCards();
            player.SetTricksBet(int.Parse(comboBoxTrickBetOptions.Text));

            this.Close();
        }

        private bool IsBetValid()
        {
            string selectedBet = comboBoxTrickBetOptions.Text;
            int betAmount = 0;
            try
            {
                betAmount = int.Parse(selectedBet);   
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
                return false;
            }

            Hand player = controller.GetPlayerCards();
            
            if (betAmount > player.GetNumberOfCards())
            {
                return false;
            }
            return true;
        }

        private void BettingForm_Load(object sender, EventArgs e)
        {
            Hand player = controller.GetPlayerCards();
            LoadPlayerCardsDisplay(player);
            LoadTrickBetsOption(player);
            LoadTrumpCardDisplay(controller.GetCurrentTrump());
        }

        private void LoadPlayerCardsDisplay(Hand player)
        {
            listBoxPlayerCardsDisplay.Items.Clear();
            foreach (Card card in player.GetAllCardsInHand())
            {
                listBoxPlayerCardsDisplay.Items.Add(card.Name);
            }
        }

        private void LoadTrickBetsOption(Hand player)
        {
            int cardsAmount = player.GetNumberOfCards();

            for (int i = 0; i <= cardsAmount; i++)
            {
                comboBoxTrickBetOptions.Items.Add(i.ToString());
            }

            comboBoxTrickBetOptions.Text = "0";
        }

        private void LoadTrumpCardDisplay(String trump)
        {
            string cardFileName = "card_" + trump.ToLower();
            pictureBoxTrumpDisplay.BackgroundImage = (Image)Resources.ResourceManager.GetObject(cardFileName);
        }


    }
}
