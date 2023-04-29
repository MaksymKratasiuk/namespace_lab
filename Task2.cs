using namespace_lab.GeometryShapes.Rectangles;
using namespace_lab.GeometryShapes.Triangles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namespace_lab
{
    namespace GeometryShapes
    {
        public abstract class Shape
        {
            public abstract double CalculateArea();
            public abstract double CalculatePerimeter();
        }

        namespace Triangles
        {
            public class Triangle : Shape
            {
                private double sideA;
                private double sideB;
                private double sideC;

                public Triangle(double a, double b, double c)
                {
                    this.sideA = a;
                    this.sideB = b;
                    this.sideC = c;
                }

                public override double CalculateArea()
                {
                    double s = (this.sideA + this.sideB + this.sideC) / 2;
                    return Math.Sqrt(s * (s - this.sideA) * (s - this.sideB) * (s - this.sideC));
                }

                public override double CalculatePerimeter()
                {
                    return this.sideA + this.sideB + this.sideC;
                }
            }
        }

        namespace Rectangles
        {
            public class Rectangl : Shape
            {
                private double width;
                private double height;

                public Rectangl(double w, double h)
                {
                    this.width = w;
                    this.height = h;
                }

                public override double CalculateArea()
                {
                    return this.width * this.height;
                }

                public override double CalculatePerimeter()
                {
                    return 2 * (this.width + this.height);
                }
            }

            public class Square : Rectangl
            {
                public Square(double s) : base(s, s)
                {
                }
            }
        }
    }
    public class Task2
    {
        public static void num2()
        {
            //  Triangle 
            Triangle t = new Triangle(3, 4, 5);
            Console.WriteLine("Triangle : 3  4  5: ");
            Console.WriteLine("Triangle area: " + t.CalculateArea());
            Console.WriteLine("Triangle perimeter: " + t.CalculatePerimeter());

            // Rectangle 
            Rectangl r = new Rectangl(4, 5);
            Console.WriteLine("Rectangle :  4  5: ");
            Console.WriteLine("Rectangle area: " + r.CalculateArea());
            Console.WriteLine("Rectangle perimeter: " + r.CalculatePerimeter());

            //  Square (Rectangle )
            Square s = new Square(5);
            Console.WriteLine("Square area: " + s.CalculateArea());
            Console.WriteLine("Square perimeter: " + s.CalculatePerimeter());
        }
    }
}