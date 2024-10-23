using Lab_4;

namespace Lab_4
{
    static class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Иван";
            employee.LastName = "Иванов";
            employee.Skill = 20;

            Console.WriteLine(employee.GetInfo());
        }
    }
}