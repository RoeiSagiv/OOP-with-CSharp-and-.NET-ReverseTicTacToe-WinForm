using System.Windows.Forms;

namespace TicTacToeGame
{
    public class Program
    {
       public static void Main() 
       {
            Application.EnableVisualStyles();
            GameFlow ReversedTicTacToeGame = new GameFlow();
            ReversedTicTacToeGame.RunGame();
       }
    }
}
