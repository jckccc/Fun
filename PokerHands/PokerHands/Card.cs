using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PokerHands
{
    public enum Suit
    {
        Club,
        Diamond,
        Heart,
        Spade
    }

    public enum Value
    {
        Ace = 14,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }

    class Card : IComparable<Card>
    {

        private Suit suit;
        private Value value;
        private Image image;

        public Card(Suit suit, Value value) {
            this.suit = suit;
            this.value = value;
            setImageName();
        }

        public Suit getSuit()
        {
            return suit;
        }

        public Value getValue()
        {
            return value;
        }

        public int getValueInt()
        {
            return (int)value;
        }

        public Image getImage()
        {
            return image;
        }

        private void setImageName() 
        {
            string cardSuit = getFirstLetterLowerCase(suit.ToString());
            string cardValue = fetchValueAbbreviation();
            string imageName = cardValue + cardSuit;

            image = (Image)PokerHands.Properties.Resources.ResourceManager.GetObject(imageName);
        }

        private string getFirstLetterLowerCase(string s)
        {
            s = s.Substring(0, 1); 
            s = s.ToLower(); 
            return s;
        }

        private string fetchValueAbbreviation()
        {
            if (value == Value.King || value == Value.Queen || value == Value.Jack || value == Value.Ten || value == Value.Ace) {
                return getFirstLetterLowerCase(value.ToString());
            }
            else {
                return (int)value + "";
            }
        }

        public int CompareTo(Card other)
        {
            if (this.getValueInt() > other.getValueInt())
            {
                return 1;
            }
            else if (this.getValueInt() < other.getValueInt())
            {
                return -1;
            }
            else
            {
                if (this.getSuit() < other.getSuit())
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }

    }

}
