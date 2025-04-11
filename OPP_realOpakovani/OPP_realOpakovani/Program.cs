using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_realOpakovani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Entity lojza = new Entity(10, "Lojza");
            //Entity karel = new Entity(13, "Karel");
            //karel.Introduce();

            Player honza = new Player(10,"honza",10,"archer");
            honza.Introduce();

            Npc merchant = new Npc(10,"Longinus", 999,"bitch",8);
            Console.ReadKey();
        }
    }
}
