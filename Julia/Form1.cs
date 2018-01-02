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
using System.Diagnostics;

namespace Julia
{
    public partial class Form1 : Form
    {
        Graphics g;
        private const double MIN_X = -2.2;
        private const double MAX_X = 1;
        private const double MIN_Y = -1.2;
        private const double MAX_Y = 1.2;
        private int PIC_SIZE = 300;
        int maxIterations = 255; //after how much iterations the function should stop
        int M_ITERSTIONS = 250;
        int N_MAX_ITERATIONS = 50;
        Bitmap mBmp, jBmp, nBmp;
        PictureBox p;

        double cRe, cIm;           //real and imaginary part of the constant c, determinate shape of the Julia Set
        
        private void button3_Click(object sender, EventArgs e)
        {
            Newton(1,1);
        }

        private double GetInitValueX(int it, int size)
        {
            return 1.5 * (it - size / 2) / (0.5 * size) - 0.25;
        }

        private double GetInitValueY(int it, int size)
        {
            return 1.5 * (it - size / 2) / (0.5 * size);
        }
        
        public Form1()
        {
            InitializeComponent();
            HookEvents();
        }

        private void HookEvents()
        {
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Julia(1,1);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Color color = mBmp.GetPixel(e.X, e.Y);
            double min = -1.5;
            double max = 1.5;
            double step = (max - min) / PIC_SIZE;

            cIm = e.X * step + min;
            cRe = e.Y * step + min;

            jBmp = Julia(0, 0);
            g.DrawImage(jBmp, PIC_SIZE + 10, 0, PIC_SIZE, PIC_SIZE);

            mBmp = Mandebrot(0, 0);
            mBmp.SetPixel(150, 150, Color.Red);
            g.DrawImage(mBmp, 0, 0, PIC_SIZE, PIC_SIZE);
            Debug.WriteLine("new COLOR is {0} {1}", cRe, cIm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g = CreateGraphics();
            g.TranslateTransform(0, 0);

            mBmp = Mandebrot(0, 0);
            g.DrawImage(mBmp, 0, 0, PIC_SIZE, PIC_SIZE);
            
            nBmp = Newton(0, 0);
            g.DrawImage(nBmp, PIC_SIZE * 2 + 20, 0, PIC_SIZE, PIC_SIZE);
        }

        private Bitmap Julia(int a, int b)
        {
            Debug.WriteLine("new Julia" + a  + " " + b);
            int Width = PIC_SIZE, Height = PIC_SIZE;
            Bitmap myBitmap = new Bitmap(Width, Height);
            
            for (int y = 0; y < Height; y++)
                for (int x = 0; x < Width; x++)
                {
                    double pr = GetInitValueX(x, Width);//1.5 * (x - Width / 2) / (0.5 * Width);
                    double pi = GetInitValueY(y, Height); //(y - Height / 2) / (0.5 * Height);
                    Complex c = new Complex(cRe, cIm);

                    //i will represent the number of iterations
                    Complex newResult = new Complex(pr, pi);
                    Complex oldResult = newResult;
                    int i;
                    for (i = 0; i < maxIterations; i++)
                    {
                        //remember value of previous iteration
                        oldResult = newResult;
                        //Complex c = new Complex(-0.7f, 0.27015f);
                        Complex oldResult2 = Complex.Multiply(oldResult, oldResult);//z^2
                        Complex oldResult4 = Complex.Multiply(oldResult2, oldResult2);//z^4
                        Complex subResult = Complex.Subtract(oldResult4, oldResult2);

                        newResult = Complex.Add(oldResult2, c);

                        if ((newResult.Real * newResult.Real + newResult.Imaginary * newResult.Imaginary) > 4) break;
                    }
                    Color color  = Color.FromArgb(255, 255, 255 * (i < maxIterations? 1: 0));
                    myBitmap.SetPixel(x, y, color);
                }
            return myBitmap;
        }

        private Bitmap Mandebrot(int a, int bi)
        {
            Complex c = new Complex(cRe, cIm);

            int Width = PIC_SIZE, Height = PIC_SIZE;
            Bitmap myBitmap = new Bitmap(Width, Height);
            for (int y = 0; y < Height; y++)
                for (int x = 0; x < Width; x++)
                {
                    double pr = GetInitValueX(x, Width);//1.5 * (x - Width / 2) / (0.5 * Width);
                    double pi = GetInitValueY(y, Height); //(y - Height / 2) / (0.5 * Height);


                    //double pr = 1.5 * (x - Width / 2) / (0.5 * Width);
                    //double pi = 1.5 * (y - Height / 2) / (0.5 * Height);
                    Complex moveC = new Complex(pr, pi); 

                    Complex newResult = new Complex(0, 0);
                    Complex oldResult = new Complex(0, 0);

                    int i;
                    //start the iteration process
                    for (i = 0; i < M_ITERSTIONS; i++)
                    {
                        oldResult = newResult;

                        Complex z = oldResult;
                        Complex z2 = Complex.Multiply(z, z);//z^2
                        Complex z4 = Complex.Multiply(z2, z2);//z^4
                        Complex subResult = Complex.Subtract(z4, z2);
                        //newResult = Complex.Add(z2, c);
                        newResult = Complex.Add(z2, moveC);

                        if ((newResult.Real * newResult.Real + newResult.Imaginary * newResult.Imaginary) > 4) break;
                    }
                    Color color = Color.FromArgb((i * 2) % 255, (i * 3) % 255, (i * 5) % 255);//use color model conversion to get rainbow palette, make brightness black if maxIterations reached
                    myBitmap.SetPixel(x, y, color);//draw the pixel
                }
            return myBitmap;
        }

        private Bitmap Newton(int a, int bi)// Draw the Mandelbrot set.
        {
            double xmin = -1.5;
            double ymin = -1.5;
            double width = 0.5;
            double height = 0.5;
            int Width = PIC_SIZE, Height = PIC_SIZE;
            Bitmap myBitmap = new Bitmap(Width, Height);
            
            for (int col = 0; col < Height; col++)
                for (int row = 0; row < Width; row++)
                {
                    double x = xmin + col * width / N_MAX_ITERATIONS;
                    double y = ymin + row * height / N_MAX_ITERATIONS;
                    Complex z = new Complex(x, y);
                    Color color = Newton(z);
                    myBitmap.SetPixel(row, col, color);
                }
            return myBitmap;
        }

        public Color Newton(Complex z)
        {
            double EPSILON = 0.01;
            Complex four = new Complex(4, 0);
            Complex one = new Complex(1, 0);

            Complex root1 = new Complex(1, 0);
            Complex root2 = new Complex(-1, 0);
            Complex root3 = new Complex(0, 1);
            Complex root4 = new Complex(0, -1);

            for (int i = 0; i < N_MAX_ITERATIONS; i++)
            {
                Complex f = Complex.Multiply(z , z);
                f = Complex.Multiply(f, z);
                f = Complex.Multiply(f, z);
                f = Complex.Subtract(f, one);

                Complex fp = Complex.Multiply(z, z);
                fp = Complex.Multiply(fp, z);
                fp = Complex.Multiply(four, fp);

                z = Complex.Subtract(z, (Complex.Divide(f, fp)));

                
                if (Complex.Subtract(z, root2).Magnitude <= EPSILON) return Color.Red;
                if (Complex.Subtract(z, root3).Magnitude <= EPSILON) return Color.Green;
                if (Complex.Subtract(z, root4).Magnitude <= EPSILON) return Color.Blue;
                if (Complex.Subtract(z, root1).Magnitude <= EPSILON) return Color.Orange;

            }
            return Color.Black;
        }
    }
}
