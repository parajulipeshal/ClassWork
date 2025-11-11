// using Web.Components;

// var builder = WebApplication.CreateBuilder(args);

// // Add services to the container.
// builder.Services.AddRazorComponents()
//     .AddInteractiveServerComponents();

// var app = builder.Build();

// // Configure the HTTP request pipeline.
// if (!app.Environment.IsDevelopment())
// {
//     app.UseExceptionHandler("/Error", createScopeForErrors: true);
//     // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//     app.UseHsts();
// }

// app.UseHttpsRedirection();


// app.UseAntiforgery();

// app.MapStaticAssets();
// app.MapRazorComponents<App>()
//     .AddInteractiveServerRenderMode();

// app.Run();

using System.Text.Json;

Game game = new Game();
await Task.Delay(3000);
System.Console.WriteLine("Writing and reading FS");
//get a string version of the Game;

string gameJson = JsonSerializer.Serialize(GameDTO.GameToDTO(game));
System.Console.WriteLine(gameJson);
File.WriteAllText("game.json", gameJson);
GameDTO copyofGame = JsonSerializer.Deserialize<GameDTO>(gameJson);
Game restoredGame = copyofGame.ToGame();
System.Console.WriteLine(restoredGame);


