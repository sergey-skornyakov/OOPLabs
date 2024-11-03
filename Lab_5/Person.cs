namespace Lab_5;

public class Person
{
    protected int id = 0;
    public int Id => id;
    public string FullName { get; set; }
    public DateTime BirthDate { get; set; }
    public Person(string fullName, DateTime birthDate)
    {
        FullName = fullName;
        BirthDate = birthDate;
        id = PeopleRegistry.AddPerson(this);
    }

    public override string ToString()
    {
        return $"{id} {FullName} {BirthDate.ToShortDateString()}";
    }
}