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
                        Write("To nebude jeden z typů lodí, zkus to znova...");
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
                        Write("Student VŠE detekován. Zadejte jeden ze směrů: Nahoru (N), Dolů (D), Doleva (L), Doprava (P).");
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
            array[0, 0] = "[:D]"; //horní levé políčko (aby bylo pole hezky zarovnané)
            for (int i = 1; i < array.GetLength(0) - 1; i++) // řádky
            {
                array[i, 0] = "[" + (i) + "] ";
            }
            array[10, 0] = "[10]"; //dolní levé políčko
            for (int i = 1; i <= 10; i++) //sloupečky
            {
                array[0, i] = "[" + (char)('A' + i - 1) + "]"; // ChatGpt vařil
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
                    Write("Blbá souřadnice, zadej znovu., např A4");
                }
                else
                {
                    char rowChar = input[0];
                    int index = rows.IndexOf(rowChar);
                    if (index == -1 || !char.IsDigit(input[1]))
                    {
                        Write("Blbá souřadnice, zadej znovu., např A4");
                    }
                    else
                    {
                        int col = int.Parse(input[1].ToString());
                        if (col < 1 || col > 10)
                        {
                            Write("Blbá souřadnice, zadej znovu., např A4");
                        }
                        else
                        {
                            validInput = true;
                            return (index + 1, col); // vráti souřadnice bodu
                        }
                    }
                }
            }
            return (-1, -1); // sem bychom jsme se neměli nikdy dostat
        }
        static void PlaceShip(string[,] arrayP)
        {
            bool userIsNotMonkey = false;
            Write("Teď si potřebuješ vybrat, kam umístíš své loďstvo.");
            Console.WriteLine("\nTvé loďstvo čítá:\n");
            List<string> ship = new List<string>() { "1x Letadlová loď (velikost 1x5): L", "1x Bitevní loď(velikost 1x4): B", "1x Křižník (velikost 1x3): K", "1x Ponorka (velikost 1x3): P", "1x Torpédoborec (velikost 1x2): T" };
            PrintList(ship);
            Write("Jakou loď chceš umístit? (zadej písmenko označující daný typ lodi)");
            while (ship.Count != 0)
            {
                char shipType = LoadChar(); // načte typ lodi od uživatele a běda mu jestli to bude mít špatně
                int shipSize = 0;
                switch (shipType)
                {
                    case 'L': shipSize = 5;
                        break;
                    case 'B': shipSize = 4;
                        break;
                    case 'K': shipSize = 3;
                        break;
                    case 'P': shipSize = 3;
                        break;
                    case 'T': shipSize = 2;
                        break;
                    default:
                        Write("Tak takovou loď neznám, zkus to znovu!");
                        continue;
                }
                Write("Kam chceš umístit svůj koráb? Zadej souřadnice (např. A4):");
                var coordinates = Input();
                Write("Teď zadej směr: Nahoru (N), Dolů (D), Doleva (L), Doprava (P):");
                while (!userIsNotMonkey)
                {
                    char direction = LoadChar2();
                    if (PlaceShipOnBoard(arrayP, coordinates.col, coordinates.row, shipSize, direction))
                    {
                        userIsNotMonkey = true;
                        Write("Loď byla úspěšně umístěna!");
                        ship.Remove(ship.Find(s => s.Contains(shipType.ToString()))); //pomoc od Mistrail
                    }
                    else
                    {
                        Write("Nějak se mi nepovedlo loď umístit, zkus to znovu.");
                    }
                }
                userIsNotMonkey = false; // Rvrátí bool do původního stavu
                if (ship.Count != 0)
                {
                    Write("Jakou loď chceš umístit? (zadej písmenko označující daný typ lodi)");
                    PrintList(ship);
                }
                PrintArray(arrayP);
            }
        }
        static void PlaceShipsRandomly(string[,] array) //funkce umístí lodě počítače náhodně, moje původní verze umis´tování lodí na hrací plochu
        {
            List<(int size, char direction)> ships = new List<(int size, char direction)> { (5, 'N'), (4, 'D'), (3, 'L'), (3, 'P'), (2, 'N') }; //tady mi musel pomoci Mistrail AI
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
        static bool PlaceShipOnBoard(string[,] array, int startRow, int startCol, int shipSize, char direction)
        {
            int rowStep = 0, colStep = 0; // Určí kroky pro každý směr
            switch (direction)
            {
                case 'N': rowStep = -1; break;
                case 'D': rowStep = 1; break;
                case 'L': colStep = -1; break;
                case 'P': colStep = 1; break;
                default:
                    Write("Špatně zadaný směr, zkus to znovu.");
                    return false;
            }
            for (int i = 0; i < shipSize; i++)// kontrola, ¨jestli se loď vejde na hrací plochu
            {
                int currentRow = startRow + i * rowStep;
                int currentCol = startCol + i * colStep;

                if (currentRow < 1 || currentRow > 10 || currentCol < 1 || currentCol > 10)
                {
                    Write("Kapitáne, sem se ta loď opravdu nevleze....");
                    return false;
                }

                if (array[currentRow, currentCol] != "[0]")
                {
                    Write("Kapitáne, na tomto místě už je loď. Zkus to znovu.");
                    return false;
                }
            }
            for (int i = 0; i < shipSize; i++)// Umístění lodi na pole 3000 ultra pro max
            {
                int currentRow = startRow + i * rowStep;
                int currentCol = startCol + i * colStep;
                array[currentRow, currentCol] = "[S]";
            }
            return true;
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
        static void Game(string[,] arrayP, string[,] arrayC, string[,] arrayG) 
        {
            bool strike = false;
            int scoreC = 0; //computer score
            int scoreP = 0; // plaxer score
            while (scoreC==17 || scoreP == 17)
            {
                Console.Clear(); //vyčístí konzoli od bordelu
                PlayerTurn(arrayP, arrayC, arrayG);
                if (strike)
                {
                    strike = false;
                    scoreP++;
                }                
                ComputerTurn(arrayP,arrayC,arrayG);
                if (strike)
                {
                    strike = false;
                    scoreC++;
                }
                CompletePrintArray(arrayP, arrayC);
            }
            if (scoreC == 17)
            {
                Write("Je mi to líto, počítač vyhrál");
            }
            else 
            {
                Write("Gratuluji, po půlhodině si vyhrál....stálo to za to?");
            }
        }
        static bool PlayerTurn(string[,] arrayP, string[,] arrayC, string[,] arrayG) 
        {
            Write("Tak na jakou pozici zaútočíme?");
            var coordinatesA = Input(); //coordinatesATTACK
            if (arrayG[coordinatesA.row, coordinatesA.col] == "[S]")
            {                
                arrayC[coordinatesA.row, coordinatesA.col] = "[X]";
                Console.WriteLine("Loď zasažena");
                return true;
            }
            else 
            {
                arrayC[coordinatesA.row, coordinatesA.col] = "[N]"; // n jako nic
                Console.WriteLine("Vedle, zasmál se počítač.");
                return false;
            }
        }
        static void ComputerTurn(string[,] arrayP, string[,] arrayC, string[,] arrayG) 
        {

        }
        static void Main(string[] args)
        {
            Write("Hola hej kapitáne, pojď si zahrát jednu přátelskou partičku lodí.");
            string[,] arrayP = new string[11, 11]; //string array player
            string[,] arrayC = new string[11, 11]; //string array guessing where to strike
            string[,] arrayG = new string[11, 11]; //string array computer Game
            SetArray(arrayP);
            SetArray(arrayC);
            SetArray(arrayG);
            Write("Takhle vypadá tvoje hrací pole:");
            PrintArray(arrayP);
            PlaceShip(arrayP);
            PlaceShipsRandomly(arrayG);
            Console.Clear();
            Write("Tak a teď přejdeme k samotné hře");
            CompletePrintArray(arrayP,arrayC);
            Game(arrayP,arrayC,arrayG);
            Console.ReadKey();
        }
    }
}
