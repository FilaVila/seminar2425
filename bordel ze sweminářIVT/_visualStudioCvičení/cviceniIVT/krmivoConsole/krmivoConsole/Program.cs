using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms; // přidal jsem knihovnu pomocí záložky references, abych mohl kingovat s messageboxem
using System.Threading.Tasks;

namespace krmivoConsole
{
    internal class Program
    {
        static int LoadNumber() //"funkce" načte input od uživatele a zkusí jestli je to integer, a bude to zkouset dokud se uzivatel netrefí
        {
            int number = 0;
            bool isValid = false; // //boolean proměnná kontrolující while cyklus
            while (isValid == false)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (FormatException)
                {
                    Write("Hele to asi nebude integer zkus to znova");
                }
            }
            return number;
        }
        static void Write(string m) //string m = string message, voidová funkce nevrací žádnou hodnotu
        {            
            foreach (char l in m)
            {
                Console.Write(l);
                Thread.Sleep(25);
            }
            Console.WriteLine("\n");
        }
        static float RoundIt(float number) //statická funkce načte float zaokrouhlí ho a vrátí
        {
            float fNumber = (float)Math.Round(number, 1);
            return fNumber; //fNumber = finished number
        }
        static void Main(string[] args)
        {
            Write("Zdravím farmáři zadej velikost tvého stáda (ve datovém typu integer).");
            int a = LoadNumber();
            float z = RoundIt(3.0f * a * 7); //3 kg zrní na 1 krávu * počet krav * 7 dní v týdnu
            float s = RoundIt(0.4f * a * 7); // za 0.4 je f, abychom to definovali jako float (nemůžeme z integeru a doublu udělat jen tak float)
            float v = RoundIt(10f * a * 7); // v jako voda :D
            string o = "Na týden bude potřeba " + z + " kg zrní " + s + " balíků sena a " + v + " l vody.";
            Console.ForegroundColor = ConsoleColor.Red;           
            Write(o);
            Console.ResetColor();
            MessageBox.Show("Kolik má kráva žaludků?\nA jak se Filipovi podařilo zapnout MessageBox v konzolové aplikaci?");
            Console.ReadKey();
        }
    }
}
