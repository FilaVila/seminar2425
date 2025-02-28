using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPG2
{
    public abstract class Npc
    {
        public string name;
        public void Write(string m) //psaní po písmenech
        {
            foreach (char l in m)
            {
                Console.Write(l);
                Thread.Sleep(25);
            }
            Console.WriteLine("\n");
        }
        public virtual void Interaction(MainCharacter mainCH) 
        {

        }
        public virtual string LoadDecision() 
        {
            return "";
        }
    }
}
