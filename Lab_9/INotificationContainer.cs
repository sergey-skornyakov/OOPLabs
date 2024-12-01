namespace Lab_9;

public interface INotificationContainer<out T> where T : Notification
{
    T this[int index] { get; }
    IEnumerable<T> GetAllNotifications();
    int Count { get; }
}