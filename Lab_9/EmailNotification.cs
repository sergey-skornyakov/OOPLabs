namespace Lab_9;

public class EmailNotification : Notification
{
    private string emailAddress;

    public EmailNotification(int priority, string message, DateTime createdAt, string emailAddress) : base(priority, message, createdAt)
    {
        this.emailAddress = emailAddress;
    }

    public EmailNotification(int priority, string message, string emailAddress) : base(priority, message)
    {
        this.emailAddress = emailAddress;
    }
}