using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpAndDownCard
{
    public class GameTrick
    {
        private string _trumpSuit;
        private string leadingSuit;
        private Card currentHighestCard;
        private bool isFirstTurn = true;
        private Hand currTrickWinnner;
        private List<Card> playedCards;

        public GameTrick(string trumpSuit)
        {
            _trumpSuit = trumpSuit;
            playedCards = new List<Card>();
        }

        public void PlayTurn(Hand currentPlayer, Card attemptedCard)
        {

            if (isFirstTurn)
            {
               
                currentHighestCard = attemptedCard;
                currTrickWinnner = currentPlayer;
                leadingSuit = attemptedCard.Suit;
                isFirstTurn = false;

            } 

            if (IsBetterThanCurrent(attemptedCard))
            {
                currentHighestCard = attemptedCard;
                currTrickWinnner = currentPlayer;
            }

            
            currentPlayer.RemoveCardFromHand(attemptedCard);
            playedCards.Add(attemptedCard);
            
        }

        public bool IsValidTurn(Hand hand, Card card)
        {
            if (card.Suit == leadingSuit || card.Suit == _trumpSuit)
            {
                return true;
            }

            if (hand.IsLeadingSuitInHand(leadingSuit))
            {
                
                return false;
            }

            return true;

        }


        private bool IsBetterThanCurrent(Card attemptedCard)
        {
            if(currentHighestCard.Suit != _trumpSuit && attemptedCard.Suit == _trumpSuit)
            {
                return true;
            } 
            else if (currentHighestCard.Suit == _trumpSuit && attemptedCard.Suit == _trumpSuit && attemptedCard.Value > currentHighestCard.Value)
            {
                return true;
            } 
            else if (attemptedCard.Suit == currentHighestCard.Suit && attemptedCard.Value > currentHighestCard.Value)
            {
                return true;
            } else
            {
                return false;
            }

            
        }

        public string GetLeadingSuit()
        {
            return leadingSuit;
        }

        public Card GetCurrentHighestCard()
        {
            return currentHighestCard;
        }

        public Hand GetTrickWinner()
        {
            return currTrickWinnner;
        }

        public Card GetLastCard()
        {
            return playedCards[playedCards.Count - 1];
        }


        
        
    }
}
