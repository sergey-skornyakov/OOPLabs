namespace Lab_8;

public abstract class Shape
{
    protected Point position;

    protected Shape(Point position)
    {
        this.position = position;
    }

    public abstract double GetPerimeter();
    public abstract double GetArea();

    public void Move(double dx, double dy)
    {
        position.X += dx;
        position.Y += dy;
    }


}