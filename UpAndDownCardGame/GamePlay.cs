using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using UpAndDownCardGame;
using UpAndDownCardGame.Properties;

namespace UpAndDownCard
{
    public partial class GamePlay : Form
    {
        GameController gameController;
        string trumpCardImageFile;






        public GamePlay(GameController gc)
        {
            InitializeComponent();

            gameController = gc;
            gameController.OnTrickStateUpdated += GameController_OnTrickStateUpdated;
            gameController.OnTrickEnded += GameController_OnTrickEnded;
            gameController.OnPlayerTurn += GameController_OnPlayerTurn;
            gameController.OnRoundEnd += GameController_OnRoundEnded;
            gameController.OnGameEnd += GameController_OnGameEnd;

            //Set list view view as detail to show multiple columns
            listViewPlayersAndWins.View = View.Details;

            listViewPlayersAndWins.Columns.Add("Player Name", 150);
            listViewPlayersAndWins.Columns.Add("Tricks Betted", 85);
            listViewPlayersAndWins.Columns.Add("Tricks Won", 85);

            GameManager.Instance.OnScoreUpdated += GameManager_OnUpdatedScores;

            listViewLeaderboard.View = View.Details;
            listViewLeaderboard.Columns.Add("Player Name", 150);
            listViewLeaderboard.Columns.Add("Score");

            UpdateActionButton();

        }





        private void GameController_OnTrickStateUpdated(GameController gc)
        {
            UpdateTrickUI();
            RefreshCardsDisplay();
        }

        private void GameManager_OnUpdatedScores(Dictionary<string, int> playerScores)
        {
            listViewLeaderboard.Items.Clear();

            foreach (var player in playerScores)
            {
                var item = new ListViewItem(player.Key);
                item.SubItems.Add(player.Value.ToString());

                listViewLeaderboard.Items.Add(item);

            }
        }

        private void GameController_OnPlayerTurn()
        {
            listBoxPlayerDisplay.SelectionMode = SelectionMode.One;
            //buttonPlayCard.Enabled = true;


            UpdateActionButton();
        }

        private void GameController_OnTrickEnded()
        {


            UpdateCurrentWins();
            SetPictureBoxMainImage(pictureBoxLastCard, "card_back");



            Hand trickWinner = gameController.GetTrickWinner();

            SetPictureBoxBackgroundImage(pictureBoxWinnerDisplay, trickWinner.GetPlayerIcon());
            labelWinningPlayer.Text = trickWinner.GetPlayerName();
            panelWinnerDisplay.Visible = true;


            UpdateActionButton();

        }

        private void GameController_OnRoundEnded()
        {


            UpdateActionButton();

        }

        private void GameController_OnGameEnd()
        {
            EndGame endForm = new EndGame(gameController);
            this.Hide();
            endForm.ShowDialog();
        }

        public void SetPictureBoxBackgroundImage(PictureBox pictureBox, string filename)
        {
            pictureBox.BackgroundImage = (Image)Resources.ResourceManager.GetObject(filename);
        }

        private void SetPictureBoxMainImage(PictureBox pictureBox, string filename)
        {
            pictureBox.Image = (Image)Resources.ResourceManager.GetObject(filename);
        }



        private void RefreshCardsDisplay()
        {
            Hand playerHand = gameController.GetPlayerCards();
            listBoxPlayerDisplay.Items.Clear();

            foreach (Card card in playerHand.GetAllCardsInHand())
            {
                listBoxPlayerDisplay.Items.Add(card.Name);
            }
        }

        private void UpdateCurrentWins()
        {
            listViewPlayersAndWins.Items.Clear();

            foreach (var player in gameController.GetAllPlayersData())
            {
                var item = new ListViewItem(player.name);
                item.SubItems.Add(player.bet.ToString());
                item.SubItems.Add(player.won.ToString());

                listViewPlayersAndWins.Items.Add(item);
            }
        }









        private void UpdateTrickUI()
        {


            //Display current winning card
            Card winner = gameController.GetCurrentWinningCard();
            String winningCardFile = winner.imgFileName + "_icon";
            SetPictureBoxBackgroundImage(pictureBoxWinningCard, winningCardFile);

            String leadingSuitFile = "card_";
            leadingSuitFile += gameController.GetLeadingSuit().ToLower();
            SetPictureBoxBackgroundImage(pictureBoxLeadingSuit, leadingSuitFile);

            Card lastCard = gameController.GetLastCard();
            SetPictureBoxMainImage(pictureBoxLastCard, lastCard.imgFileName);


        }


        ///Action button methods
        ///---------------------------------------------------------------------------------------------------------

        private async void PlayCard()
        {
            if (!gameController.IsWaitingForInput())
                return;

            // Get the selected index of the players choice for card play
            int selectedIndex = listBoxPlayerDisplay.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select a card");
                return;
            }

            //Retrieve the card object that was selected
            Hand playerHand = gameController.GetPlayerCards();
            Card attemptedCard = playerHand.GetCardByName(
                listBoxPlayerDisplay.Items[selectedIndex].ToString());

            if (!gameController.CanUseCard(playerHand, attemptedCard))
            {
                MessageBox.Show("Card: " + attemptedCard.Name + " is an invalid play, try again");
                return;
            }



            await gameController.PlayCard(playerHand, attemptedCard);

            RefreshCardsDisplay();
            UpdateTrickUI();
            //buttonPlayCard.Enabled = false;
            listBoxPlayerDisplay.SelectionMode = SelectionMode.None;

            UpdateActionButton();
        }

        private void StartNextTrick()
        {
            RefreshCardsDisplay();
            ClearUI();

            gameController.BeginTrick();

            UpdateActionButton();
        }

        private void StartNextRound()
        {
            string trump = gameController.GetCurrentTrump();

            if (trump == "No Trumps")
            {
                SetPictureBoxBackgroundImage(pictureBoxTrumpDisplay, "card_empty");
            } else
            {
                trumpCardImageFile = "card_";
                //Display the current Trump to all players
                trumpCardImageFile += trump.ToLower();
                SetPictureBoxBackgroundImage(pictureBoxTrumpDisplay, trumpCardImageFile);
            }
           
            ClearUI();
            gameController.BeginRound();

            RefreshCardsDisplay();
            //buttonStartRound.Enabled = false;




            //Display the betting form to the user, hiding the current form
            BettingForm bettingForm = new BettingForm(gameController);
            bettingForm.StartPosition = FormStartPosition.CenterParent;
            this.Hide();
            bettingForm.ShowDialog();
            this.Show();

            UpdateCurrentWins();
            //buttonPlayCard.Enabled = true;
            gameController.BeginTrick();

            UpdateActionButton();
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            switch (gameController.currentGameState)
            {
                case GameController.GameState.WaitingForPlayerInput:
                    PlayCard();
                    break;

                case GameController.GameState.EndOfTrick:
                    StartNextTrick();
                    break;

                case GameController.GameState.RoundEnd:
                    StartNextRound();
                    break;


            }
        }

        private void UpdateActionButton()
        {
            switch (gameController.currentGameState)
            {
                case GameController.GameState.WaitingForPlayerInput:
                    buttonAction.Text = "Play Card";
                    buttonAction.Enabled = true;
                    break;

                case GameController.GameState.EndOfTrick:
                    buttonAction.Text = "Start Next Trick";
                    buttonAction.Enabled = true;
                    break;

                case GameController.GameState.BotTurn:
                    buttonAction.Text = "Waiting...";
                    buttonAction.Enabled = false;
                    break;

                case GameController.GameState.RoundEnd:
                    buttonAction.Text = "Start Round";
                    buttonAction.Enabled = true;
                    break;

                case GameController.GameState.GameEnd:
                    buttonAction.Text = "Game Ended";
                    buttonAction.Enabled = false;
                    break;


            }
        }


        ///----------------------------------------------------------------------------------------------------------




        public void ClearUI()
        {
            pictureBoxWinningCard.Refresh();
            pictureBoxLeadingSuit.Refresh();
            pictureBoxWinnerDisplay.Refresh();
            labelWinningPlayer.Refresh();
            panelWinnerDisplay.Visible = false;

        }

        private void buttonStartTrick_Click(object sender, EventArgs e)
        {
            //Reset UI values
            RefreshCardsDisplay();
            ClearUI();

            gameController.BeginTrick();

        }

        private void listBoxPlayerDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxSelectedCard.Refresh();

            int selectedIndex = listBoxPlayerDisplay.SelectedIndex;

            if (selectedIndex == -1)
            {
                return;
            }

            Hand playerHand = gameController.GetPlayerCards();

            Card currentSelctedCard = playerHand.GetCardByName(
                listBoxPlayerDisplay.Items[selectedIndex].ToString());

            String fileName = currentSelctedCard.imgFileName + "_icon";
            SetPictureBoxBackgroundImage(pictureBoxSelectedCard, fileName);

        }

        private void buttonRules_Click(object sender, EventArgs e)
        {
            RulebookForm rulebookForm = new RulebookForm();
            rulebookForm.ShowDialog();
        }
    }
}
