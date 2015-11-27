using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    // suit order (low to high): diamond, club, heart, spade
    // information from https://www.pokerstars.com/pages/poker/hand-rankings/ 
    enum Hand
    {
        HighCard,
        Pair,
        TwoPair,
        ThreeOfAKind,
        Straight,
        Flush,
        FullHouse,
        FourOfAKind,
        StraightFlush
    }

    class HandChecker
    {

        List<Card> cards;
        Hand hand;

        public HandChecker(List<Card> cards)
        {
            this.cards = cards;
            sortCards();
            setHand();
        }

        public Hand getHandResult()
        {
            return hand;
        }

        public void sortCards(){
            cards.Sort((x, y) => x.CompareTo(y));
        }

        public void setHand()
        {
            if (checkStraightFlush())
            {
                hand = Hand.StraightFlush;
            }
            else if (checkFourOfAKind())
            {
                hand = Hand.FourOfAKind;
            }
            else if (checkFullHouse())
            {
                hand = Hand.FullHouse;
            }
            else if (checkFlush())
            {
                hand = Hand.Flush;
            }
            else if (checkStraight())
            {
                hand = Hand.Straight;
            }
            else if (checkThreeOfAKind())
            {
                hand = Hand.ThreeOfAKind;
            }
            else if (checkTwoPair())
            {
                hand = Hand.TwoPair;
            }
            else if (checkPair())
            {
                hand = Hand.Pair;
            }
            else
            {
                hand = Hand.HighCard;
            }
        }

        private bool checkStraightFlush()
        {
            return checkFlush() && checkStraight();
        }

        private bool checkFourOfAKind()
        {
            return checkNumSameCardValues(4);
        }

        private bool checkFullHouse()
        {
            return checkPair() && checkThreeOfAKind();
        }

        private bool checkFlush()
        {
            int numSpades = 0;
            int numHearts = 0;
            int numClubs = 0;
            int numDiamonds = 0;
            foreach (Card c in cards) {
                if (c.getSuit() == Suit.Spade)
                {
                    numSpades++;
                }
                else if (c.getSuit() == Suit.Heart)
                {
                    numHearts++;
                }
                else if (c.getSuit() == Suit.Club)
                {
                    numClubs++;
                }
                else if (c.getSuit() == Suit.Diamond)
                {
                    numDiamonds++;
                }
            }
            return numSpades >= 5 || numHearts >= 5 || numClubs >= 5 || numDiamonds >= 5;
        }

        public bool checkStraight()
        {
            return (cards[0].getValueInt() == cards[1].getValueInt() - 1
                && cards[0].getValueInt() == (cards[2].getValueInt() - 2)
                && cards[0].getValueInt() == (cards[3].getValueInt() - 3)
                && cards[0].getValueInt() == (cards[4].getValueInt() - 4))
                ||
                (cards[1].getValueInt() == cards[2].getValueInt() - 1
                && cards[1].getValueInt() == (cards[3].getValueInt() - 2)
                && cards[1].getValueInt() == (cards[4].getValueInt() - 3)
                && cards[1].getValueInt() == (cards[5].getValueInt() - 4))
                ||
                (cards[2].getValueInt() == cards[3].getValueInt() - 1
                && cards[2].getValueInt() == (cards[4].getValueInt() - 2)
                && cards[2].getValueInt() == (cards[5].getValueInt() - 3)
                && cards[2].getValueInt() == (cards[6].getValueInt() - 4));
        }

        public bool checkThreeOfAKind()
        {
            return checkNumSameCardValues(3);
        }

        public bool checkTwoPair()
        {
            bool onePair = false;
            bool twoPair = false;
            int numSame = 1;
            int current = 0;
            foreach (Card c in cards)
            {
                if (current == c.getValueInt())
                {
                    numSame++;
                }
                else
                {
                    current = c.getValueInt();
                    numSame = 1;
                }
                if (numSame == 2)
                {
                    if (onePair)
                    {
                        twoPair = true;
                    }
                    else
                    {
                        onePair = true;
                    }
                }
                else if (numSame > 2)
                {
                    if (onePair)
                    {
                        onePair = false;
                    }
                    else
                    {
                        twoPair = false;
                    }
                }
            }
            return twoPair;
        }

        public bool checkPair()
        {
            return checkNumSameCardValues(2);
        }

        private bool checkNumSameCardValues(int numValues)
        {
            bool satisfied = false;
            int numSame = 1;
            int current = 0;
            foreach (Card c in cards)
            {
                if (current == c.getValueInt())
                {
                    numSame++;
                }
                else
                {
                    current = c.getValueInt();
                    numSame = 1;
                }
                if (numSame == numValues)
                {
                    satisfied = true;
                }
                else if (numSame > numValues)
                {
                    satisfied = false;
                }
            }
            return satisfied;
        }

    }
}
