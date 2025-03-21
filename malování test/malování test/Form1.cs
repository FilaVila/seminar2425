using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace malování_test
{
    public partial class Form1 : Form
    {
        Graphics panelGraphics;
        public Form1()
        {
            InitializeComponent();
            panelGraphics = panel1.CreateGraphics();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Brush brush = new SolidBrush(Color.Green);
            Pen pen = new Pen(Color.Black, 5);
            panelGraphics.DrawEllipse(pen, 50, 50, 20, 20);
            panelGraphics.FillRectangle(brush, 100, 150, 30, 30);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
