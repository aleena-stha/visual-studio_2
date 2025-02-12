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
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlstr = "insert into student (StudentId," +
                "StudentName, RollNo, Marks) values (" +
                txtStudentId.Text +
                ",'" +
                txtName.Text +

                 ",'" +
                 txtRollNo.Text +
                  ",'" +
                  txtMarksObtained.Text +
                   ",'";
            
                  txtGenerateQuery.Text = sqlstr;
        }
        private void textBox1_TxtChanged (object sender, EventArgs e)
         {
            string sqlstr = "Update Student Set  StudentName='" +
                txStudentName.Text + "',RollNo=" + txtRollNo.Text + ",Marks=" + txtMarks.Text +
                "where StudentId =" + txtStudentId.Text + "";
            txtGenerateQuery.Text = a;

        }
        private void btnDelete_Click (object sender, PaintEventArgs e)
        {
            string delstr = "delete from student where StudentId="
                + txtStudentId.Text + "";
            txtQuery.text = delstr;

        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel8_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmStudent_Load_1(object sender, EventArgs e)
        {

        }

        private void panel7_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
