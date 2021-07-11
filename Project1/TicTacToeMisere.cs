using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class TicTacToeMisere : Form
    {
        private const int k_SymbolButtonMargin = 10;
        private const int k_SymbolButtonHeight = 50;
        private const int k_SymbolButtonWidth = 45;
        private const int k_NumberOfPlayers = 2;
        private static Game m_ReversedTicTacToeGame;
        private static Player[] m_PlayersOfTheGame;
        private static Player m_CurrentPlayer;
        private static ComputerLogic m_CompLogic;
        private static int[] m_IndexPositionOfSymbolCompLogic;
        private static int[] m_IndexPositionOfSymbol;
        private PositionOfSymbol[,] m_PositionOfSymbolButtons;
        private bool m_WantToPlayAnotherGame;
        private Label labelPlayerOne;
        private Label labelPlayerTwo;
        private Label scoreOfPlayerOneLabel;
        private Label scoreOfPlayerTwoLabel;

        public bool WantToPlayAnotherGame
        {
            get
            {
                return m_WantToPlayAnotherGame;
            }

            set
            {
                m_WantToPlayAnotherGame = value;
            }
        }

        public TicTacToeMisere(GameSettingsBoard i_GameSettingsFromForm)
        {
            m_WantToPlayAnotherGame = false;
            InitGame(i_GameSettingsFromForm);
            m_CurrentPlayer = m_PlayersOfTheGame[0];
            InitializeComponent();

            if(i_GameSettingsFromForm.TextBoxOfPlayerOne == string.Empty)
            {
                Environment.Exit(0);
            }
            else
            {
                this.ShowDialog();
            } 
        }

        private static Player[] InitPlayers(GameSettingsBoard i_GameSettingsFromForm)
        {
            Player[] ticTacToePlayers = new Player[k_NumberOfPlayers];
            Player firstPlayer = new Player(i_GameSettingsFromForm.TextBoxOfPlayerOne);
            ticTacToePlayers[0] = firstPlayer;
            if(i_GameSettingsFromForm.NameOfSecondPlayer != "[Computer]")
            {
                Player secondPlayer = new Player(i_GameSettingsFromForm.TextBoxOfPlayerTwo);
                secondPlayer.PlayerSymbol = 'O';
                ticTacToePlayers[1] = secondPlayer;
            }
            else
            {
                Player computerPlayer = new Player();
                ticTacToePlayers[1] = computerPlayer;
            }

            return ticTacToePlayers;
        }

        private static Player ChangeTurn(Player i_PlayerPlayingNow)
        {
            Player playerPlayingNow = i_PlayerPlayingNow;
            if(playerPlayingNow.NameOfPlayer == m_PlayersOfTheGame[0].NameOfPlayer)
            {
                playerPlayingNow = m_PlayersOfTheGame[1];
            }
            else
            {
                playerPlayingNow = m_PlayersOfTheGame[0];
            }

            return playerPlayingNow;
        }

        private void labelPlayerTwo_Click(object sender, EventArgs e)
        {
        }

        private void positionOfSymbol_Click(object sender, EventArgs e)
        {
            PositionOfSymbol currentPosition = new PositionOfSymbol((sender as PositionOfSymbol).PositionofTheSymbol[0], (sender as PositionOfSymbol).PositionofTheSymbol[1]);
            m_IndexPositionOfSymbol[0] = currentPosition.PositionofTheSymbol[0] + 1;
            m_IndexPositionOfSymbol[1] = currentPosition.PositionofTheSymbol[1] + 1;
            PlayTurn();

            (sender as PositionOfSymbol).Text = m_CurrentPlayer.PlayerSymbol.ToString();
            (sender as PositionOfSymbol).Enabled = false;
             
            if (m_ReversedTicTacToeGame.TicTacToeBoard.CheckIfMatrixFull() || m_ReversedTicTacToeGame.TicTacToeBoard.CheckIfSequence() == "X" || m_ReversedTicTacToeGame.TicTacToeBoard.CheckIfSequence() == "O")
            {
                EndGame();
            }
            else if(m_CurrentPlayer.NameOfPlayer != "[Computer]")
            {
                m_CurrentPlayer = ChangeTurn(m_CurrentPlayer);
                PlayTurn();
                if(m_ReversedTicTacToeGame.TicTacToeBoard.CheckIfMatrixFull() || m_ReversedTicTacToeGame.TicTacToeBoard.CheckIfSequence() == "X" || m_ReversedTicTacToeGame.TicTacToeBoard.CheckIfSequence() == "O")
                {
                    EndGame();
                }
            }
            else 
            {
                m_CurrentPlayer = ChangeTurn(m_CurrentPlayer);
            }
        }

        internal void InitGame(GameSettingsBoard i_GameSettingsFromForm)
        {
            if(m_WantToPlayAnotherGame == false)
            {
                m_PlayersOfTheGame = InitPlayers(i_GameSettingsFromForm);
            }
            else
            {
                updatePlayersNameAndScore();
            }

            int sizeOfSquareBoard = i_GameSettingsFromForm.RowsSize;
            m_ReversedTicTacToeGame = new Game(sizeOfSquareBoard, m_PlayersOfTheGame);
            m_PositionOfSymbolButtons = new PositionOfSymbol[i_GameSettingsFromForm.RowsSize, i_GameSettingsFromForm.ColsSize];
            RunGame();
        }

        private void RunGame()
        {
            m_IndexPositionOfSymbol = new int[2];
            m_IndexPositionOfSymbol[0] = 1;
            m_IndexPositionOfSymbol[1] = 1;
            m_IndexPositionOfSymbolCompLogic = new int[2];
        }

        private void EndGame()
        {
            StringBuilder endGameMsg = new StringBuilder();
            DialogResult dialogResult;

            if(m_ReversedTicTacToeGame.TicTacToeBoard.CheckIfSequence() == "X")
            {
                m_PlayersOfTheGame[1].ScoreOfPlayer++;
                updatePlayersNameAndScore();
                endGameMsg.Append(string.Format("The Winner is: {0}!{1}Would you like to play another round?", m_PlayersOfTheGame[1].NameOfPlayer, Environment.NewLine));
                dialogResult = MessageBox.Show(endGameMsg.ToString(), "A Win!", MessageBoxButtons.YesNo);
                PlayAnotherGame(dialogResult);
            }
            else if(m_ReversedTicTacToeGame.TicTacToeBoard.CheckIfSequence() == "O")
            {
                m_PlayersOfTheGame[0].ScoreOfPlayer++;
                updatePlayersNameAndScore();
                endGameMsg.Append(string.Format("The Winner is: {0}!{1}Would you like to play another round?", m_PlayersOfTheGame[0].NameOfPlayer, Environment.NewLine));
                dialogResult = MessageBox.Show(endGameMsg.ToString(), "A Win!", MessageBoxButtons.YesNo);
                PlayAnotherGame(dialogResult);
            }
            else if(m_ReversedTicTacToeGame.TicTacToeBoard.CheckIfMatrixFull())
            {
                endGameMsg.Append(string.Format("Tie!{0} Would you like to play another round?", Environment.NewLine));
                dialogResult = MessageBox.Show(endGameMsg.ToString(), "A Tie!", MessageBoxButtons.YesNo);
                PlayAnotherGame(dialogResult);
            }
        }

        private void PlayAnotherGame(DialogResult dialogResult)
        {
            if(dialogResult == DialogResult.Yes)
            {
                setNewRound();
                m_WantToPlayAnotherGame = true;
            }
            else if(dialogResult == DialogResult.No)
            {
                this.Close();
                Environment.Exit(0);
            }
        }

        private void setNewRound() 
        {
            m_ReversedTicTacToeGame.TicTacToeBoard.ClearTicTacToeBoard();
            
            for(int i = 0; i < this.m_PositionOfSymbolButtons.GetLength(0); i++)
            {
                for(int j = 0; j < this.m_PositionOfSymbolButtons.GetLength(1); j++)
                {
                    if(m_PositionOfSymbolButtons[i, j].Text != string.Empty) 
                    {
                        m_PositionOfSymbolButtons[i, j].PlayerSymbol = ' ';
                        m_PositionOfSymbolButtons[i, j].Text = string.Empty;
                        m_PositionOfSymbolButtons[i, j].Enabled = true;
                    }
                }
            }

            m_CurrentPlayer = m_PlayersOfTheGame[0];
        }

        private void PlayTurn()
        {
            int[] positionSymbol;
            int playerChoosenRow = 0;
            int playerChoosenColumn = 0;

            if(m_CurrentPlayer.NameOfPlayer != "[Computer]")
            { 
                boldCurrentPlayerName();
            }

            if(m_CurrentPlayer.NameOfPlayer == "[Computer]")
            {
                m_CompLogic = new ComputerLogic();
                positionSymbol = m_CompLogic.ChooseRandomCell(m_ReversedTicTacToeGame);
                m_IndexPositionOfSymbolCompLogic = positionSymbol;
                for(int i = 1; i <= this.m_PositionOfSymbolButtons.GetLength(0); i++)
                {
                    for(int j = 1; j <= this.m_PositionOfSymbolButtons.GetLength(1); j++)
                    {
                        if(positionSymbol[0] == i && positionSymbol[1] == j)
                        {
                            m_PositionOfSymbolButtons[i - 1, j - 1].Text = m_CurrentPlayer.PlayerSymbol.ToString();
                            m_PositionOfSymbolButtons[i - 1, j - 1].Enabled = false;
                            playerChoosenRow = positionSymbol[0];
                            playerChoosenColumn = positionSymbol[1];
                            m_ReversedTicTacToeGame.TicTacToeBoard.EnterNewSymbolToMatrix(m_CurrentPlayer, playerChoosenRow, playerChoosenColumn);
                            m_CurrentPlayer = ChangeTurn(m_CurrentPlayer);
                            break;
                        }
                    }
                } 
            }
            else
            {
                positionSymbol = m_IndexPositionOfSymbol;
                playerChoosenRow = positionSymbol[0];
                playerChoosenColumn = positionSymbol[1];
                m_ReversedTicTacToeGame.TicTacToeBoard.EnterNewSymbolToMatrix(m_CurrentPlayer, playerChoosenRow, playerChoosenColumn );
            }
        }

        private void TicTacToeMisere_Load(object sender, EventArgs e)
        {
            setGameBoardStartPosition();
            InitializeSymbolButtons();
            setGameBoardSize();
            updatePlayersNameAndScore();
        }

        private void setGameBoardStartPosition()
        {
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Left = 10;
            this.Top = 10;
        }

        private void InitializeSymbolButtons()
        {
            PositionOfSymbol newPositionOfSymbolButton;
            int topMarginSymbolButton = k_SymbolButtonMargin;
            int leftMarginSymbolButton = k_SymbolButtonMargin;

            for(int i = 0; i < this.m_PositionOfSymbolButtons.GetLength(0); i++)
            {
                for(int j = 0; j < this.m_PositionOfSymbolButtons.GetLength(1); j++)
                {
                    newPositionOfSymbolButton = new PositionOfSymbol(i, j);
                    newPositionOfSymbolButton.Click += positionOfSymbol_Click;
                    newPositionOfSymbolButton.TabStop = false;
                    newPositionOfSymbolButton.Width = k_SymbolButtonWidth;
                    newPositionOfSymbolButton.Height = k_SymbolButtonHeight;
                    newPositionOfSymbolButton.Top = topMarginSymbolButton;
                    newPositionOfSymbolButton.Left = leftMarginSymbolButton;
                    m_PositionOfSymbolButtons[i, j] = newPositionOfSymbolButton;
                    this.Controls.Add(newPositionOfSymbolButton);
                    leftMarginSymbolButton += k_SymbolButtonMargin + k_SymbolButtonWidth;
                }

                leftMarginSymbolButton = k_SymbolButtonMargin;
                topMarginSymbolButton += k_SymbolButtonMargin + k_SymbolButtonHeight;
                setPositionStatusOfTheGame();
            }
        }

        private void setGameBoardSize()
        {
            this.Width = (this.m_PositionOfSymbolButtons.GetLength(1) * k_SymbolButtonWidth) + ((this.m_PositionOfSymbolButtons.GetLength(1) + 3) * k_SymbolButtonMargin);
            this.Height = (this.m_PositionOfSymbolButtons.GetLength(0) * k_SymbolButtonHeight) + ((this.m_PositionOfSymbolButtons.GetLength(0) + 8) * k_SymbolButtonMargin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void setPositionStatusOfTheGame()
        {
            int labelOneHeight = (this.m_PositionOfSymbolButtons.GetLength(0) * k_SymbolButtonHeight) + (this.m_PositionOfSymbolButtons.GetLength(0) * k_SymbolButtonMargin) + 3;
            int labelOneWidth = ((this.m_PositionOfSymbolButtons.GetLength(1) * k_SymbolButtonWidth) + (this.m_PositionOfSymbolButtons.GetLength(1) * k_SymbolButtonMargin) - 60 - labelPlayerOne.Size.Width) / 2;
            labelPlayerOne.Location = new Point(labelOneWidth, labelOneHeight);
            scoreOfPlayerOneLabel.Location = new Point(labelOneWidth + labelPlayerOne.Size.Width, labelOneHeight);
            labelPlayerTwo.Location = new Point(labelOneWidth + labelPlayerOne.Size.Width + 10, labelOneHeight);
            scoreOfPlayerTwoLabel.Location = new Point(labelOneWidth + labelPlayerOne.Size.Width + labelPlayerTwo.Size.Width + 5, labelOneHeight);
        }

        private void updatePlayersNameAndScore()
        {
            this.labelPlayerOne.Text = m_PlayersOfTheGame[0].NameOfPlayer.ToString() + ":";
            if(m_PlayersOfTheGame[1].NameOfPlayer == "[Computer]")
            {
                this.labelPlayerTwo.Text = "Computer" + ":";
            }
            else
            {
                this.labelPlayerTwo.Text = m_PlayersOfTheGame[1].NameOfPlayer.ToString() + ":";
            }

            this.scoreOfPlayerOneLabel.Text = m_PlayersOfTheGame[0].ScoreOfPlayer.ToString();
            this.scoreOfPlayerTwoLabel.Text = m_PlayersOfTheGame[1].ScoreOfPlayer.ToString();
        }

        private void boldCurrentPlayerName()
        {
            if(m_CurrentPlayer == m_PlayersOfTheGame[0])
            {
                labelPlayerOne.Font = new Font(Label.DefaultFont, FontStyle.Bold);
                scoreOfPlayerOneLabel.Font = new Font(Label.DefaultFont, FontStyle.Bold);
                labelPlayerTwo.Font = new Font(Label.DefaultFont, FontStyle.Regular);
                scoreOfPlayerTwoLabel.Font = new Font(Label.DefaultFont, FontStyle.Regular);
            }
            else
            {
                labelPlayerTwo.Font = new Font(Label.DefaultFont, FontStyle.Bold);
                scoreOfPlayerTwoLabel.Font = new Font(Label.DefaultFont, FontStyle.Bold);
                labelPlayerOne.Font = new Font(Label.DefaultFont, FontStyle.Regular);
                scoreOfPlayerOneLabel.Font = new Font(Label.DefaultFont, FontStyle.Regular);
            } 
        }
    }
}
