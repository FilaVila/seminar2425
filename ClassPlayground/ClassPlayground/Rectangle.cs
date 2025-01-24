using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class Rectangle: Shape2D
    {
        public double height;
        public double width;

        public Rectangle(double height, double width) 
        {
            if (width==0) this.width = 1;
            else if (width<0)
            {
                this.width = -width;
            }
            else
            {
                this.width = width;
            }
            if(height==0)this.height = 1;
            else if(height<0)
            {
                    this.height = -height;
            }
            else
            {
                this.height= height;
            }
        }
        public override bool ContainsPoint(int x, int y) 
        {
            bool pravda = x<=height && y<=width;
            return pravda;
        }
        public override double CalculateAspectRatio() 
        {
            return height / width;
        }
        public override double CalculateArea() 
        {
  
            return height*width;
        }
        public void WriteData(bool pravda, double area, double ratio) 
        {
            string yesNo = "bod neleží v obdélníku";
            if (pravda)
            {
                yesNo = "bod leží v obdelníku";
            }
            Console.WriteLine("Obdélník s výškou " + height + " a šířkou "+width+" s celkovou plochou:"+ area +" jednotek čtverečních. Poměr výšky ku šířce je:"+ratio+" a co se týče bodu..."+yesNo);
        }
    }
}
