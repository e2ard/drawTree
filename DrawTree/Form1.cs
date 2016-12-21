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
            g.TranslateTransform(Width / 2, Height / 2 + 200);
            DrawLine(0, -100, (int)itNumber.Value);
        }

        private void DrawLine(int x, int y, int a)
        {
            if (a <= 0)
                return;

            g.DrawLine(new Pen(itNum % 2 == 0 ? Brushes.Blue : Brushes.Red), 0, 0, 0, -100);
            g.TranslateTransform(0, -100);
            GraphicsContainer containerState1;
            if (b1angle.Value > 0)
            {
                containerState1 = g.BeginContainer();
                g.RotateTransform((int)b1angle.Value);
                DrawLine(0, 50, a - 1);//----
                g.ScaleTransform((float)b1length.Value, (float)b1length.Value);
                g.EndContainer(containerState1);
            }

            if (b2angle.Value > 0)
            {
                containerState1 = g.BeginContainer();
                g.RotateTransform((int)b2angle.Value);
                g.ScaleTransform((float)b2length.Value, (float)b2length.Value);
                DrawLine(0, 100, a - 1);//----
                g.EndContainer(containerState1);
            }

            if (b3angle.Value > 0)
            {
                containerState1 = g.BeginContainer();
                g.RotateTransform((int)b3angle.Value);
                g.ScaleTransform((float)b3length.Value, (float)b3length.Value);
                DrawLine(0, 100, a - 1);//----
                g.EndContainer(containerState1);
            }

            if (b4angle.Value > 0)
            {
                containerState1 = g.BeginContainer();
                g.RotateTransform((int)b4angle.Value);
                g.ScaleTransform((float)b4length.Value, (float)b4length.Value);
                DrawLine(0, 100, a - 1);//----
                g.EndContainer(containerState1);
            }
            if (b5angle.Value > 0)
            {
                containerState1 = g.BeginContainer();
                g.RotateTransform((int)b5angle.Value);
                g.ScaleTransform((float)b5length.Value, (float)b5length.Value);
                DrawLine(0, 100, a - 1);//----
                g.EndContainer(containerState1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawSomething(Brushes.Chocolate);
        }
    }
}
