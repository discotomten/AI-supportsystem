using Azure.AI.TextAnalytics;

namespace AI_supportsystem;

public class TicketHandler
{
    public Ticket HandleTicket(TextAnalyticsClient client, TicketDto ticketDto)
    {
        var ticket = new Ticket
        {
            Title = ticketDto.Title,
            Description = ticketDto.Description,
            ContactInformation = ticketDto.ContactInformation,
            Status = Status.Open,
            CreatedAt = DateTime.UtcNow,
        };
        
        var totalTicket = $"Title: " + ticket.Title + "Description: " + ticket.Description;

        var language = client.DetectLanguage(totalTicket);
        DocumentSentiment documentSentiment = client.AnalyzeSentiment(totalTicket, language.Value.Iso6391Name);
        ticket.Sentiment = documentSentiment.Sentiment;

        var keyPhrases = client.ExtractKeyPhrases(totalTicket, language.Value.Iso6391Name);
        foreach (var phrase in keyPhrases.Value)
        {
            ticket.Keywords.Add(new Keyword { Text = phrase });
        }
        
        GuessedPriority(ticket);

        return ticket;
    }
    
    public void CloseTicket(Ticket ticket)
    {
        ticket.Status = Status.Closed;
        ticket.ClosedAt = DateTime.UtcNow;
    }

    private void GuessedPriority(Ticket ticket)
    {
        ticket.Priority = ticket.Sentiment is TextSentiment.Negative or TextSentiment.Mixed or TextSentiment.Neutral 
            ? Priority.High 
            : Priority.Medium;
        
        foreach (var badWord in BadWords)
        {
            if (!ticket.Description.Contains(badWord, StringComparison.OrdinalIgnoreCase)) 
                continue;
            ticket.Priority = Priority.High;
            break;
        }
    }

    private readonly List<string> BadWords = new List<string>(new []{
        "äcklig",
        "matförgiftning",
        "farlig",
        "fattas",
        "idioter",
        "smakar strumpa",
        "stämningsansökan",
        "advokat",
        "vegetarisk",
        "höstrullar",
        "yuck",
        "blä",
        "kvävdes",
        "advokat",
        "stämma",
        "dyrt",
        "italiensk",
        "italien",
        "italienska",
        "italiensk mat",
        "italiensk restaurang",
        "rom",
        "latin",
        "mumie",
        "dammråttor",
    });
}