using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpAndDownCard
{
    public class BotPlayer : Hand
    {

        List<Card>? validCards;
        Card? bestCard;

        public BotPlayer(string playerName, int id, string playerIcon)
            : base(playerName, id, playerIcon)
        {

        }

        public void SelectCard(GameController gc)
        {
            GetValidCardsInHand(gc);

            if (IsTrickWinnable(gc) && !HasMatchedBet()) 
            {
                _ = gc.PlayCard(this,bestCard!);
                bestCard = null;
                
            } else
            {
                _ = gc.PlayCard(this, validCards!.FirstOrDefault()!);
            }

        }

        private bool IsTrickWinnable(GameController gc)
        {
            Card currentWinner = gc.GetCurrentWinningCard()!;
            String currentTrump = gc.GetCurrentTrump();

            foreach (Card card in validCards!)
            {
                //If the current card value is higher than the current winning card
                if (card.Value > currentWinner.Value)
                {
                    bestCard = card;
                    return true;
                }

                if (card.Suit == currentTrump && currentWinner.Suit != currentTrump)
                {
                    bestCard = card;
                    return true;
                }
            }

            return false;
        }

        private void GetValidCardsInHand(GameController gc)
        {
            validCards = new List<Card>();

            foreach(Card card in fullHand)
            {
                //Check if card is a valid play
                if(gc.CanUseCard(this, card))
                {
                    validCards.Add(card);
                }
            }

            
        }

        private bool HasMatchedBet()
        {
            if(numsWinsThisRound == GetTricksBet())
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// This method allows a bot to look at it's own cards
        /// and 'place a bet'
        /// </summary>
        /// <param name="gc"></param>
        public void SetBotBet(string trump)
        {
            //First the bot will check how many trump cards in hand            
            int numTrumpCards = GetNumberOfTrumpsInHand(trump);

            //Then will count how many non trump high value cards are there (Queens - Ace)
            int numHighValueCards = GetNumHighCards(trump); 
            //It will then take a random number from 0 to that value of winnable cards
            int totalValueCards = numHighValueCards + numTrumpCards;
            Random random = new Random();
            int betValue = random.Next(0, totalValueCards + 1);
            SetTricksBet(betValue);
        }

        private int GetNumberOfTrumpsInHand(string trump)
        {
            int trumpCount = 0;
            foreach (Card card in fullHand)
            {
                if (card.Suit == trump)
                {
                    trumpCount++;
                }
            }

            return trumpCount;
        }

        private int GetNumHighCards(string trump)
        {
            int numOfHighCards = 0;
            foreach (Card card in fullHand)
            {
                if(card.Suit != trump && card.Value > 11)
                {
                    numOfHighCards++;
                }
            }

            return numOfHighCards;
        }
    }
}
