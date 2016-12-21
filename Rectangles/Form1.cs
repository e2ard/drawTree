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

namespace Rectangles
{
    public partial class Form1 : Form
    {
        System.Drawing.Graphics graphics;
        private bool go;
        private int dx = 1;
        private float rotated = 1;
        public Form1()
        {
            InitializeComponent();
            DrawIt();

        }

        private void DrawIt()
        {
            graphics = CreateGraphics();
            graphics.TranslateTransform(Width / 2, Height / 2);

            for (double i = 0; i < 1000; i++)
            {
                graphics.Clear(Color.White);
                graphics.RotateTransform(100 * (float)Math.Sin(i));
                Rectangle rectangle = new Rectangle(-150, -150, 150, 150);
                graphics.DrawRectangle(Pens.Red, rectangle);
                Invalidate();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //DrawIt();
            go = true;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (go)
            {
                //this.Location = new Point(this.Location.X + dx, this.Location.Y);
                rotated += 0.01f;
                Debug.WriteLine(Math.Sin(rotated));
                Rectangle rectangle = new Rectangle(-150 / 2 * (int)Math.Round(Math.Sqrt(2),0), -150 / 2 * (int)Math.Round(Math.Sqrt(2), 0), 150, 150);
                GraphicsContainer containerState1;
                containerState1 = graphics.BeginContainer();

                graphics.RotateTransform( 360 *(float)Math.Sin(rotated));
                graphics.ScaleTransform((float)Math.Sin(rotated),  (float)Math.Sin(rotated));
                graphics.DrawRectangle(Pens.Red, rectangle);

                graphics.EndContainer(containerState1);

                this.Invalidate();
                System.Threading.Thread.Sleep(50);
            }
        }
        
    }
}
