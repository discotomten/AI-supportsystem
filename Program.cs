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

var tickets = TicketsData.GetTickets();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/api/tickets", () => tickets);

app.MapGet("/api/tickets/{id}", (int id) => tickets.FirstOrDefault(t => t.Id == id));
app.MapPost("/api/tickets", (TicketDto ticket) =>
{
    var handler = new TicketHandler();
    var newTicket = handler.HandleTicket(client, ticket);
    newTicket.Id = tickets.Max(t => t.Id) + 1;
    tickets.Add(newTicket);
    return Results.Created($"/api/tickets/{newTicket.Id}", newTicket);
});
app.MapPut("/api/tickets/{id}/close", (int id, TicketDto ticket) =>
{
    var existingTicket = tickets.FirstOrDefault(t => t.Id == id);
    if (existingTicket is null)
    {
        return Results.NotFound();
    }

    existingTicket.Title = ticket.Title;
    existingTicket.Description = ticket.Description;
    existingTicket.ContactInformation = ticket.ContactInformation;

    var handler = new TicketHandler();
    handler.CloseTicket(existingTicket);

    return Results.Ok(existingTicket);
});

app.MapGet("/api/tickets/open", () => tickets.Where(t => t.Status == Status.Open).ToList());

app.Run();