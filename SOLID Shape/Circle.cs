using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Shape
{
    public class Circle : Shape
    {
        public int straal;
        public Circle(int s)
        {
            straal = s;
        }
        public override double Opp()
        {
            return straal * straal * Math.PI;
        }
    }
}
