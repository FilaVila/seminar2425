using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_realOpakovani
{
    abstract class Entity
    {
        int health;
        string name;

        public Entity(int health, string name) 
        {
            this.health = health;
            this.name = name;
        }
        public void Introduce() 
        {
            Console.WriteLine("This is "+name);
        }

    }
}
