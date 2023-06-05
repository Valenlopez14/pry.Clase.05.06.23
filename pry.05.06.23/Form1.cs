﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry._05._06._23
{
    public partial class Form1 : Form
    {
        Graphics gra;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gra = pictureBox1.CreateGraphics();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gra.DrawLine(Pens.Black, 0, 0, 399, 399);
            gra.DrawLine(Pens.Black, 399,0, 0,399);
            gra.DrawLine(Pens.Black, 0, 199, 399, 199);
            gra.DrawLine(Pens.Black, 199, 0, 199, 399);
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gra.DrawEllipse(Pens.Red, 0, 0, 200,200);
            gra.DrawEllipse(Pens.Red,200, 0,200 , 200);
            gra.DrawEllipse(Pens.Red, 0, 200, 200, 200);
            gra.DrawEllipse(Pens.Red, 200, 200, 200, 200);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pen milapiz = new Pen(Color.Red, 100);
            gra.DrawLine(milapiz, 399, 0, 0, 399);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pen milapiz = new Pen(Color.Green, 10);
            gra.DrawEllipse(milapiz, 0, 0, 399, 399);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gra.FillRectangle(Brushes.Orange, 200, 200, 80, 80);
            gra.DrawRectangle(Pens.Blue, 100, 100, 80, 80);
        }
    }
}
