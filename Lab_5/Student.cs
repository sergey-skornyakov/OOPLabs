namespace Lab_5;

public class Student : Person
{
    private int number;
    private string firstName;
    private string lastName;
    private DateTime birthDate;
    private double avgScore;

    public Student(string firstName, string lastName, DateTime birthDate, double avgScore) : base($"{firstName} {lastName}", birthDate)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.avgScore = avgScore;
    }

    public string FirstName => firstName;
    public string LastName => lastName;
    public double AvgScore => avgScore;

    public int Number
    {
        get => number;

        set => number = value;
    }

    public override string ToString()
    {
        return $"{number} ({id}) {firstName} {lastName} {birthDate} {avgScore}";
    }
}