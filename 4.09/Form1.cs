using System;
using System.Drawing;
using System.Windows.Forms;

namespace _4._09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                using (Pen pen = new Pen(Color.Black, 3.0f))
                {
                    int x = 100;
                    int y = 50;
                    bool diagonal = false;
                    SolidBrush brush = new SolidBrush(Color.Black);
                    for (; y <= 400; y += 50)
                    {
                        for (; x <= 400; x += 100)
                            g.FillRectangle(brush, new Rectangle(x, y, 50, 50));
                        if (diagonal)
                        {
                            x = 100;
                            diagonal = false;
                        }
                        else
                        {
                            x = 50;
                            diagonal = true;
                        }
                    }
                    g.DrawRectangle(pen, new Rectangle(50,50,400,400));
                }
            }
        }
    }

}
