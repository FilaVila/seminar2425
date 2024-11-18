using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ivtTestik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int LoadNumber(string input) // tato statická funkce načte input od uživatele a zkusí jestli je to integer
        {
            int number = 0;
            bool isInvalid = false; //boolean proměnná kontrolující while cyklus
            while (isInvalid == false)
            {
                try
                {
                    number = int.Parse(input);
                    isInvalid = true;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Hele to asi nebude integer zkus to znova");
                }
            }
            return number;
        }
        static float RoundIt(float number) //statická funkce načte float zaokrouhlí ho a vrátí
        {
            float fNumber = (float)Math.Round(number, 1);
            return fNumber; //fNumber = finished number
        }

        private async Task Write(string message) //async funkce umožňuje provádět operaci aniž by to "zastavilo zbylý chod aplikace"
        {                                       //šikovné pro práci s časem, tady je odkaz na vysvětlení:https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/
            string eMessage =""; // empty message
            foreach (var item in message) 
            {
                eMessage = eMessage + item.ToString();
                textBox2.Text=(eMessage);
                await Task.Delay(30);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a = LoadNumber(textBox1.Text);
            float z = RoundIt(3.0f * a * 7); //3 kg zrní na 1 krávu * počet krav * 7 dní v týdnu
            float s = RoundIt(0.4f * a * 7); // za 0.4 je f, abychom to definovali jako float (nemůžeme z integeru a doublu udělat jen tak float)
            float v = RoundIt(10f * a * 7); // v jako voda :D
            Write("Na týden bude potřeba " + z + " kg zrní a " + s + " balíků sena " + v + " l vody.");
            //textBox2.Text = ("Na týden bude potřeba "+ z +" kg zrní a " + s + " balíků sena "+v +" l vody."); //alternativní možnost pro lidi z Omský
            MessageBox.Show("Kolik má kráva žaludků?");
        }
    }
}
