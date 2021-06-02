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
    public partial class Form8 : Form
    {
        List<string> se = new List<string>();
        List<string> en = new List<string>();
        List<string> res = new List<string>();
        int count = 0;
        int cAns = 0;
        int icAns = 0;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            gbxTest.Enabled = false;
        }

        //Addera glosor
        private void addGlosa_Click(object sender, EventArgs e)
        {
            se.Add(addSE.Text);
            en.Add(addEN.Text);
            addSE.Text = "";
            addEN.Text = "";
            btnStart.Enabled = true;
        }
        //Starta glostest
        private void btnStart_Click(object sender, EventArgs e)
        {
            count = 0;
            gbxAdd.Enabled = false;
            btnStart.Enabled = false;
            gbxTest.Enabled = true;
            ansSE.Text = se[0];
            lblAmount.Text = "";
            lblRes.Text = "";
        }
        //svara på glosor knappen 
        private void btnAns_Click(object sender, EventArgs e)
        {
            if (ansSE.Text == se[count] && ansEN.Text == en[count])
            {
                res.Add($"{se[count]} är rätt svar.");
                cAns++;
            }
            else
            {
                res.Add($" fel. Rätt svar {en[count]}");
                icAns++;
            }
            count++;
            if (count == se.Count)
            {
                lblAmount.Text = $"Antal rätt/fel = {cAns}/{icAns}";
                btnStart.Enabled = true;
                btnNewG.Enabled = true;
                count--;
                gbxTest.Enabled = false;
                for (int i = 0; i < se.Count; i++)
                {
                    textBox1.AppendText("" + res[i] + "\r\n");
                }
            }
            ansSE.Text = se[count];
            ansEN.Text = "";
        }
        //Nya glosor (reset)
        private void btnNewG_Click(object sender, EventArgs e)
        {
            gbxTest.Enabled = false;
            gbxAdd.Enabled = true;
            se.Clear();
            en.Clear();
            res.Clear();
            count = 0;
            lblAmount.Text = "";
            lblRes.Text = "";
        }

        private void gbxAdd_Enter(object sender, EventArgs e)
        {

        }
    }
}
