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
    public partial class AddModify : Form
    {
        public AddModify(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        MainForm mainForm;
        public string Mode { get; set; }
        public Employee Employee { get; set; }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Close without saving?", "Cancel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                this.Close();
            }
        }

        private void AddModify_Load(object sender, EventArgs e)
        {
            this.Text = Mode;
            if (Mode == "Modify") {
                populateTxtBoxes();
            }
        }

        private void populateTxtBoxes(){
            label_employeeID.Text = Employee.employeeID;
            tbox_firstName.Text = Employee.firstName;
            tbox_lastName.Text = Employee.lastName;
            tbox_street.Text = Employee.street;
            tbox_city.Text = Employee.city;
            tbox_state.Text = Employee.state;
            tbox_zipCode.Text = Employee.zipCode;
            tbox_accountNum.Text = Employee.accountNum;
            tbox_routingNum.Text = Employee.routingNum;
            tbox_hours_worked.Text = Employee.hours.ToString();
            tbox_pay.Text = Employee.pay.ToString();
            tbox_taxes.Text = Employee.tax.ToString();
            if (Employee.fullTime == true)
            {
                rbutton_fulltime.Checked = true;
            }
            else
            {
                radio_parttime.Checked = true;
            }
            if (Employee.directDeposit == true)
            {
                radio_directDeposit.Checked = true;
            }
            else
            {
                radio_check.Checked = true;
            }

        }
        private void button_save_Click(object sender, EventArgs e)
        {
            MainForm owningForm = (MainForm)Application.OpenForms["MainForm"];
            if (this.Mode == "Modify")
            {
                owningForm.selectedRow.Cells["DataGridViewTextBoxColumn1"].Value = label_employeeID.Text;
                owningForm.selectedRow.Cells["DataGridViewTextBoxColumn2"].Value = tbox_lastName.Text;
                owningForm.selectedRow.Cells["DataGridViewTextBoxColumn3"].Value = tbox_firstName.Text;
                owningForm.selectedRow.Cells["DataGridViewTextBoxColumn4"].Value = tbox_street.Text;
                owningForm.selectedRow.Cells["DataGridViewTextBoxColumn5"].Value = tbox_city.Text;
                owningForm.selectedRow.Cells["DataGridViewTextBoxColumn6"].Value = tbox_state.Text;
                owningForm.selectedRow.Cells["DataGridViewTextBoxColumn7"].Value = tbox_zipCode.Text;
                owningForm.selectedRow.Cells["DataGridViewTextBoxColumn11"].Value = tbox_accountNum.Text;
                owningForm.selectedRow.Cells["DataGridViewTextBoxColumn12"].Value = tbox_routingNum.Text;
                owningForm.selectedRow.Cells["DataGridViewTextBoxColumn8"].Value = tbox_hours_worked.Text;
                owningForm.selectedRow.Cells["DataGridViewTextBoxColumn9"].Value = tbox_pay.Text;
                owningForm.selectedRow.Cells["DataGridViewTextBoxColumn10"].Value = tbox_taxes.Text;
                if (radio_check.Checked == true)
                {
                    owningForm.selectedRow.Cells["dataGridViewCheckBoxColumn1"].Value = false;
                }
                else
                    owningForm.selectedRow.Cells["dataGridViewCheckBoxColumn1"].Value = true;
                if (rbutton_fulltime.Checked == true)
                {
                    owningForm.selectedRow.Cells["dataGridViewCheckBoxColumn2"].Value = Employee.fullTime = true;
                }
                else
                    owningForm.selectedRow.Cells["dataGridViewCheckBoxColumn2"].Value = Employee.fullTime = false;

                owningForm.employeeDataGridView.ClearSelection();
                MessageBox.Show("Sucessfully Modified");
                owningForm.employeeDataGridView.Focus();    
            }

            if (this.Mode == "Add")
            {
                int count =owningForm.employeeDataGridView.Rows.Count;
                owningForm.employeeTableAdapter.Insert(count+1, "Ruffe", "Ed", "12 test", "SI", "NY", "10310", 5, 5, 17, "00", "00", true, true,null,null,null,null,null,null,null);
            }
                this.Close();
            
        }

        /// <summary>
        /// checks all text boxes for errors
        /// </summary>
        /// <returns>if all text boxes pass</returns>
        private bool textBoxErrorChecking() {
            return true;
        }

        private void CompanyCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear all insurance related fields
            insuranceID_tbox.Clear();
            PlanCombo.Items.Clear();
            DescriptionCombo.Items.Clear();

            PlanCombo.Text = "Select One...";
            DescriptionCombo.Text = "Select One...";

            string selection = CompanyCombo.Text.ToString();
            //plans only given with medicare
            string[] medicarePlans = new string[] { "A", "B", "A & B" };
            //plans given with blue cross, hip, and aetna
            string[] generalPlans = new string[] { "HMO", "POS", "PPO" };

            if (selection == "Medicare") {
                //show plan (A,B)
                insurancePlan_label.Visible = true;
                PlanCombo.Visible = true;
                insuranceID_label.Visible = true;
                insuranceID_tbox.Visible = true;

                insuranceDescription_label.Visible = false;
                DescriptionCombo.Visible = false;
                PlanCombo.Items.Clear();
                PlanCombo.Items.AddRange(medicarePlans);
            }
            else if (selection == "Medicaid") {
                //hide
                //show
                insurancePlan_label.Visible = false;
                PlanCombo.Visible = false;
                price_label.Visible = true;
                insuranceDescription_label.Visible = false;
                DescriptionCombo.Visible = false;
                insuranceID_label.Visible = true;
                insuranceID_tbox.Visible = true;
            }
            else if (selection == "Blue Cross" || selection == "HIP" || selection == "Aetna") {
                //hide
                //show plan (HMO, POS, PPO)
                insurancePlan_label.Visible = true;
                PlanCombo.Visible = true;

                insuranceID_label.Visible = true;
                insuranceID_tbox.Visible = true;
                PlanCombo.Items.Clear();
                PlanCombo.Items.AddRange(generalPlans);
            }
            else if (selection == "None") {
                //hide
                insuranceID_label.Visible = false;
                insuranceID_tbox.Visible = false;
                insurancePlan_label.Visible = false;
                PlanCombo.Visible = false;
                price_label.Visible = false;
                insuranceDescription_label.Visible = false;
                DescriptionCombo.Visible = false;
                price_label.Visible = false;
            }
        }

        private void PlanCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = PlanCombo.Text.ToString();
            string[] descriptions = new string[] { "Individual", "Family"};

            if (PlanCombo.Text.ToString() == "HMO" || PlanCombo.Text.ToString() == "POS" || PlanCombo.Text.ToString() == "PPO") {
                DescriptionCombo.Text = "Select One...";
                DescriptionCombo.Items.Clear();
                DescriptionCombo.Items.AddRange(descriptions);

                insuranceDescription_label.Visible = true;
                DescriptionCombo.Visible = true;
            }
        }

        private void DescriptionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = DescriptionCombo.Text.ToString();
            //get price from text file based on information

            //show price
            price_label.Visible = true;
        }

        
    }
}
