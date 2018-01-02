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
        private int PIC_SIZE = 300;
        int J_ITERATIONS = 50; //after how much iterations the function should stop
        int M_ITERSTIONS = 50;
        int N_MAX_ITERATIONS = 50;
        Bitmap mBmp, jBmp, nBmp;
        double cRe, cIm;
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

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            double min = -2;
            double max = 2;
            double step = (max - min) / PIC_SIZE;

            cIm = e.Y * step + min;
            cRe = e.X * step + min;

            Complex myC = new Complex(0, 0);

            try
            {
                myC = GetMandebrotValue(e.X, e.Y);
                mBmp = Mandebrot(0, 0);
                mBmp.SetPixel(e.X, e.Y, Color.Red);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("OUT OF RANGE");
            }

            Debug.WriteLine("COMPLEX VALUES {0} {1}", myC.Real, myC.Imaginary);

            inputIm.Text = myC.Imaginary.ToString();
            inputRe.Text = myC.Real.ToString();

            jBmp = Julia(myC.Real, myC.Imaginary);
            g.DrawImage(jBmp, PIC_SIZE + 10, 0, PIC_SIZE, PIC_SIZE);

            
            g.DrawImage(mBmp, 0, 0, PIC_SIZE, PIC_SIZE);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g = CreateGraphics();
            g.TranslateTransform(0, 0);

            cIm = Convert.ToDouble(inputIm.Text);
            cRe = Convert.ToDouble(inputRe.Text);
            J_ITERATIONS = M_ITERSTIONS = N_MAX_ITERATIONS = Convert.ToInt32(itNum.Text);
            jBmp = Julia(cRe, cIm);
            g.DrawImage(jBmp, PIC_SIZE + 10, 0, PIC_SIZE, PIC_SIZE);

            mBmp = Mandebrot(0, 0);
            mBmp.SetPixel(150, 150, Color.Red);
            g.DrawImage(mBmp, 0, 0, PIC_SIZE, PIC_SIZE);


            nBmp = Newton(0, 0);
            g.DrawImage(nBmp, PIC_SIZE * 2 + 20, 0, PIC_SIZE, PIC_SIZE);
        }

        private Bitmap Julia(double a, double b)
        {
            Debug.WriteLine("new Julia" + a  + " " + b);
            int Width = PIC_SIZE, Height = PIC_SIZE;
            Bitmap myBitmap = new Bitmap(Width, Height);
            
            for (int y = 0; y < Height; y++)
                for (int x = 0; x < Width; x++)
                {
                    double pr = GetInitValueX(x, Width) + 0.25;//1.5 * (x - Width / 2) / (0.5 * Width);
                    double pi = GetInitValueY(y, Height); //(y - Height / 2) / (0.5 * Height);
                    Complex c = new Complex(a, b);

                    Complex newResult = new Complex(pr, pi);
                    Complex oldResult = newResult;
                    int i;
                    for (i = 0; i < J_ITERATIONS; i++)
                    {
                        oldResult = newResult;
                        //Complex c = new Complex(-0.7f, 0.27015f);
                        Complex oldResult2 = Complex.Multiply(oldResult, oldResult);//z^2
                        Complex oldResult4 = Complex.Multiply(oldResult2, oldResult2);//z^4
                        Complex subResult = Complex.Subtract(oldResult4, oldResult2);

                        newResult = Complex.Add(subResult, c);

                        if ((newResult.Real * newResult.Real + newResult.Imaginary * newResult.Imaginary) > 4) break;
                    }
                    int colValue = i >= J_ITERATIONS ? 255 : 0;
                    Color color  = Color.FromArgb((i * 2) % 255, (i * 3) % 255, (i * 5) % 255);
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
                        newResult = Complex.Add(subResult, moveC);

                        if ((newResult.Real * newResult.Real + newResult.Imaginary * newResult.Imaginary) > 4) break;
                    }
                    Color color = Color.FromArgb((i * 2) % 255, (i * 3) % 255, (i * 5) % 255);//use color model conversion to get rainbow palette, make brightness black if maxIterations reached
                    myBitmap.SetPixel(x, y, color);//draw the pixel
                }
            return myBitmap;
        }

        private Complex GetMandebrotValue(int x, int y)
        {
            Complex c = new Complex(cRe, cIm);
            Complex newResult = new Complex(0, 0);

            int Width = PIC_SIZE, Height = PIC_SIZE;
            Bitmap myBitmap = new Bitmap(Width, Height);
                {
                    double pr = GetInitValueX(x, Width);//1.5 * (x - Width / 2) / (0.5 * Width);
                    double pi = GetInitValueY(y, Height); //(y - Height / 2) / (0.5 * Height);


                    //double pr = 1.5 * (x - Width / 2) / (0.5 * Width);
                    //double pi = 1.5 * (y - Height / 2) / (0.5 * Height);
                    Complex moveC = new Complex(pr, pi);

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
                        newResult = Complex.Add(subResult, moveC);

                        if ((newResult.Real * newResult.Real + newResult.Imaginary * newResult.Imaginary) > 4) break;
                    }
                    Color color = Color.FromArgb((i * 2) % 255, (i * 3) % 255, (i * 5) % 255);//use color model conversion to get rainbow palette, make brightness black if maxIterations reached
                    myBitmap.SetPixel(x, y, color);//draw the pixel
                }
            return newResult;
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
            Complex a = new Complex(Convert.ToDouble(newtonA.Text), 0);
            for (int i = 0; i < N_MAX_ITERATIONS; i++)
            {
                Complex f = Complex.Multiply(z , z);
                f = Complex.Multiply(f, z);
                f = Complex.Multiply(f, z);
                f = Complex.Subtract(f, one);

                Complex fp = Complex.Multiply(z, z);
                fp = Complex.Multiply(fp, z);
                fp = Complex.Multiply(four, fp);

                z = Complex.Subtract(z, Complex.Multiply((Complex.Divide(f, fp)), a));

                
                if (Complex.Subtract(z, root2).Magnitude <= EPSILON) return Color.Red;
                if (Complex.Subtract(z, root3).Magnitude <= EPSILON) return Color.Green;
                if (Complex.Subtract(z, root4).Magnitude <= EPSILON) return Color.Blue;
                if (Complex.Subtract(z, root1).Magnitude <= EPSILON) return Color.Orange;

            }
            return Color.Black;
        }
    }
}
