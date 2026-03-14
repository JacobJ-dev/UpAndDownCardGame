using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpAndDownCard
{
    public class BotPlayer : Hand
    {

        List<Card> validCards;
        Card bestCard;

        public BotPlayer(string playerName, int id, string playerIcon)
            : base(playerName, id, true, playerIcon)
        {

        }

        public void SelectCard(GameController gc)
        {
            GetValidCardsInHand(gc);

            if (IsTrickWinnable(gc)) 
            {
                gc.PlayCard(this,bestCard);
                bestCard = null;
                
            } else
            {
                gc.PlayCard(this, validCards.FirstOrDefault());
            }

        }

        private bool IsTrickWinnable(GameController gc)
        {
            Card currentWinner = gc.GetCurrentWinningCard();
            String currentTrump = gc.GetCurrentTrump();

            foreach (Card card in validCards)
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
    }
}
