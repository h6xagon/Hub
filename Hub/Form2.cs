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
    public partial class Form2 : Form
    {
        Random gen = new Random();
        int[] r1 = new int[6];
        int[] r2 = new int[6];
        int[] r3 = new int[6];
        public Form2()
        {
            InitializeComponent();
            listBox1.SelectedIndex = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Gen btn
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i=0;i<6;i++)
            {
                r1[i] = gen.Next(1, 21);
                textBox1.AppendText("" + r1[i] + "\n" );
                r2[i] = gen.Next(1, 21);
                textBox2.AppendText("" + r2[i] + "\n");
                r3[i] = gen.Next(1, 21);
                textBox3.AppendText("" + r3[i] + "\n");
            }
        }
        //r1
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //r2
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //r3
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //väljbtn
        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            for(int i=0; i<6;i++)
            {
                if (listBox1.SelectedIndex == 0) textBox4.AppendText(""+r1[i]+ "\n");
                if (listBox1.SelectedIndex == 1) textBox4.AppendText(""+r2[i]+ "\n");
                if (listBox1.SelectedIndex == 2) textBox4.AppendText(""+r3[i]+ "\n");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
