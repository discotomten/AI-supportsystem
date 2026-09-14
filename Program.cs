using AI_supportsystem;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var tickets = new List<Ticket>
{
    new Ticket { Id = 1, Title = "Ticket 1", Description = "Description for Ticket 1" },
    new Ticket { Id = 2, Title = "Ticket 2", Description = "Description for Ticket 2" },
    new Ticket { Id = 3, Title = "Ticket 3", Description = "Description for Ticket 3" }
};

app.MapGet("/", () => "Hello World!");
app.MapGet("/api/tickets", () =>
{
    return tickets;
});

app.Run();
