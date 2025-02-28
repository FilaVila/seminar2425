using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2
{
    public class MainCharacter: Character
    {
        public MainCharacter(string name, int health, int attack) 
        {
            this.name = name;
            this.health = health;
            this.attack = attack;
        }
        public override void Attack(MainCharacter mainCh, Enemy enemy)
        {
            enemy.health -= mainCh.attack;
        }
        public char LoadDecision() //funkce načte vstup, a pokud je char, tak vrátí
        {
            char output;
            while (true)
            {
                if (char.TryParse(Console.ReadLine(), out output))
                {
                    return output;
                }
                else
                {
                    Write("Nevím, co si tím chtěl říct udatný bojovníku");
                }
            }
        }
        public void Combat(MainCharacter mainCh, Enemy enemy) //kombat
        {
            int i = 0;
            int j = 0;
            Write("Ocitáš se tváří v tvář " + enemy.name + ". Vaše pohledy se střetnou a rovnou si jdete po krku");
            Console.WriteLine("Boj začal!!!\n\nÚtok!!! - A\n\nObrana je nejlepší útok. - B\n\nZkusím začít souboj zatancováním ...to ho jistě rozhodí. - C");
            while (mainCh.health > 0 && enemy.health > 0)
            {
                if (i > 0) // zajišťuje, že není možno tancovat znova
                {
                    Stats(mainCh, enemy);
                    Console.WriteLine("Nepřítel stále stojí!!! \nÚtok!!! - A\nObrana je nejlepší útok. - B\n");
                }
                i++;
                switch (LoadDecision())
                {
                    case 'A':
                        mainCh.Attack(mainCh, enemy);
                        enemy.Attack(mainCh, enemy);
                        Write("Zaútočil jsi na protivnika!!! A on ti útok, než bys řekl Raksakorikofalapatorius, vrátil\n");
                        break;
                    case 'B':
                        enemy.Attack(mainCh, enemy);
                        mainCh.health += 15;
                        Write("Zkusil si odrazit nepřítelovu ránu....ale s limitovaným úspěchem");
                        break;
                    case 'C':
                        if (j == 0)
                        {
                            Write("Nepřítel se lekl a upustil část své zbroje! (Enemy Health - 10)");
                            enemy.health -= 10;
                            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=xvFZjo5PgG0");
                            j++;
                        }
                        else
                        {
                            Write("Takovéto fintičky už si " + enemy.name + "nenechá líbit a uštědří ti pořádnou ránu");
                            enemy.Attack(mainCh, enemy);
                        }
                        break;
                    default:
                        Write("Při boji na život a na smrt není prostor pro chyby.....");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                }
            }
            if (mainCh.health <= 0) //nepřítel tě porazil (v podstatě nemožné)
            {
                Write("Bojoval si statečně, ale nakonec ti to k ničemu nebylo. RIP");
                Console.WriteLine("Děkuji, že si si zahrál moji hru :D");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
