public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
    public virtual  double getArea()
    {
        Console.WriteLine("Area of a shape");
        return -1;
    }
}
    public class Circle:Shape
    {
        public double Radius {get; set;}
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
        public override double getArea()
        {
            return Radius*Radius*Math.PI;
        }
    }
public class Retangle:Shape
    {
        public double Length{get; set;}
        public double Width{get; set;}
        public Retangle(double length, double width)
        {
            this.Length = length;
            this.Width = width;
        }
        public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
        public override double getArea()
    {
        return Length * Width;
    }
    }
    public class Triangle:Shape
{
    public double Base {get; set;}
    public double Height{get; set;}
    public Triangle(double b, double h)
    {
        this.Base = b;
        this.Height= h;
    }
    public override void Draw()
    {
        Console.WriteLine("Drawing a Triangle");
    }
    public override double getArea()
    {
        return Base*Height/2;
    }
}
public class Program
{
    static void Main()
    {
        Shape[] shape=
        {
            new Circle(78.6),
            new Retangle(67.3, 83.4),
            new Triangle(7,3)
        };
        foreach(Shape item in shape)
        {
            item.Draw();
            Console.WriteLine("Area= "+ item.getArea());
            Console.WriteLine();
        }
    }
}
