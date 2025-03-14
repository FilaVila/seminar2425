using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Dnes bude vasim ukolem vytvorit formularovou reprezentaci kalkulacky. Priblizny vzhled si nakreslime na tabuli
 * (Pokud jsem to nenakreslil, pripomente mi to prosim!)
 * Inspirujte se kalkulackou ve Windows.
 * Pozadovane prvky/funkcionality:
 * - Tlacitka pro kazde z cisel 0-9
 * - Tlacitka pro operace +, -, *, a /
 * - Tlacitko pro = (vypsani vysledku)
 * - Textbox, do ktereho se propisou cisla/operace pri stisku jejich tlacitek
 * - Textbox s vysledkem operace (mozne sloucit s predeslym, nechavam na vas)
 * - Tlacitko pro vymazani textu v textboxu s cisly a operaci
 * 
 * Volitelne prvky/funkcionality:
 * - Tlacitko pro mazani cisel a operaci v textboxu zprava vzdy po jednom znaku
 * - Pokud mam vypsany vysledek a hned po tom stisknu tlacitko nejake operace, vysledek se vezme jako prvni cislo a
 *   rovnou mohu po zadani operace zadat druhe cislo
 * - Moznost ulozeni vysledku do nekolika preddefinovanych labelu/neinteraktivnich textboxu (treba kombinaci comboboxu a tlacitka, kde
 *   v comboboxu vyberu do ktereho labelu/textboxu se mi to ulozi a tlacitkem provedu ulozeni)
 *   + pridat tlacitko pro kazdy label/neint. textbox, kterym ulozeny vysledek pouziju jako cislo do vypoctu
 * - Pridani mocnin/odmocnin atd. (napr. pomoci dalsich tlacitek, ktere rovnou misto daneho cisla daji jeho (popr. zaokrouhlenou) odmocninu apod.)
 * - Cokoliv dalsiho vas napadne! :)
 * 
 * Snazte se o to, aby byla kalkulacka v ramci moznosti hezka, a aby bylo jeji ovladani intuitivni a aby mel kazdy prvek v okne dobre vyuziti
 */

namespace CalculatorRevisited
{
    public partial class CalculatorRevisited : Form
    {
        string a; //číslo jedna        
        char o; //operace       
        string saveAnswer; //uložení odpovědi poro další použití
        public CalculatorRevisited()
        {
            InitializeComponent();            
        }

        public void SaveNumber() 
        {
            a = textBox1.Text;
            textBox1.Text = null;

        }

        public void Calculate() 
        {
            float x = float.Parse(a);
            float y = float.Parse(textBox1.Text);
            float r = 0; //answer
            switch (o)
            {
                case '+':
                    r = x + y;
                    break;
                case '-':
                    r = x - y;
                    break;
                case '*':
                    r = x * y;
                    break;
                case '/':
                    if (y!=0)
                    {
                        textBox1.Text = "Nulou se dělit nedá.";
                    }
                    r = x / y;
                    break;
                default:
                    break;
            }
            textBox1.Text = Convert.ToString(r);
            saveAnswer = Convert.ToString(r);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            a = null;            
            o = '+';
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            o = '/';
            SaveNumber();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            o = '+';
            SaveNumber();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            o = '-';
            SaveNumber();
        }

        private void buttonNas_Click(object sender, EventArgs e)
        {
            o = '*';
            SaveNumber();
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void buttonAns_Click(object sender, EventArgs e)
        {
            textBox1.Text = saveAnswer;
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Tak zase někdy";
            timerOff.Enabled = true;
        }

        private void timerOff_Tick(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
