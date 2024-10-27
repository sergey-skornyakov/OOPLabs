namespace Lab_5;

public class Person
{
    private static int id;
    public static int Id => id;
    public string FullName { get; set; }
    public DateTime BirthDate { get; set; }
    public Person(string fullName, DateTime birthDate)
    {
        FullName = fullName;
        BirthDate = birthDate;
        id = PeopleRegistry.AddPerson(this);
    }
}