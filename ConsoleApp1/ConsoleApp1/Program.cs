using System;
abstract class Shape//абстрактный класс 
{
    public abstract double CalculateArea();// абстрактный метод для вычисления площади
}

class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Радиус должен быть положительным");
        }
        this.radius = radius;
    }
    public override double CalculateArea()//реализация метода для круга
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}

class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        if (width <= 0 || height <= 0)
        {
            throw new ArgumentException("Ширина и высота должны быть положительными");
        }
        this.width = width;
        this.height = height;
    }
    public override double CalculateArea()//реализация метода для прямоугольника
    {
        return width * height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Shape circle = new Circle(5);
            Console.WriteLine("Площадь круга: " + circle.CalculateArea());

            Shape rectangle = new Rectangle(4, 6);
            Console.WriteLine("Площадь прямоугольника: " + rectangle.CalculateArea());
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }
}


