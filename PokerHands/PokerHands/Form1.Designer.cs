namespace PokerHands
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
            this.table1 = new System.Windows.Forms.PictureBox();
            this.table2 = new System.Windows.Forms.PictureBox();
            this.table3 = new System.Windows.Forms.PictureBox();
            this.table4 = new System.Windows.Forms.PictureBox();
            this.table5 = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.play = new System.Windows.Forms.Button();
            this.play10000 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.currentResult = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.overallStats = new System.Windows.Forms.Label();
            this.resetStats = new System.Windows.Forms.Button();
            this.play100 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            this.SuspendLayout();
            // 
            // table1
            // 
            this.table1.Location = new System.Drawing.Point(184, 150);
            this.table1.Name = "table1";
            this.table1.Size = new System.Drawing.Size(73, 97);
            this.table1.TabIndex = 0;
            this.table1.TabStop = false;
            // 
            // table2
            // 
            this.table2.Location = new System.Drawing.Point(297, 150);
            this.table2.Name = "table2";
            this.table2.Size = new System.Drawing.Size(73, 97);
            this.table2.TabIndex = 1;
            this.table2.TabStop = false;
            // 
            // table3
            // 
            this.table3.Location = new System.Drawing.Point(411, 150);
            this.table3.Name = "table3";
            this.table3.Size = new System.Drawing.Size(73, 97);
            this.table3.TabIndex = 2;
            this.table3.TabStop = false;
            // 
            // table4
            // 
            this.table4.Location = new System.Drawing.Point(524, 150);
            this.table4.Name = "table4";
            this.table4.Size = new System.Drawing.Size(73, 97);
            this.table4.TabIndex = 3;
            this.table4.TabStop = false;
            // 
            // table5
            // 
            this.table5.Location = new System.Drawing.Point(636, 150);
            this.table5.Name = "table5";
            this.table5.Size = new System.Drawing.Size(73, 97);
            this.table5.TabIndex = 4;
            this.table5.TabStop = false;
            // 
            // player1
            // 
            this.player1.Location = new System.Drawing.Point(826, 150);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(73, 97);
            this.player1.TabIndex = 5;
            this.player1.TabStop = false;
            // 
            // player2
            // 
            this.player2.Location = new System.Drawing.Point(938, 150);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(73, 97);
            this.player2.TabIndex = 6;
            this.player2.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(492, 53);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(90, 17);
            this.title.TabIndex = 7;
            this.title.Text = "Poker Hands";
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(161, 414);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(100, 23);
            this.play.TabIndex = 8;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // play10000
            // 
            this.play10000.Location = new System.Drawing.Point(161, 529);
            this.play10000.Name = "play10000";
            this.play10000.Size = new System.Drawing.Size(100, 23);
            this.play10000.TabIndex = 10;
            this.play10000.Text = "Play x 10000";
            this.play10000.UseVisualStyleBackColor = true;
            this.play10000.Click += new System.EventHandler(this.play10000_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(385, 476);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 17);
            this.result.TabIndex = 11;
            // 
            // currentResult
            // 
            this.currentResult.AutoSize = true;
            this.currentResult.Location = new System.Drawing.Point(385, 414);
            this.currentResult.Name = "currentResult";
            this.currentResult.Size = new System.Drawing.Size(99, 17);
            this.currentResult.TabIndex = 12;
            this.currentResult.Text = "Current Result";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(161, 586);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 23);
            this.exit.TabIndex = 13;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // overallStats
            // 
            this.overallStats.AutoSize = true;
            this.overallStats.Location = new System.Drawing.Point(908, 414);
            this.overallStats.Name = "overallStats";
            this.overallStats.Size = new System.Drawing.Size(89, 17);
            this.overallStats.TabIndex = 14;
            this.overallStats.Text = "Overall Stats";
            // 
            // resetStats
            // 
            this.resetStats.Location = new System.Drawing.Point(911, 629);
            this.resetStats.Name = "resetStats";
            this.resetStats.Size = new System.Drawing.Size(75, 23);
            this.resetStats.TabIndex = 15;
            this.resetStats.Text = "Reset Stats";
            this.resetStats.UseVisualStyleBackColor = true;
            this.resetStats.Click += new System.EventHandler(this.resetStats_Click);
            // 
            // play100
            // 
            this.play100.Location = new System.Drawing.Point(161, 472);
            this.play100.Name = "play100";
            this.play100.Size = new System.Drawing.Size(100, 23);
            this.play100.TabIndex = 16;
            this.play100.Text = "Play x 100";
            this.play100.UseVisualStyleBackColor = true;
            this.play100.Click += new System.EventHandler(this.play100_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 675);
            this.Controls.Add(this.play100);
            this.Controls.Add(this.resetStats);
            this.Controls.Add(this.overallStats);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.currentResult);
            this.Controls.Add(this.result);
            this.Controls.Add(this.play10000);
            this.Controls.Add(this.play);
            this.Controls.Add(this.title);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.table5);
            this.Controls.Add(this.table4);
            this.Controls.Add(this.table3);
            this.Controls.Add(this.table2);
            this.Controls.Add(this.table1);
            this.Name = "Form1";
            this.Text = "Poker Hands";
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox table1;
        private System.Windows.Forms.PictureBox table2;
        private System.Windows.Forms.PictureBox table3;
        private System.Windows.Forms.PictureBox table4;
        private System.Windows.Forms.PictureBox table5;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button play10000;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label currentResult;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label overallStats;
        private System.Windows.Forms.Button resetStats;
        private System.Windows.Forms.Button play100;

    }
}

