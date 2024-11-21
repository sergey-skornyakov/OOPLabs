namespace Lab_8;

public class Circle : Shape
{
    private double radius;

    public Circle(Point position, double radius) : base(position)
    {
        this.radius  = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * radius;
    }

    public double GetDiameter()
    {
        return 2 * radius;
    }

    public override string ToString()
    {
        return $"Circle: position = {position}, radius = {radius}";
    }
}