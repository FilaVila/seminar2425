using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG2
{
    public class Longinus: Npc
    {
        public Longinus(string name) 
        {
            this.name = name;
        }

        public override string LoadDecision()
        {
            string input;
            bool userDoesNotHaveBrain = false;
            while (userDoesNotHaveBrain == false) 
            {
                input = Console.ReadLine();
                if (input == "Boring" |input =="SneakyPeaky")
                {
                    userDoesNotHaveBrain = true;
                    return input;
                }
                Write("Úplně si nejsem jistý, co si tím chtěl říci (zvol jednu z variant Boring/SneakyPeaky)");
            }
            return null;
        }
        public void Theft(MainCharacter mainCh) 
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 7);
            if (a == 1)
            {
                Write(mainCh.name + " se zachoval jako skutečný hrdina. Dal Longinusovi hrnec přes hlavu a okradl ho o jeho elixíry. (zdraví + 30)\n");
                mainCh.health += 30;                
            }
            else
            {
                Write(mainCh.name + " byl přistižen při pokusu o krádež. Když se snažil utéci před rozzuřeným prodavačem lektvarů, praštil se hlavou o futra. (zdraví - 20)\n");                
                mainCh.health -= 20;
            }
        }
        public override void Interaction(MainCharacter mainCh)
        {
            Write("\nNa hlavním náměstí stál Longinus, místní obchodník. Jeho krám byl plný lektvarů. Longinus nabídl "+ mainCh.name + " možnost posílit svou výbavu, a tak mladý rytíř stál před rozhodnutím:\n\nPřátelská Interakce s Longinem: " + mainCh.name + " si od něj koupil lektvary uzdravení.- Boring\n\nNepřátelská Interakce s Longinem: "+ mainCh.name + " se rozhodl zkusit okrást obchodníka.- SneakyPeaky\n");//snad uživatel pochopí co má napsat
            if (LoadDecision() == "Boring")
            {
                Write(mainCh.name + " zvolil přátelskou variantu a koupil od Longinuse lektvar uzdravení (zdraví + 15, útok -10).\n");
                mainCh.health += 15;
                mainCh.attack -= 10;
            }
            else 
            {
                Theft(mainCh);
            }

        }
    }
}
