using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2024-2025.
 * Extended by students.
 */

namespace _2D_Array_Playground
{
    internal class Program
    {
        static void SetArrayToDefault(int[,] array) 
        {            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int l = 0; l < array.GetLength(1); l++)
                {
                    array[i, l] = i * 5 + l + 1;
                }
            }
        }
        static void PrintArray(int[,] array) 
        {
            for (int i = 0; i <array.GetLength(0); i++)
            {
                for (int l = 0; l < array.GetLength(1); l++)
                {
                    Console.Write(array[i, l] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové 2D pole velikosti 5 x 5, naplň ho čísly od 1 do 25 a vypiš ho do konzole (5 řádků po 5 číslech).

            int[,] array = new int[5, 5];
            SetArrayToDefault(array);
            PrintArray(array);

            //TODO 2: Vypiš do konzole n-tý řádek pole, kde n určuje proměnná nRow.
            int nRow = Convert.ToInt32(Console.ReadLine());
            string row = "";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                row += array[nRow,i]+ ", ";
            }
            Console.WriteLine(row);


            //TODO 3: Vypiš do konzole n-tý sloupec pole, kde n určuje proměnná nColumn.
            int nColumn = Convert.ToInt32(Console.ReadLine());           
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write(array[i,nColumn] + " ");
            }
            Console.WriteLine("\n");

            //TODO 4: Prohoď prvek na souřadnicích [xFirst, yFirst] s prvkem na souřadnicích [xSecond, ySecond] a vypiš celé pole do konzole po prohození.
            //Nápověda: Budeš potřebovat proměnnou navíc, do které si uložíš první z prvků před tím, než ho přepíšeš druhým, abys hodnotou prvního prvku potom mohl přepsat druhý
            int xFirst = 2;
            int yFirst = 2;
            int xSecond = 3;
            int ySecond = 2;
            int a = array[xFirst,yFirst];
            array[xFirst, yFirst] = array[xSecond, ySecond];
            array[xSecond, ySecond] = a;
            PrintArray(array);
            Console.WriteLine("\n");

            //TODO 5: Prohoď n-tý řádek v poli s m-tým řádkem (n je dáno proměnnou nRowSwap, m mRowSwap) a vypiš celé pole do konzole po prohození.
            int nRowSwap = 0;
            int mRowSwap = 1;
            int backup;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                backup = array[nRowSwap, i];
                array[nRowSwap, i] = array[mRowSwap, i];
                array[mRowSwap, i] = backup;
            }
            PrintArray(array);
            Console.WriteLine("\n");

            //TODO 6: Prohoď n-tý sloupec v poli s m-tým sloupcem (n je dáno proměnnou nColSwap, m mColSwap) a vypiš celé pole do konzole po prohození.
            int nColSwap = 0;
            int mColSwap = 1;
            int backup2;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                backup2 = array[i, nColSwap];
                array[i, nColSwap] = array[i, mColSwap];
                array[i, mColSwap] = backup2;
            }
            PrintArray(array);
            Console.WriteLine("\n");

            //TODO 7: Otoč pořadí prvků na hlavní diagonále (z levého horního rohu do pravého dolního rohu) a vypiš celé pole do konzole po otočení.
            
            SetArrayToDefault(array);
            int backup3;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                backup3 = array[i, i];
                array[i, i] = array[array.GetLength(0) - i-1, array.GetLength(1) - i - 1];
                array[array.GetLength(0) - i-1, array.GetLength(1) - i - 1] = backup3;
                PrintArray(array);
            }

            //TODO 8: Otoč pořadí prvků na vedlejší diagonále (z pravého horního rohu do levého dolního rohu) a vypiš celé pole do konzole po otočení.

            for (int i = 0; i < array.GetLength(0); i++)
            {
                backup = array[i, array.GetLength(0) - i - 1];
                array[i, array.GetLength(0) - i - 1] = array[array.GetLength(0) - i - 1, i];
                array[array.GetLength(0) - i - 1, i] = backup;
            }

            Console.ReadKey();
        }
    }
}
