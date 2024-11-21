namespace Lab_8;

public class Square : Rectangle
{
    public Square(Point position, double size) : base(position, size, size)
    {
    }

    public override string ToString()
    {
        return $"Square: position = {position}, width = {width}, height = {height}";
    }
}