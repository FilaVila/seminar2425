using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleShip2
{
    internal class Program
    {
        static void PrintArray(string[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int l = 0; l < array.GetLength(1); l++)
                {
                    Console.Write(array[i, l] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void PrintList(List<string> list) 
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i] + "\n");
            }
        }
        static void CompletePrintArray(string[,] array1, string[,] array2) 
        {
            Console.WriteLine("Tvoje pole:");
            PrintArray(array1);
            Console.WriteLine("Soupeřovo pole:");
            PrintArray(array2);
        }
        static void Write(string m) //string m = string message 
        {
            foreach (char l in m)
            {
                Console.Write(l);
                Thread.Sleep(25);
            }
            Console.WriteLine("\n");
        }
        static int LoadNumber() //"funkce" načte input od uživatele a zkusí jestli je to float, a bude to zkouset dokud se uzivatel netrefí
        {
            int number = 1;
            bool n = false; //n jako náhodná proměnná
            while (n == false)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    n = true;
                }
                catch (FormatException)
                {
                    Write("Hele to asi nebude float zkus to znova");
                }
            }
            return number;
        }
        static char LoadChar() //"funkce" načte input od uživatele a zkusí jestli je to float, a bude to zkouset dokud se uzivatel netrefí
        {
            char letter = 'A';
            bool n = false; //n jako náhodná proměnná
            while (n == false)
            {
                try
                {
                    letter = char.Parse(Console.ReadLine());
                    n = true;
                }
                catch (FormatException)
                {
                    Write("Hele to asi nebude Char zkus to znova");
                }
            }
            return letter;
        }
        static void SetArray(string[,] array) //první nastavení hracích polí
        {
            for (int i = 1; i < array.GetLength(0); i++)
            {
                for (int l = 1; l < array.GetLength(1); l++)
                {
                    array[i, l] = "[0]";
                }
            }
            array[0,0] = "[:D]"; //horní levé políčko (aby bylo pole hezky zarovnané)
            for (int i = 1; i < array.GetLength(0)-1; i++) // řádky
            {
                array[i, 0] = "["+(i)+"] "; 
            }
            array[10, 0] = "[10]"; //dolní levé políčko
            for (int i = 1; i <= 10; i++) //sloupečky
            {
                array[0, i] = "[" + (char)('A' + i-1 ) + "]"; // ChatGpt vařil
            }
        }
        static void Input() 
        {
            bool validInput = false;
            List<char> rows = new List<char>(){ 'A' , 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };//písmenka
            
            while (!validInput)
            {
                string input =Console.ReadLine();
                if (input.Length != 1)
                {
                    //osetreni spatneho vstupu
                    validInput = false;
                }
                else
                {
                    char row = input[0];
                    int index = rows.IndexOf(row);
                    if (index==-1)
                    {
                        //osetreni spatneho vstupu
                        validInput = false;
                    }
                    else
                    {
                        //nastavení souradnice radku podle promenne indexu
                    }
                }
            }            
        }
        static void Game() 
        {

        }
        static void PlaceShip() 
        {
            Write("Tak a teď si potřebuješ vybrat kam dáš své loďstvo");
            Console.WriteLine("\nTvé loďstvo čítá:\n");
            List<string> ship = new List<string>() { "1x Letadlová loď (velikost 1x5): L", "1x Bitevní loď(velikost 1x4): B", "1x Křižník (velikost 1x3): K", "1x Ponorka (velikost 1x3): P", "1x Torpédoborec (velikost 1x2): T" };
            PrintList(ship);
            Write("Jakou loď chceš umístit (zadej jen písmenko označující daný typ lodě)");
            while (ship.Count!=0)
            {                
                switch (LoadChar())
                {
                    case 'L':
                        Console.WriteLine("Hurááááá");
                        ship.RemoveAt(0);
                        break;
                    case 'B':
                        Console.WriteLine("Hurááááá");
                        ship.RemoveAt(1);
                        break;
                    case 'K':
                        Console.WriteLine("Hurááááá");
                        ship.RemoveAt(2);
                        break;
                    case 'P':
                        Console.WriteLine("Hurááááá");
                        ship.RemoveAt(3);
                        break;
                    case 'T':
                        Console.WriteLine("Hurááááá");
                        ship.RemoveAt(4);
                        break;
                    default:
                        Write("Tak takovou loď neznám, zkus to znova!");
                        break;
                }
                Write("Jakou loď chceš umístit (zadej jen písmenko označující daný typ lodě)");
                PrintList(ship);
            }            
        }
        static void Main(string[] args)
        {
            Write("Hola hej kapitáne, pojď si zahrát jednu přátelskou partičku lodí.");
            string[,] arrayP = new string[11, 11]; //string array player
            string[,] arrayC = new string[11, 11]; //string array computer
            string[,] arrayG = new string[11, 11]; //string array computer Game
            SetArray(arrayP);
            SetArray(arrayC);
            SetArray(arrayG);
            Write("Takhle vypadá tvoje hrací pole:");
            PrintArray(arrayP);
            PlaceShip();
            Console.ReadKey();
        }
    }
}
