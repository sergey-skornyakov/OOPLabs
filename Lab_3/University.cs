namespace Lab_3;

public class University
{
    private List<Student?> students = [];

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