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
    public partial class Form4 : Form
    {
        private string pos = "";
        int r = 0;
        int g = 0;
        int b = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.FromArgb(r, g, b));
            if (pos.Equals("right"))
            {
                gr.FillRectangle(brush, 100, 25, 50, 40);
            }
            else if (pos.Equals("left"))
            {
                gr.FillRectangle(brush, 0, 25, 50, 40);
            }
            else
            {
                gr.FillRectangle(brush, 50, 25, 50, 40);
            }
        }

        private void rightPos_Click(object sender, EventArgs e)
        {
            pos = "right";
            Invalidate();
        }

        private void leftPos_Click(object sender, EventArgs e)
        {
            pos = "left";
            Invalidate();
        }
    }
}
