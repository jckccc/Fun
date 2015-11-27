using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Hangman
{

    // A window for managing the database. Future iterations can include deleting of words and other functions
    public partial class WordManagement : Form
    {

        private readonly String connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\WordDatabase.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;

        public WordManagement()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.wordDatabaseDataSet1);
        }

        private void WordManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wordDatabaseDataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.wordDatabaseDataSet1.Table);

        }

        private void closeWindow_Click(object sender, EventArgs e)
        {
            this.Close();
            conn.Close();
        }

        // there is a lot of room for improvements here, especially in error checking
        private void addWord_Click(object sender, EventArgs e)
        {
            String newWord = addWordTextBox.Text;
            newWord = newWord.ToLower();
            if (newWord == null ||
                newWord.Length == 0 ||
                newWord.Length >= 50)
            {
                MessageBox.Show("Please enter a valid word. ");
                
                return;
            }
            String sqlQuery = "INSERT INTO [dbo].[Table] (word) " + 
                                            "VALUES ('" + newWord + "'); ";

            String sqlQuery2 = "IF NOT EXISTS (SELECT * FROM [dbo].[Table] WHERE [dbo].[Table].word = '" + newWord + "') " +
                                                "BEGIN " +
                                                    "INSERT INTO [dbo].[Table] (word) " +
                                                    "VALUES ('" + newWord + "'); " +
                                                "END";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sqlQuery2;
            cmd.Connection = conn;

            int res = cmd.ExecuteNonQuery();

            this.tableTableAdapter.Fill(this.wordDatabaseDataSet1.Table);
        }


    }
}
