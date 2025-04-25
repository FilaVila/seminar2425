using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kruhy
{
    public class kruh
    {
        public int x, y;
        public int velikost;
        public Pen pero;
       
        public void Zvetsovanim() 
        {
            velikost += 10;
        }
        public void Zmensovani() 
        {
            velikost -= 10;
        }

    }
}
