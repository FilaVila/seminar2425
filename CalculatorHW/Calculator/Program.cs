using System;
using System.Collections.Generic;
using System.Linq;
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
            int a;
            int b;
            double result = 0;
            string operace;
            string obracennéLomitkoAbychHoNemuselHledatPokazdeJakoVul = ("\\");

            static int LoadNumber() //"funkce" načte input od uživatele a zkusí jestli je to integer, a bude to zkouset dokud se uzivatel netrefí
            {
                int number =0;
                bool n = false;
                while (n == false)
                {
                    try
                    {
                        number = Convert.ToInt32(Console.ReadLine());
                        n = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Hele to asi nebude integer zkus to znova");
                    }
                }
                return number;
            }

            void Write(string m) //string m = string message 
            {
                Console.WriteLine("\n");
                foreach (char l in m)
                {
                    Console.Write(l);
                    Thread.Sleep(25);
                }
                Console.WriteLine("\n");
            }
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
            Write("Zdravím já jsem tvoje nová kalkulačka, prosím zadej své první číslo (nezapomeň má to být v integeru) se kteým budu počítat.");
            a = LoadNumber();
            Write("Dobrá tak to máme první číslo, teď mi prosím dej druhé číslo.");
            b = LoadNumber();
            Write("Pecka tak a teď mi řekni co s tím budeme dělat. Chceš to: \n secist \n odecist \n vydelit \n vynásobit");

            switch (operace = Console.ReadLine())
            {
                case "secist":
                    result = a+b;
                    break;
                case "odecist":
                    result = a - b;
                    break;
                case "vydelit":
                    if (b ==0)
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
                case "vynásobit":
                    result = a * b;
                    break;
                default:
                    Write("Hele tak ty seš jinej případ, končím.");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
            }
            Write("Tak jsme to spolu zvládli, ale že to byl fuška....výsledek je "+result);
            Console.ReadKey(); //Toto nech jako posledni radek, aby se program neukoncil ihned, ale cekal na stisk klavesy od uzivatele.
        }
    }
}
