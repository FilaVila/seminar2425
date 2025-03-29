using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace malovani
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Color color = Color.Black;
        Pen pen = new Pen(Color.Black, 3);
        Brush brush= new SolidBrush(Color.Black);
        Random rnd = new Random();
        bool mouseActive;
        int x,y,x2,y2;//souřadnice bodu, a souřadnice bodu pro kreslení tvarů
        bool rainbowActive = false;
        char tool = 'A'; //výchoze nastaveno na tužku
        float w=0;
        float h=0;
        char shape = 'B'; //výchoze nastaveno na rectangle
        public Form1()
        {
            InitializeComponent();
            graphics = panel1.CreateGraphics();
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round; //nějaký hokus pokus z githubu
            pictureBoxCurrentColor.BackColor = color;
            textBoxTloustka.Text = "3 px"; //předstírám, že je tužka zvolena už od začátku
        }
        //funkce (stal se mi z toho moc velký špageta kód, musel jsem si pojmenovat jednotlivé části)
        public void SetColor(Color color) 
        {
            rainbowActive = false;
            pen.Color = color;
            brush = new SolidBrush(color);
            pictureBoxCurrentColor.BackColor = color;
        }
        public void SliderSet(Pen pen) 
        {
            trackBarSize.Enabled = true;
            trackBarSize.Value = Convert.ToInt32(pen.Width);
            textBoxTloustka.Text = trackBarSize.Value.ToString() + " px";
        }
        private void DrawStar(int x, int y, float width, float height) //tímto bych chtěl poděkovat za pomoc mistrail ai, původně jsem chtěl nakreslit hvězdičku, ale nakonec vzbikl celkem doberj pentagram
        {
            PointF[] starPoints = new PointF[10];
            double angle = Math.PI / 2; // Startuje z horního bodu
            double step = Math.PI / 5; // 36 stupňů mezi vrcholy
            float centerX = x + w / 2;
            float centerY = y + h / 2;
            float outerRadius = Math.Min(w, h) / 2;
            float innerRadius = outerRadius / 2.5f; 

            for (int i = 0; i < 10; i++)
            {
                float radius = (i % 2 == 0) ? outerRadius : innerRadius;
                starPoints[i] = new PointF(
                    centerX + (float)(radius * Math.Cos(angle)),
                    centerY - (float)(radius * Math.Sin(angle)) 
                );
                angle += step * 2;
            }
            graphics.DrawEllipse(pen,x,y,width,height);
            graphics.DrawPolygon(pen, starPoints);            
        }
        //barvičky
        private void buttonRed_Click(object sender, EventArgs e)
        {
            SetColor(Color.Red);
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            SetColor(Color.Blue);
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            SetColor(Color.LimeGreen);
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            SetColor(Color.Yellow);
        }
        private void buttonBlack_Click(object sender, EventArgs e)
        {
            SetColor(Color.Black);
        }
        private void buttonPink_Click(object sender, EventArgs e)
        {
            SetColor(Color.Pink);
        }
        private void buttonGrey_Click(object sender, EventArgs e)
        {
            SetColor(Color.Gray); 
        }
        private void buttonOrange_Click(object sender, EventArgs e)
        {
            SetColor(Color.Orange);
        }
        private void buttonLightBlue_Click(object sender, EventArgs e)
        {
            SetColor(Color.Cyan);
        }
        private void buttonRainbow_Click(object sender, EventArgs e)
        {
            rainbowActive = true;
        }
        //nástroje
        private void buttonPencil_Click(object sender, EventArgs e)
        {
            tool = 'A';
            pen.Width = 3;
            SetColor(Color.Black);
            SliderSet(pen);
        }
        private void buttonBrush_Click(object sender, EventArgs e)
        {
            tool = 'B';
            pen.Width = 20;
            SliderSet(pen);
        }
        private void buttonPen_Click(object sender, EventArgs e)
        {
            tool = 'C';
            pen.Width = 3;
            SetColor(Color.FromArgb(51, 0, 102));
            trackBarSize.Enabled = false; //efekt není nad 3px vidět
            textBoxTloustka.Text = "záleží";
        }
        private void buttonCrayon_Click(object sender, EventArgs e)
        {
            tool = 'D';
            pen.Width = 5;
            SliderSet(pen);
        }
        private void buttonSpray_Click(object sender, EventArgs e)
        {
            tool = 'E';
            pen.Width = 10;
            SliderSet(pen);
        }
        private void buttonEraser_Click(object sender, EventArgs e)
        {
            SetColor(Color.White);
            pen.Width = 5;
            tool = 'A';
            SliderSet(pen);
        }       
        //tvary
        private void buttonStar_Click(object sender, EventArgs e) //pentagram
        {
            checkBox1.Checked = false;
            pen.Width = 3;
            textBoxWidth.Text = "69";
            textBoxHeight.Text = "69";
            shape = 'A';
            SetColor(Color.FromArgb(136, 8, 8));
        }
        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            shape = 'B';
        }
        private void buttonCircle_Click(object sender, EventArgs e)
        {
            shape = 'C';
        }
        //hejblátka
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            w = Convert.ToInt32(textBoxWidth.Text);
            h = Convert.ToInt32(textBoxHeight.Text);

            switch (shape)
            {
                case 'A': //pentagram
                    DrawStar(x2, y2, w, h);
                    break;
                case 'B': //rectangle
                    if (checkBox1.Checked)
                    {
                        graphics.FillRectangle(brush, x2, y2, w, h);
                    }
                    else
                    {
                        graphics.DrawRectangle(pen, x2, y2, w, h);
                    }
                    break;
                case 'C': //circle
                    if (checkBox1.Checked)
                    {
                        graphics.FillEllipse(brush, x2, y2, w, h);
                    }
                    else
                    {
                        graphics.DrawEllipse(pen, x2, y2, w, h);
                    }
                    break;
                default:
                    MessageBox.Show("Nemám tušení, jak se ti tohle povedlo, ale absolutní respekt");
                    break;
            }
        }
        private void buttonSave_Click(object sender, EventArgs e) //chtěl jsem udělat čudlík na ukládání, ale musel bych celý kód překopat do bitmapy, nebo celý kód přesunout z MouseMove do panel1.Paint()
        {

            /*SaveFileDialog save = new SaveFileDialog();
            save.Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.gif)|*.gif";
            if (save.ShowDialog() == DialogResult.OK)
            {               
                Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);                
                panel1.DrawToBitmap(bmp, new Rectangle(0, 0, panel1.Width, panel1.Height));                
                bmp.Save(save.FileName);
            }*/
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            Brush clearBrush = new SolidBrush(Color.White);
            graphics.FillRectangle(clearBrush, 0, -1, 500, 350);//musím posunout o jedno nahoru.....proč stále zůstává záhadou
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseActive = true;
            x = e.X;
            x2 = e.X;
            y = e.Y; 
            y2= e.Y;
            textBoxLocation.Text = x.ToString() + ";" + y.ToString()+" px";                    
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBoxTloustka.Text = trackBarSize.Value.ToString() + " px";
            pen.Width = trackBarSize.Value;
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseActive = false;
            x = 0;
            y = 0;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseActive && x != 0 && y != 0)
            {
                if (rainbowActive)
                {
                    Color rainbow = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                    pen.Color = rainbow;
                    brush = new SolidBrush(rainbow);
                    pictureBoxCurrentColor.BackColor = rainbow;
                }
                switch (tool)
                {

                    case 'A':
                        graphics.DrawLine(pen, new Point(x, y), e.Location);
                        x = e.X;
                        y = e.Y;
                        break;
                    case 'B':
                        Pen PaintingB = new Pen(Color.FromArgb(17, pen.Color), pen.Width); //definoval jsem nový štětec, který je transparentní, Alpha = 17
                        PaintingB.StartCap = PaintingB.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                        graphics.DrawLine(PaintingB, new Point(x, y), e.Location);
                        x = e.X;
                        y = e.Y;
                        break;
                    case 'C':
                        double distance = Math.Sqrt(Math.Pow(e.X - x, 2) + Math.Pow(e.Y - y, 2));
                        double speed = distance / pen.Width; // simuluje rychlost
                        float CWidth = (float)(pen.Width / speed);//čím pomalejší tím širší
                        Pen Cpen = new Pen(pen.Color, CWidth);
                        Cpen.StartCap = Cpen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                        graphics.DrawLine(Cpen, new Point(x, y), e.Location);
                        x = e.X;
                        y = e.Y;
                        break;
                    case 'D':
                        int CrWidth = Convert.ToInt32(pen.Width);
                        Pen Crayon = new Pen(Color.FromArgb(9, pen.Color), CrWidth + rnd.Next(-5, 5));
                        Crayon.StartCap = Crayon.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                        for (int i = -CrWidth / 2; i < CrWidth / 2; i++)
                        {
                            graphics.DrawLine(Crayon, x, y, e.X + 1, e.Y + i);
                        }
                        x = e.X;
                        y = e.Y;
                        break;
                    case 'E':
                        int off = Convert.ToInt32(pen.Width);
                        int eS = rnd.Next(1, off / 2);//poměry of jsou pokus omyl
                        graphics.FillEllipse(brush, e.X + rnd.Next(off, off * 2), e.Y + rnd.Next(off, off * 2), eS, eS); //malé kruhy náhodně od pozice
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
