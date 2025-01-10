using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace trídy1
{
    internal class Player
    {
        public string name;
        public int health;
        int damage;
        Random rnd;

        public Player(string name, int health, int damage) 
        {
            this.name = name;
            this.health = health;
            this.damage = damage;
            rnd = new Random();
        }

        public void SetDamage(int value) 
        {
            damage = value;
            if (damage <= 0) 
            {
                damage = 1;
            }
        }
        public void Hurt(int incDamege)
        {
            health = health - incDamege; 
            Console.WriteLine("Player " + name + " dostal před držku o tolik bodů: " + incDamege);
            Console.WriteLine("Player health: " + health);
            if (health < 0)
            {
                Console.WriteLine(name + " is dead....sad");
            }
        }
        public bool IsAlive() 
        {
            return (health > 0);
        }

        public int Attack() 
        {
            return rnd.Next(damage/2, damage+damage/2);
        }
        public void StateInfo()
        {
            string state = "Player " + name + " has " + health + " and deals this much damage: " + damage;
            Console.WriteLine(state);
        }
    }
}
