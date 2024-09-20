using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            for (int i = 0; i < 11; i++)
            {
                int a = rnd.Next(0, 101);

                if (a > 50)
                {
                    Console.WriteLine(a + " Je překvapivě větší než 50");
                }
                else if (a > 25)
                {
                    Console.WriteLine(a + " Je mezi 50 a 25...woooow");
                }
                else
                {
                    Console.WriteLine("Az na to že vůbec frajere, hodnota " + a + " je menší nebo rovno 25");
                }
            }          

            Console.ReadKey();
        }
    }
}
