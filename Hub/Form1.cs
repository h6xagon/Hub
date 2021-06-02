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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 popupform = new Form3();
            DialogResult dialogresult = popupform.ShowDialog();
            if (dialogresult == DialogResult.Cancel)
            {
                popupform.Dispose();
            }
            popupform.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            DialogResult dialogresult = Form2.ShowDialog();
            if (dialogresult == DialogResult.Cancel)
            {
                Form2.Dispose();
            }
            Form2.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            DialogResult dialogresult = Form4.ShowDialog();
            if (dialogresult == DialogResult.Cancel)
            {
                Form4.Dispose();
            }
            Form4.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            DialogResult dialogresult = Form5.ShowDialog();
            if (dialogresult == DialogResult.Cancel)
            {
                Form5.Dispose();
            }
            Form5.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 Form6 = new Form6();
            DialogResult dialogresult = Form6.ShowDialog();
            if (dialogresult == DialogResult.Cancel)
            {
                Form6.Dispose();
            }
            Form6.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 Form7 = new Form7();
            DialogResult dialogresult = Form7.ShowDialog();
            if (dialogresult == DialogResult.Cancel)
            {
                Form7.Dispose();
            }
            Form7.Dispose();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 Form8 = new Form8();
            DialogResult dialogresult = Form8.ShowDialog();
            if (dialogresult == DialogResult.Cancel)
            {
                Form8.Dispose();
            }
            Form8.Dispose();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form9 Form9 = new Form9();
            DialogResult dialogresult = Form9.ShowDialog();
            if (dialogresult == DialogResult.Cancel)
            {
                Form9.Dispose();
            }
            Form9.Dispose();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form10 Form10 = new Form10();
            DialogResult dialogresult = Form10.ShowDialog();
            if (dialogresult == DialogResult.Cancel)
            {
                Form10.Dispose();
            }
            Form10.Dispose();
        }
    }
}
