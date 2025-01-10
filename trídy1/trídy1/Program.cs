using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trídy1
{
    internal class Program
    {
        static void Duel(Player player, Enemy bandit) 
        {
            player.StateInfo();
            bandit.StateInfo();
            while (player.IsAlive() && bandit.IsAlive())
            {
                bandit.Hurt(player.Attack());
                if (bandit.IsAlive())
                {
                    player.Hurt(bandit.Attack());
                }
            }
        }
        static void Main(string[] args)
        {
            Player player = new Player("Řehoř", 100,10);
            Random rnd = new Random();
            while (player.IsAlive())
            {
                Enemy enemy = new Enemy("Test", rnd.Next(5,20), rnd.Next(5,10), rnd.Next(5, 10));
            }
            Enemy bandit = new Enemy("Bandit", 20, 4, 1);
            Duel(player, bandit);
            Enemy bandit2 = new Enemy("ZlýŘehoř", 30, 8, 3);
            Duel(player, bandit2);
            Console.ReadKey();
        }
    }
}
