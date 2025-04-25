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
        public Form1()
        {
            InitializeComponent();            

        }       

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           /*if (KeyPress. == 'm')
            {

            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            Pen pen = new Pen(Color.Red, 3);

            kruh1.velikost = 50;
            kruh1.x = 0;
            kruh1.y = 0;
            kruh1.pero = pen;

            
            kruh2.velikost = 50;
            kruh2.x = 0;
            kruh2.y = 200;
            kruh2.pero = pen;
            Refresh();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawEllipse(kruh1.pero, kruh1.x, kruh1.y, kruh1.velikost, kruh1.velikost);
            g.DrawEllipse(kruh1.pero, kruh2.x, kruh2.y, kruh2.velikost, kruh2.velikost);
        }
    }
}
