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
        public Form1()
        {
            InitializeComponent();
        }
        Thread thread;
        private void button1_Click(object sender, EventArgs e) //triugulnik
        {
           
        }

        private void button2_Click(object sender, EventArgs e) //krug
        {

        }

        private void RectangleBtn_Click(object sender, EventArgs e) //pravougulnik
        {            
            thread = new Thread(DrawRectangle);
            thread.Start();
        }
        private void DrawRectangle()
        {
                for (int i = 0; i < 50; i--)
                {
                    int x = new Random().Next(1, 656);
                    int y = new Random().Next(1, 656);
                    int a = new Random().Next(1, 400);
                    int b = new Random().Next(1, 400);
                    if (x + a <= 656 && y + b <= 600)
                    {
                        Color red = Color.FromArgb(255, 255, 0, 0);
                        Pen redPen = new Pen(red);
                        redPen.Width = 5;
                        this.CreateGraphics().DrawRectangle(redPen, x, y, a, b);
                        Thread.Sleep(3000);
                    }
                  
                }
            
            
            
        }   

        private void StopBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
