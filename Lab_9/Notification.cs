namespace Lab_9;

public class Notification : IComparable<Notification>
{
    public int Priority => priority;

    public string Message => message;

    public DateTime CreatedAt => createdAt;

    private int priority;
    private string message;
    private DateTime createdAt;

    protected Notification(int priority, string message, DateTime createdAt)
    {
        this.priority = priority;
        this.message = message;
        this.createdAt = createdAt;
    }
    protected Notification(int priority, string message) : this(priority, message, DateTime.Now) { }

    public virtual int CompareTo(Notification other)
    {
        if (other == null) return 1;
        return CreatedAt.CompareTo(other.CreatedAt);
    }

    public override string ToString()
    {
        return $"Priority: {Priority}, Message: {Message}, Created: {CreatedAt}";
    }
}