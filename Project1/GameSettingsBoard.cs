using System;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class GameSettingsBoard : Form
    {
        public GameSettingsBoard()
        {
            InitializeComponent();
        }

        internal string NameOfFirstPlayer 
        {
            get 
            {
                return this.nameOfPlayerOne.Text;
            }
        }

        internal string NameOfSecondPlayer
        {
            get
            {
                return this.nameOfPlayerTwo.Text;
            }
        }

        internal string TextBoxOfPlayerOne
        {
            get
            {
                return this.textBoxOfPlayerOne.Text;
            }
        }

        internal string TextBoxOfPlayerTwo
        {
            get
            {
                return this.textBoxOfPlayerTwo.Text;
            }
        }

        internal int RowsSize
        {
            get
            {
                return (int)this.sizeOfRows.Value;
            }
        }

        internal int ColsSize
        {
            get
            {
                return (int)this.sizeOfCols.Value;
            }
        }

        private void gameSettingsBoard_Load(object sender, EventArgs e)
        {
        }

        private void labelOfPlayers_Click(object sender, EventArgs e)
        {  
        }

        private void nameOfPlayerTwo_CheckedChanged(object sender, EventArgs e)
        {
            if(nameOfPlayerTwo.Checked)
            {
                textBoxOfPlayerTwo.Text = string.Empty;
                textBoxOfPlayerTwo.Enabled = true;
            }
            else
            {
                textBoxOfPlayerTwo.Text = "[Computer]";
                textBoxOfPlayerTwo.Enabled = false;
            }
        }

        private void textBoxOfPlayerTwo_TextChanged(object sender, EventArgs e)
        {
        }

        private void nameOfPlayerOne_Click(object sender, EventArgs e)
        {
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sizeOfCols_ValueChanged(object sender, EventArgs e)
        {
            sizeOfCols.Value = sizeOfRows.Value;
        }

        private void sizeOfRows_ValueChanged(object sender, EventArgs e)
        {
            sizeOfRows.Value = sizeOfCols.Value;
        }
    }
}
