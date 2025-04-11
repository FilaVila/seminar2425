using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OPP_realOpakovani
{
    internal class Player: Entity, Interface1
    {
        int money;
        string profession;
        public Player(int health, string name, int money, string profession):base(health, name) 
        {
            this.money = money;
            this.profession = profession;
        }

        public string damageType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void GetDamage()
        {
            throw new NotImplementedException();
        }
    }
}
