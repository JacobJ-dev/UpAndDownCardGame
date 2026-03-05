using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpAndDownCard
{
    public class Hand
    {
        private List<Card> fullHand;
        private List<Card> allDiamonds;
        private List<Card> allHearts;
        private List<Card> allSpades;
        private List<Card> allClubs;

        private string _name;
        public int id;
        private bool isBot;
        public int numsWinsThisRound = 0;

        private int tricksBetToWin = 0;

        private string playerIcon;

        public Hand(string playerName, int id, bool isBot, string playerIcon)
        {
            fullHand = new List<Card>();
            allDiamonds = new List<Card>();
            allHearts = new List<Card>();
            allSpades = new List<Card>();
            allClubs = new List<Card>();

            _name = playerName;
            this.id = id;
            this.isBot = isBot;
            this.playerIcon = playerIcon;
        }

        public string GetPlayerIcon()
        {
            return playerIcon;
        }

        public void SetTricksBet(int tricksBet)
        {
            tricksBetToWin = tricksBet;
        }

        public int GetTricksBet()
        {
            return tricksBetToWin;
        }

        public void ResetWinningRounds()
        {
            numsWinsThisRound = 0;
        }

        public void AddCardToHand(Card card)
        {
            fullHand.Add(card);
        }

        public bool IsPlayerBot()
        {
            return isBot;
        }

        public string GetPlayerName()
        {
            return _name;
        }

        public void SortCardsBySuit()
        {
            foreach (Card card in fullHand)
            {
                switch (card.Suit)
                {
                    case "Diamonds":
                        allDiamonds.Add(card);
                        break;
                    case "Hearts":
                        allHearts.Add(card);
                        break;
                    case "Spades":
                        allSpades.Add(card);
                        break;
                    case "Clubs":
                        allClubs.Add(card);
                        break;
                }
            }

            SortCards(allDiamonds, 0, allDiamonds.Count - 1);
            SortCards(allHearts, 0, allHearts.Count - 1);
            SortCards(allSpades, 0, allSpades.Count - 1);
            SortCards(allClubs, 0, allClubs.Count - 1);

            fullHand.Clear();

            fullHand.AddRange(allDiamonds);
            fullHand.AddRange(allHearts);
            fullHand.AddRange(allSpades);
            fullHand.AddRange(allClubs);

            allDiamonds = null;
            allHearts = null;
            allSpades = null;
            allClubs = null;

            //SortCards(fullHand, 0, fullHand.Count - 1);
        }

        

        /// <summary>
        /// QuickSort method to order the cards for play
        /// </summary>
        /// <param name="cards">The list of cards to sort</param>
        /// <param name="low">The left pointer</param>
        /// <param name="high">The right pointer</param>
        private void SortCards(List<Card> cards, int low, int high)
        {
            if (low < high)
            {
                int pivot_location = Partition(cards, low, high);
                SortCards(cards, low, pivot_location - 1);
                SortCards(cards, pivot_location + 1, high);
            }
        }

        private int Partition(List<Card> cards, int low, int high)
        {
            int pivot = cards[low].Value;
            int pivotInt = low;
            int leftwall = low;

            for (int i = low + 1; i <= high; i++)
            {
                if(cards[i].Value < pivot){
                    leftwall++;
                    Swap(cards, i, leftwall);
                    
                }
            }
            Swap(cards, pivotInt, leftwall);

            return leftwall;
        }

        private void Swap(List<Card> cards, int leftSwapIndex, int rightSwapIndex)
        {
            Card temp = cards[leftSwapIndex];
            cards[leftSwapIndex] = cards[rightSwapIndex];
            cards[rightSwapIndex] = temp;
            return;
        }

        /// <summary>
        /// Checks through a whole hand to ensure no invalid plays are made
        /// </summary>
        /// <param name="leadingSuit"></param>
        /// <returns></returns>
        public bool IsLeadingSuitInHand(String leadingSuit)
        {
            foreach (Card card in fullHand)
            {
                if (card.Suit == leadingSuit)
                {
                    return true;
                }
            }
            return false;
        }


        public Card GetCardByName(String name)
        {
            foreach(Card card in fullHand)
            {
                if (card.Name == name)
                {
                    return card;
                }
            }

            Console.Error.WriteLine("Card: " + name + " not found in " + _name + " hand");
            return null;
        }

        public List<Card> GetAllCardsInHand()
        {
            return fullHand;
        }

        public int GetNumberOfCards()
        {
            return fullHand.Count;
        }

        public int GetTricksWon()
        {
            return numsWinsThisRound;
        }

        public void RemoveCardFromHand(Card card)
        {
            fullHand.Remove(card);
        }

        public void ResetHand()
        {
            fullHand = new List<Card>();
            allDiamonds = new List<Card>();
            allHearts = new List<Card>();
            allSpades = new List<Card>();
            allClubs = new List<Card>();
            numsWinsThisRound = 0;
        }

        public int GetNumberOfTrumpsInHand(string trump)
        {
            int trumpCount = 0;
            foreach (Card card in fullHand)
            {
                if(card.Suit == trump)
                {
                    trumpCount++;
                }
            }

            return trumpCount;
        }
    }
}
