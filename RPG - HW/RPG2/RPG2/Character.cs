using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPG2
{
    public abstract class Character
    {
        public string name;
        public int health;
        public int attack;

        public void Write(string m)
        {
            foreach (char l in m)
            {
                Console.Write(l);
                Thread.Sleep(25);
            }
            Console.WriteLine("\n");
        }
        public virtual void Attack(MainCharacter mainCh, Enemy enemy) 
        {
            
        }        
        public void Stats(MainCharacter mainCh, Enemy appa)
        {
            Write("Tvoje zdraví je " + mainCh.health + " tvůj mocný útok činní " + mainCh.attack + ". " + appa.name + " je na tom takto, zdraví: " + appa.health + ", útok: " + appa.attack + ".");
        }             
    }
}
