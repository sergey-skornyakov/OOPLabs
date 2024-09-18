namespace Lab_2
{
    static class Program
    {
        static void ChangeTime(Time time)
        {
            time.AddSeconds(10);
        }

        static void ChangeDate(Date date)
        {
            date.AddDay();
        }

        static void Main(string[] args)
        {
            // Работа со структурой
            Time tm = new Time(1, 1, 1);
            Console.WriteLine(tm);
            ChangeTime(tm);
            Console.WriteLine(tm);
            // Значение не поменялось, т.к. структруры передаются в методы ПО ЗНАЧЕНИЮ

            Time tm2 = tm with {hours = 12};
            Console.WriteLine(tm2);

            // Работа с классом
            Date dt = new Date(1, 1, 1970);
            Console.WriteLine(dt);
            ChangeDate(dt);
            Console.WriteLine(dt);
            // Значение поменялось, т.к. классы передаются в методы ПО ССЫЛКЕ
        }

        /*
         * Вопросы
         * 1. Типы значений хранятся в стеке, а ссылочные типы в куче.
         *    При передаче в функцию типы значений невозможно изменить снаружи функции, а при передаче по ссылке возможно.
         * 2. Сборщик мусора освобождает выделенную память, которая больше не используется.
         * 3. Пользовательский тип данных можно создать при помощи служеюных слов class, struct.
         * 4.
         * 5. Получить доступ к полям можно либо через изменения модификаторов доступа, либо через создание геттеров и сеттеров.
         */
    }
}