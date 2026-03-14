using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
//using System.Runtime.InteropServices.WindowsRuntime;

namespace UpAndDownCard
{
    public class GameController
    {
        //Testing commit

        //List to keep track of players
        private List<Hand> allPlayers;
        private int turnOwner;
        private int startingTurnOwner;


        private int maxRounds;
        private bool isDecrease = true;
        
        
        //Keeping track of current trump suit
        private string[] trumpList = { "Diamonds", "Hearts", "Spades", "Clubs", "No Trumps" };
        private int trumpPointer;

        private GameTrick currentTrick;
        

        //Deck related variables
        private Deck deck;
        private int totalCardNum;
        private int cardPerPlayer;


        private int cardsPlayedThisTrick;


        //UI related information
        private Hand winningPlayer;
        private Card winningCard;
        private string leadingSuit;
        private Card lastPlacedCard;

        private bool isRoundFinished = true;


        public event Action<GameController> OnTrickStateUpdated;
        public event Action OnTrickEnded;
        public event Action OnPlayerTurn;
        public event Action OnRoundEnd;
        public event Action OnGameEnd;

        
        public enum GameState
        {
            WaitingForPlayerInput,
            BotTurn,
            EndOfTrick,
            RoundEnd,
            GameEnd
        }

        public GameState currentGameState;


        public GameController() 
        {
            turnOwner = 0;
            startingTurnOwner = 0;
            trumpPointer = 0;
            deck = new Deck();
            allPlayers = new List<Hand>();
            currentGameState = GameState.RoundEnd;
        }

        /// PUBLIC METHODS (Entry points for UI)
        //--------------------------------------------------------------------------------------------------------------------

        ///<summary>
        ///Creates a new player in the game
        /// </summary>
        /// <param name="PlayerName"></param>
        /// <param name="isBot"></param>
        public void CreatePlayer(string PlayerName, bool isBot, string icon)
        {
            Hand newPlayer = new Hand(PlayerName, allPlayers.Count, isBot, icon);
            allPlayers.Add(newPlayer);
        }

        /// <summary>
        /// Setups the game to have the correct amount of cards per player
        /// </summary>
        public void BeginGame()
        {
            totalCardNum = deck.splitEqualCards(allPlayers.Count);
            Console.WriteLine(totalCardNum.ToString() + " is total");

            cardPerPlayer = totalCardNum / allPlayers.Count;

          
            maxRounds = cardPerPlayer;
            
            
        }

        /// <summary>
        /// Setups the round with a new deck and deals the correct number of cards to every player
        /// </summary>
        public void BeginRound()
        {
            //Refresh the deck
            deck = new Deck();
            deck.ShuffleDeck();
            DealAllCards();

            isRoundFinished = false;

            SetBotBets();

            turnOwner = startingTurnOwner;

            

        }

        /// <summary>
        /// Setups the single trick, initialising the trick object with a trump, and allows players to place one card for this trick
        /// </summary>
        public void BeginTrick()
        {
            //Create a new trick logic object
            currentTrick = new GameTrick(trumpList[trumpPointer]);
            cardsPlayedThisTrick = 0;


            

            //Set the state to decide what player leads the round
            currentGameState = allPlayers[turnOwner].IsPlayerBot() ? GameState.BotTurn : GameState.WaitingForPlayerInput;

            _ = AdvanceGameStep();

        }

        /// <summary>
        /// Bool checker to test validity of card to play if turn is valid or not
        /// </summary>
        /// <param name="player"></param>
        /// <param name="card"></param>
        /// <returns></returns>
        public bool CanUseCard(Hand player, Card card)
        {
            //If the card is not a valid play
            if (!currentTrick.IsValidTurn(player, card))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// This method allows a player to 'play' a card onto the trick
        /// </summary> 
        /// <param name="player">The hand of the player to place a card</param>
        /// <param name="card">The intended 'card' to play</param>
        /// <returns></returns>
        public async Task PlayCard(Hand player, Card card)
        {
            currentTrick.PlayTurn(player, card);
            cardsPlayedThisTrick++;
            //Debugging
            Console.WriteLine("Player: " + player.GetPlayerName() + " has played card -> " + card.Name);

            

            SetUIValues();
            OnTrickStateUpdated?.Invoke(this);
            Application.DoEvents();
            await Task.Delay(600);

            CheckGameProgress();




        }

        

        //----------------------------------------------------------------------------------------------------------

        ///Private Methods
        //----------------------------------------------------------------------------------------------------------

        private async Task AdvanceGameStep()
        {
            //If it is a bot turn, then play one move only
            if (currentGameState == GameState.BotTurn)
            {
                Hand bot = allPlayers[turnOwner];



                //Selects the first card in a bots hand that is a legal play
                Card chosenCard = bot.GetAllCardsInHand().First(c => currentTrick.IsValidTurn(bot, c));

                await PlayCard(bot, chosenCard);


            } 
            else if(currentGameState == GameState.WaitingForPlayerInput) 
            {
                OnPlayerTurn?.Invoke();
            }
        }


        private async Task CheckGameProgress()
        {
            if (cardsPlayedThisTrick == allPlayers.Count)
            {
                winningPlayer = currentTrick.GetTrickWinner();
                winningPlayer.numsWinsThisRound += 1;

                currentGameState = GameState.EndOfTrick;
                OnTrickEnded?.Invoke();
                ResolveTrickEnd();
                return;
            }

            turnOwner = (turnOwner + 1) % allPlayers.Count;

            currentGameState =
                allPlayers[turnOwner].IsPlayerBot()
                ? GameState.BotTurn
                : GameState.WaitingForPlayerInput;

           
                await Task.Delay(600);
                _ = AdvanceGameStep();
            
        }

        private void SetUIValues()
        {
            winningPlayer = currentTrick.GetTrickWinner();
            winningCard = currentTrick.GetCurrentHighestCard();
            leadingSuit = currentTrick.GetLeadingSuit();
            lastPlacedCard = currentTrick.GetLastCard();
        }


        /// <summary>
        /// This runs at the end of a trick
        /// </summary>
        /// <returns></returns>
        private void ResolveTrickEnd()
        {
            //await Task.Delay(600);

            
            SetUIValues();

            

            for (int i = 0; i < allPlayers.Count; i++)
            {
                if(winningPlayer == allPlayers[i])
                {
                    //allPlayers[i].numsWinsThisRound += 1;
                    turnOwner = i;
                    break;
                }
            }

            
            
            currentTrick = null;

            if (WillRoundEnd())
            {
                isRoundFinished = true;
                EndRound();
            }

           

        }

        public bool WillRoundEnd()
        {
            int currCardsInPlayerHand = allPlayers[turnOwner].GetNumberOfCards();

            if (currCardsInPlayerHand == 0)
            { return true; }
            return false;
        }

        private void EndRound()
        {
            GameManager.Instance.UpdateScores(allPlayers);

            currentGameState = GameState.RoundEnd;
            startingTurnOwner = (startingTurnOwner + 1) % allPlayers.Count;

            SetCardsLimitNextRound();
            ResetAllPlayers();
            OnRoundEnd?.Invoke();

            trumpPointer = (trumpPointer + 1) % trumpList.Length;

            if (cardPerPlayer == -1)
            {
                MessageBox.Show("Game has ended");
                OnGameEnd?.Invoke();
                return;
            }
        }

        private void SetCardsLimitNextRound()
        {
            if (isDecrease && cardPerPlayer - 1 > 0)
            {
                cardPerPlayer--;
                return;
            }

            if (isDecrease && cardPerPlayer - 1 == 0)
            {
                isDecrease = false;
                return;
            }

            if (!isDecrease && cardPerPlayer < maxRounds)
            {
                cardPerPlayer++;
                return;
            }

            cardPerPlayer = -1;

        }

        /// <summary>
        /// This method resets all players inbetween rounds for hand, bets and wins.
        /// </summary>
        private void ResetAllPlayers()
        {
            foreach (var player in allPlayers) 
            {
                player.ResetHand();
                player.SetTricksBet(0);
                player.ResetWinningRounds();
            }
        }



        private void SetBotBets()
        {
            foreach(Hand player in allPlayers)
            {
                if (player.IsPlayerBot())
                {
                    int numTrumpCards = player.GetNumberOfTrumpsInHand(trumpList[trumpPointer]);
                    Random random = new Random();
                    
                    int botBet = random.Next(0, numTrumpCards + 1);
                    player.SetTricksBet(botBet);
                    
                    Console.WriteLine("Setting bet for: " + player.GetPlayerName() + " " + botBet); 
                    Console.WriteLine();

                }
            }
        }




        

        

        /// <summary>
        /// Deals every card for the hand and sorts each players hand 
        /// </summary>
        private void DealAllCards()
        {
            //Clear the hand of each player
            foreach (Hand player in allPlayers)
            {
                player.ResetHand();
            }
            //Deal all the cards out equally
            for (int i = 0; i < cardPerPlayer; i++)
            {
                foreach (Hand player in allPlayers)
                {
                    player.AddCardToHand(deck.dealCard());
                }
            }
            //Sort each players hands
            foreach (Hand player in allPlayers)
            {
                player.SortCardsBySuit();
            }
        }

        //----------------------------------------------------------------------------------------------------------

        // GETTERS AND SETTERS

        public bool GetRoundState()
        {
            return isRoundFinished;
        }

        public Card GetLastCard()
        {
            return lastPlacedCard;
        }

        public Card GetCurrentWinningCard()
        {
            return winningCard;
        }

        public string GetLeadingSuit()
        {
            return leadingSuit;
        }
        
        /// <summary>
        /// Retrieves the current trump for the round
        /// </summary>
        /// <returns></returns>
        public string GetCurrentTrump()
        {
            return trumpList[trumpPointer];
        }

        /// <summary>
        /// Retrieves the player who is currently the turn maker (person to place a card)
        /// </summary>
        /// <returns></returns>
        public Hand GetCurrentTurnsPlayer()
        {
            return allPlayers[turnOwner];
        }

        /// <summary>
        /// Retrieves the human player hand object
        /// </summary>
        /// <returns></returns>
        public Hand GetPlayerCards()
        {
            foreach (Hand p in allPlayers)
            {
                if (!p.IsPlayerBot())
                {
                    return p;
                }
            }

            return null;
        }

        public String GetWinningMessage()
        {
            return "Winner of trick -> " + winningPlayer.GetPlayerName() + " with : " + winningCard.Name;
        }

        public int GetPlayerBet()
        {
            Hand player = GetPlayerCards();
            return player.GetTricksBet();
        }

        public List<Hand> GetAllPlayers()
        {
            return allPlayers;
        }


        public List<(string name, int bet, int won)> GetAllPlayersData()
        {
            var result = new List<(string, int, int)>();

            foreach (Hand p in allPlayers)
            {
                result.Add((p.GetPlayerName(), p.GetTricksBet(), p.GetTricksWon()));
            }

            return result;
        }

        public bool IsWaitingForInput()
        {
            if(currentGameState == GameState.WaitingForPlayerInput)
                return true;
            return false;
        }

        public Hand GetTrickWinner()
        {
            return winningPlayer;
        }
    }
}
