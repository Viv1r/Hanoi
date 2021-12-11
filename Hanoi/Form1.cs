using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hanoi
{
    public partial class Hanoi : Form
    {
        private bool started = false;
        private int rings = 3;
        private Ring[] ringsarray = new Ring[100];
        public Hanoi()
        {
            InitializeComponent();
        }
        class Ring
        {
            public string color; public int length, x, y;
            public Ring(string color, int length, int x, int y)
            {
                this.color = color;
                this.length = length;
                this.x = x;
                this.y = y;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void startbutton_Click(object sender, EventArgs e)
        {
            if (started == true)
            {
                started = false;
                startbutton.Text = "Старт!";
                buttonminus.Enabled = true;
                buttonminus10.Enabled = true;
                buttonplus.Enabled = true;
                buttonplus10.Enabled = true;
                checkBox1.Enabled = true;
                progressBar1.Value = 0;
            }
            else
            {
                started = true;
                startbutton.Text = "Стоп";
                buttonminus.Enabled = false;
                buttonminus10.Enabled = false;
                buttonplus.Enabled = false;
                buttonplus10.Enabled = false;
                checkBox1.Enabled = false;
                // while(progressBar1.Value < 100) { progressBar1.Value++; }
                int tempy = 550, templen = 200;
                string tempcolor = "";
                for (int i = 0; i < rings; i++)
                {
                    switch(i % 4)
                    {
                        case 0:
                            tempcolor = "bluePen";
                            break;
                        case 1:
                            tempcolor = "yellowPen";
                            break;
                        case 2:
                            tempcolor = "redPen";
                            break;
                        case 3:
                            tempcolor = "greenPen";
                            break;
                    }
                    ringsarray[i] = new Ring(tempcolor, templen, 400, tempy);
                    templen -= 10;
                    tempy -= 50;
                }
                drawEverything();
            }
        }
        private void buttonminus_Click(object sender, EventArgs e)
        {
            if (rings > 1) { rings--; } else { MessageBox.Show("Ноль колец захотел?", "Пошёл нахер"); }
            label1.Text = String.Concat("Количество колец: ", rings);
        }
        private void buttonplus_Click(object sender, EventArgs e)
        {
            rings++;
            label1.Text = String.Concat("Количество колец: ", rings);
        }
        private void buttonplus10_Click(object sender, EventArgs e)
        {
            rings += 10;
            label1.Text = String.Concat("Количество колец: ", rings);
        }
        private void buttonminus10_Click(object sender, EventArgs e)
        {
            if (rings > 10) { rings -= 10; } else if (rings > 1) { rings = 1; } else { MessageBox.Show("Мы так в минус уйдём, успокойся", "Пошёл нахер"); }
            label1.Text = String.Concat("Количество колец: ", rings);
        }
        Graphics g;
        private void Hanoi_Paint_1(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 4);
            Pen bluePen = new Pen(Color.Blue, 1);
            g.DrawLine(blackPen, 400, 80, 400, 600);
            g.DrawLine(blackPen, 750, 80, 750, 600);
            g.DrawLine(blackPen, 1100, 80, 1100, 600);
        }
        public void drawEverything()
        {
            Pen blackPen = new Pen(Color.Black, 4);
            Pen bluePen = new Pen(Color.Blue, 3);
            Pen yellowPen = new Pen(Color.Yellow, 3);
            Pen redPen = new Pen(Color.Red, 3);
            Pen greenPen = new Pen(Color.Green, 3);
            while (started = true)
            {
                g.Clear(Color.White);
                g.DrawLine(blackPen, 400, 80, 400, 600);
                g.DrawLine(blackPen, 750, 80, 750, 600);
                g.DrawLine(blackPen, 1100, 80, 1100, 600);
                for (int i = 0; i < rings; i++)
                {
                    g.DrawRectangle(bluePen, (ringsarray[i].x - (ringsarray[i].length / 2)), ringsarray[i].y, ringsarray[i].length, 50);
                }
                Task.Delay(100);
            }
        }
        private void Hanoi_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
