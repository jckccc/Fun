using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokerHands
{
    public partial class Form1 : Form
    {
        List<PictureBox> tableCardsUI;
        List<PictureBox> playerCardsUI;
        Stats stats;
        Deck deck;

        public Form1()
        {
            InitializeComponent();
            setupTextComponents();
            setupCardComponents();
        }

        private void setupTextComponents()
        {
            stats = new Stats();
            overallStats.Text = stats.ToString();

            title.Font = new Font(title.Font.FontFamily, 20);
            currentResult.Font = new Font(title.Font.FontFamily, 18);
            result.Font = new Font(title.Font.FontFamily, 18);
        }

        private void setupCardComponents()
        {
            deck = new Deck();

            tableCardsUI = new List<PictureBox>();
            tableCardsUI.Add(table1);
            tableCardsUI.Add(table2);
            tableCardsUI.Add(table3);
            tableCardsUI.Add(table4);
            tableCardsUI.Add(table5);

            playerCardsUI = new List<PictureBox>();
            playerCardsUI.Add(player1);
            playerCardsUI.Add(player2);
        }

        public void playGame(int numGames)
        {
            int counter = 0;
            List<Card> tableCards;
            List<Card> playerCards;
            HandChecker handChecker;
            do
            {
                deck.shuffleDeck();
                tableCards = deck.drawNumCards(5);
                playerCards = deck.drawNumCards(2);
                handChecker = new HandChecker(tableCards.Concat(playerCards).ToList());
                stats.addStat(handChecker.getHandResult());
                counter++;
            }
            while (counter < numGames);

            for (int i = 0; i < tableCards.Count; i++)
            {
                tableCardsUI[i].Image = tableCards[i].getImage();
            }
            for (int i = 0; i < playerCards.Count; i++)
            {
                playerCardsUI[i].Image = playerCards[i].getImage();
            }
            result.Text = handChecker.getHandResult().ToString();
            overallStats.Text = stats.ToString();
        }

        private void play_Click(object sender, EventArgs e)
        {
            playGame(1);
        }

        private void play100_Click(object sender, EventArgs e)
        {
            playGame(100);
        }

        private void play10000_Click(object sender, EventArgs e)
        {
            playGame(10000);
        }

        private void resetStats_Click(object sender, EventArgs e)
        {
            stats.resetStats();
            overallStats.Text = stats.ToString();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
