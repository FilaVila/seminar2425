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
        static char LoadChar() //"funkce" načte input od uživatele a zkusí jestli je to cahr, a bude to zkouset dokud se uzivatel netrefí
        {
            char letter = 'A'; // funkce kontroluje vstup pro tzp lodě
            bool n = false;
            while (n == false)
            {
                try
                {
                    string input = Console.ReadLine().ToUpper();
                    if (input.Length != 1 || !"LBKPT".Contains(input))
                    {
                        Write("Neplatný vstup. Zadejte jeden ze směrů: Nahoru (N), Dolů (D), Doleva (L), Doprava (P).");
                    }
                    else
                    {
                        letter = char.Parse(input);
                        n = true;
                    }
                }
                catch (FormatException)
                {
                    Write("Hele to asi nebude Char zkus to znova");
                }
            }
            return letter;
        }
        static char LoadChar2() // načítá vstup pro směr lodí
        {
            char letter = 'A';
            bool n = false;
            while (n == false)
            {
                try
                {
                    string input = Console.ReadLine().ToUpper();
                    if (input.Length != 1 || !"NDLP".Contains(input))
                    {
                        Write("Neplatný vstup. Zadejte jeden ze směrů: Nahoru (N), Dolů (D), Doleva (L), Doprava (P).");
                    }
                    else
                    {
                        letter = char.Parse(input);
                        n = true;
                    }
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
        static (int row, int col) Input()
        {
            bool validInput = false;
            List<char> rows = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' }; //sloupečky

            while (!validInput)
            {
                string input = Console.ReadLine().ToUpper();
                if (input.Length != 2)
                {
                    Write("Neplatná souřadnice, zadej znovu., např A4");
                }
                else
                {
                    char rowChar = input[0];
                    int index = rows.IndexOf(rowChar);
                    if (index == -1 || !char.IsDigit(input[1]))
                    {
                        Write("Neplatná souřadnice, zadej znovu., např A4");
                    }
                    else
                    {
                        int col = int.Parse(input[1].ToString());
                        if (col < 1 || col > 10)
                        {
                            Write("Neplatná souřadnice, zadej znovu., např A4");
                        }
                        else
                        {
                            validInput = true;
                            return (index + 1, col); // vráti souřadnice bodu
                        }
                    }
                }
            }
            return (-1, -1); // jsem bychom jsme se neměli nikdy dostat
        }
        static void PlaceShip(string[,] arrayP) 
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
                        Write("A kam tetno koráb chceš umístit?\nZadej políčko, kde bude mít tvoje loď předek (např. A4): ");
                        var coordinatesL = Input(); //načte souřadnice od uživatele
                        Console.WriteLine("Tak a ješte zadej směr: Nahoru (N), Dolu (D), Doleva(L), Doprava (P)");
                        char directionL = LoadChar2();// načte směr lodi
                        PlaceShipOnBoard(arrayP, coordinatesL.col, coordinatesL.row, 5, directionL); //funkce umístí loď na hrací plochu, vkládám, pole do kterého vkládám: souř. a  velikost lodě a směr 
                        ship.Remove("1x Letadlová loď (velikost 1x5): L"); 
                        break;
                    case 'B':
                        Write("A kam tetno koráb chceš umístit?\nZadej políčko, kde bude mít tvoje loď předek (např. A4): ");
                        var coordinatesB = Input();
                        Console.WriteLine("Tak a ješte zadej směr: Nahoru (N), Dolu (D), Doleva(L), Doprava (P)");
                        char directionB = LoadChar2();
                        PlaceShipOnBoard(arrayP, coordinatesB.col, coordinatesB.row, 4, directionB);
                        ship.Remove("1x Bitevní loď(velikost 1x4): B");
                        break;
                    case 'K':
                        Write("A kam tetno koráb chceš umístit?\nZadej políčko, kde bude mít tvoje loď předek (např. A4): ");
                        var coordinatesK = Input();
                        Console.WriteLine("Tak a ješte zadej směr: Nahoru (N), Dolu (D), Doleva(L), Doprava (P)");
                        char directionK = LoadChar2();
                        PlaceShipOnBoard(arrayP, coordinatesK.col, coordinatesK.row, 3, directionK);
                        ship.Remove("1x Křižník (velikost 1x3): K");
                        break;
                    case 'P':
                        Write("A kam tetno koráb chceš umístit?\nZadej políčko, kde bude mít tvoje loď předek (např. A4): ");                                               
                        var coordinatesP = Input();
                        Console.WriteLine("Tak a ješte zadej směr: Nahoru (N), Dolu (D), Doleva(L), Doprava (P)");
                        char directionP = LoadChar2();
                        PlaceShipOnBoard(arrayP, coordinatesP.col, coordinatesP.row, 3, directionP);
                        ship.Remove("1x Ponorka (velikost 1x3): P");
                        break;
                    case 'T':
                        Write("A kam tetno koráb chceš umístit?\nZadej políčko, kde bude mít tvoje loď předek (např. A4): ");                        
                        var coordinatesT = Input();
                        Console.WriteLine("Tak a ješte zadej směr: Nahoru (N), Dolu (D), Doleva(L), Doprava (P)");
                        char directionT = LoadChar2();
                        PlaceShipOnBoard(arrayP, coordinatesT.col, coordinatesT.row, 2, directionT);
                        ship.Remove("1x Torpédoborec (velikost 1x2): T");
                        break;
                    default:
                        Write("Tak takovou loď neznám, zkus to znova!");
                        break;
                }
                if (ship.Count !=0)
                {
                    Write("Jakou loď chceš umístit (zadej jen písmenko označující daný typ lodě)");
                    PrintList(ship);
                }
                PrintArray(arrayP);
            }            
        }
        static void PlaceShipsRandomly(string[,] array) //funkce umístí lodě počítače náhodně 
        {
            List<(int size, char direction)> ships = new List<(int size, char direction)>{(5, 'N'), (4, 'D'), (3, 'L'), (3, 'P'), (2, 'N')}; //tady mi musel pomoci Mistrail AI
            Random random = new Random();
            foreach (var ship in ships)
            {
                bool placed = false;
                while (!placed)
                {
                    int startRow = random.Next(1, 11);
                    int startCol = random.Next(1, 11);
                    char direction = (char)random.Next('N', 'P' + 1);

                    bool fits = true;
                    bool overlap = false;

                    switch (direction)
                    {
                        case 'N':
                            for (int i = 0; i < ship.size; i++)
                            {
                                if (startRow - i < 1 || array[startRow - i, startCol] != "[0]")
                                {
                                    fits = false;
                                    overlap = true;
                                    break;
                                }
                            }
                            break;

                        case 'D':
                            for (int i = 0; i < ship.size; i++)
                            {
                                if (startRow + i > 10 || array[startRow + i, startCol] != "[0]")
                                {
                                    fits = false;
                                    overlap = true;
                                    break;
                                }
                            }
                            break;

                        case 'L':
                            for (int i = 0; i < ship.size; i++)
                            {
                                if (startCol - i < 1 || array[startRow, startCol - i] != "[0]")
                                {
                                    fits = false;
                                    overlap = true;
                                    break;
                                }
                            }
                            break;

                        case 'P':
                            for (int i = 0; i < ship.size; i++)
                            {
                                if (startCol + i > 10 || array[startRow, startCol + i] != "[0]")
                                {
                                    fits = false;
                                    overlap = true;
                                    break;
                                }
                            }
                            break;
                    }

                    if (fits && !overlap)
                    {
                        PlaceShipOnBoard2(array, startRow, startCol, ship.size, direction);
                        placed = true;
                    }
                }
            }
        }
        static void PlaceShipOnBoard(string[,] array, int startRow, int startCol, int shipSize, char direction)
        {
            bool fits = true; // vejde se = ano/ne
            bool overlap = false; // překrývají se = ano/ne

            switch (direction)
            {
                case 'N':
                    for (int i = 0; i < shipSize; i++)
                    {
                        if (startRow - i < 1) // kontroluje jestli se loď vejde nebo ne
                        {
                            fits = false;
                            break;
                        }
                        if (array[startRow - i, startCol] != "[0]") // kontroluje překrývání
                        {
                            overlap = true;
                            break;
                        }
                    }
                    if (fits && !overlap)
                    {
                        for (int i = 0; i < shipSize; i++)
                        {
                            array[startRow - i, startCol] = "[S]"; // označí loď na mapě
                        }
                    }
                    break;

                case 'D':
                    for (int i = 0; i < shipSize; i++)
                    {
                        if (startRow + i > 10)
                        {
                            fits = false;
                            break;
                        }
                        if (array[startRow + i, startCol] != "[0]")
                        {
                            overlap = true;
                            break;
                        }
                    }
                    if (fits && !overlap)
                    {
                        for (int i = 0; i < shipSize; i++)
                        {
                            array[startRow + i, startCol] = "[S]";
                        }
                    }
                    break;

                case 'L':
                    for (int i = 0; i < shipSize; i++)
                    {
                        if (startCol - i < 1)
                        {
                            fits = false;
                            break;
                        }
                        if (array[startRow, startCol - i] != "[0]")
                        {
                            overlap = true;
                            break;
                        }
                    }
                    if (fits && !overlap)
                    {
                        for (int i = 0; i < shipSize; i++)
                        {
                            array[startRow, startCol - i] = "[S]";
                        }
                    }
                    break;

                case 'P':
                    for (int i = 0; i < shipSize; i++)
                    {
                        if (startCol + i > 10)
                        {
                            fits = false;
                            break;
                        }
                        if (array[startRow, startCol + i] != "[0]")
                        {
                            overlap = true;
                            break;
                        }
                    }
                    if (fits && !overlap)
                    {
                        for (int i = 0; i < shipSize; i++)
                        {
                            array[startRow, startCol + i] = "[S]";
                        }
                    }
                    break;

                default:
                    Write("Špatně zadaný směr, zkus to znova");
                    return;
            }

            if (!fits)
            {
                Write("Kapitáne, že sem se ta loď opravdu nevleze....");
            }
            else if (overlap)
            {
                Write("Kapitáne, na tomto místě už je loď. Zkus to znovu.");
            }
        }
        static void PlaceShipOnBoard2(string[,] array, int startRow, int startCol, int shipSize, char direction) //stejné jako PlaceShipsOnBoard, ale bez hcybových hlášek
        {
            switch (direction)
            {
                case 'N':
                    for (int i = 0; i < shipSize; i++)
                    {
                        array[startRow - i, startCol] = "[S]";
                    }
                    break;

                case 'D':
                    for (int i = 0; i < shipSize; i++)
                    {
                        array[startRow + i, startCol] = "[S]";
                    }
                    break;

                case 'L':
                    for (int i = 0; i < shipSize; i++)
                    {
                        array[startRow, startCol - i] = "[S]";
                    }
                    break;

                case 'P':
                    for (int i = 0; i < shipSize; i++)
                    {
                        array[startRow, startCol + i] = "[S]";
                    }
                    break;
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
            PlaceShip(arrayP);
            PlaceShipsRandomly(arrayG);
            Write("hura hej funguje to");
            Console.ReadKey();
        }
    }
}
