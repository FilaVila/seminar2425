using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testíklol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            float z = 3; // počet kg zrni na jednu krávu
            float b = 4 / 10;// počet balíků sena na 1 krávu 
            float v = 10; // litrů vody na 1 krávu
            float z1 = a * z;
            float b1 = b * a;
            float v1 = v * a;
            textBox2.Text = "";
            
        }
    }
}
