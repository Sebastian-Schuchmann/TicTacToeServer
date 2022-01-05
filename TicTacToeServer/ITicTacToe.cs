namespace TicTacToeServer;

public enum GameState
{
    InProgress,
    Draw,
    PlayerXWon,
    PlayerOWon
}

public interface ITicTacToe
{
    public void StartGame();
    
    /// <summary>
    /// Executes a move on the board after a game has been started.
    /// </summary>
    /// <param name="playerId">PlayerID is either 0 (PlayerX) or 1 (PlayerO)</param>
    /// <param name="selectedField">SelectedField is a value between 0 and 8 where 0 represents the top left field</param>
    /// <returns>Returns the GameState Enum (InProgress / Draw / PlayerXWon / PlayerOWon)</returns>
    public GameState MakeTurn(int playerId, int selectedField);
    
    /// <summary>
    /// Return the TicTacToe board as an array of integers.
    /// </summary>
    /// <returns>Elements in the array can have the following values: -1, 0, 1, where -1 means Empty and 0 / 1 represent the first/second player</returns>
    public int[] GetField();
    
    public string GetFieldPretty();
}