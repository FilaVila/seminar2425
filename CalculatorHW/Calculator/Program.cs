using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2024-2025.
 * Extended by students.
 */

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * ZADANI
            * Vytvor program ktery bude fungovat jako kalkulacka. Kroky programu budou nasledujici:
            * 1) Nacte vstup pro prvni cislo od uzivatele (vyuzijte metodu Console.ReadLine() - https://learn.microsoft.com/en-us/dotnet/api/system.console.readline?view=netframework-4.8.
            * 2) Zkonvertuje vstup od uzivatele ze stringu do integeru - https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number.
            * 3) Nacte vstup pro druhe cislo od uzivatele a zkonvertuje ho do integeru. (zopakovani kroku 1 a 2 pro druhe cislo)
            * 4) Nacte vstup pro ciselnou operaci. Rozmysli si, jak operace nazves. Muze to byt "soucet", "rozdil" atd. nebo napr "+", "-", nebo jakkoliv jinak.
            * 5) Nadefinuj integerovou promennou result a prirad ji prozatimne hodnotu 0.
            * 6) Vytvor podminky (if statement), podle kterych urcis, co se bude s cisly dit podle zadane operace
            *    a proved danou operaci - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements.
            * 7) Vypis promennou result do konzole
            * 
            * Rozsireni programu pro rychliky / na doma (na poradi nezalezi):
            * 1) Vypis do konzole pred nactenim kazdeho uzivatelova vstupu co po nem chces (aby vedel, co ma zadat)
            * 2) a) Kontroluj, ze uzivatel do vstupu zadal, co mel (cisla, popr. ciselnou operaci). Pokud zadal neco jineho, napis mu, co ma priste zadat a program ukoncete.
            * 2) b) To same, co a) ale misto ukonceni programu opakovane cti vstup, dokud uzivatel nezada to, co ma
            *       - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-while-statement
            * 3) Umozni uzivateli zadavat i desetinna cisla, tedy prekopej kalkulacku tak, aby umela pracovat s floaty
            */
            float a =0;
            float b =0;
            float result = 0;
            string result2 =""; // proměnná pro odmocňování
            string operace;
            bool repeat = true;
            Random rnd = new Random();
            string obracennéLomitkoAbychHoNemuselHledatPokazdeJakoVul = ("\\");

            static float LoadNumber() //"funkce" načte input od uživatele a zkusí jestli je to float, a bude to zkouset dokud se uzivatel netrefí
            {
                float number =0;
                bool n = false; //n jako náhodná proměnná
                while (n == false)
                {
                    try
                    {
                        number = float.Parse(Console.ReadLine());
                        n = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Hele to asi nebude float zkus to znova");
                    }
                }
                return number;
            }

            void Write(string m) //string m = string message 
            {
                foreach (char l in m)
                {
                    Console.Write(l);
                    Thread.Sleep(25);
                }
                Console.WriteLine("\n");
            }

            void Calculate(float a, float b) 
            {
                Write("Prosím zadej své první číslo (nezapomeň má to být ve floatu) se kteým budu počítat.");
                a = LoadNumber();
                Write("Dobrá tak to máme první číslo, teď mi prosím dej druhé číslo.");
                b = LoadNumber();
                Write("Pecka tak a teď mi řekni co s tím budeme dělat. Chceš to: \n secist \n odecist \n vydelit \n vynasobit \n umocnit (a na b) \n odmocnit (2 odmocnina z obou čísel) \n random (sečte čísla a vynásobí náhodným číslem mezi 7 a 528)\n odmocnina2 (b odmocnina z a) \n HELP");
                switch (operace = Console.ReadLine())
                {
                    case "secist":
                        result = a + b;
                        break;
                    case "odecist":
                        result = a - b;
                        break;
                    case "vydelit":
                        if (b == 0)
                        {
                            Write("Sorry, ale nulou dělit nelze. Měj se.");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        else
                        {
                            result = a / b;
                        }
                        break;
                    case "vynasobit":
                        result = a * b;
                        break;
                    case "umocnit": //od Mistrail Ai
                        result = a;
                        for (int i = 1; i < b; i++)
                        {
                            result = result * a;
                        }
                        break;
                    case "odmocnit":
                        result = (float)Math.Sqrt(a);
                        result2 = " a " + Convert.ToString((float)Math.Sqrt(b));
                        break;
                    case "random":
                        result = (a + b) * rnd.Next(7, 529);
                        break;
                    case "odmocnina2":
                        result = (float)Math.Pow(a, 1 / b);
                        break;
                    case "HELP":
                        System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=xvFZjo5PgG0");
                        break;
                    default:
                        Write("Hele tak ty seš jinej případ, končím.");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                }
                Write("Tak jsme to spolu zvládli, ale že to byl fuška....výsledek je " + result + result2+ "\n");
            }
            Write("Zdravím já jsem tvoje nová kalkulačka.");
            while (repeat == true)
            {
                Calculate(a, b);
                Write("Přeješ si jěště něco spočítat: \n ANO \n NE");
                if (Console.ReadLine()=="NE")
                {
                    Write("Tak jo měj se!!!");
                    break;
                }
                Write("Oh damn here we go again....\n");
            }
            Console.ReadKey(); //Toto nech jako posledni radek, aby se program neukoncil ihned, ale cekal na stisk klavesy od uzivatele.
        }
    }
}
