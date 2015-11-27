using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    class Stats
    {
        int highCard,
        pair,
        twoPair,
        threeOfAKind,
        straight,
        flush,
        fullHouse,
        fourOfAKind,
        straightFlush;
        int numRuns;

        public Stats()
        {
            resetStats();
        }

        public void resetStats()
        {
            highCard = 0;
            pair = 0;
            twoPair = 0;
            threeOfAKind = 0;
            straight = 0;
            flush = 0;
            fullHouse = 0;
            fourOfAKind = 0;
            straightFlush = 0;
            numRuns = 0;
        }

        public void addStat(Hand hand) {
            numRuns++;
            if (hand == Hand.StraightFlush)
            {
                straightFlush++;
            }
            else if (hand == Hand.FourOfAKind)
            {
                fourOfAKind++;
            }
            else if (hand == Hand.FullHouse)
            {
                fullHouse++;
            }
            else if (hand == Hand.Flush)
            {
                flush++;
            }
            else if (hand == Hand.Straight)
            {
                straight++;
            }
            else if (hand == Hand.ThreeOfAKind)
            {
                threeOfAKind++;
            }
            else if (hand == Hand.TwoPair)
            {
                twoPair++;
            }
            else if (hand == Hand.Pair)
            {
                pair++;
            }
            else
            {
                highCard++;
            }
        }

        override
        public String ToString()
        {
            return "Overall Stats\n" +
                "Number of Runs: " + numRuns + "\n" + 
                "High Card: " + highCard + "\n" +
                "Pair: " + pair + "\n" +
                "Two Pair: " + twoPair + "\n" +
                "Three Of A Kind: " + threeOfAKind + "\n" +
                "Straight: " + straight + "\n" +
                "Flush: " + flush + "\n" +
                "Full House: " + fullHouse + "\n" +
                "Four Of A Kind: " + fourOfAKind + "\n" +
                "Straight Flush: " + straightFlush;
        }

    }
}
