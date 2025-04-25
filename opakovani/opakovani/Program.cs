using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opakovani
{
    internal class Program
    {
        static int LoadNumber() 
        {
            string input ="";
            int output;
            while (true) 
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out output))
                {
                    return output;
                }
                else 
                {
                    Console.WriteLine("špatný input");
                }
            }            
        }
        static int Factorial(int a) 
        {
            if (a ==0)
            {
                return 1;
            }
            else
            {
                return a * Factorial(a-1);
            }
        }
        static int Fibbonnacci(int a) 
        {
            if (a==0)
            {
                return 0;
            }
            if (a ==1)
            {
                return 1;
            }
            else 
            {
                return Fibbonnacci(a - 1) + Fibbonnacci(a - 2);
            }
        }
        static void Main(string[] args)
        {
            int a = LoadNumber();
            Console.WriteLine("VAše "+Factorial(a));
            Console.WriteLine(Fibbonnacci(a));
            Console.ReadKey();
        }

    }
}
