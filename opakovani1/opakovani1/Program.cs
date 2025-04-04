using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opakovani1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pole, nedokážu změnit velikost

            int[] numberArray = new int[10]; //pole s 10 místy, prázdné
            int[] numberArray2 = { 1,2,3,4,5,6,7,8,9,10};//rovnou naplníme
            int[] numberArray3 = new int[10] { 1,2,3,4,5,6,7,8,9,10}; //neměnná velikost

            int b = numberArray2[4];

            numberArray = new int[9]; //změna velikosti na 9
            numberArray.CopyTo(numberArray2, 0); //zkopíruje do každého 
            numberArray.Clone(); //shallow copy, reálně kopíruje
            numberArray.Sum();
            numberArray.Average();
            numberArray.ToList(); // převede do listu

            int[,] twoDimArray = new int[3,3];
            int[,,] threeDimArray = new int[3,3,3];
            int[,] twoDimArray2 = {{ 1, 2, 3 },{ 1, 2, 3 },{ 1, 2, 3 } };

            int a = twoDimArray2.GetLength(0); //nutné zadat dimenzi
            foreach (int i in numberArray2) 
            {
                //bez problému
            }

            for (int i = 0; i < numberArray2.GetLength(0); i++) 
            {

            }

            //listy, nemusím zadávat délku, je nulové velikosti dokud neřeknu jinak

            List<int> myList = new List<int>() { 1,2,3,4,5,7,8,9,10};
            myList[4] = 5;
            myList.Add(12); //nakonec přidám
            myList.Remove(5);//smaže první 5, kterou najde
            myList.RemoveAt(0);//smaže na indexu 0
            myList.RemoveRange(0, 5); //od kud, kolik
            myList.Count();//spočítá prvky
            myList.Find(x=> x==5); //najde 5 a vypíše index
            myList.Insert(0, 12);//kam chci vkládat a co chci vložit
            myList.Sort();

            //slovníky: klíč a hodnota

            Dictionary<int,int> myDict = new Dictionary<int,int>();
            myDict[0] = 1; // 0 je index = klíč, 1 je hodnota

            Dictionary<string, int> myDic2 = new Dictionary<string, int>();
            myDic2["tvoje máma"] = 6;

            foreach (KeyValuePair<int,int> kvp in myDict) 
            {
                //Console.WriteLine(kvp.Key+" --> "+kvp.Value);
            }

            //quick sort



        }
    }
}
