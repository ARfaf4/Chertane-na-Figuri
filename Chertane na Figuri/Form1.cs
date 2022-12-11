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

namespace Chertane_na_Figuri
{
    public partial class Form1 : Form
    {
        
        Random random = new Random();
        Thread thread;
        public Form1()
        {
            InitializeComponent();
        }      
        private void button1_Click(object sender, EventArgs e) //triugulnik
        {
            thread = new Thread(DrawTriangle);
            thread.Start();
        }

        private void button2_Click(object sender, EventArgs e) //krug
        {
            thread = new Thread(DrawCircle);
            thread.Start();
        }

        private void RectangleBtn_Click(object sender, EventArgs e) //pravougulnik
        {            
            thread = new Thread(DrawRectangle);
            thread.Start();
        }
        private void StopBtn_Click(object sender, EventArgs e)
        {
            thread.Abort(true);
            MessageBox.Show("Thread have been stopped");
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
                        Color color = Color.FromArgb(random.Next(0,255), random.Next(0,255), random.Next(0,255));
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

    }
}
