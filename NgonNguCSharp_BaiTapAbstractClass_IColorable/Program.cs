using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgonNguCSharp_BaiTapAbstractClass_IColorable
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            shape = new Square();

            IColorable iColorable = (Square)shape;

            Console.WriteLine("Square 's color is: " + iColorable.HowToColor());

            Console.ReadKey();
        }
    }
}
