using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharp___GDI__Graphics_Tutorial
{
    public partial class frmGraphics : Form
    {
        Font myFont = new Font("Arial", 14, FontStyle.Bold);
        Pen myPen = new Pen(Brushes.Black, 5);
        SolidBrush myBrush = new SolidBrush(Color.FromArgb(128, 0, 255, 0));
        //SolidBrush myBrush = new SolidBrush(Color.FromArgb(128, Color.Green));
        Point[] polyPoints = new Point[4];
        public frmGraphics()
        {
            InitializeComponent();
        }

        private void frmGraphics_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            createPolyPoints();
        }

        private void createPolyPoints()
        {
            Random r = new Random();

            for (int k = 0; k < polyPoints.Length; k++)
            {
                polyPoints[k].X = r.Next(0, this.ClientSize.Width);
                polyPoints[k].Y = r.Next(0, this.ClientSize.Height);
            }
        }

        private void frmGraphics_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Yellow);
            e.Graphics.FillRectangle(Brushes.Blue, 100, 100, 50, 75);
            e.Graphics.DrawRectangle(Pens.Black, 10, 10, 50, 75);
            e.Graphics.DrawRectangle(Pens.Red, new Rectangle(50, 50, 75, 100));
            e.Graphics.DrawImage(Properties.Resources.stick, 200, 200);
            e.Graphics.DrawLine(Pens.Cyan, 200, 100, 300, 200);
            e.Graphics.DrawString("hello, my name is Joe",
                this.Font, Brushes.Green, 150, 150);
            e.Graphics.DrawString("hello, my name is Joe",
                myFont, Brushes.Black, 150, 175);
            e.Graphics.DrawPie(Pens.Red, 300, 300, 100, 100, 0, 360);
            e.Graphics.FillPie(Brushes.White, 600, 300, 100, 100, 0, 360);
            e.Graphics.FillPie(Brushes.DarkMagenta, 450, 200, 100, 100, 90, 270);
            e.Graphics.DrawArc(Pens.DarkMagenta, 450, 50, 100, 100, 90, 270);
            e.Graphics.DrawArc(myPen, 650, 50, 100, 100, 90, 270);
            e.Graphics.DrawPolygon(myPen, polyPoints);
            //e.Graphics.FillPolygon(Brushes.LightPink, polyPoints);
            e.Graphics.FillPolygon(myBrush, polyPoints);

        }

        private void btnPoly_Click(object sender, EventArgs e)
        {
            createPolyPoints();
        }

        private void timAppTimer_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}

//https://www.youtube.com/watch?v=8kr-V4EQ7gw&list=PLcQ2nczl5iJsrumNOFRYuWt_qAe6S5rv6
