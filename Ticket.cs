namespace AI_supportsystem;

public class Ticket
{
    public long Id { get; set; }
    public string Title { get; set; } = "Untitled";
    public string Description { get; set; } = "";
    public Status Status { get; set; } = Status.Open;
    public Priority Priority { get; set; } = Priority.Low;
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