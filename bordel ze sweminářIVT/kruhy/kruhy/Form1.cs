using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kruhy
{
    public partial class Form1 : Form
    {
        kruh kruh1 = new kruh();
        kruh kruh2 = new kruh();
        Potomek kruh3 = new Potomek();
        public Form1()
        {
            InitializeComponent();            

        }       

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V)
            {
                kruh1.Zvetsovanim();
                kruh2.Zvetsovanim();
            }
            if (e.KeyCode == Keys.M)
            {
                kruh1.Zmensovani();
                kruh2.Zmensovani();
            }
            if (e.KeyCode ==Keys.A)
            {
                kruh3.Doleva();
            }
            if (e.KeyCode ==Keys.D)
            {
                kruh3.Doprava();
            }
            Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            Pen pen = new Pen(Color.Red, 3);
            Pen pen2 = new Pen(Color.Blue, 3);

            kruh1.velikost = 50;
            kruh1.x = 0;
            kruh1.y = 0;
            kruh1.pero = pen;

            
            kruh2.velikost = 50;
            kruh2.x = 0;
            kruh2.y = 200;
            kruh2.pero = pen;

            kruh3.velikost = 30;
            kruh3.pero = pen2;
            kruh3.x = 10;
            kruh3.y = 100;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawEllipse(kruh1.pero, kruh1.x, kruh1.y, kruh1.velikost, kruh1.velikost);
            g.DrawEllipse(kruh2.pero, kruh2.x, kruh2.y, kruh2.velikost, kruh2.velikost);
            g.DrawEllipse(kruh3.pero,kruh3.x,kruh3.y, kruh3.velikost,kruh3.velikost);
        }
    }
}
