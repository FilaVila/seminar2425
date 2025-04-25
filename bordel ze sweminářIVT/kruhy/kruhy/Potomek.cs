using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kruhy
{
    internal class Potomek: kruh
    {
        public void Doleva() 
        {
            x -= 10;
        }
        public void Doprava() 
        {
            x += 10;
        }
    }
}
