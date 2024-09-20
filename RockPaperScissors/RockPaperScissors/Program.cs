using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2024-2025.
 * Extended by students.
 */

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Jednoduchy program na procviceni podminek a cyklu.
             * 
             * Vytvor program, kde bude uzivatel hrat s pocitacem kamen-nuzky-papir.
             * 
             * Struktura:
             * 
             * - nadefinuj promenne, ktere budes potrebovat po celou dobu hry, tedy skore obou, pripadne cokoliv dalsiho budes potrebovat
             *
             * Opakuj tolikrat, kolik kol chces hrat, nebo treba do doby, nez bude mit jeden z hracu pocet bodu nutnych k vyhre:
             * {
             *      Dokud uzivatel nezada vstup spravne:
             *      {
             *          - nacitej vstup od uzivatele
             *      }
             *      
             *      - vygeneruj s pomoci rng.Next() nahodny vstup pocitace
             *      
             *      Pokud vyhral uzivatel:
             *      {
             *          - informuj uzivatele, ze vyhral kolo
             *          - zvys skore uzivateli o 1
             *      }
             *      Pokud vyhral pocitac:
             *      {
             *          - informuj uzivatele, ze prohral kolo
             *          - zvys skore pocitaci o 1
             *      }
             *      Pokud byla remiza:
             *      {
             *          - informuj uzivatele, ze doslo k remize
             *      }
             * }
             * 
             * - informuj uzivatele, jake mel skore on/a a pocitac a kdo vyhral.
             */
            int score = 0; //skore hráče
            int scorePC = 0; //skoer počítače
            double winLose; //pomocná proměnná
            string pResponse; //tah hráče
            int pRes =0; //číselný tah hráče
            int pcRes =0; // tah PC

            Random rnd = new Random(); //instance tridy Random pro generovani nahodnych cisel

            void Skore() //funkce která vypíše skóre
            {
                Console.WriteLine("\n Naše akutální skóre: \n \n Hráč: "+ score + "\n PC: "+scorePC+ "\n");
            }

            void Tah() //zpravuje tah hrače
            {
                pResponse = Console.ReadLine();
                if (pResponse == "kamen")
                {
                    pRes = 1;
                }
                else if (pResponse == "nuzky")
                {
                    pRes = 2;
                }
                else if (pResponse == "papir")
                {
                    pRes = 3;
                }
                else 
                {
                    Console.WriteLine(" hele tak s tebou kocnim ty nejses ani schopnej napsat kamen/nuzky/papir správně");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                
            }

            void Hra ()
            {
                pcRes = rnd.Next(1, 4);
                winLose = pcRes / pRes;
                if (winLose == 1)
                {
                    Console.WriteLine("\n Plichta");
                    Skore();
                    Console.WriteLine(pcRes);
                }
                else if (winLose == 1/3)
                {
                    Console.WriteLine("Gratuluji vyhrál jsi, já dal kamen a ty jsi dal papír");
                    score++;
                    Skore();
                    Console.WriteLine(pcRes);
                }
                else if (winLose == 3)
                {
                    Console.WriteLine("Ha ha ha vyhrál jsem, já dal papir a ty jsi dal kamen");
                    scorePC++;
                    Skore();
                    Console.WriteLine(pcRes);
                }
                else if (winLose == 2/3)
                {
                    Console.WriteLine("Ha ha ha vyhrál jsem, já dal nuzky a ty jsi dal papir");
                    scorePC++;
                    Skore();
                    Console.WriteLine(pcRes);
                }
                else if (winLose == 3/2)
                {
                    Console.WriteLine("Gratuluji vyhrál jsi, já dal papir a ty jsi dal nuzky");
                    score++;
                    Skore();
                    Console.WriteLine(pcRes);
                }
                else if (winLose ==1/2)
                {
                    Console.WriteLine("Ha ha ha vyhrál jsem, já dal kamen a ty jsi dal nuzky");
                    scorePC++;
                    Skore();
                    Console.WriteLine(pcRes);
                }
                else if (winLose ==2)
                {
                    Console.WriteLine("Gratuluji vyhrál jsi, já dal nuzky a ty jsi dal kamen");
                    score++;
                    Skore();
                    Console.WriteLine(pcRes);
                }
            }

            Console.WriteLine("zdravím, pojďme si zahrát kámen nůžky papír teď \n pokud chceš zahrát kamen napiš....kamen, pokud nůžky....nůžky, opravdu musím říkat co máš napsat, když cheš hrát papir? ");            
            Skore();
            Tah();   

            while (score == 3 || scorePC == 3)
            {
                Hra();
            }
            if (score ==3)
            {
                Console.WriteLine("\nGratuluji porazil jsi mě.....");
            }
            else
            {
                Console.WriteLine("\n Ha ha ha porazil jsem tě...NOOOOB!!!!");
            }
            Console.ReadKey(); //Aby se nam to hnedka neukoncilo
        }
    }
}
