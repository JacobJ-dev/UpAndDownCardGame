using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpAndDownCard
{
    public class GameManager
    {

        private static GameManager _gameManagerInstance;

        public event Action<Dictionary<string, int>> OnScoreUpdated;

        private Hand winningPlayer;
        private GameManager()
        {

        }

        public static GameManager Instance
        {
            get
            {
                if (_gameManagerInstance == null)
                {
                    _gameManagerInstance = new GameManager();
                }
                return _gameManagerInstance;
            }
        }

        private Dictionary<string, int> playerScores = new Dictionary<string, int>();

        public void LoadPlayers(List<Hand> hands)
        {
            foreach (Hand player in hands)
            {
                playerScores.Add(player.GetPlayerName(), 0);
            }
        }

        public Dictionary<string, int> GetPlayerScores()
        {
            return playerScores;
        }

        /// <summary>
        /// Updates score based on performance of previous round
        /// </summary>
        /// <param name=""></param>
        public void UpdateScores(List<Hand> hands)
        {
            foreach (Hand player in hands)
            {
                

                if (HasBetCorrectly(player) && IsAZeroMerchant(player))
                {
                    playerScores[player.GetPlayerName()] += 5;
                } else if (HasBetCorrectly(player))
                {
                    playerScores[player.GetPlayerName()] += 10 + player.numsWinsThisRound;
                } else
                {
                    playerScores[player.GetPlayerName()] += player.numsWinsThisRound;
                }

                if (winningPlayer == null || playerScores[player.GetPlayerName()] > playerScores[winningPlayer.GetPlayerName()])
                {
                    winningPlayer = player;
                }
                OnScoreUpdated?.Invoke(GetPlayerScores());
            }
        }

        private bool HasBetCorrectly(Hand player)
        {
            if (player.numsWinsThisRound == player.GetTricksBet())
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// This method makes a check to see if a player made a 0 tricks bet (zero merchant)
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        private bool IsAZeroMerchant(Hand player)
        {
            if(player.GetTricksBet() == 0)
            {
                return true;
            }
            return false;
        }

        public Hand GetWinningPlayer()
        {
            return winningPlayer;
        }
       
        
    }
}
