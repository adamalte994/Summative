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
namespace Summative
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            //Pen drawPen = new Pen(Color.Blue);
            Font font = new Font("Arial", 24,FontStyle.Bold);
            SolidBrush brush = new SolidBrush(Color.Pink);
            SolidBrush brush1 = new SolidBrush(Color.Black);
            g.FillRectangle(brush, 110, 30, 550, 350);
            g.DrawString("Happy Valentime's Day!", font, brush1, 140, 50);
            g.DrawString("Greeting Card", font, brush1, 140, 110);
            g.DrawString("\n Will you be my valentime?", font, brush1, 140, 120);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 10);
            Font font = new Font("Arial", 24, FontStyle.Bold);
            SolidBrush brush = new SolidBrush(Color.Pink);
            SolidBrush brush1 = new SolidBrush(Color.Black);
            g.FillRectangle(brush, 110, 30, 550, 350);

            //first frame
            g.Clear(Color.Pink);
            g.FillRectangle(brush1, 40, 200, 100, 230);
            g.FillEllipse(brush1, 20, 90, 140, 120);
            g.DrawLine(drawPen, 160, 250, 260, 250);
            Thread.Sleep(500);

            //second frame
            g.Clear(Color.Pink);
            g.FillRectangle(brush1, 40, 200, 100, 230);
            g.FillEllipse(brush1, 20, 90, 140, 120);
            g.DrawLine(drawPen, 210, 250, 310, 250);
            Thread.Sleep(500);

            //third frame
            g.Clear(Color.Pink);
            g.FillRectangle(brush1, 40, 200, 100, 230);
            g.FillEllipse(brush1, 20, 90, 140, 120);
            g.DrawLine(drawPen, 260, 250, 360, 250);
            Thread.Sleep(500);

            //fourth frame
            g.Clear(Color.Pink);
            g.FillRectangle(brush1, 40, 200, 100, 230);
            g.FillEllipse(brush1, 20, 90, 140, 120);
            g.DrawLine(drawPen, 310, 250, 410, 250);
            Thread.Sleep(500);

            //fifth frame
            g.Clear(Color.Pink);
            g.FillRectangle(brush1, 40, 200, 100, 230);
            g.FillEllipse(brush1, 20, 90, 140, 120);
            g.DrawLine(drawPen, 360, 250, 460, 250);
            Thread.Sleep(500);

            //sixth frame
            g.Clear(Color.Pink);
            g.FillRectangle(brush1, 40, 200, 100, 230);
            g.FillEllipse(brush1, 20, 90, 140, 120);
            g.DrawLine(drawPen, 410, 250, 510, 250);
            Thread.Sleep(500);

            //seventh frame
            g.Clear(Color.Pink);
            g.FillRectangle(brush1, 40, 200, 100, 230);
            g.FillEllipse(brush1, 20, 90, 140, 120);
            g.DrawLine(drawPen, 460, 250, 560, 250);
            Thread.Sleep(500);

           //eigth frame
            g.Clear(Color.Pink);
            g.FillRectangle(brush1, 40, 200, 100, 230);
            g.FillEllipse(brush1, 20, 90, 140, 120);
            g.DrawLine(drawPen, 460, 250, 560, 250);
            Thread.Sleep(500);

            //second body
            g.FillRectangle(brush1, 500, 200, 100, 230);
            g.FillEllipse(brush1, 480, 90, 140, 120);
            g.DrawLine(drawPen, 160, 250, 260, 250);
            Thread.Sleep(500);
        }
    }
}
