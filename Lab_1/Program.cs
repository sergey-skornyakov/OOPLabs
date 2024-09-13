namespace Lab_1
{
    static class Program
    {
        // Точка входа в программу (С данной функции начинается выполнение программы)
        static void Main(string[] args)
        {
            // Экземпляр класса Person
            Person person1 = new Person("Сергей", 19, "sergey@gmail.com");

        }
        /*
         * Ответы на вопросы:
         * 1. После запуска кода, приведённого в файле, поля будут иметь значения, которые указаны в классе.
         * 2. Если вызвать конструктор с тремя параметрами, то будут вызываться по-очереди все конструкторы и
         *    в них будут инициализироваться соответсвующие значения.
         *    Person(string name, int age, string email) -> Person(string name, int age) -> Person(string name)
         */
    }
}