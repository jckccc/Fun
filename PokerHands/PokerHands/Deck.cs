using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PokerHands
{
    class Deck
    {

        List<Card> deck;
        int currentCardIndex;

        public Deck()
        {
            createAndShuffleDeck();
        }

        public void createAndShuffleDeck() {
            createDeck();
            shuffleDeck();
        }

        private void createDeck()
        {
            currentCardIndex = 0;
            deck = new List<Card>();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Value value in Enum.GetValues(typeof(Value)))
                {
                    Card currentCard = new Card(suit, value);
                    deck.Add(currentCard);
                }
            }
        }

        public void shuffleDeck()
        {
            currentCardIndex = 0;
            // modified based on the Fisher-Yates shuffle
            Random random = new Random();
            int length = deck.Count;
            for (int i = 0; i < length; i++)
            {
                int r = i + (int)(random.NextDouble() * (length - i));
                Card t = deck[r];
                deck[r] = deck[i];
                deck[i] = t;
            }
        }

        public Card drawCard()
        {
            Card c = deck[currentCardIndex];
            currentCardIndex++;
            return c;
        }

        public List<Card> drawNumCards(int numCards)
        {
            List<Card> drawnCards = new List<Card>();
            if (numCards <= 0)
            {
                return drawnCards;
            }
            for (int i = 0; i < numCards; i++)
            {
                drawnCards.Add(drawCard());
            }
            return drawnCards;
        }

    }
}
