using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace Hangman
{
    // Class saves game information and contains methods used by form1 to control the game
    class Game
    {

        private readonly String connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\WordDatabase.mdf;Integrated Security=True;Connect Timeout=30";
        String currentWord;
        String userGuessedWord;
        int livesLeft;

        public Game()
        {
            newGame();
        }

        private void newGame()
        {
            setCurrentWord();
            livesLeft = 7;
            userGuessedWord = getDefaultUserGuessedWord();
        }

        // pulls a random word from the db and sets it to the currentWord variable
        private void setCurrentWord()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            String sqlQuery = "SELECT TOP 1 word FROM [dbo].[Table] " +
                                            "ORDER BY NEWID() ";

            // String sqlQuery2 = "SELECT COUNT(word) FROM [dbo].[Table] "; // for testing purposes

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sqlQuery;
            cmd.Connection = conn;

            String res = cmd.ExecuteScalar() + "";
            currentWord = res.ToString().Trim();

            conn.Close();
        }

        public int numChars()
        {
            return currentWord.Length;
        }

        public String getDefaultUserGuessedWord()
        {
            String res = "";
            for (int i = 0; i < numChars(); i++)
                res += "-";
            return res;
        }

        public String getWord()
        {
            return currentWord;
        }

        public String getUserGuessedWord()
        {
            return userGuessedWord;
        }

        public bool isAlive()
        {
            return livesLeft > 0;
        }

        public bool victory()
        {
            return !userGuessedWord.Contains("-");
        }

        public Image getCurrentImage()
        {
            return (Image)Hangman.Properties.Resources.ResourceManager.GetObject("_" + (7-livesLeft) + "");
        }

        public void guessLetter(String letter)
        {
   
            if (currentWord.Contains(letter))
            {
                List<Int32> characterIndexes = new List<Int32>();
                int currentIndex = -1;
                do
                {
                    currentIndex = currentWord.IndexOf(letter, currentIndex+1);
                    if (currentIndex > -1)
                    {
                        characterIndexes.Add(currentIndex);
                    }
                }
                while (currentIndex > -1);

                fixUserGuessedWord(characterIndexes, letter);
            }
            else
            {
                livesLeft--;
            }

        }

        private void fixUserGuessedWord(List<Int32> indexes, String letter) {
            foreach (Int32 i in indexes)
            {
                String front = userGuessedWord.Remove(i);
                String back = userGuessedWord.Substring(i+1);
                userGuessedWord = front + letter + back;
            }
        }


    }
}
