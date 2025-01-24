using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class Shape2D
    {
        public virtual double CalculateArea() 
        {
            Console.WriteLine("tak takhle to nepůjde...blbečku");
            return -1;  
        }
        public virtual double CalculateAspectRatio() 
        {
            Console.WriteLine("tak takhle to nepůjde...blbečku");
            return -1;
        }
        public virtual bool ContainsPoint(int x, int y) 
        {
            Console.WriteLine("Ano nebo ne o ´tom rozhodne Děd vševěd");
            return false;
        }
    }
}
