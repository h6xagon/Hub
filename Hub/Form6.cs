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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        int t1 = 0;
        int t2 = 0;
        int t3 = 0;
        int t4 = 0;
        int t5 = 0;
        int t6 = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            Random dice = new Random();
            int[] res = new int[1000];
            for (int i = 0; i<res.Length;i++)
            {
                res[i] = dice.Next(1, 7);

            }
            for (int i = 0; i < res.Length; i++)
            {
                if (res[i] == 1)
                {
                    t1++;
                }
                if (res[i] == 2)
                {
                    t2++;
                }
                if (res[i] == 3)
                {
                    t3++;
                }
                if (res[i] == 4)
                {
                    t4++;
                }
                if (res[i] == 5)
                {
                    t5++;
                }
                if (res[i] == 6)
                {
                    t6++;
                }
                Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.FromArgb(0, 0, 0));
            g.FillRectangle(brush, 25, 100, 5, t1*2);
            g.FillRectangle(brush, 45, 100, 5, t2*2);
            g.FillRectangle(brush, 70, 100, 5, t3*2);
            g.FillRectangle(brush, 95, 100, 5, t4*2);
            g.FillRectangle(brush, 120, 100, 5, t5*2);
            g.FillRectangle(brush, 145, 100, 5, t6*2);
            label1.Text = t1.ToString();
            label2.Text = t2.ToString();
            label3.Text = t3.ToString();
            label4.Text = t4.ToString();
            label5.Text = t5.ToString();
            label6.Text = t6.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            t1 = 0;
            t2 = 0;
            t3 = 0;
            t4 = 0;
            t5 = 0;
            t6 = 0;
            Invalidate();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
