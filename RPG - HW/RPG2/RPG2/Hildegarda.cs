using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2
{
    public class Hildegarda: Npc
    {
        public Hildegarda(string name) 
        {
            this.name = name;
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
        public override void Interaction(MainCharacter mainCh)
        {
            Write("Dále náš hrdina potkal Hildegardu, mladou dívku v nesnázích. Její bratr René byl unesen Appyným pomocníkem, a ona zoufale potřebovala pomoc. "+ mainCh.name + " se ocitl před dalším rozhodnutím:\n\nPomoc Hildegardě: " + mainCh.name + " se rozhodl pomoci Hildegardě. - A\n\nIgnorování Hildegardy: "+ mainCh.name + " se rozhodl ignorovat prosbu Hildegardy a zaměřil se na poražení hlavního bandity Appy. - B\n");
            switch (LoadDecisionH()) 
            {
                case 'A':
                    Write(mainCh.name + " se od Hildegardy dozvěděl, že jejího bratra Reného drží Appyn pomocník v jeskyni za městem. Náš dobrodruch se tedy do oné jeskyně vydal. Souboj byl nevyhnutelný.\n");
                    SideQuest(mainCh);
                    return;
                case 'B':
                    Write(mainCh.name + " se rozhodl Hildegardě nepomoci, ta mu za projevenou ochotu prokopla koleno. (útok - 10)\n");
                    mainCh.attack -= 10;
                    return;
                default:
                    Write("Zasažen Hildegardinou krásou jsi se nezmohl na víc, než nějaký nesmysluplný pazvuk. Hildegarda se ti odměnila pořádnou fackou. (zdraví -10)");
                    mainCh.health -= 10;
                    return;
            }
        }
        public void SideQuest(MainCharacter mainCh) 
        {
            Enemy bandit = new Enemy("bandit", 50,30);
            mainCh.Combat(mainCh,bandit);
            Write(", ale už mu to nebylo nic platné. PDodařilo se ti porazit Appova pomocníka a jako odměnu jsi od Reného dostal jeho legendární meč 'NGGYUNGLYD', který měl celou dobu u sebe.(útok + 50)\n ");
            mainCh.attack += 50;
        }
    }
}
