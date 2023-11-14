public class Solution
{
    public bool ValidTicTacToe(string[] board)
    {
        int countX = 0;
        int countO = 0;


        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[i][j] == 'X') countX++;
                else if (board[i][j] == 'O') countO++;
            }
        }

        if (countX != countO && countX != countO + 1)
        {
            return false;
        }

        // Check for a winner
        if (IsWinner(board, 3, 'X') && IsWinner(board, 3, 'O'))
        {
            return false;
        }

        if (IsWinner(board, 3, 'X') && countX <= countO)
        {
            return false;
        }

        if (IsWinner(board, 3, 'O') && countX != countO)
        {
            return false;
        }

        return true;
    }

    static bool IsWinner(string[] board, int N, char player)
    {
        
        for (int i = 0; i < N; i++)
        {
            if (board[i][0] == player && board[i][1] == player && board[i][2] == player) return true;
            if (board[0][i] == player && board[1][i] == player && board[2][i] == player) return true;
        }

       
        if (board[0][0] == player && board[1][1] == player && board[2][2] == player) return true; 
        if (board[0][2] == player && board[1][1] == player && board[2][0] == player) return true;

        return false;
    }

}
