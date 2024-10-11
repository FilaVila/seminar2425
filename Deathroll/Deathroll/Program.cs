using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2024-2025.
 * Extended by students.
 */

namespace Deathroll
{
    internal class Program
    {
        public static void Napis(string intput)
        {
            Console.WriteLine(intput+"\n");
        }

        public static int TahHrace() 
        {
            int a = Convert.ToInt32(Console.ReadLine());
            return a;
        }
        static void Main(string[] args)
        {
            /*
             * Jednoduchy program na procviceni podminek a cyklu (lze udelat i rekurzi).
             * 
             * Vytvor program, kde bude uzivatel hrat s pocitacem deathroll.
             * Pravidla deathrollu: Prvni hrac navrhne cislo (puvodne ve wowku pocet goldu, o ktere se hraci vsadi) a "rollne" navrhnute cislo, jinak receno je to stejne,
             * jako kdyby si hodil kostkou s tolika stenami, jako je navrhnute cislo. Prvnimu hraci "padne" nejake cislo a druhy hrac si "rollne" padnute cislo
             * (ktere uz je mensi nez to predesleho hrace).
             * Prohrava ten hrac, kteremu padne 1 jako prvnimu.
             * Ukazka hry: Hraci se shodnou na cisle 1000. Prvni hrac rollne 1-1000, padne mu 920. Druhy hrac rolluje 1-920, padne mu 235 atd. atd. az jednomu z hracu padne 1
             * a ten prohrava.
             * 
             * Struktura:
             * 
             * - nadefinuj promenne, ktere budes potrebovat po celou dobu hry, tedy aktualne rollovane cislo a stav "goldu" uzivatele i pocitace (oba zacinaji treba s 1000 goldu)
             * 
             * - uzivatel zada prvotni sazku, ktera musi byt maximalne tolik, kolik ma goldu
             * 
             * Opakuj dokud nepadne jednomu z hracu 1:
             * {
             *      Pokud je sude kolo:
             *      {
             *          - uzivatel zada hodnotu, kterou rolluje
             *          - kontroluj, ze uzivatel zadal spravnou hodnotu
             *          - uloz rollnute cislo
             *          - vypis uzivateli, co rollnul
             *      }
             *      Pokud je liche kolo:
             *      {
             *          - pocitac rollne nahodne cislo mezi 1 a aktualne rollovanym cislem
             *          - vypis uzivateli, co rollnul pocitac
             *      }
             * }
             * 
             * 
             * - posledni hrajici hrac prohral, protoze mu padla 1 a sazku bere druhy hrac
             * - vypis uzivateli kdo vyhral a stav goldu uzivatele i pocitace
             * 
             * ROZSIRENI:
             * - umozni uzivateli opakovat deathroll dokud ma nejake goldy
             */
            Random rnd = new Random();
            int apvg = 0; //aktuální počet vsazených goldů
            bool pp = true; //hraje hráč? player playing?

            string zprava1 = "Zdravim dobrodruhu, vyzývám těš na deathroll kolik goldů chceš vsadit \n";
            Napis(zprava1);
            apvg = TahHrace();
            while (apvg>=1) 
            {
                string zprava6 = "Tak teď hraješ ty:";
                Napis(zprava6);
                pp = true;
                apvg = rnd.Next(apvg);
                Napis(Convert.ToString(apvg));
                string zprava3 = "Tak a teď hraju já";
                pp = false;
                Napis(zprava3);
                apvg = rnd.Next(apvg);
                Napis(Convert.ToString(apvg));
            }
            if (pp == true) 
            {
                string zprava4 = "Ha lol prohrál jsi";
                Napis(zprava4);
            }
            else
            {
                string zprava5 = "Prohrál jsem a hanba padla na můj rod";
                Napis(zprava5);
            }
            Console.ReadKey();
        }
    }
}
