using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawTree
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen p;
        int itNum = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void DrawSomething(Brush b)
        {
            g = CreateGraphics();
            g.Clear(Color.White);
            p = new Pen(b);
            g.TranslateTransform(Width / 2, Height / 2);
            g.DrawLine(new Pen(itNum % 2 == 0 ? Brushes.Blue : Brushes.Red), -150, 150, 150, 150);
            g.DrawLine(new Pen(itNum % 2 == 0 ? Brushes.Blue : Brushes.Red), -150, 150, -150, -150);
            g.DrawLine(new Pen(itNum % 2 == 0 ? Brushes.Blue : Brushes.Red), 150, 150, 150, -150);
            g.DrawLine(new Pen(itNum % 2 == 0 ? Brushes.Blue : Brushes.Red), -150, -150, 150, -150);
            DrawLine(0, -100, (int)itNumber.Value);
        }

        private void DrawLine(int x, int y, int a)
        {
            if (a <= 0)
                return;
            
            g.DrawLine(new Pen(itNum % 2 == 0 ? Brushes.Blue : Brushes.Red), -50, 0, 50, 0);
            GraphicsContainer containerState1;
            if (b1angle.Value > 0)
            {
                containerState1 = g.BeginContainer();
                g.TranslateTransform(-100, 75);
                g.ScaleTransform((float)0.33, (float)0.5);
                DrawLine(0, -50, a - 1);//----
                g.EndContainer(containerState1);
                if (a == 1)
                    g.DrawLine(new Pen(Brushes.Red), -50, 0, -150, 150);

            }
           
            if (b1angle.Value > 0)
            {
                containerState1 = g.BeginContainer();
                g.TranslateTransform(100, -75);
                g.ScaleTransform((float)0.33, (float)0.5);
                DrawLine(0, -50, a - 1);//----
                g.EndContainer(containerState1);
                if (a == 1)
                    g.DrawLine(new Pen(Brushes.Red), 50, 0, 150, -150);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawSomething(Brushes.Chocolate);
        }
    }
}
