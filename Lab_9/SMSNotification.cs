namespace Lab_9;

public class SMSNotification : Notification
{
    private string phoneNumber;
    public SMSNotification(int priority, string message, DateTime createdAt, string phoneNumber) : base(priority, message, createdAt)
    {
        this.phoneNumber = phoneNumber;
    }

    public SMSNotification(int priority, string? message, string phoneNumber) : base(priority, message)
    {
        this.phoneNumber = phoneNumber;
    }
}