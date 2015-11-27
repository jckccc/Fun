using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    // game flow happens here, mainly when user clicks on buttons
    public partial class Form1 : Form
    {

        Game g;

        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void wordManagement_Click(object sender, EventArgs e)
        {
            WordManagement wm = new WordManagement();
            wm.Show();
        }

        // also resets the game
        private void playButton_Click(object sender, EventArgs e)
        {
            newGame();
        }

        // what happens when a player guesses letters
        private void enter_Click(object sender, EventArgs e)
        {
            if (g != null)
            {
                guessLetter();
                changeImage();
                victoryCondition();
                defeatCondition();
            }
        }

        private void newGame()
        {
            g = new Game();
            enter.Enabled = true;
            wordTextBox.Text = g.getDefaultUserGuessedWord();
            guessedLetters.Text = "";
            pictureBox1.Image = (Image)Hangman.Properties.Resources.ResourceManager.GetObject("_0");
        }

        private void guessLetter()
        {
            String guessedLetter = playerInputLetter.Text;
            if (guessedLetters.Text.ToLower().Contains(guessedLetter))
            {
                MessageBox.Show("You have already guessed this letter");
            }
            else
            {
                guessedLetters.Text += guessedLetter.ToUpper();
                g.guessLetter(guessedLetter);
                wordTextBox.Text = g.getUserGuessedWord();
            }
        }

        private void victoryCondition()
        {
            if (g.victory())
            {
                MessageBox.Show("Congratulations! You solved it!");
                enter.Enabled = false;
            }
        }

        private void changeImage()
        {
            pictureBox1.Image = g.getCurrentImage();
        }

        private void defeatCondition()
        {
            if (!g.isAlive())
            {
                MessageBox.Show("Hangman is sad. The word was: " + g.getWord());
            }
        }

    }
}
