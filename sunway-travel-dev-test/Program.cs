using sunway_travel_dev_test.Services;

var builder = WebApplication.CreateBuilder(args);

// Path to the hotels.json file
var jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "hotels.json");

// Register DataLoader as a singleton
builder.Services.AddSingleton(new DataLoader(jsonFilePath));
builder.Services.AddControllers();

var app = builder.Build();

app.UseRouting();
app.MapControllers(); // Map attribute-based controllers

app.Run();