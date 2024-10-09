namespace Lab_1;

public class Person
{
    // Поля класса
    public string name = "Ben";
    public int age = 18;
    public string email = "ben@gmail.com";

    // Конструктор класса - функция, которая вызывается при создании экземпляра класса.
    // Конструктор должен называться также, как и класс.
    public Person(string name)
    {
        // this - указатель на текущий класс. С помощью него можно обратиться к полям и методам данного класса.
        this.name = name;
    }

    public Person(string name, int age) : this(name)
    {
        this.age = age;
    }

    public Person(string name, int age, string email) : this("Bob", age)
    {
        this.email = email;
    }
}