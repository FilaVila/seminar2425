using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class Circle: Shape2D
    {
        public double radius;
        

        public Circle(double radius)
        {
            if (radius == 0) this.radius = 1;
            else if (radius < 0)
            {
                this.radius = -radius;
            }
            else
            {
                this.radius = radius;
            }
           
        }
        public override bool ContainsPoint(int x, int y)
        {
           return radius >= Math.Sqrt(x*x+y*y);
        }
        public override double CalculateArea()
        {

            return Math.PI*radius*radius;
        }        
    }
}
