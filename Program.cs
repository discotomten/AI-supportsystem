using AI_supportsystem;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var tickets = new List<Ticket>
{
    new Ticket { Id = 1, Title = "Aj", Description = "Gör ont när jag biter i folie", Status = "Open" },
    new Ticket { Id = 2, Title = "Hur kan ni kalla detta för en leksak?", Description = "Yxan orsakar väggskador när min son slår med den mot fasaden", Status = "In Progress" },
    new Ticket { Id = 3, Title = "Betala tillbaka!!!!!", Description = "Dubbel betalning för kyckling och keso på Ica Togo", Status = "Closed" }
};

app.MapGet("/", () => "Hello World!");
app.MapGet("/api/tickets", () => tickets);

app.MapGet("/api/tickets/{id}", (int id) => tickets.FirstOrDefault(t => t.Id == id));
app.MapPost("/api/tickets", (Ticket ticket) => tickets.Add(ticket));

app.Run();
