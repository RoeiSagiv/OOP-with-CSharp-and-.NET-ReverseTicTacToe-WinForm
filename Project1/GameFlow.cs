using System;

namespace TicTacToeGame
{
    public class GameFlow
    {
        private GameSettingsBoard m_GameSettings;
        private TicTacToeMisere m_GameBoard;

        internal void RunGame()
        {
            setReversedTicTacToeGame();
            this.m_GameBoard = new TicTacToeMisere(this.m_GameSettings);
            
            while(this.m_GameBoard.WantToPlayAnotherGame)
            {
               this.m_GameBoard = new TicTacToeMisere(this.m_GameSettings);
            }  
        }

        private void setReversedTicTacToeGame()
        {
            m_GameSettings = new GameSettingsBoard();
            m_GameSettings.ShowDialog();
        }
    }
}
