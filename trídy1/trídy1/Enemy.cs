using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trídy1
{
    internal class Enemy
    {
        string name;
        int health;
        int damage;
        int level;
        Random rnd;
        public Enemy(string name, int health, int damage, int level)
        {
            this.name = name;
            this.health = health;
            this.damage = damage;
            this.level = level;
            rnd = new Random();
        }

        public void Hurt(int incDamege) 
        {
            if (health < 0) 
            {
                Console.WriteLine("Do mrtvoly se nekope");
                return;
            }
            health = health - incDamege; //enemy dostane damage
            Console.WriteLine("Enemy "+name+" dostal před držku o tolik bodů: "+incDamege);
            Console.WriteLine("Enemy health: "+health);
            if(health < 0) 
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
            return  rnd.Next(damage / 2, damage);
        }
        public void StateInfo()
        {
            string state = "Enemy " + name + " has " + health + " and deals this much damage: " + damage;
            Console.WriteLine(state);
        }
    }
}
