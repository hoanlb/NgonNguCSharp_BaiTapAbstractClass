using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgonNguCSharp_BaiTapAbstractClass_IColorable
{
    public class Circle : Shape, IColorable
    {
        public Circle()
        {

        }

        public string HowToColor()
        {
            return "Blue";
        }
    }
}
