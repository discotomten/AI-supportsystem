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

        var language = client.DetectLanguage(ticket.Description);
        DocumentSentiment documentSentiment = client.AnalyzeSentiment(ticket.Description, language.Value.Iso6391Name);
        ticket.Sentiment = documentSentiment.Sentiment switch
        {
            TextSentiment.Positive => Sentiment.Positive,
            TextSentiment.Neutral => Sentiment.Neutral,
            TextSentiment.Negative => Sentiment.Negative,
            TextSentiment.Mixed => Sentiment.Mixed,
            _ => ticket.Sentiment
        };

        var keyPhrases = client.ExtractKeyPhrases(ticket.Description, language.Value.Iso6391Name);
        foreach (var phrase in keyPhrases.Value)
        {
            ticket.Keywords.Add(new Keyword { Text = phrase });
        }

        return ticket;
    }
    
    public void CloseTicket(Ticket ticket)
    {
        ticket.Status = Status.Closed;
        ticket.ClosedAt = DateTime.UtcNow;
    }
    
    public List<string> BadWords = new List<string>(new []{
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
    });
}