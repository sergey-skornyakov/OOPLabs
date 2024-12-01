namespace Lab_5;

public class University
{
    private List<Student?> students = new List<Student?>();
    private int nextId = 1;

    public University()
    {
    }

    public University(List<Student> students)
    {
        this.students = students;
    }

    public List<Student?> Students => students;

    public void AddStudent(Student? student)
    {
        student.Number = nextId++;
        students.Add(student);
    }

    public void RemoveStudent(Student? student)
    {
        students.Remove(student);
    }

    public Student? FindStudent(string firstName, string lastname)
    {
        return students.Find(student => student?.FirstName == firstName && student.LastName == lastname);
    }

    public override string ToString()
    {
        return students.Aggregate("", (current, student) => current + (student + "\n"));
    }
}