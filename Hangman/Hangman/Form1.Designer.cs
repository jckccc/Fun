namespace Hangman
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exit = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.playerInputLetter = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.wordManagement = new System.Windows.Forms.Button();
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.playButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guessedLetters = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(18, 605);
            this.exit.Margin = new System.Windows.Forms.Padding(9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(406, 52);
            this.exit.TabIndex = 14;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(102, 24);
            this.title.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(322, 76);
            this.title.TabIndex = 15;
            this.title.Text = "Hangman";
            // 
            // playerInputLetter
            // 
            this.playerInputLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerInputLetter.Location = new System.Drawing.Point(115, 179);
            this.playerInputLetter.Margin = new System.Windows.Forms.Padding(9);
            this.playerInputLetter.MaxLength = 1;
            this.playerInputLetter.Name = "playerInputLetter";
            this.playerInputLetter.Size = new System.Drawing.Size(292, 45);
            this.playerInputLetter.TabIndex = 16;
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(115, 242);
            this.enter.Margin = new System.Windows.Forms.Padding(9);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(300, 69);
            this.enter.TabIndex = 17;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // wordManagement
            // 
            this.wordManagement.Location = new System.Drawing.Point(18, 533);
            this.wordManagement.Margin = new System.Windows.Forms.Padding(9);
            this.wordManagement.Name = "wordManagement";
            this.wordManagement.Size = new System.Drawing.Size(406, 54);
            this.wordManagement.TabIndex = 18;
            this.wordManagement.Text = "Word Management";
            this.wordManagement.UseVisualStyleBackColor = true;
            this.wordManagement.Click += new System.EventHandler(this.wordManagement_Click);
            // 
            // wordTextBox
            // 
            this.wordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordTextBox.Location = new System.Drawing.Point(717, 572);
            this.wordTextBox.Margin = new System.Windows.Forms.Padding(9);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.ReadOnly = true;
            this.wordTextBox.Size = new System.Drawing.Size(292, 55);
            this.wordTextBox.TabIndex = 20;
            this.wordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(709, 24);
            this.playButton.Margin = new System.Windows.Forms.Padding(9);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(300, 69);
            this.playButton.TabIndex = 21;
            this.playButton.Text = "New Game!";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hangman.Properties.Resources._4;
            this.pictureBox1.Location = new System.Drawing.Point(595, 100);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 450);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // guessedLetters
            // 
            this.guessedLetters.AutoSize = true;
            this.guessedLetters.Location = new System.Drawing.Point(41, 433);
            this.guessedLetters.Name = "guessedLetters";
            this.guessedLetters.Size = new System.Drawing.Size(455, 48);
            this.guessedLetters.TabIndex = 22;
            this.guessedLetters.Text = "(Guessed Letters Here)";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1182, 675);
            this.Controls.Add(this.guessedLetters);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.wordTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.wordManagement);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.playerInputLetter);
            this.Controls.Add(this.title);
            this.Controls.Add(this.exit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox playerInputLetter;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button wordManagement;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label guessedLetters;
    }
}

