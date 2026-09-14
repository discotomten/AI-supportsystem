using AI_supportsystem;
using Azure;
using Azure.AI.TextAnalytics;
using DotNetEnv;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Env.Load();
// Eller hur det nu hämtas
string? endpoint = Environment.GetEnvironmentVariable("LANGUAGE_ENDPOINT");
string? key = Environment.GetEnvironmentVariable("LANGUAGE_KEY");

// Den viktiga biten
var client = new TextAnalyticsClient(
    new Uri(endpoint),
    new AzureKeyCredential(key)
);

var tickets = new List<Ticket>
{
    new Ticket
    {
        Id = 1,
        Title = "Aj",
        Description = "Gör ont när jag biter i folie",
        Status = Status.Open,
        Priority = Priority.High
    },
    new Ticket
    {
        Id = 2,
        Title = "Hur kan ni kalla detta för en leksak?",
        Description = "Yxan orsakar väggskador när min son slår med den mot fasaden",
        Status = Status.InProgress,
        Priority = Priority.Medium
    },
    new Ticket
    {
        Id = 3,
        Title = "Betala tillbaka!!!!!",
        Description = "Dubbel betalning för kyckling och keso på Ica Togo",
        Status = Status.Closed,
        Priority = Priority.Low
    }
};

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/api/tickets", () => tickets);

app.MapGet("/api/tickets/{id}", (int id) => tickets.FirstOrDefault(t => t.Id == id));
app.MapPost("/api/tickets", (Ticket ticket) => tickets.Add(ticket));



app.Run();