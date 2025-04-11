using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_realOpakovani
{
    internal class Npc:Entity
    {
        string attitude;
        int friendliness;
        int money;
        public Npc(int health, string name, int money, string attitude,int friendliness):base(health,name) 
        {
            this.friendliness = friendliness;
            this.attitude = attitude;
            this.money = money;
        }
        
    }
}
