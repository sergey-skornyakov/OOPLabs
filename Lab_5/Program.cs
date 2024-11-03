using Lab_5;

namespace Lab_5
{
    static class Program
    {
        static void Main(string[] args)
        {
            // Создаем два университета
            University mgu = new University();
            University spbu = new University();

            // Создаем студентов
            Student student1 = new Student("Иван", "Иванов", new DateTime(2000, 1, 1), 4.5);
            Student student2 = new Student("Петр", "Петров", new DateTime(2001, 2, 2), 4.8);
            Student student3 = new Student("Мария", "Сидорова", new DateTime(1999, 3, 3), 4.2);
            Student student4 = new Student("Анна", "Кузнецова", new DateTime(2002, 4, 4), 4.9);

            // Добавляем студентов в университеты
            mgu.AddStudent(student1);
            mgu.AddStudent(student2);
            spbu.AddStudent(student3);
            spbu.AddStudent(student4);

            // Выводим информацию о студентах в каждом университете
            Console.WriteLine("Студенты МГУ:");
            foreach (var student in mgu.Students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nСтуденты СПбГУ:");
            foreach (var student in spbu.Students)
            {
                Console.WriteLine(student);
            }
        }
    }
}