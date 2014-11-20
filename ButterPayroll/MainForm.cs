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
            selectedEmployee.employeeID = selectedRow.Cells["employeeId"].Value.ToString();
            selectedEmployee.firstName = selectedRow.Cells["fname"].Value.ToString();
            selectedEmployee.lastName = selectedRow.Cells["lname"].Value.ToString();
            selectedEmployee.street = selectedRow.Cells["street"].Value.ToString();
            selectedEmployee.city = selectedRow.Cells["city"].Value.ToString();
            selectedEmployee.state = selectedRow.Cells["state"].Value.ToString();
            selectedEmployee.zipCode = selectedRow.Cells["zip"].Value.ToString();
            selectedEmployee.accountNum = selectedRow.Cells["accountNum"].Value.ToString();
            selectedEmployee.routingNum = selectedRow.Cells["routingNum"].Value.ToString();
            selectedEmployee.hours = (double)selectedRow.Cells["hours"].Value;
            selectedEmployee.pay= (double)selectedRow.Cells["rate"].Value;
            selectedEmployee.tax = (double)selectedRow.Cells["taxes"].Value;
            selectedEmployee.fullTime = (bool)selectedRow.Cells["status"].Value;
            selectedEmployee.directDeposit = (bool)selectedRow.Cells["directdeposit"].Value;
            selectedEmployee.company = selectedRow.Cells["companyName"].Value;
            selectedEmployee.planId = selectedRow.Cells["planId"].Value;

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
            // TODO: This line of code loads data into the 'goodDataBase.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.goodDataBase.Employee);
            // TODO: This line of code loads data into the 'goodDataBase.Employee1' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.goodDataBase.Employee1);
            // TODO: This line of code loads data into the 'goodDataBase.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.goodDataBase.Employee);
            // TODO: This line of code loads data into the 'goodDataBase.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.goodDataBase.Employee);
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
        //Askes the user if they want to leave the program
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

        //Updates the database and gridview
        private void Update_Click(object sender, EventArgs e)
        {
            employeeDataGridView.Focus();
            employeeTableAdapter.Update(goodDataBase);
            this.employeeTableAdapter.Fill(this.goodDataBase.Employee1);
        }
        //Deletes the selected value from the datagridview and database
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (employeeDataGridView.SelectedRows.Count > 0)
            {
                employeeDataGridView.Rows.RemoveAt(employeeDataGridView.SelectedRows[0].Index);
                employeeDataGridView.Focus();
                employeeTableAdapter.Update(goodDataBase);
            } 
        }
        //Updates the database on the Form Closing
        private void MainForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            employeeTableAdapter.Update(goodDataBase);
        }
        //Gets the current selected row and puts it into cell
        private void employeeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectedRow = employeeDataGridView.CurrentRow;
        }
        //Text box Changed Searches our datagridview for a selected employee
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            employeeDataGridView.CurrentCell = null;
            comboBox1.Enabled = false;
            if (comboBox1.Text == "Last Name")
            {
                foreach (DataGridViewRow row in employeeDataGridView.Rows)
                {
                    if (row.Cells[1].Value.ToString().ToUpper().Contains(textBox1.Text.ToUpper()) && textBox1.Text != "")
                    {
                        row.Visible = true;
                    }
                    else if (textBox1.Text != "")
                        row.Visible = false;
                    else
                    {
                        row.Visible = true;
                        comboBox1.Enabled = true;
                    }
                }
            }
            if (comboBox1.Text == "Employee Id")
            {
                foreach (DataGridViewRow row in employeeDataGridView.Rows)
                {
                    if (row.Cells[0].Value.ToString().ToUpper().Contains(textBox1.Text.ToUpper()) && textBox1.Text != "")
                    {
                        row.Visible = true;
                    }
                    else if (textBox1.Text != "")
                        row.Visible = false;
                    else
                    {
                        row.Visible = true;
                        comboBox1.Enabled = true;
                    }
                }
            }
            if (comboBox1.Text == "First Name")
            {
                foreach (DataGridViewRow row in employeeDataGridView.Rows)
                {
                    if (row.Cells[2].Value.ToString().ToUpper().Contains(textBox1.Text.ToUpper()) && textBox1.Text != "")
                    {
                        row.Visible = true;
                    }
                    else if (textBox1.Text != "")
                        row.Visible = false;
                    else
                    {
                        row.Visible = true;
                        comboBox1.Enabled = true;
                    }
                }
            }
            if (comboBox1.Text == "State")
            {
                foreach (DataGridViewRow row in employeeDataGridView.Rows)
                {
                    if (row.Cells[5].Value.ToString().ToUpper().Contains(textBox1.Text.ToUpper()) && textBox1.Text != "")
                    {
                        row.Visible = true;
                    }
                    else if (textBox1.Text != "")
                        row.Visible = false;
                    else
                    {
                        row.Visible = true;
                        comboBox1.Enabled = true;
                    }
                }
            }
        }
        //Enables the textbox when a value is chosen
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void insuranceBenefitsRatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

    }
}