using Lab_9;

namespace Lab_9
{
    static class Program
    {
        static void PrintNotifications<T>(NotificationContainer<T> container) where T : Notification
        {
            foreach (var notification in container.GetAllNotifications())
            {
                Console.WriteLine($"- {notification}");
            }
        }
        static void Main(string[] args)
        {
            var smsContainer = new NotificationContainer<SMSNotification>();
            var emailContainer = new NotificationContainer<EmailNotification>();
            var pushContainer = new NotificationContainer<PushNotification>();

            // Добавляем SMS уведомления int priority, string message, DateTime createdAt, string phoneNumber
            smsContainer.AddNotification(new SMSNotification(2, "Подтвердите вход", DateTime.Parse("2024-11-02 11:05:14"),"+79001234567"));
            smsContainer.AddNotification(new SMSNotification(1, "Срочное сообщение", DateTime.Parse("2024-11-03 11:05:14"), "+79009876543"));
            smsContainer.AddNotification(new SMSNotification(3, "Акция!", DateTime.Parse("2024-12-01 11:05:14"), "+79005555555"));

            // Добавляем Email уведомления
            emailContainer.AddNotification(new EmailNotification(3, "Новости недели", DateTime.Parse("2024-09-02 11:05:14"), "user1@mail.com"));
            emailContainer.AddNotification(new EmailNotification(1, "Сброс пароля", DateTime.Parse("2024-08-12 11:05:14"), "user2@mail.com"));
            emailContainer.AddNotification(new EmailNotification(2, "Подписка истекает", DateTime.Parse("2024-10-08 11:05:14"), "user3@mail.com"));

            // Добавляем Push уведомления
            var push1 = new PushNotification(2, "Новое сообщение", DateTime.Parse("2024-11-29 11:05:14"), "com.app.messenger");
            var push2 = new PushNotification(1, "Критическое обновление", DateTime.Parse("2024-10-11 11:05:14"), "com.app.messenger");
            pushContainer.AddNotification(push1);
            pushContainer.AddNotification(push2);

            Console.WriteLine("Проверка наличия элементов\n");
            Console.WriteLine($"SMS уведомлений: {smsContainer.Count}");
            Console.WriteLine($"Email уведомлений: {emailContainer.Count}");
            Console.WriteLine($"Push уведомлений: {pushContainer.Count}");

            Console.WriteLine("\nВывод элементов до сортировки\n");
            Console.WriteLine("SMS уведомления:");
            PrintNotifications(smsContainer);

            Console.WriteLine("\nEmail уведомления:");
            PrintNotifications(emailContainer);

            Console.WriteLine("\nPush уведомления:");
            PrintNotifications(pushContainer);

            Console.WriteLine("\nСортировка и вывод отсортированных элементов\n");

            smsContainer.Sort();
            emailContainer.Sort();
            pushContainer.Sort();

            Console.WriteLine("Отсортированные SMS уведомления:");
            PrintNotifications(smsContainer);

            Console.WriteLine("\nОтсортированные Email уведомления:");
            PrintNotifications(emailContainer);

            Console.WriteLine("\nОтсортированные Push уведомления:");
            PrintNotifications(pushContainer);

            Console.WriteLine("\nДемонстрация проверки наличия конкретного элемента\n");
            var testSms = new SMSNotification(2, "Подтвердите вход", "+79001234567");
            Console.WriteLine($"Содержит ли SMS контейнер тестовое уведомление: {smsContainer.IsContains(testSms)}");
        }
    }
}