﻿using System;
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
            selectedEmployee.employeeID = selectedRow.Cells["DataGridViewTextBoxColumn1"].Value.ToString();
            selectedEmployee.firstName = selectedRow.Cells["DataGridViewTextBoxColumn2"].Value.ToString();
            selectedEmployee.lastName = selectedRow.Cells["DataGridViewTextBoxColumn3"].Value.ToString();
            selectedEmployee.street = selectedRow.Cells["DataGridViewTextBoxColumn4"].Value.ToString();
            selectedEmployee.city = selectedRow.Cells["DataGridViewTextBoxColumn5"].Value.ToString();
            selectedEmployee.state = selectedRow.Cells["DataGridViewTextBoxColumn6"].Value.ToString();
            selectedEmployee.zipCode = selectedRow.Cells["DataGridViewTextBoxColumn7"].Value.ToString();
            selectedEmployee.accountNum = selectedRow.Cells["DataGridViewTextBoxColumn8"].Value.ToString();
            selectedEmployee.routingNum = selectedRow.Cells["DataGridViewTextBoxColumn9"].Value.ToString();
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
            // TODO: This line of code loads data into the 'goodDataBase.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.goodDataBase.Employee);
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
        private void Update_Click(object sender, EventArgs e)
        {
            employeeTableAdapter.Update(goodDataBase);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (employeeDataGridView.SelectedRows.Count > 0)
            {
                employeeDataGridView.Rows.RemoveAt(employeeDataGridView.SelectedRows[0].Index);
                employeeTableAdapter.Update(goodDataBase);
            } 
        }

        private void MainForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            employeeTableAdapter.Update(goodDataBase);
        }

        private void employeeDataGridView_SelectionChanged_1(object sender, EventArgs e)
        {
            selectedRow = employeeDataGridView.CurrentRow;
        }
    }
}