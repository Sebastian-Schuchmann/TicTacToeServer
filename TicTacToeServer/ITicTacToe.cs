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
    public GameState MakeTurn(int playerId, int selectedField);
    public int[] GetField();
    public string GetFieldPretty();
}