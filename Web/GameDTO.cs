public class GameDTO
{
    public Guid Id { get; set; }
    public bool GameIsRunning { get; set; }
    public string Player1 { get; set; }
    public string Player2 { get; set; }
    public int TickNumber { get; set; }
    public static GameDTO GameToDTO(Game game)
    {
        return new GameDTO()
        {
            Id = game.Id,
            GameIsRunning = game.GameIsRunning,
            Player1 = game.Player1,
            Player2 = game.Player2,
        };
    }
    public Game ToGame()
    {
        Game newgame = new Game()
        {
            Id = Id,
            Player1 = Player1,
            Player2 = Player2,
            TickNumber = TickNumber,

        };
        if (GameIsRunning)
            newgame.StartGame();
        return new Game();

    }
}