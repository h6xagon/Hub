using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hub
{
    public partial class Form10 : Form
    {
        private Pil[] pilar;
        private int antalP = 0;
        public Form10()
        {
            InitializeComponent();
            pilar = new Pil[99];
        }
        int num = 0;
        private void button2_Click(object sender, EventArgs e)
        {
 
            num++;

            Invalidate();

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            
            for (int i=0;i<antalP;i++)
            {
                if (pilar[i] != null) pilar[i].paint(e.Graphics);
            }
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (antalP<98)
            {
                pilar[antalP++] = new Pil(e.X, e.Y, 5);

                Invalidate();
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
        //classes
        class Pil
        {
            //medlemsdata
            private int x = 0;
            private int y = 0;
            private int radie = 0;
            //Konstruktor
            public Pil(int x, int y, int r)
            {
                this.x = x;
                this.y = y;
                this.Radie = r;
            }
            //egenskaper
            public int X
            {
                get { return x; }
                set { x = value; }
            }
            public int Y
            {
                get { return y; }
                set { y = value; }
            }
            public int Radie
            {
                get { return radie; }
                set
                {
                    if (radie > 0) this.radie = value;
                    else this.radie = -value;
                }
            }
            public Point Position
            {
                get { return new Point(X, Y); }
                set { y = value.X; y = value.Y; }
            }
            //metoder
            public void paint(Graphics g)
            {
                Pen brush = new Pen(Brushes.Pink, 2);
                g.DrawLine(brush, x - radie, y - radie, x + radie, y + radie);
                g.DrawLine(brush, x - radie, y + radie, x + radie, y - radie);
            }
        }
    }
}
