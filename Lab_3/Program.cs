using System.Text.Json;
using Lab_3;

namespace Lab_3
{
    static class Program
    {
        static void Main(string[] args)
        {
            University university = new University();

            university.AddStudent(new Student("Андрей", "Боев", 18, 4.5));
            university.AddStudent(new Student("Иван", "Иванов", 17, 4.8));

            DataAccess.StudentsRepository.SaveStudents(university, "students.json");

            University uni = new University(DataAccess.StudentsRepository.LoadStudents("students.json"));

            Console.WriteLine($"Список студентов:\n{uni}");
        }
    }
}

namespace DataAccess
{
    public static class StudentsRepository
    {
        public static void SaveStudents(University university, string filePath)
        {
            var json = JsonSerializer.Serialize(university.Students);
            File.WriteAllText(filePath, json);
        }

        public static List<Student> LoadStudents(string filePath)
        {
            if (!File.Exists(filePath))
                return new List<Student>();

            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Student>>(json) ?? new List<Student>();
        }
    }
}