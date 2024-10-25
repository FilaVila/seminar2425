using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2024-2025.
 * Extended by students.
 */

namespace ArrayPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            //TODO 1: Vytvoř integerové pole a naplň ho pěti libovolnými čísly.

            int[] intArray = new int[5];
            
            for (int i = 0; i < 4; i++)
            {
                intArray[i] = rnd.Next(0,20);
            }
            //Console.WriteLine(string.Join(", ", intArray)); easy chatgpt odpověď

            //TODO 2: Vypiš do konzole všechny prvky pole, zkus jak klasický for, kde i využiješ jako index v poli, tak foreach.
            string output="";
            for (int i = 0;i < intArray.Length; i++) 
            {
                output += intArray[i] + " ";    
            }
            Console.WriteLine(output);

            //TODO 3: Spočti sumu všech prvků v poli a vypiš ji uživateli.
            int sum =0;

            foreach (int i in intArray) 
            {
                sum += i;
            }
            Console.WriteLine("\n"+"Suma všech prvků je "+sum);

            //TODO 4: Spočti průměr prvků v poli a vypiš ho do konzole.
            double average = sum/5.0;
            Console.WriteLine("\n" + "Průměr je "+average);

            //TODO 5: Najdi maximum v poli a vypiš ho do konzole.
            int max =0;
            foreach (int i in intArray) 
            {
                if (i > max) 
                {
                    max = i;
                }
            }
            Console.WriteLine("\n"+"Největší prvek je "+max);

            //TODO 6: Najdi minimum v poli a vypiš ho do konzole.
            int min = intArray[0];

            foreach (int i in intArray)
            {
                if (i<min)
                {
                    min = i;
                }
            }
            Console.WriteLine("\n" + "Nejmenší pervek je "+min);

            //TODO 7: Vyhledej v poli číslo, které zadá uživatel, a vypiš index nalezeného prvku do konzole.
            int index;
            Console.WriteLine("\n" + "Tak a teď to bude chtít tvoji součinnost. napiš mi číslo, jehož index mám napsat:");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] == input)
                {
                    Console.WriteLine("\nTebou vybrané číslo má index "+i);
                }
            }
            //TODO 8: Přepiš pole na úplně nové tak, že bude obsahovat 100 náhodně vygenerovaných čísel od 0 do 9.

            intArray = new int[10];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = rnd.Next(0, 10);
            }
            Console.WriteLine(string.Join(", ", intArray));
            //TODO 9: Spočítej kolikrát se každé číslo v poli vyskytuje a spočítané četnosti vypiš do konzole.
            int[] counts = new int[10];
            foreach (int i in intArray) 
            {
                counts[i]++;
            }
            Console.WriteLine(string.Join(", ", counts));
            //TODO 10: Vytvoř druhé pole, do kterého zkopíruješ prvky z prvního pole v opačném pořadí.
            int[] intArray2 = new int[intArray.Length];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray2[i] = intArray[intArray.Length - 1 - i];
            }
            Console.WriteLine(string.Join(", ", intArray2));
            Console.ReadKey();
        }
    }
}
