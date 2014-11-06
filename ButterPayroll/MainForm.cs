using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButterPayroll
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Payroll payroll;

        AddModify addForm;
        AddModify modifyForm;

        #region non-generated funtions

        #endregion

        private void button_add_Click(object sender, EventArgs e)
        {
            //change
            addForm = new AddModify();
            addForm.Mode = "Add";
            addForm.Show();
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            modifyForm = new AddModify();
            modifyForm.Mode = "Modify";
            modifyForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.database1DataSet.Employee);
            // TODO: This line of code loads data into the 'directoryDataSet1.Employee' table. You can move, or remove it, as needed.
            payroll = new Payroll();
            payroll.getEmployeeData();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version: 2.0.0.1 Alpha","");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitProgramSequence();
        }

        private void ExitProgramSequence()
        {
            DialogResult dr = MessageBox.Show("Do you want to save?", "Goodbye", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                payroll.saveEmployeeData();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
