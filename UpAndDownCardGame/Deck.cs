using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UpAndDownCard
{
    public class Deck
    {
        private List<Card> deckOfCards = new List<Card>();
        private Card nextCard = null;
        private const int TOTAL_CARDS = 52;
        private static Random random = new Random();

        public Deck() 
        {
            string[] suits = { "Hearts", "Diamonds", "Spades", "Clubs" };

            
            //Creating all the cards
            for (int suitIndex = 0; suitIndex < 4; suitIndex++)
            {
                string currentSuit = suits[suitIndex];

                for (int numberIndex = 1; numberIndex < 14; numberIndex++)
                {
                    string cardName = "";
                    string fileName = "";

                    if (numberIndex == 1)
                    {
                        cardName += "Ace";
                        cardName += " of " + currentSuit;
                        Card newCardAce = new Card(currentSuit, cardName, 14, "card_" + currentSuit.ToLower() + "_A");
                        deckOfCards.Add(newCardAce);
                        continue;
                    }

                    if (numberIndex < 11) {
                        cardName += numberIndex.ToString();
                        if (numberIndex == 10)
                        {
                            fileName = numberIndex.ToString();
                        }
                        else
                        {
                            fileName = "0" + numberIndex.ToString();
                        }
                    } else if (numberIndex == 11)
                    {
                        cardName += "Jack";
                        fileName = "J";
                    } else if (numberIndex == 12) {
                        cardName += "Queen";
                        fileName = "Q";
                    } else if (numberIndex == 13) {
                        cardName += "King";
                        fileName = "K";
                    } 

                    cardName += " of " + currentSuit;
                    Card newCard = new Card(currentSuit, cardName, numberIndex, "card_" + currentSuit.ToLower() + "_"+fileName);
                    deckOfCards.Add(newCard);
                }
            }

            nextCard = deckOfCards[deckOfCards.Count - 1];
        }

        public void ShuffleDeck()
        {

            int lastIndex = deckOfCards.Count - 1;
            while (lastIndex > 0)
            {
                Card tempCard = deckOfCards[lastIndex];
                int randIndex = random.Next(0, lastIndex);
                deckOfCards[lastIndex] = deckOfCards[randIndex];
                deckOfCards[randIndex] = tempCard;
                lastIndex--;
            }

            nextCard = deckOfCards[deckOfCards.Count - 1];
        }


        public void PrintDeck()
        {
            foreach (Card card in deckOfCards)
            {
                Console.WriteLine(card.Name);
            }
        }

        public Card dealCard()
        {
            if(nextCard == null)
            {
                Console.WriteLine("Deck is out of cards");
                return null;
            }

            Card newCard = nextCard;

            deckOfCards.Remove(nextCard);
            if(deckOfCards.Count == 0)
            {
                Console.WriteLine("Out of cards");
                nextCard = null;
                return newCard;
            }
            nextCard = deckOfCards[deckOfCards.Count - 1];

            return newCard;
        }

        /// <summary>
        /// Deals a single hand of cards for a player
        /// </summary>
        /// <param name="hand">The "hand" to be dealt the cards to</param>
        /// <param name="totalCardsForHand">The total number of cards needed for the round</param>
        /// <returns></returns>
        public List<Card> DealHand(List<Card> hand, int totalCardsForHand)
        {
            List<Card> newHand = new List<Card>();
            for (int i = 0; i < totalCardsForHand; i++)
            {
                newHand.Add(dealCard());
            }

            return newHand;
        }

        public int splitEqualCards(int totalPlayerCount)
        {
            int result = TOTAL_CARDS % totalPlayerCount;
            Console.WriteLine(result);

            int card_total = TOTAL_CARDS - result;

            Console.WriteLine(card_total);

            return card_total;
        }
        

        
    }
}
