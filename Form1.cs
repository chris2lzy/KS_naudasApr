using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KS_naudasApr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void aprekinat_Click(object sender, EventArgs e)
        {
            int label1 = Convert.ToInt32(numericUpDown1.Value);

            int label2 = Convert.ToInt32(numericUpDown2.Value);

            int ire = Convert.ToInt32(numericUpDown3.Value);

            int partika = Convert.ToInt32(numericUpDown4.Value);

            int komunalie_maksajumi = Convert.ToInt32(numericUpDown5.Value);

            int ienakumi = label1 + label2;

            int izdevumi = ire + partika + komunalie_maksajumi;

            int budzets = ienakumi - izdevumi;

            textBox1.Text = budzets.ToString();

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
