using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpAndDownCardGame
{
    public partial class RulebookForm : Form
    {
        public RulebookForm()
        {
            InitializeComponent();
            LoadRulebook();
        }

        private void LoadRulebook()
        {
            richTextBox1.Clear();

            AppendTitle("UP AND DOWN — Rulebook\n\n");

            AppendHeading("Overview\n");
            AppendBody("Up and Down is a trick-taking card game where players bet on exactly how many tricks they will win each round. Points are earned by predicting correctly — not just by winning tricks.\n\n");

            AppendHeading("Players & Setup\n");
            AppendBody("4 to 10 players (1 human + bots). Uses a standard 52-card deck, no Jokers. Ace is always the highest card.\n\n");

            AppendHeading("Round Structure\n");
            AppendBody("Cards dealt decrease by one each round down to 1, then increase back up to the maximum. The trump suit rotates each round: Diamonds → Hearts → Spades → Clubs → No Trumps.\n\n");

            AppendHeading("Betting\n");
            AppendBody("After seeing your hand and the trump suit, bet how many tricks you think you will win. Bets are private — you won't know what others have bet.\n\n");

            AppendHeading("Playing a Trick\n");
            AppendBody("1. The round leader plays any card — this sets the leading suit.\n");
            AppendBody("2. You MUST play a card of the leading suit if you have one.\n");
            AppendBody("3. If you have no leading suit cards, you may play any card including a trump.\n");
            AppendBody("4. You may NEVER play a trump if you still hold the leading suit.\n\n");

            AppendHeading("Winning a Trick\n");
            AppendBody("The highest card of the leading suit wins, unless a trump was played. The highest trump wins if any were played. The trick winner leads the next trick.\n\n");

            AppendHeading("Round Start\n");
            AppendBody("The player who starts each round rotates clockwise after every round.\n\n");

            AppendHeading("Scoring\n");
            AppendBody("• Bet 1 or more and matched exactly: tricks won + 10 bonus\n");
            AppendBody("• Bet 0 and won 0 tricks: +5 bonus only\n");
            AppendBody("• Bet incorrectly: tricks won only, no bonus\n\n");
            AppendBody("Example: Bet 3, win 3 = 13 points. Bet 0, win 0 = 5 points. Bet 2, win 4 = 4 points.\n\n");

            AppendHeading("Winning the Game\n");
            AppendBody("The player with the highest total score after all rounds wins.\n");

            richTextBox1.SelectionStart = 0;
            richTextBox1.ScrollToCaret();

            buttonReturn.Focus();
        }

        private void AppendTitle(string text)
        {
            richTextBox1.SelectionFont = new Font("Arial", 16, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.DarkRed;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.AppendText(text);
        }

        private void AppendHeading(string text)
        {
            richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.DarkRed;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox1.AppendText(text);
        }

        private void AppendBody(string text)
        {
            richTextBox1.SelectionFont = new Font("Arial", 10, FontStyle.Regular);
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox1.AppendText(text);
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
