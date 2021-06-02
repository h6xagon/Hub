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
    public partial class Form5 : Form
    {
        private bool changer = true;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            int r = 0;
            int g = 0;
            int b = 0;
            Graphics gr = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.FromArgb(r, g, b));
            gr.FillRectangle(brush, 100, 25, 50, 40);
            if (changer)
            {
                bool pR;
                pR = int.TryParse(textBox1.Text, out r);
                pR = int.TryParse(textBox2.Text, out g);
                pR = int.TryParse(textBox3.Text, out b);
                brush.Color = Color.FromArgb(r, g, b);
                gr.FillRectangle(brush, 100, 25, 50, 40);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            changer = !changer;
            Invalidate();
        }
    }
}
