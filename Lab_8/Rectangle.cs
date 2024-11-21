namespace Lab_8;

public class Rectangle : Shape
{
    protected double width;
    protected double height;

    public Rectangle(Point position, double width, double height) : base(position)
    {
        this.width = width;
        this.height = height;
    }

    public override double GetArea()
    {
        return width * height;
    }

    public override double GetPerimeter()
    {
        return 2 * (width + height);
    }

    public double GetDiagonal()
    {
        return Math.Sqrt(width * width + height * height);
    }

    public override string ToString()
    {
        return $"Rectangle: position = {position}, width = {width}, height = {height}";
    }
}