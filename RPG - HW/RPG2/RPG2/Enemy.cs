using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2
{
    public class Enemy:Character
    {
        public Enemy(string name, int health, int attack)
        {
            this.name = name;
            this.health = health;
            this.attack = attack;
        }
        public override void Attack(MainCharacter mainCh, Enemy enemy)
        {
            Random rnd = new Random();
            mainCh.health -= enemy.attack*rnd.Next(1,5);
        }
        public void Stats2(MainCharacter mainCh)
        {
            Write("Tvoje zdraví je " + mainCh.health + " tvůj mocný útok činní " + mainCh.attack + ".");
        }
        public char LoadDecisionH() //funkce načte vstup, a pokud je char, tak vrátí
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
        public void Interaction(MainCharacter mainCh, Enemy enemy) 
        {
            Write("Po dlouhém hledání se "+mainCh.name+ " podařilo najít tábor, kde Appa přebýval. Po bližšímn prozkoumání ho napadly tři možnosti, jak na Appu zaútočit:\n\nPřímý Útok: " + mainCh.name + " se postavil Appa tváří v tvář v otevřeném boji.(útok + 10, zdraví - 10) - A\n\nTaktický Útok: " + mainCh.name + " zvolil taktický přístup, využil okolní prostředí a léčky.(zdraví + 5, útok + 5) - B\n\nSkrytý Útok: " + mainCh.name + " se rozhodl zaútočit skrytě, získal překvapení nad banditou. (zdraví + 10, útok - 10) - C\n");
            switch (LoadDecisionH()) 
            {
                case 'A':
                    Write(mainCh.name + " se rozhodl pro Přímý útok. \nTvoje statistiky před hlavním soubojem jsou: \n");
                    mainCh.health -= 10;
                    mainCh.attack += 10;
                    Stats2(mainCh);
                    break;
                case 'B':
                    Write(mainCh.name + " se rozhodl pro Taktický útok. \nTvoje statistiky před hlavním soubojem jsou: \n");
                    mainCh.health += 5;
                    mainCh.attack += 5;
                    Stats2(mainCh);
                    break;
                case 'C':
                    Write(mainCh.name + " se rozhodl pro Skrytý útok. \nTvoje statistiky před hlavním soubojem jsou: \n");
                    mainCh.health += 10;
                    mainCh.attack -= 10;
                    Stats2(mainCh);
                    break;
                default:
                    Write("Nedokázal jsi se rozhodnout (netrefil jsi klávesu, všechny statistiky ti zůstavájí, jen ti k jménu přidám titul co si zasloužíš)");
                    mainCh.name += " z Neumětelova";
                    break;
            }
            Write("Po zvolení strategie už nebylo na co čekat a " + mainCh.name + " vyrazil proti Appovi.\n");
            mainCh.Combat(mainCh, this);
            Write("\n" + mainCh.name+ " se podařilo Appu porazit a záchranit celé město!!! \nGratuluji a děkuji, že si si zahrál moji hru!");
        }
    }
}
