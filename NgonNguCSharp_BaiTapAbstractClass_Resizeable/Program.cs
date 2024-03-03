using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgonNguCSharp_BaiTapAbstractClass_Resizeable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[3];
            shapes[0] = new Circle();
            shapes[1] = new Rectangle();
            shapes[2] = new Square();
            

            foreach (Shape shape in shapes)
            {
                if (shape is Circle)
                {
                    Resizeable resizeable = (Circle)shape;
                    
                    Circle circle = new Circle();
                    circle.setRadius(5);

                    double resizeArea = circle.GetArea() * resizeable.Resize(30);
                    Console.WriteLine("Circle 's Resize Area is: " + resizeArea);
                    double resizePerimeter = circle.GetPerimeter() * resizeable.Resize(30);
                    Console.WriteLine("Circle 's Resize Perimeter is: " + resizePerimeter);
                }

                if (shape is Rectangle)
                {
                    Resizeable resizeable = (Rectangle)shape;

                    Rectangle rectangle = new Rectangle();
                    rectangle.SetWidth(6);
                    rectangle.SetLength(8);

                    double resizeArea = rectangle.GetArea() * resizeable.Resize(60);
                    Console.WriteLine("Rectangle 's Resize Area is: " + resizeArea);
                    double resizePerimeter = rectangle.GetPerimeter() * resizeable.Resize(60);
                    Console.WriteLine("Rectangle 's Resize Perimeter is: " + resizePerimeter);
                }

                if (shape is Square)
                {
                    Resizeable resizeable = (Square)shape;
                    
                    Square square = new Square();
                    square.SetSide(5);

                    double resizeArea = square.GetArea() * resizeable.Resize(90);
                    Console.WriteLine("Square 's Resize Area is: " + resizeArea);
                    double resizePerimeter = square.GetPerimeter() * resizeable.Resize(90);
                    Console.WriteLine("Square 's Resize Perimeter is: " + resizePerimeter);
                }
            }

            Console.ReadKey();
        }
    }
}
