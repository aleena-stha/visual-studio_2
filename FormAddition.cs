using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstDesktop
{
    public partial class FormAddition : Form
    {
        public FormAddition()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormAddition_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Sum_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //txtSum.Text = txtFirstNumber.Text + txtSecondNumber.Text;
            //int fn, sn, sum;
            //fn = int.Parse(txtFirstNumber.Text);
            //sn = int.Parse(txtSecondNumber.Text);
          txtSum.Text = (int.Parse(txtFirstNumber.Text) + int.Parse(txtSecondNumber.Text)).ToString();
           
            
            //txtSum.Text = sum.ToString();// to change the number into string
        }

        private void txtSecondNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
