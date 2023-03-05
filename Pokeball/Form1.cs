using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokeball
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private SolidBrush brush01 = new SolidBrush(Color.Red);
        private SolidBrush brush02 = new SolidBrush(Color.White);
        private SolidBrush brush03 = new SolidBrush(Color.Black);
        //
        Pen pen01 = new Pen(Color.Black);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            //
            Draw();
        }

        private void Draw()
        {
            int tamanhoD01 = 930;
            int tamanhoD03 = 300;
            int tamanhoD02 = 155;
            //
            int x1 = (this.Width / 2) - (tamanhoD01 - ((tamanhoD01 / 2) - 8));
            int y1 = (this.Height / 2) - (tamanhoD01 - ((tamanhoD01 / 2) - 7));
            int x2 = (this.Width / 2) - (tamanhoD02 - ((tamanhoD02 / 2) - 8));
            int y2 = (this.Height / 2) - (tamanhoD02 - ((tamanhoD02 / 2) - 7));
            int x3 = (this.Width / 2) - (tamanhoD03 - ((tamanhoD03 / 2) - 8));
            int y3 = (this.Height / 2) - (tamanhoD03 - ((tamanhoD03 / 2) - 7));
            //
            graphics.FillEllipse(brush01, x1, y1, tamanhoD01, tamanhoD01);
            graphics.FillEllipse(brush03, x3, y3, tamanhoD03, tamanhoD03);
            graphics.FillEllipse(brush02, x2, y2, tamanhoD02, tamanhoD02);
            //
            Rectangle rect = new Rectangle(650, 160, 620, 672);
            graphics.DrawArc(new Pen(new SolidBrush(Color.White), 310), rect, 0, 180);
            //
            pen01.Width = 90;
            //
            graphics.DrawLine(pen01, 1049, 516, 1429, 516);
            //
            graphics.DrawLine(pen01, 489, 516, 869, 516);
        }
    }
}
