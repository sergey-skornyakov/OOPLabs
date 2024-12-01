using Lab_8;

namespace Lab_8
{
    static class Program
    {
        static void Test(Shape shape)
        {
            Console.WriteLine($"Информация о фигуре: {shape}");

            Console.WriteLine($"Площадь: {shape.GetArea()}");
            Console.WriteLine($"Периметр: {shape.GetPerimeter()}");

            if (shape is Circle circle)
            {
                Console.WriteLine($"Диаметр окружности: {circle.GetDiameter()}");
            }
            else if (shape is Square square)
            {
                Console.WriteLine($"Диагональ квадрата: {square.GetDiagonal()}");
            }
            else if (shape is Rectangle rectangle)
            {
                Console.WriteLine($"Диагональ прямоугольника: {rectangle.GetDiagonal()}");
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Circle circle = new Circle(new Point(0, 0), 5);
            Rectangle rectangle = new Rectangle(new Point(1, 1), 4, 3);
            Square square = new Square(new Point(2, 2), 5);

            Test(circle);
            Test(rectangle);
            Test(square);
        }
    }
}