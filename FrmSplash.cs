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
    public partial class FrmSplash : Form
    { 
        private double _cntr=0;
        public boo1 ShowLoginForm { get; set; }
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_cntr < 1)
            {
                _cntr += 0.01;   //if less than 1 increment by 0.01
                progressBar1.Value = Convert.ToInt32(_cntr + 100);
            }
            else 
            {
                timer1.Stop();
                ShowLoginForm = true;
                this.Close();
            }
            if (timer1.Interval == 10 && _cntr * 100 >= 60)
            {
                progressBar1.Text = @"Loading Completed .. Starting program ..";
               progressBar1.Refresh();
            }
        }

       
    }
}
