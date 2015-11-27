namespace Hangman
{
    partial class WordManagement
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
            this.components = new System.ComponentModel.Container();
            this.wordDatabaseDataSet1 = new Hangman.WordDatabaseDataSet1();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new Hangman.WordDatabaseDataSet1TableAdapters.TableTableAdapter();
            this.tableAdapterManager = new Hangman.WordDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeWindow = new System.Windows.Forms.Button();
            this.addWord = new System.Windows.Forms.Button();
            this.addWordTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.wordDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // wordDatabaseDataSet1
            // 
            this.wordDatabaseDataSet1.DataSetName = "WordDatabaseDataSet1";
            this.wordDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.wordDatabaseDataSet1;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Hangman.WordDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.AllowUserToAddRows = false;
            this.tableDataGridView.AllowUserToDeleteRows = false;
            this.tableDataGridView.AutoGenerateColumns = false;
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.tableDataGridView.DataSource = this.tableBindingSource;
            this.tableDataGridView.Location = new System.Drawing.Point(21, 12);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.ReadOnly = true;
            this.tableDataGridView.RowTemplate.Height = 24;
            this.tableDataGridView.Size = new System.Drawing.Size(198, 451);
            this.tableDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "word";
            this.dataGridViewTextBoxColumn2.HeaderText = "word";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // closeWindow
            // 
            this.closeWindow.Location = new System.Drawing.Point(38, 564);
            this.closeWindow.Name = "closeWindow";
            this.closeWindow.Size = new System.Drawing.Size(156, 23);
            this.closeWindow.TabIndex = 15;
            this.closeWindow.Text = "Close Window";
            this.closeWindow.UseVisualStyleBackColor = true;
            this.closeWindow.Click += new System.EventHandler(this.closeWindow_Click);
            // 
            // addWord
            // 
            this.addWord.Location = new System.Drawing.Point(38, 508);
            this.addWord.Name = "addWord";
            this.addWord.Size = new System.Drawing.Size(156, 23);
            this.addWord.TabIndex = 16;
            this.addWord.Text = "Add Word";
            this.addWord.UseVisualStyleBackColor = true;
            this.addWord.Click += new System.EventHandler(this.addWord_Click);
            // 
            // addWordTextBox
            // 
            this.addWordTextBox.Location = new System.Drawing.Point(12, 480);
            this.addWordTextBox.MaxLength = 50;
            this.addWordTextBox.Name = "addWordTextBox";
            this.addWordTextBox.Size = new System.Drawing.Size(216, 22);
            this.addWordTextBox.TabIndex = 17;
            // 
            // WordManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 599);
            this.Controls.Add(this.addWordTextBox);
            this.Controls.Add(this.addWord);
            this.Controls.Add(this.closeWindow);
            this.Controls.Add(this.tableDataGridView);
            this.Name = "WordManagement";
            this.Text = "WordManagement";
            this.Load += new System.EventHandler(this.WordManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wordDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WordDatabaseDataSet1 wordDatabaseDataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private WordDatabaseDataSet1TableAdapters.TableTableAdapter tableTableAdapter;
        private WordDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tableDataGridView;
        public System.Windows.Forms.Button closeWindow;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        public System.Windows.Forms.Button addWord;
        private System.Windows.Forms.TextBox addWordTextBox;
    }
}