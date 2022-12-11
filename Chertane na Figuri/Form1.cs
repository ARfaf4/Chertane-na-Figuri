using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Reflection;

namespace Chertane_na_Figuri
{
    public partial class Form1 : Form
    {
        private bool isspamon = false;
        private bool istri = false;
        private bool isrect = false;
        private bool iscirc = false;
        private bool ispoly = false;
        private bool isepileptic = false;

        Random random = new Random();

        Thread thread;
        Thread thread1;
        Thread thread2;
        Thread thread3;
        Thread thread4;
        Thread thread5;
        public Form1()
        {
            InitializeComponent();
        }      
        private void button1_Click(object sender, EventArgs e) //triugulnik
        {
            istri = true;
            if (isspamon)
            {
                thread = new Thread(DrawTriangle);
                thread.Start();
            }
            else
            {
                thread1 = new Thread(DrawTriangle);
                thread1.Start();
            }
            
        }

        private void button2_Click(object sender, EventArgs e) //krug
        {
            iscirc = true;
            if (isspamon)
            {
                thread = new Thread(DrawCircle);
                thread.Start();
            }
            else
            {
                thread2 = new Thread(DrawCircle);
                thread2.Start(); ;
            }
        }

        private void RectangleBtn_Click(object sender, EventArgs e) //pravougulnik
        {
            isrect = true;
            if (isspamon)
            {
                thread = new Thread(DrawRectangle);
                thread.Start();
            }
            else
            {
                thread3 = new Thread(DrawRectangle);
                thread3.Start();
            }
        }
        private void PolygonBtn_Click(object sender, EventArgs e)
        {
            ispoly = true;
            if (isspamon)
            {
                thread = new Thread(DrawPolygon);
                thread.Start();
            }
            else
            {
                thread4 = new Thread(DrawPolygon);
                thread4.Start();
            }
        }
        private void StopBtn_Click(object sender, EventArgs e)
        {
            if (isspamon)
            {
                thread.Abort(true);
                MessageBox.Show("Thread have been stopped!");
                MessageBox.Show("Nope it wasnt!");
            }
            else
            {
                if (istri)
                {
                    thread1.Abort(true);
                }
                if (iscirc)
                {
                    thread2.Abort(true);
                }
                if (isrect)
                {
                    thread3.Abort(true);
                }
                if (ispoly)
                {
                    thread4.Abort(true);
                }
                if (isepileptic)
                {
                    thread5.Abort(true);
                }
                MessageBox.Show("Threads have been stopped!");
            }
            
        }
        private void SpamModeBtn_CheckedChanged(object sender, EventArgs e)
        {
            isspamon = true;
        }

        private void EpilepticModeBtn_Click(object sender, EventArgs e)
        {
            ispoly = true;
            if (isepileptic)
            {
                thread = new Thread(EpilepticMode);
                thread.Start();
            }
            else
            {
                thread5 = new Thread(EpilepticMode);
                thread5.Start();
            }
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
        private void DrawRectangle()
        {
                for (int i = 0; i < 50; i--)
                {
                    int x = new Random().Next(1, 656);
                    int y = new Random().Next(1, 656);
                    int a = new Random().Next(1, 400);
                    int b = new Random().Next(1, 400);
                    if (x + a <= 600 && y + b <= 600)
                    {
                        Color color = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                        Pen Pen = new Pen(color);
                        Pen.Width = 5;
                        this.CreateGraphics().DrawRectangle(Pen, x, y, a, b);
                        Thread.Sleep(3000);
                    }
                }                    
        }
        private void DrawCircle()
        {
                for (int i = 0; i < 50; i--)
                {
                    int x = new Random().Next(1, 656);
                    int y = new Random().Next(1, 656);
                    int r = new Random().Next(1, 400);
                    if (r + x <= 656 && r + y <= 600)
                    {
                        Color color = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                        Pen Pen = new Pen(color);
                        Pen.Width = 5;
                        this.CreateGraphics().DrawEllipse(Pen, x, y, r, r);
                        Thread.Sleep(4000);
                    }
                }           
        }
        private void DrawTriangle()
        {
                for (int i = 0; i < 50; i--)
                {
                    Color color = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                    Pen Pen = new Pen(color);
                    Pen.Width = 5;
                    Point point = new Point(random.Next(1, 606), random.Next(1, 606));
                    Point point1 = new Point(random.Next(1, 606), random.Next(1, 606));
                    Point point2 = new Point(random.Next(1, 606), random.Next(1, 606));
                    this.CreateGraphics().DrawLine(Pen, point, point1);
                    this.CreateGraphics().DrawLine(Pen, point, point2);
                    this.CreateGraphics().DrawLine(Pen, point1, point2);
                    Thread.Sleep(2000);
                }           
        }
        private void DrawPolygon()
        {
                for (int i = 0; i < 50; i--)
                {
                    int n = new Random().Next(5, 9);
                    Point[] points = new Point[n];
                    Color color = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                    Pen Pen = new Pen(color);
                    Pen.Width = 5;
                    for (int ii = 0; ii < n; ii++)
                    {
                        Point pt = new Point(random.Next(1, 606), random.Next(1, 606));
                        points[ii] = pt;
                    }
                    this.CreateGraphics().DrawPolygon(Pen, points);
                    Thread.Sleep(1500);
                }   
        }
       
        private void EpilepticMode()
        {
                for (int i = 0; i < 50; i--)
                {
                    Color color = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                    Pen Pen = new Pen(color);
                    Pen.Width = 5;
                    Point point = new Point(random.Next(1, 606), random.Next(1, 606));
                    Point point1 = new Point(random.Next(1, 606), random.Next(1, 606));
                    Point point2 = new Point(random.Next(1, 606), random.Next(1, 606));
                    this.CreateGraphics().DrawLine(Pen, point, point1);
                    this.CreateGraphics().DrawLine(Pen, point, point2);
                    this.CreateGraphics().DrawLine(Pen, point1, point2);
                }      
        }
    }
}
