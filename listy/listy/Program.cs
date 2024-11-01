using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listy
{
    internal class Program
    {
        static string wList ="";
        static List<string> myList = new List<string>();

        static void PrintList(List<string> list) 
        {
            Console.WriteLine("\ntoto je tvůj list");
            foreach (string i in myList)
            {
                wList += i+", ";
            }
            Console.WriteLine(wList);
        }

        static void Add() 
        {
            wList = "";
            Console.WriteLine("tak jaké jídlo přidáme");
            while (true)
            {
                string chalkos = Console.ReadLine();
                if (myList.Contains(chalkos))
                {
                    Console.WriteLine("sorry tohle jídlo už tam je, zadej nové");
                }
                else
                {
                    myList.Add(chalkos);
                    break;
                }
            }
            PrintList(myList);
            Console.WriteLine("Chceš přidat ještě nějaqké své oblíbené jídlo (ano/ne)");
            if (Console.ReadLine() == "ano")
            {
                Add();
            }
        }
        static void Remove() 
        {
            wList = "";
            Console.WriteLine("tak jaké jídlo odebereme");
            while (true)
            {
                string chalkos2 = Console.ReadLine();
                if (myList.Contains(chalkos2))
                {
                    myList.Remove(chalkos2);
                    break;                    
                }
                else
                {
                    Console.WriteLine("sorry takové číslo tam není zkus to znova");
                    break;
                }
            }
            PrintList(myList);
            Console.WriteLine("Chceš přidat ještě nějaqké své oblíbené jídlo (ano/ne)");
            if (Console.ReadLine() == "ano")
            {
                Add();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Zdravím dobrodruhu");
            while (true)
            {
                Console.WriteLine("Tak co chceš dělat se svým listem: \nadd\nremove\n");
                switch (Console.ReadLine())
                {
                    case "add":
                        Add();
                        break;
                    case "remove":
                        Remove();
                        break;
                    default:
                        Console.WriteLine("Tak ty seš fakt mentál končím");
                        break;
                }
                Console.WriteLine("tak chceš ještě pokračovat v jiné operaci\nano\nne");
                if (Console.ReadLine()=="ne")
                {
                    break;
                }
            }            
            Console.WriteLine("ok jdeme na slovníky");
            Dictionary<string, string> myDic = new Dictionary<string, string>();
            myDic["apple"] = "jablko";
            myDic["tree"] = "strom";
            myDic["corn"] = "kukuřice";
            foreach (KeyValuePair<string,string> i in myDic)
            {
                string englishWord = i.Key;
                string czechWord = i.Value;
                Console.WriteLine("Anglické slovo "+englishWord +" má český překldad: "+czechWord );
            }
            Console.ReadKey();
        }
    }
}
