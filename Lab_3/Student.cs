namespace Lab_3;

public class Student
{
    private string firstName;
    private string lastName;
    private int age;
    private double avgScore;

    // Конструктор с параметрами
    public Student(string firstName, string lastName, int age, double avgScore)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = CheckAge(age);
        this.avgScore = avgScore;
    }

    // Функция, проверяющая, правильно ли введён возраст и возвращающая его
    public int CheckAge(int age)
    {
        if (age >= 3 && age <= 120)
            return age;
        throw new Exception("Некорректный возраст");
    }

    // Свойства для доступа только для чтения полей
    public string FirstName => firstName;
    public string LastName => lastName;
    public int Age => age;
    public double AvgScore => avgScore;

    public override string ToString()
    {
        return $"{firstName} {lastName} {age} {avgScore}";
    }
}