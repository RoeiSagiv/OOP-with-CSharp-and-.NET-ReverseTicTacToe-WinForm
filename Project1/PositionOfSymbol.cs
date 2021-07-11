using System.Windows.Forms;

namespace TicTacToeGame
{
    public class PositionOfSymbol : Button
    {
        private int[] m_PositionOfTheSymbol;
        private char m_PlayerSymbol;

        public PositionOfSymbol(int i_X, int i_Y) : base()
        {
            m_PositionOfTheSymbol = new int[2];
            m_PositionOfTheSymbol[0] = i_X;
            m_PositionOfTheSymbol[1] = i_Y;
            m_PlayerSymbol = ' ';
        }

        public int[] PositionofTheSymbol
        {
            get
            {
                return m_PositionOfTheSymbol;
            }
        }

        public char PlayerSymbol
        {
            get
            {
                return m_PlayerSymbol;
            }

            set
            {
                m_PlayerSymbol = value;
            }
        }
    }
}
