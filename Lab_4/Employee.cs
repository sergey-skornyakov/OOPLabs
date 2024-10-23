namespace Lab_4;

public class Employee
{
    public string FirstName { get; set; }

    private string lastName;
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    private int skill;
    public int Skill
    {
        get => skill;
        set
        {
            if (skill >= 0)
                skill = value;
        }
    }

    public bool IsBest => Skill < 25;

    public string GetInfo() => GetInfo(true);

    public string GetInfo(bool includeIntProperty) =>
        $"{FirstName} {lastName}{(includeIntProperty ? $" {Skill}" : "")} {IsBest}";
}