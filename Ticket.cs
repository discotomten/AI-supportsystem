using Azure.AI.TextAnalytics;

namespace AI_supportsystem;

public class Ticket
{
    public long Id { get; set; }
    public string Title { get; set; } = "Untitled";
    public string Description { get; set; } = "";
    public Status Status { get; set; } = Status.Open;
    public Priority Priority { get; set; } = Priority.Low;
    public List<Keyword> Keywords { get; set; } = new List<Keyword>();
    public TextSentiment Sentiment { get; set; } = TextSentiment.Neutral;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;   
    public DateTime? ClosedAt { get; set; } = null;
    public string ContactInformation { get; set; } = "";
}

public class Keyword
{
    public string Text { get; set; } = "";
}

public enum Status
{
    Open,
    InProgress,
    Closed
}

public enum Priority
{
    Low,
    Medium,
    High
}

public class TicketDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string ContactInformation { get; set; }
}