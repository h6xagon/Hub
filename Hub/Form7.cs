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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics gr = e.Graphics;

            for (int i = 0; i<255;i++)

            {
                SolidBrush brush = new SolidBrush(Color.FromArgb(255, i, i));
                brush.Color = Color.FromArgb(255, i, i);
                gr.FillRectangle(brush, 25, i, 20, 1);
            }
            Owso Oval1 = new Owso();
            Oval1.x = 2;
            Oval1.y = 2;
            Oval1.w = 2;
            Oval1.h = 2;




        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
