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
        public DataGridViewRow selectedRow;

        Employee selectedEmployee = new Employee();

        #region non-generated funtions

        #endregion



        private void button_add_Click(object sender, EventArgs e)
        {
            //change
            addForm = new AddModify(this);
            addForm.Mode = "Add";
            addForm.Show();
            
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            //get data from selected row
            selectedEmployee.employeeID = selectedRow.Cells["DataGridViewTextBoxColumn1"].Value.ToString();
            selectedEmployee.firstName = selectedRow.Cells["DataGridViewTextBoxColumn3"].Value.ToString();
            selectedEmployee.lastName = selectedRow.Cells["DataGridViewTextBoxColumn2"].Value.ToString();
            selectedEmployee.street = selectedRow.Cells["DataGridViewTextBoxColumn4"].Value.ToString();
            selectedEmployee.city = selectedRow.Cells["DataGridViewTextBoxColumn5"].Value.ToString();
            selectedEmployee.state = selectedRow.Cells["DataGridViewTextBoxColumn6"].Value.ToString();
            selectedEmployee.zipCode = selectedRow.Cells["DataGridViewTextBoxColumn7"].Value.ToString();
            selectedEmployee.accountNum = selectedRow.Cells["DataGridViewTextBoxColumn11"].Value.ToString();
            selectedEmployee.routingNum = selectedRow.Cells["DataGridViewTextBoxColumn12"].Value.ToString();
            selectedEmployee.hours = (double)selectedRow.Cells["DataGridViewTextBoxColumn8"].Value;
            selectedEmployee.pay= (double)selectedRow.Cells["DataGridViewTextBoxColumn9"].Value;
            selectedEmployee.tax = (double)selectedRow.Cells["DataGridViewTextBoxColumn10"].Value;
            selectedEmployee.fullTime = (bool)selectedRow.Cells["dataGridViewCheckBoxColumn2"].Value;
            selectedEmployee.directDeposit = (bool)selectedRow.Cells["dataGridViewCheckBoxColumn1"].Value;

            //initialize modify form and show
            modifyForm = new AddModify(this);
            modifyForm.Mode = "Modify";
            modifyForm.Employee = selectedEmployee;
            modifyForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'goodDataBase.Employee1' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.goodDataBase.Employee1);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version: 2.0.0.1 Alpha","");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            employeeDataGridView.Focus();
            employeeTableAdapter.Update(goodDataBase);
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
        private void Update_Click(object sender, EventArgs e)
        {
            employeeDataGridView.Focus();
            employeeTableAdapter.Update(goodDataBase);
            this.employeeTableAdapter.Fill(this.goodDataBase.Employee1);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (employeeDataGridView.SelectedRows.Count > 0)
            {
                employeeDataGridView.Rows.RemoveAt(employeeDataGridView.SelectedRows[0].Index);
                employeeDataGridView.Focus();
                employeeTableAdapter.Update(goodDataBase);
            } 
        }

        private void MainForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            employeeTableAdapter.Update(goodDataBase);
        }

        private void employeeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectedRow = employeeDataGridView.CurrentRow;
        }

        

        /// <summary>
        /// changes selected row when new row selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        

    }
}