namespace Lab_9;

public class NotificationContainer<T> : INotificationContainer<T> where T : Notification
{
    private List<T> notifications;

    public NotificationContainer()
    {
        notifications = new List<T>();
    }

    public void AddNotification(T notification)
    {
        if (notification != null)
        {
            notifications.Add(notification);
        }
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= notifications.Count)
            {
                throw new ArgumentOutOfRangeException("index", "Index is out of range.");
            }
            return notifications[index];
        }
    }

    public IEnumerable<T> GetAllNotifications()
    {
        return new List<T>(notifications);
    }

    public bool IsContains(T notification)
    {
        return notifications.Contains(notification);
    }

    public int Count => notifications.Count;

    public void Sort()
    {
        notifications.Sort();
    }
}