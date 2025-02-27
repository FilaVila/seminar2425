using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPG2
{
    internal class Program
    {        
        public static void Stats2(MainCharacter mainCh) 
        {
            Write("Tvoje zdraví je " + mainCh.health + " tvůj mocný útok činní " + mainCh.attack + ".");
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
        static void Main(string[] args)
        {
            Write("Zdravím dobroduhu, jaké je tvé vznešené jméno?");
            MainCharacter mainCh = new MainCharacter(Console.ReadLine(), 100, 30);
            Write("\n" + mainCh.name + ", mladý rytíř s odvahou v srdci, dorazil do malebného města Harare. Zvěsti o nebezpečném banditovi jménem Appa, který terorizuje okolní oblasti, plnily ulice města. " + mainCh.name + ", odhodlaný postavit se zlu, se vydal do srdce města, kde narazil na dva obyvatele (NPC bez duše).");
            Longinus longinus = new Longinus("Longinus");//mohl bych výrazně zjednodušit, ale baví mě kolirát jsem byl schopen použít longinus na jednom řádku
            longinus.Interaction(mainCh);
            Stats2(mainCh);
            Hildegarda hildegarda = new Hildegarda("Hildegarda");
            hildegarda.Interaction(mainCh);
            Stats2(mainCh);            
            Enemy appa = new Enemy("Appa", 100, 25);
            appa.Interaction(mainCh, appa);
            Console.ReadKey();
        }
    }
}
