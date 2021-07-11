namespace TicTacToeGame
{
    public partial class GameSettingsBoard
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
            if(disposing && (components != null))
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
            this.labelOfPlayers = new System.Windows.Forms.Label();
            this.nameOfPlayerOne = new System.Windows.Forms.Label();
            this.textBoxOfPlayerOne = new System.Windows.Forms.TextBox();
            this.nameOfPlayerTwo = new System.Windows.Forms.CheckBox();
            this.textBoxOfPlayerTwo = new System.Windows.Forms.TextBox();
            this.labelOfBoardSize = new System.Windows.Forms.Label();
            this.labeOfRows = new System.Windows.Forms.Label();
            this.labelOfCols = new System.Windows.Forms.Label();
            this.sizeOfRows = new System.Windows.Forms.NumericUpDown();
            this.sizeOfCols = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sizeOfRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeOfCols)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOfPlayers
            // 
            this.labelOfPlayers.AutoSize = true;
            this.labelOfPlayers.Location = new System.Drawing.Point(25, 25);
            this.labelOfPlayers.Name = "labelOfPlayers";
            this.labelOfPlayers.Size = new System.Drawing.Size(59, 17);
            this.labelOfPlayers.TabIndex = 0;
            this.labelOfPlayers.Text = "Players:";
            this.labelOfPlayers.Click += new System.EventHandler(this.labelOfPlayers_Click);
            // 
            // nameOfPlayerOne
            // 
            this.nameOfPlayerOne.AutoSize = true;
            this.nameOfPlayerOne.Location = new System.Drawing.Point(38, 58);
            this.nameOfPlayerOne.Name = "nameOfPlayerOne";
            this.nameOfPlayerOne.Size = new System.Drawing.Size(64, 17);
            this.nameOfPlayerOne.TabIndex = 1;
            this.nameOfPlayerOne.Text = "Player 1:";
            this.nameOfPlayerOne.Click += new System.EventHandler(this.nameOfPlayerOne_Click);
            // 
            // textBoxOfPlayerOne
            // 
            this.textBoxOfPlayerOne.Location = new System.Drawing.Point(136, 58);
            this.textBoxOfPlayerOne.Name = "textBoxOfPlayerOne";
            this.textBoxOfPlayerOne.Size = new System.Drawing.Size(136, 22);
            this.textBoxOfPlayerOne.TabIndex = 2;
            // 
            // nameOfPlayerTwo
            // 
            this.nameOfPlayerTwo.AutoSize = true;
            this.nameOfPlayerTwo.Location = new System.Drawing.Point(41, 88);
            this.nameOfPlayerTwo.Name = "nameOfPlayerTwo";
            this.nameOfPlayerTwo.Size = new System.Drawing.Size(86, 21);
            this.nameOfPlayerTwo.TabIndex = 3;
            this.nameOfPlayerTwo.Text = "Player 2:";
            this.nameOfPlayerTwo.UseVisualStyleBackColor = true;
            this.nameOfPlayerTwo.CheckedChanged += new System.EventHandler(this.nameOfPlayerTwo_CheckedChanged);
            // 
            // textBoxOfPlayerTwo
            // 
            this.textBoxOfPlayerTwo.Enabled = false;
            this.textBoxOfPlayerTwo.Location = new System.Drawing.Point(136, 88);
            this.textBoxOfPlayerTwo.Name = "textBoxOfPlayerTwo";
            this.textBoxOfPlayerTwo.Size = new System.Drawing.Size(136, 22);
            this.textBoxOfPlayerTwo.TabIndex = 4;
            this.textBoxOfPlayerTwo.Text = "[Computer]";
            this.textBoxOfPlayerTwo.TextChanged += new System.EventHandler(this.textBoxOfPlayerTwo_TextChanged);
            // 
            // labelOfBoardSize
            // 
            this.labelOfBoardSize.AutoSize = true;
            this.labelOfBoardSize.Location = new System.Drawing.Point(25, 148);
            this.labelOfBoardSize.Name = "labelOfBoardSize";
            this.labelOfBoardSize.Size = new System.Drawing.Size(81, 17);
            this.labelOfBoardSize.TabIndex = 5;
            this.labelOfBoardSize.Text = "Board Size:";
            // 
            // labeOfRows
            // 
            this.labeOfRows.AutoSize = true;
            this.labeOfRows.Location = new System.Drawing.Point(38, 182);
            this.labeOfRows.Name = "labeOfRows";
            this.labeOfRows.Size = new System.Drawing.Size(46, 17);
            this.labeOfRows.TabIndex = 6;
            this.labeOfRows.Text = "Rows:";
            // 
            // labelOfCols
            // 
            this.labelOfCols.AutoSize = true;
            this.labelOfCols.Location = new System.Drawing.Point(168, 182);
            this.labelOfCols.Name = "labelOfCols";
            this.labelOfCols.Size = new System.Drawing.Size(39, 17);
            this.labelOfCols.TabIndex = 7;
            this.labelOfCols.Text = "Cols:";
            // 
            // sizeOfRows
            // 
            this.sizeOfRows.Location = new System.Drawing.Point(90, 180);
            this.sizeOfRows.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.sizeOfRows.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.sizeOfRows.Name = "sizeOfRows";
            this.sizeOfRows.Size = new System.Drawing.Size(40, 22);
            this.sizeOfRows.TabIndex = 8;
            this.sizeOfRows.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.sizeOfRows.ValueChanged += new System.EventHandler(this.sizeOfCols_ValueChanged);
            // 
            // sizeOfCols
            // 
            this.sizeOfCols.Location = new System.Drawing.Point(213, 177);
            this.sizeOfCols.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.sizeOfCols.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.sizeOfCols.Name = "sizeOfCols";
            this.sizeOfCols.Size = new System.Drawing.Size(40, 22);
            this.sizeOfCols.TabIndex = 9;
            this.sizeOfCols.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.sizeOfCols.ValueChanged += new System.EventHandler(this.sizeOfRows_ValueChanged);
            // 
            // startButton
            // 
            this.startButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.startButton.Location = new System.Drawing.Point(28, 229);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(244, 23);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // GameSettingsBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 275);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.sizeOfCols);
            this.Controls.Add(this.sizeOfRows);
            this.Controls.Add(this.labelOfCols);
            this.Controls.Add(this.labeOfRows);
            this.Controls.Add(this.labelOfBoardSize);
            this.Controls.Add(this.textBoxOfPlayerTwo);
            this.Controls.Add(this.nameOfPlayerTwo);
            this.Controls.Add(this.textBoxOfPlayerOne);
            this.Controls.Add(this.nameOfPlayerOne);
            this.Controls.Add(this.labelOfPlayers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GameSettingsBoard";
            this.Text = "Game Settings";
            this.Load += new System.EventHandler(this.gameSettingsBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sizeOfRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeOfCols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOfPlayers;
        private System.Windows.Forms.Label nameOfPlayerOne;
        private System.Windows.Forms.TextBox textBoxOfPlayerOne;
        private System.Windows.Forms.CheckBox nameOfPlayerTwo;
        private System.Windows.Forms.TextBox textBoxOfPlayerTwo;
        private System.Windows.Forms.Label labelOfBoardSize;
        private System.Windows.Forms.Label labeOfRows;
        private System.Windows.Forms.Label labelOfCols;
        private System.Windows.Forms.NumericUpDown sizeOfRows;
        private System.Windows.Forms.NumericUpDown sizeOfCols;
        private System.Windows.Forms.Button startButton;
    }
}