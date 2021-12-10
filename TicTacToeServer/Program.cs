using TicTacToeServer;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

ITicTacToe? game = null;

app.MapGet("/", () => "Running!");
app.MapGet("/GetField", () => game?.GetField());

app.MapPost("/CreateGame", () => game?.StartGame());
app.MapPost("/MakeTurn", (int playerId, int selectedField) => game?.MakeTurn(playerId, selectedField));

app.Run();