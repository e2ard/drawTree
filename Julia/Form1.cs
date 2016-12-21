using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
namespace Julia
{
    public partial class Form1 : Form
    {
        Graphics g;
        public int MaxIterations;
        public double Zr = 1, Zim = 1, Z2r = 0.5f, Z2im = 0.5f;

        private Bitmap m_Bm;

        private const double MIN_X = -2.2;
        private const double MAX_X = 1;
        private const double MIN_Y = -1.2;
        private const double MAX_Y = 1.2;

        double cRe, cIm;           //real and imaginary part of the constant c, determinate shape of the Julia Set
        double newRe, newIm, oldRe, oldIm;   //real and imaginary parts of new and old
        double zoom = 1, moveX = 0, moveY = 0; //you can change these to zoom and change position

        private void button3_Click(object sender, EventArgs e)
        {
            Newton();
        }

        Color color = Color.Red; //the RGB color value for the pixel
        int maxIterations = 150; //after how much iterations the function should stop



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Julia();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mandelbrot();
        }

        private void Julia()
        {
            g = CreateGraphics();
            g.TranslateTransform(0, -25);

            //pick some values for the constant c, this determines the shape of the Julia Set
            cRe = Convert.ToDouble(inputRe.Text);
            cIm = Convert.ToDouble(inputIm.Text);
            //loop through every pixel
            int w = Width;
            int h = Height;
            Bitmap myBitmap = new Bitmap(w, h);
            for (int y = 0; y < h; y++)
                for (int x = 0; x < w; x++)
                {
                    //calculate the initial real and imaginary part of z, based on the pixel location and zoom and position values
                    newRe = 1.5 * (x - w / 2) / (0.5 * zoom * w) + moveX;
                    newIm = (y - h / 2) / (0.5 * zoom * h) + moveY;
                    //i will represent the number of iterations
                    int i;
                    //start the iteration process
                    for (i = 0; i < maxIterations; i++)
                    {
                        //remember value of previous iteration
                        oldRe = newRe;
                        oldIm = newIm;
                        //the actual iteration, the real and imaginary part are calculated
                        newRe = oldRe * oldRe * oldRe - 3 * oldRe * oldIm * oldIm + cRe;
                        newIm = 3 * oldRe * oldRe * oldIm - oldIm * oldIm * oldIm + cIm;

                        ////newRe = oldRe * oldRe * oldRe - 3 * oldRe * oldIm * oldIm - oldRe + cRe;
                        //newIm = 3 * oldRe * oldRe * oldIm - oldIm * oldIm * oldIm - oldIm + cIm;
                        //if the point is outside the circle with radius 2: stop
                        if ((newRe * newRe + newIm * newIm) > 4) break;
                    }
                    //use color model conversion to get rainbow palette, make brightness black if maxIterations reached
                    color  = Color.FromArgb(255, 255, (i < maxIterations)?i%255:0);
                    //draw the pixel
                    myBitmap.SetPixel(x, y, color);
                }
            g.DrawImage(myBitmap, 0, 0);
            //make the Julia Set visible and wait to exit
            //redraw();
        }

        private void Mandelbrot()// Draw the Mandelbrot set.
        {
            g = CreateGraphics();
            g.TranslateTransform(0, -25);

            //pick some values for the constant c, this determines the shape of the Julia Set
            cRe = Convert.ToDouble(inputRe.Text);
            cIm = Convert.ToDouble(inputIm.Text);

            //loop through every pixel
            int w = Width;
            int h = Height;
            double pr, pi;           //real and imaginary part of the pixel p

            Bitmap myBitmap = new Bitmap(w, h);
            for (int y = 0; y < h; y++)
                for (int x = 0; x < w; x++)
                {
                    pr = 1.5 * (x - w / 2) / (0.5 * zoom * w) + moveX;
                    pi = (y - h / 2) / (0.5 * zoom * h) + moveY;
                    newRe = newIm = oldRe = oldIm = 0; //these should start at 0,0

                    int i;
                    //start the iteration process
                    for (i = 0; i < maxIterations; i++)
                    {
                        //remember value of previous iteration
                        oldRe = newRe;
                        oldIm = newIm;
                        //the actual iteration, the real and imaginary part are calculated
                        //newRe = oldRe * oldRe * oldRe - 3 * oldRe * oldIm * oldIm + cRe;
                        //newIm = 3 * oldRe * oldRe * oldIm - oldIm * oldIm  * oldIm + cIm;

                        newRe = oldRe * oldRe * oldRe - 3 * oldRe * oldIm * oldIm - oldRe + pr;
                        newIm = 3 * oldRe * oldRe * oldIm - oldIm * oldIm * oldIm - oldIm + pi;
                        //if the point is outside the circle with radius 2: stop
                        if ((newRe * newRe + newIm * newIm) > 4) break;
                    }
                    color = Color.FromArgb(i%255, 255, (i < maxIterations) ? 255 : 0);//use color model conversion to get rainbow palette, make brightness black if maxIterations reached
                    myBitmap.SetPixel(x, y, color);//draw the pixel
                }
            g.DrawImage(myBitmap, 0, 0);
        }

        private void Newton()// Draw the Mandelbrot set.
        {
            g = CreateGraphics();
            g.TranslateTransform(0, -25);
            
            double xmin = -3.5;
            double ymin = -3;
            double width = 2.0;
            double height = 2.0;
            int h = Height;
            int w = Width;
            int n = maxIterations;
            Bitmap myBitmap = new Bitmap(w, h);
            
            for (int col = 0; col < h; col++)
                for (int row = 0; row < w; row++)
                {
                    double x = xmin + col * width / n;
                    double y = ymin + row * height / n;
                    Complex z = new Complex(x, y);
                    Color color = Newton(z);
                    myBitmap.SetPixel(row, col, color);
                }
            g.DrawImage(myBitmap, 0, 0);
        }

        public Color Newton(Complex z)
        {
            double EPSILON = 0.01;
            Complex four = new Complex(3, 0);
            Complex one = new Complex(1, 0);

            Complex root1 = new Complex(1, 0);
            Complex root2 = new Complex(-1, 0);
            Complex root3 = new Complex(0, 1);
            Complex root4 = new Complex(0, -1);

            for (int i = 0; i < 100; i++)
            {
                Complex f = Complex.Multiply(z , z);
                f = Complex.Multiply(f, z);
                f = Complex.Multiply(f, z);
                f = Complex.Subtract(f, one);

                Complex fp = Complex.Multiply(z, z);
                fp = Complex.Multiply(fp, z);
                fp = Complex.Multiply(four, fp);

                z = Complex.Subtract(z, (Complex.Divide(f, fp)));

                if (Complex.Subtract(z, root1).Magnitude <= EPSILON) return Color.White;
                if (Complex.Subtract(z, root2).Magnitude <= EPSILON) return Color.Black;
                if (Complex.Subtract(z, root3).Magnitude <= EPSILON) return Color.White;
                if (Complex.Subtract(z, root4).Magnitude <= EPSILON) return Color.Black;
            }
            return Color.White;
        }
    }
}
