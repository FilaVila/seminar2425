namespace malovani
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonLightBlue = new System.Windows.Forms.Button();
            this.buttonOrange = new System.Windows.Forms.Button();
            this.buttonGrey = new System.Windows.Forms.Button();
            this.buttonPink = new System.Windows.Forms.Button();
            this.buttonBlack = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.textBoxTloustka = new System.Windows.Forms.TextBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.labelLocation = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBoxCurrentColor = new System.Windows.Forms.PictureBox();
            this.buttonEraser = new System.Windows.Forms.Button();
            this.buttonSpray = new System.Windows.Forms.Button();
            this.buttonCrayon = new System.Windows.Forms.Button();
            this.buttonPen = new System.Windows.Forms.Button();
            this.buttonBrush = new System.Windows.Forms.Button();
            this.buttonPencil = new System.Windows.Forms.Button();
            this.buttonStar = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonRainbow = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentColor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 350);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(90, 26);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(60, 60);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.BackColor = System.Drawing.Color.White;
            this.textBoxLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLocation.Location = new System.Drawing.Point(699, 337);
            this.textBoxLocation.Multiline = true;
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.ReadOnly = true;
            this.textBoxLocation.Size = new System.Drawing.Size(135, 35);
            this.textBoxLocation.TabIndex = 2;
            this.textBoxLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonRainbow);
            this.panel2.Controls.Add(this.buttonLightBlue);
            this.panel2.Controls.Add(this.buttonOrange);
            this.panel2.Controls.Add(this.buttonGrey);
            this.panel2.Controls.Add(this.buttonPink);
            this.panel2.Controls.Add(this.buttonBlack);
            this.panel2.Controls.Add(this.buttonYellow);
            this.panel2.Controls.Add(this.buttonGreen);
            this.panel2.Controls.Add(this.buttonBlue);
            this.panel2.Controls.Add(this.buttonRed);
            this.panel2.Location = new System.Drawing.Point(625, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 118);
            this.panel2.TabIndex = 3;
            // 
            // buttonLightBlue
            // 
            this.buttonLightBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonLightBlue.Location = new System.Drawing.Point(171, 61);
            this.buttonLightBlue.Name = "buttonLightBlue";
            this.buttonLightBlue.Size = new System.Drawing.Size(50, 50);
            this.buttonLightBlue.TabIndex = 5;
            this.buttonLightBlue.UseVisualStyleBackColor = false;
            this.buttonLightBlue.Click += new System.EventHandler(this.buttonLightBlue_Click);
            // 
            // buttonOrange
            // 
            this.buttonOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonOrange.Location = new System.Drawing.Point(115, 61);
            this.buttonOrange.Name = "buttonOrange";
            this.buttonOrange.Size = new System.Drawing.Size(50, 50);
            this.buttonOrange.TabIndex = 5;
            this.buttonOrange.UseVisualStyleBackColor = false;
            this.buttonOrange.Click += new System.EventHandler(this.buttonOrange_Click);
            // 
            // buttonGrey
            // 
            this.buttonGrey.BackColor = System.Drawing.Color.LightGray;
            this.buttonGrey.Location = new System.Drawing.Point(59, 61);
            this.buttonGrey.Name = "buttonGrey";
            this.buttonGrey.Size = new System.Drawing.Size(50, 50);
            this.buttonGrey.TabIndex = 5;
            this.buttonGrey.UseVisualStyleBackColor = false;
            this.buttonGrey.Click += new System.EventHandler(this.buttonGrey_Click);
            // 
            // buttonPink
            // 
            this.buttonPink.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonPink.Location = new System.Drawing.Point(3, 61);
            this.buttonPink.Name = "buttonPink";
            this.buttonPink.Size = new System.Drawing.Size(50, 50);
            this.buttonPink.TabIndex = 5;
            this.buttonPink.UseVisualStyleBackColor = false;
            this.buttonPink.Click += new System.EventHandler(this.buttonPink_Click);
            // 
            // buttonBlack
            // 
            this.buttonBlack.BackColor = System.Drawing.Color.Black;
            this.buttonBlack.Location = new System.Drawing.Point(227, 5);
            this.buttonBlack.Name = "buttonBlack";
            this.buttonBlack.Size = new System.Drawing.Size(50, 50);
            this.buttonBlack.TabIndex = 5;
            this.buttonBlack.UseVisualStyleBackColor = false;
            this.buttonBlack.Click += new System.EventHandler(this.buttonBlack_Click);
            // 
            // buttonYellow
            // 
            this.buttonYellow.BackColor = System.Drawing.Color.Yellow;
            this.buttonYellow.Location = new System.Drawing.Point(171, 5);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(50, 50);
            this.buttonYellow.TabIndex = 5;
            this.buttonYellow.UseVisualStyleBackColor = false;
            this.buttonYellow.Click += new System.EventHandler(this.buttonYellow_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.Lime;
            this.buttonGreen.Location = new System.Drawing.Point(115, 5);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(50, 50);
            this.buttonGreen.TabIndex = 5;
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonBlue.Location = new System.Drawing.Point(59, 5);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(50, 50);
            this.buttonBlue.TabIndex = 5;
            this.buttonBlue.UseVisualStyleBackColor = false;
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Red;
            this.buttonRed.Location = new System.Drawing.Point(3, 5);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(50, 50);
            this.buttonRed.TabIndex = 4;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // textBoxTloustka
            // 
            this.textBoxTloustka.BackColor = System.Drawing.Color.White;
            this.textBoxTloustka.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTloustka.Location = new System.Drawing.Point(744, 247);
            this.textBoxTloustka.Multiline = true;
            this.textBoxTloustka.Name = "textBoxTloustka";
            this.textBoxTloustka.ReadOnly = true;
            this.textBoxTloustka.Size = new System.Drawing.Size(135, 35);
            this.textBoxTloustka.TabIndex = 4;
            this.textBoxTloustka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSize.Location = new System.Drawing.Point(660, 247);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(75, 31);
            this.labelSize.TabIndex = 5;
            this.labelSize.Text = "Size:";
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(932, 465);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(89, 35);
            this.buttonDraw.TabIndex = 6;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLocation.Location = new System.Drawing.Point(568, 337);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(125, 31);
            this.labelLocation.TabIndex = 7;
            this.labelLocation.Text = "Location:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBoxCurrentColor);
            this.panel3.Location = new System.Drawing.Point(559, 137);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(58, 58);
            this.panel3.TabIndex = 17;
            // 
            // trackBarSize
            // 
            this.trackBarSize.Location = new System.Drawing.Point(613, 289);
            this.trackBarSize.Maximum = 30;
            this.trackBarSize.Minimum = 3;
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(316, 45);
            this.trackBarSize.TabIndex = 18;
            this.trackBarSize.Value = 3;
            this.trackBarSize.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(24, 26);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(60, 60);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(542, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(537, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Height:";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxWidth.Location = new System.Drawing.Point(625, 400);
            this.textBoxWidth.Multiline = true;
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 35);
            this.textBoxWidth.TabIndex = 22;
            this.textBoxWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxHeight.Location = new System.Drawing.Point(625, 446);
            this.textBoxHeight.Multiline = true;
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 35);
            this.textBoxHeight.TabIndex = 23;
            this.textBoxHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox1.Location = new System.Drawing.Point(837, 471);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 29);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Fill?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBoxCurrentColor
            // 
            this.pictureBoxCurrentColor.BackColor = System.Drawing.Color.Black;
            this.pictureBoxCurrentColor.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxCurrentColor.Name = "pictureBoxCurrentColor";
            this.pictureBoxCurrentColor.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxCurrentColor.TabIndex = 0;
            this.pictureBoxCurrentColor.TabStop = false;
            // 
            // buttonEraser
            // 
            this.buttonEraser.BackgroundImage = global::malovani.Properties.Resources.eraser;
            this.buttonEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEraser.Location = new System.Drawing.Point(853, 59);
            this.buttonEraser.Name = "buttonEraser";
            this.buttonEraser.Size = new System.Drawing.Size(50, 50);
            this.buttonEraser.TabIndex = 16;
            this.buttonEraser.UseVisualStyleBackColor = true;
            this.buttonEraser.Click += new System.EventHandler(this.buttonEraser_Click);
            // 
            // buttonSpray
            // 
            this.buttonSpray.BackgroundImage = global::malovani.Properties.Resources.spray_can_png_28843__1_;
            this.buttonSpray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSpray.Location = new System.Drawing.Point(853, 3);
            this.buttonSpray.Name = "buttonSpray";
            this.buttonSpray.Size = new System.Drawing.Size(50, 50);
            this.buttonSpray.TabIndex = 15;
            this.buttonSpray.UseVisualStyleBackColor = true;
            this.buttonSpray.Click += new System.EventHandler(this.buttonSpray_Click);
            // 
            // buttonCrayon
            // 
            this.buttonCrayon.BackgroundImage = global::malovani.Properties.Resources.pngegg;
            this.buttonCrayon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCrayon.Location = new System.Drawing.Point(797, 3);
            this.buttonCrayon.Name = "buttonCrayon";
            this.buttonCrayon.Size = new System.Drawing.Size(50, 50);
            this.buttonCrayon.TabIndex = 14;
            this.buttonCrayon.UseVisualStyleBackColor = true;
            this.buttonCrayon.Click += new System.EventHandler(this.buttonCrayon_Click);
            // 
            // buttonPen
            // 
            this.buttonPen.BackgroundImage = global::malovani.Properties.Resources.Fountain_Pen_Head__1_;
            this.buttonPen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPen.Location = new System.Drawing.Point(741, 3);
            this.buttonPen.Name = "buttonPen";
            this.buttonPen.Size = new System.Drawing.Size(50, 50);
            this.buttonPen.TabIndex = 13;
            this.buttonPen.UseVisualStyleBackColor = true;
            this.buttonPen.Click += new System.EventHandler(this.buttonPen_Click);
            // 
            // buttonBrush
            // 
            this.buttonBrush.BackgroundImage = global::malovani.Properties.Resources.Paint_Brush_Free_Download_PNG__1_;
            this.buttonBrush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBrush.Location = new System.Drawing.Point(685, 3);
            this.buttonBrush.Name = "buttonBrush";
            this.buttonBrush.Size = new System.Drawing.Size(50, 50);
            this.buttonBrush.TabIndex = 12;
            this.buttonBrush.UseVisualStyleBackColor = true;
            this.buttonBrush.Click += new System.EventHandler(this.buttonBrush_Click);
            // 
            // buttonPencil
            // 
            this.buttonPencil.BackgroundImage = global::malovani.Properties.Resources.pencil_motherfucker;
            this.buttonPencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPencil.Location = new System.Drawing.Point(629, 3);
            this.buttonPencil.Name = "buttonPencil";
            this.buttonPencil.Size = new System.Drawing.Size(50, 50);
            this.buttonPencil.TabIndex = 11;
            this.buttonPencil.UseVisualStyleBackColor = true;
            this.buttonPencil.Click += new System.EventHandler(this.buttonPencil_Click);
            // 
            // buttonStar
            // 
            this.buttonStar.BackgroundImage = global::malovani.Properties.Resources.favpng_pentacle_pentagram;
            this.buttonStar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonStar.Location = new System.Drawing.Point(827, 394);
            this.buttonStar.Name = "buttonStar";
            this.buttonStar.Size = new System.Drawing.Size(80, 55);
            this.buttonStar.TabIndex = 10;
            this.buttonStar.UseVisualStyleBackColor = true;
            this.buttonStar.Click += new System.EventHandler(this.buttonStar_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.BackColor = System.Drawing.Color.White;
            this.buttonRectangle.BackgroundImage = global::malovani.Properties.Resources.rectangle;
            this.buttonRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRectangle.Location = new System.Drawing.Point(737, 394);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(80, 55);
            this.buttonRectangle.TabIndex = 9;
            this.buttonRectangle.UseVisualStyleBackColor = false;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // buttonCircle
            // 
            this.buttonCircle.BackColor = System.Drawing.Color.White;
            this.buttonCircle.BackgroundImage = global::malovani.Properties.Resources.hiclipart_com__1_;
            this.buttonCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCircle.Location = new System.Drawing.Point(737, 455);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(80, 55);
            this.buttonCircle.TabIndex = 8;
            this.buttonCircle.UseVisualStyleBackColor = false;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // buttonRainbow
            // 
            this.buttonRainbow.BackgroundImage = global::malovani.Properties.Resources.duha2;
            this.buttonRainbow.Location = new System.Drawing.Point(227, 61);
            this.buttonRainbow.Name = "buttonRainbow";
            this.buttonRainbow.Size = new System.Drawing.Size(50, 50);
            this.buttonRainbow.TabIndex = 5;
            this.buttonRainbow.UseVisualStyleBackColor = true;
            this.buttonRainbow.Click += new System.EventHandler(this.buttonRainbow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 511);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.trackBarSize);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonEraser);
            this.Controls.Add(this.buttonSpray);
            this.Controls.Add(this.buttonCrayon);
            this.Controls.Add(this.buttonPen);
            this.Controls.Add(this.buttonBrush);
            this.Controls.Add(this.buttonPencil);
            this.Controls.Add(this.buttonStar);
            this.Controls.Add(this.buttonRectangle);
            this.Controls.Add(this.buttonCircle);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.textBoxTloustka);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonRainbow;
        private System.Windows.Forms.Button buttonLightBlue;
        private System.Windows.Forms.Button buttonOrange;
        private System.Windows.Forms.Button buttonGrey;
        private System.Windows.Forms.Button buttonPink;
        private System.Windows.Forms.Button buttonBlack;
        private System.Windows.Forms.Button buttonYellow;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.TextBox textBoxTloustka;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Button buttonStar;
        private System.Windows.Forms.Button buttonPencil;
        private System.Windows.Forms.Button buttonBrush;
        private System.Windows.Forms.Button buttonPen;
        private System.Windows.Forms.Button buttonCrayon;
        private System.Windows.Forms.Button buttonSpray;
        private System.Windows.Forms.Button buttonEraser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TrackBar trackBarSize;
        private System.Windows.Forms.PictureBox pictureBoxCurrentColor;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

