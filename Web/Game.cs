using System.Timers;
using Web;

public record Game
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public event Action? GameUpdated;
    public bool GameIsRunning
    {
        get => tickTimer != null;
    }
    public string? player { get; set; }
    public string Player1 { get; set; }
    public string Player2 { get; set; }

    public int TickNumber { get; set; }
    private System.Timers.Timer? tickTimer = null;
    public void DoTick(object? sender, ElapsedEventArgs e)
    {
        TickNumber++;
        GameUpdated?.Invoke();
    }

    public void StartGame()
    {

        tickTimer = new System.Timers.Timer(1000);
        tickTimer.Elapsed += DoTick;
        tickTimer.AutoReset = true;
        tickTimer.Enabled = true;
    }
    public void StopGame()
    {
        if (tickTimer != null)
        {
            tickTimer.Enabled = false;
            Console.WriteLine("Game stopped.");
        }
    }
}