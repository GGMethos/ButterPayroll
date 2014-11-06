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

        AddModify addForm;
        AddModify modifyForm;

        DataGridViewRow selectedRow;
        Employee selectedEmployee = new Employee();

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
            //get data from selected row
            selectedEmployee.employeeID = selectedRow.Cells["employeeIdDataGridViewTextBoxColumn"].Value.ToString();
            selectedEmployee.firstName = selectedRow.Cells["firstNameDataGridViewTextBoxColumn"].Value.ToString();
            selectedEmployee.lastName = selectedRow.Cells["lastNameDataGridViewTextBoxColumn"].Value.ToString();
            selectedEmployee.street = selectedRow.Cells["streetDataGridViewTextBoxColumn"].Value.ToString();
            selectedEmployee.city = selectedRow.Cells["cityDataGridViewTextBoxColumn"].Value.ToString();
            selectedEmployee.state = selectedRow.Cells["stateDataGridViewTextBoxColumn"].Value.ToString();
            selectedEmployee.zipCode = selectedRow.Cells["zipDataGridViewTextBoxColumn"].Value.ToString();
            selectedEmployee.accountNum = selectedRow.Cells["accountNumberDataGridViewTextBoxColumn"].Value.ToString();
            selectedEmployee.routingNum = selectedRow.Cells["routingNumberDataGridViewTextBoxColumn"].Value.ToString();
            //selectedEmployee.hours = (double)selectedRow.Cells["Hours"].Value;
            //selectedEmployee.fullTime = (bool)selectedRow.Cells["Full Time"].Value;
            //selectedEmployee.directDeposit = (bool)selectedRow.Cells["Direct Deposit"].Value;

            //initialize modify form and show
            modifyForm = new AddModify();
            modifyForm.Mode = "Modify";
            modifyForm.Employee = selectedEmployee;
            modifyForm.Show();


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.database1DataSet.Employee);
            // TODO: This line of code loads data into the 'directoryDataSet1.Employee' table. You can move, or remove it, as needed.

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
                this.Close();
            }
            else
            {
                this.Close();
                
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectedRow = dataGridView.CurrentRow;
        }
    }
}
