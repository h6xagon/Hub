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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        List<string> order = new List<string>();
        Stack<string> stack = new Stack<string>();
        int wrong = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            wrong = 0;
            string box = textBox1.Text;
            List<string> loot = new List<string>();
            loot.AddRange(textBox1.Text.Select(c => c.ToString()));
            for (int i =0;i<loot.Count;i++)
            {
                if (loot[i]=="(")
                {
                    stack.Push(loot[i]);
                }
                if (loot[i] == ")")
                {
                    if (stack.Count == 0)
                    {
                        textBox2.Text = "Höger parantes för mycket";
                        wrong++;
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
            }
            if(stack.Count>0)
            {
                textBox2.Text = "Höger parantes för lite";
                wrong++;
            }
            if (wrong == 0)
            {
                textBox2.Text = "OK";
            }
        }
    }
}
