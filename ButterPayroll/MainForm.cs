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
            //create new instance of AddModify form
            addForm = new AddModify(this);
            //sets the mode of the Form
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
            selectedEmployee.planName = selectedRow.Cells["planName"].Value;
            selectedEmployee.description = selectedRow.Cells["description"].Value;
            selectedEmployee.cost = selectedRow.Cells["cost"].Value;
            selectedEmployee.optical = selectedRow.Cells["opticalDeduction"].Value;
            selectedEmployee.dental = selectedRow.Cells["dentalDeduction"].Value;
            selectedEmployee.cafe = selectedRow.Cells["cafeteriaBenifits"].Value;
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
            //this.employeeTableAdapter1.Fill(this.goodDataBase.Employee);

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            employeeDataGridView.Focus();
            employeeTableAdapter.Update(goodDataBase);
            ExitProgramSequence();
        }

        //Askes the user if they want to save the database before exiting
        private void ExitProgramSequence()
        {
            DialogResult dr = MessageBox.Show("Do you want to save?", "Goodbye", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                employeeTableAdapter.Update(goodDataBase);
                employeeTableAdapter.Fill(this.goodDataBase.Employee1);
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
        }
        //Deletes the selected value from the datagridview and database
        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this Employee?", "Delete", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (employeeDataGridView.SelectedRows.Count > 0)
                {
                    employeeDataGridView.Rows.RemoveAt(employeeDataGridView.SelectedRows[0].Index);
                    employeeDataGridView.Focus();
                    employeeTableAdapter.Update(goodDataBase);
                }
            }
        }

        //Updates the database on the Form Closing
        private void MainForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            employeeTableAdapter.Update(goodDataBase);
        }

        //upon selection change
        //gets current row information and updates employee details sidebar
        private void employeeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectedRow = employeeDataGridView.CurrentRow;
            //Pay checks are every 2 weeks so divide optical and dental by 24 because yearly price and by two on insurance price (monthly value)
            double totalDeductions = ((Convert.ToDouble(selectedRow.Cells["opticalDeduction"].Value.ToString())/24) + (Convert.ToDouble(selectedRow.Cells["dentalDeduction"].Value.ToString())/24) + (Convert.ToDouble(selectedRow.Cells["cafeteriaBenifits"].Value.ToString())/12) + (Convert.ToDouble(selectedRow.Cells["cost"].Value.ToString())/2));
            double taxes = ((Convert.ToDouble(selectedRow.Cells["hours"].Value.ToString()) * Convert.ToDouble(selectedRow.Cells["rate"].Value.ToString()))) * ((Convert.ToDouble(selectedRow.Cells["taxes"].Value.ToString()))/100);
            double netPay = ((Convert.ToDouble(selectedRow.Cells["hours"].Value.ToString()) * Convert.ToDouble(selectedRow.Cells["rate"].Value.ToString()) - taxes)) -totalDeductions;

            //populate additionalinformation richtextbox with information
            additionalInformation.Text = "Name:\n\t" + selectedRow.Cells["lname"].Value.ToString() + "," + selectedRow.Cells["fname"].Value.ToString() +
                "\nAddress:\n\t" + selectedRow.Cells["street"].Value.ToString() + "\n\t" + selectedRow.Cells["city"].Value.ToString() + ", " + selectedRow.Cells["state"].Value.ToString() + " " + selectedRow.Cells["zip"].Value.ToString() +
                "\nBank Information:\n\t" + "Account #: " + selectedRow.Cells["accountNum"].Value.ToString() + "\n\tRouting #: " + selectedRow.Cells["routingNum"].Value.ToString();
            if ((bool)selectedRow.Cells["directdeposit"].Value)
            {
                additionalInformation.Text += "\n\tMethod: Direct Deposit\n";
            }
            else {
                additionalInformation.Text += "\n\tMethod: Check\n";
            }
            if (selectedRow.Cells["companyname"].Value.ToString() != "")
            {
                additionalInformation.Text += "Insurance Information:\n\t" + "Provider: " + selectedRow.Cells["companyName"].Value.ToString() + "\n\tID: " + selectedRow.Cells["planId"].Value.ToString() + "\n\tPlan: "+ selectedRow.Cells["planName"].Value.ToString() + "\n\tType: "+ selectedRow.Cells["description"].Value.ToString();

            }
            else {
                additionalInformation.Text += "Insurance Information:\n\tNot Available\n\n\n";

            }
            additionalInformation.Text += "\nDeductions:\n\t" +
                "Optical/yr: " + selectedRow.Cells["opticalDeduction"].Value.ToString() +
                "\n\tDental/yr: " + selectedRow.Cells["dentalDeduction"].Value.ToString()+
                "\n\tCafeteria/yr: " + selectedRow.Cells["cafeteriaBenifits"].Value.ToString() +
                "\n\tMedical/mth: " + (Convert.ToDouble(selectedRow.Cells["cost"].Value)).ToString("#.##")+
                "\n\tTotal Deductions/mth: " + totalDeductions.ToString("#.##");

            additionalInformation.Text += "\nEarnings:" +
                "\n\tHours: " + selectedRow.Cells["hours"].Value.ToString() +
                "\n\tRate: " + selectedRow.Cells["rate"].Value.ToString() +
                "\n\tTaxes: " + selectedRow.Cells["taxes"].Value.ToString();
            if ((bool)selectedRow.Cells["status"].Value)
            {
                additionalInformation.Text += "\n\tStatus: Full-Time";
            }
            else {
                additionalInformation.Text += "\n\tStatus: Part-Time";
            }
            additionalInformation.Text += "\n\tNet Pay: " + netPay.ToString("#.##");
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
                    if (row.Cells[1].Value.ToString().ToUpper().Contains(search_textBox.Text.ToUpper()) && search_textBox.Text != "")
                    {
                        row.Visible = true;
                    }
                    else if (search_textBox.Text != "")
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
                    if (row.Cells[0].Value.ToString().ToUpper().Contains(search_textBox.Text.ToUpper()) && search_textBox.Text != "")
                    {
                        row.Visible = true;
                    }
                    else if (search_textBox.Text != "")
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
                    if (row.Cells[2].Value.ToString().ToUpper().Contains(search_textBox.Text.ToUpper()) && search_textBox.Text != "")
                    {
                        row.Visible = true;
                    }
                    else if (search_textBox.Text != "")
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
                    if (row.Cells[5].Value.ToString().ToUpper().Contains(search_textBox.Text.ToUpper()) && search_textBox.Text != "")
                    {
                        row.Visible = true;
                    }
                    else if (search_textBox.Text != "")
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
            search_textBox.Enabled = true;
        }

        private void insuranceDeductionRatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            System.DateTime dateTime;

            double hours, rate, taxes, taxAmount, pay, cents;
            double payInt, checkNumber = 0;
            string paymentString;

            string directDepositPrintString = "";
            string checkPrintString = "";
            //generate print strings for checks and direct deposits
            foreach(DataGridViewRow row in employeeDataGridView.Rows) {
                //get current date
                dateTime = DateTime.Now;

                //calculate net pay
                //current net pay algorithm 
                //

                hours = Convert.ToDouble(row.Cells["hours"].Value);
                rate = Convert.ToDouble(row.Cells["rate"].Value);
                taxes = Convert.ToDouble(row.Cells["taxes"].Value) / 100;
                taxAmount = hours * rate * taxes;
                double deductions=((Convert.ToDouble(row.Cells["opticalDeduction"].Value.ToString())/24) + (Convert.ToDouble(row.Cells["dentalDeduction"].Value.ToString())/24) + (Convert.ToDouble(row.Cells["cafeteriaBenifits"].Value.ToString())/12) + (Convert.ToDouble(row.Cells["cost"].Value.ToString())/2));
                payInt = Math.Floor(Convert.ToDouble((hours * rate - taxAmount) - (deductions)));
                pay = (hours * rate - taxAmount)-( deductions);
                cents = pay - payInt;

                if ((bool)row.Cells["directdeposit"].Value)
                {
                    directDepositPrintString += "Last Name: " + row.Cells["lname"].Value.ToString() +
                        "\nFirst Name: " + row.Cells["fname"].Value.ToString() +
                        "\nAddress: " + row.Cells["street"].Value.ToString() +
                        ", " + row.Cells["city"].Value.ToString() + " " + row.Cells["state"].Value.ToString() + " " + row.Cells["zip"].Value.ToString() +
                        "\nAccount Number: " + row.Cells["accountNum"].Value.ToString() +
                        "\nRouting Number: " + row.Cells["routingNum"].Value.ToString() +
                        "\nWeekly Hours: " + row.Cells["hours"].Value.ToString() +
                        "\nTax Withholdings: $" + taxAmount +
                        "\nDeductions: $" +  deductions.ToString() +
                        "\nHourly Rate: $" + row.Cells["rate"].Value.ToString() +
                        "\nPay: $" + pay + "\nProcessing Date and Time: " + dateTime +
                        "\n____________________________________________________________________________________________\n\n";
                }
                else if (!(bool)row.Cells["directdeposit"].Value)
                {
                    checkNumber++;
                    checkPrintString += "____________________________________________________________________________________________\n\n" +
                        Properties.CompanyInfo.Default.Name + "\t\t\t\t\t\tCheck Number: " + checkNumber + "\n" +
                        Properties.CompanyInfo.Default.Street + "\n" +
                        Properties.CompanyInfo.Default.City + ", " + Properties.CompanyInfo.Default.State + " " + Properties.CompanyInfo.Default.ZipCode +"\t\t\t\t Date: " + dateTime.Month+ "/" + dateTime.Day + "/" + dateTime.Year +
                        "\nPay to the order of: " + row.Cells["fname"].Value.ToString() + " " + row.Cells["lname"].Value.ToString() + "\t\t\t\t$" + pay +
                        //"\n" + paymentString + " " + cents + "/100" + "---------------" + 
                        "\n\nMemo _______________" + "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tSig _________________________" +
                        "\n____________________________________________________________________________________________\n\n";
                }
            }
            PrintPreview preview = new PrintPreview();
            preview.setPrintStrings(directDepositPrintString, checkPrintString);
            preview.ShowDialog();
        }

        private void companyInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyInformation companyInfo = new CompanyInformation();
            companyInfo.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Butter Payroll\nVersion 2.0.0.1\nPublished by: Butter Payroll Systems Inc. | Group 3\nJelzon Monzon, Michael Ruffe, William Diaz, Kevin Mak","About");
        }


    }
}