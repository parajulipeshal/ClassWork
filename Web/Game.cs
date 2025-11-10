using System.Timers;
using Web;

public class Game
{
    public Guid Id { get; } = Guid.NewGuid();
    public event Action? GameUpdated;
    public string? player { get; set; }

    public int TickNumber { get; set; }
    private System.Timers.Timer? tickTimer = null;
    public void DoTick(object? sender, ElapsedEventArgs e)
    {
        TickNumber++;
        //System.Console.WriteLine("Did tick: " + TickNumber);
        GameUpdated?.Invoke();
    }
    public void StartGame()
    {
    
        tickTimer = new System.Timers.Timer(1000);
        tickTimer.Elapsed += DoTick;
        tickTimer.AutoReset = true;
        tickTimer.Enabled = true;
    }
}