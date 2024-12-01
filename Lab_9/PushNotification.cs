namespace Lab_9;

public class PushNotification : Notification
{
    private string appId;

    public PushNotification(int priority, string message, DateTime createdAt, string appId) : base(priority, message, createdAt)
    {
        this.appId = appId;
    }

    public PushNotification(int priority, string message, string appId) : base(priority, message)
    {
        this.appId = appId;
    }
}