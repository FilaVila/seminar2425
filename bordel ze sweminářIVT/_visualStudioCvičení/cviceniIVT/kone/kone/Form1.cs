using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double LoadNumber(string input) // tato statická funkce načte input od uživatele a zkusí jestli je to integer
        {
            double number = 0;
            bool isInvalid = true; //boolean proměnná kontrolující while cyklus
            while (isInvalid)
            {
                try
                {
                    number = double.Parse(input);
                    isInvalid = false;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Hele to asi nebude double zkus to znova");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    return 0;
                }
            }
            return number;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double z = LoadNumber(textBox1.Text); // double abych si taky procvičil jiné proměnné než float :D
            double v = LoadNumber(textBox2.Text);
            int nH = Convert.ToInt32((z * v)/2)/50; //spočítá plochu pozemku a vyděli prostorem nutným pro 1 koně
            textBox3.Text = nH.ToString();
            if (nH<1) 
            {
                MessageBox.Show("Nevejde se ani jeden");
            }
            else if (nH<10)
            {
                MessageBox.Show("Míň než 10 koní nemá cenu");
            }
            else 
            {
                MessageBox.Show("Těšíme se na koníky :D");
            }
        }
    }
}
