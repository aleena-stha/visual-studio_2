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
    public partial class FrmStudentNew : Form
    {
        public FrmStudentNew()
        {
            InitializeComponent();
        }

        private bool IsEditMode;
        
        private void EnableDisableControl(string mode)
        {
            switch (mode)
            {
                case "Reset":
                btnNew.Enabled = true;
                  btnDelete.Enabled = false;
                    btnEdit.Enabled = true;
                    btnSave.Enabled = false;
                    txtStudentId.Clear();
                    txtStudentName.Clear();
                    txtRollNo.Clear();
                    txtMarks.Clear();
                    txtStudentId.ReadOnly = true;
                    txtStudentName.ReadOnly = true; 
                    txtRollNo.ReadOnly = true;
                    txtMarks.ReadOnly = true;

                    break;

                case "New":
                    btnNew.Enabled = false;
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    //grpUserList.Enabled = false;

                    txtStudentId.ReadOnly = true;
                    txtStudentName.ReadOnly = true;
                    txtRollNo.ReadOnly = true;
                    txtMarks.ReadOnly = true;
                    break;

                case "Edit":
                    btnNew.Enabled = false;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled=false;
                    txtStudentId.ReadOnly = true;  
                    txtStudentName.ReadOnly = true;
                    txtRollNo.ReadOnly = true;
                    txtMarks.ReadOnly = true;
                    break;

            }
        }

        

        

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            txtStudentId.Text = dataGridView1.CurrentRow.Cells["StudentID"].Value.ToString();
            txtStudentName.Text = dataGridView1.CurrentRow.Cells["StudentName"].Value.ToString();
            txtRollNo.Text = dataGridView1.CurrentRow.Cells["RollNo"].Value.ToString();
            txtMarks.Text = dataGridView1.CurrentRow.Cells["Marks"].Value.ToString();
            btnNew.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
           
        }

        private void FrmStudentNew_Load(object sender, EventArgs e)
        {
            EnableDisableControl("Reset");
            DisplayData();

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }
    }
}
