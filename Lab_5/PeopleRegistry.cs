namespace Lab_5;

public class PeopleRegistry
{
    private static int nextId = 1;
    private static Dictionary<int, Person> people = new();
    public static int AddPerson(Person person)
    {
        int id = nextId++;
        people[id] = person;
        return id;
    }

    public static Person? GetPerson(int id)
    {
        return people.ContainsKey(id) ? people[id] : null;
    }
}