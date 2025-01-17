using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class Rectangle
    {
        public double height;
        public double width;

        public Rectangle(double height, double width) 
        {
            this.height = height;
            this.width = width;
        }
        public bool ContainsPoint(int x, int y) 
        {
            bool pravda = x<=height && y<=width;
            return pravda;
        }
        public double CalculateAspectRatio() 
        {
            return height / width;
        }
        public double CalculateArea() 
        {
            double area = height * width;
            return area;
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
