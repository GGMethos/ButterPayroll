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
        MainForm owningForm = (MainForm)Application.OpenForms["MainForm"];
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
            if (Mode == "Add")
            {
                if (owningForm.employeeDataGridView.RowCount == 0) { }
                else{
                int MaxID = owningForm.employeeDataGridView.Rows.Cast<DataGridViewRow>()
                        .Max(r => Convert.ToInt32(r.Cells["employeeId"].Value));
                label_employeeID.Text = (MaxID + 1).ToString();
                }
            }
        }

        private void adjustTotalDeductionCost()
        {
            totalDeductions.Text = "$" + ((Convert.ToDouble(dental_price.Text) +
                Convert.ToDouble(optical_price.Text) +
                Convert.ToDouble(tbox_cafeteria.Text))).ToString();
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
            CompanyCombo.Text = Employee.company.ToString();
            insuranceID_tbox.Text = Employee.planId.ToString();
            PlanCombo.Text = Employee.planName.ToString();
            DescriptionCombo.Text = Employee.description.ToString();
            Price_Value.Text = Employee.cost.ToString();
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
            if (Properties.InsuranceRates.Default.Dental_I == owningForm.selectedRow.Cells["dentalDeduction"].Value.ToString())
                {
                    cbox_dental.Checked = true;
                    combo_Dental.Text = "Individual";
                }
                else if (Properties.InsuranceRates.Default.Dental_F == owningForm.selectedRow.Cells["dentalDeduction"].Value.ToString())
                {
                    cbox_dental.Checked = true;
                    combo_Dental.Text = "Family";
                }
                else
                    cbox_dental.Checked = false;

                if (Properties.InsuranceRates.Default.Optical_I == owningForm.selectedRow.Cells["opticalDeduction"].Value.ToString())
                {
                    cbox_optical.Checked = true;
                    combo_optical.Text = "Individual";
                }
                else if (Properties.InsuranceRates.Default.Optical_F == owningForm.selectedRow.Cells["opticalDeduction"].Value.ToString())
                {
                    cbox_optical.Checked = true;
                    combo_optical.Text = "Family";
                }
                else
                    cbox_optical.Checked = false;
                if (Employee.hours < 20)
                {
                    groupBox6.Enabled = false;
                    rbutton_fulltime.Checked = false;
                    Deductions.Enabled = false;
                    ineligible_label.BackColor = Color.Transparent;
                    ineligible_label.Visible = true;
                }
                if(Convert.ToInt32(Employee.cafe)>0)
                {
                    cbox_cafeteria.Checked = true;
                    tbox_cafeteria.Text = Employee.cafe.ToString();
                }
                adjustTotalDeductionCost();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (this.Mode == "Modify")
            {
                owningForm.selectedRow.Cells["employeeId"].Value = label_employeeID.Text;
                owningForm.selectedRow.Cells["lname"].Value = tbox_lastName.Text;
                owningForm.selectedRow.Cells["fname"].Value = tbox_firstName.Text;
                owningForm.selectedRow.Cells["street"].Value = tbox_street.Text;
                owningForm.selectedRow.Cells["city"].Value = tbox_city.Text;
                owningForm.selectedRow.Cells["state"].Value = tbox_state.Text;
                owningForm.selectedRow.Cells["zip"].Value = tbox_zipCode.Text;
                owningForm.selectedRow.Cells["accountNum"].Value = tbox_accountNum.Text;
                owningForm.selectedRow.Cells["routingNum"].Value = tbox_routingNum.Text;
                owningForm.selectedRow.Cells["hours"].Value = tbox_hours_worked.Text;
                owningForm.selectedRow.Cells["rate"].Value = tbox_pay.Text;
                owningForm.selectedRow.Cells["taxes"].Value = tbox_taxes.Text;
                owningForm.selectedRow.Cells["companyName"].Value = CompanyCombo.Text;
                owningForm.selectedRow.Cells["planId"].Value = insuranceID_tbox.Text;
                owningForm.selectedRow.Cells["planName"].Value = PlanCombo.Text;
                owningForm.selectedRow.Cells["description"].Value = DescriptionCombo.Text;
                owningForm.selectedRow.Cells["cost"].Value = Price_Value.Text;
                if (radio_check.Checked == true)
                {
                    owningForm.selectedRow.Cells["directdeposit"].Value = false;
                }
                else
                    owningForm.selectedRow.Cells["directdeposit"].Value = true;
                if (rbutton_fulltime.Checked == true)
                {
                    owningForm.selectedRow.Cells["status"].Value = Employee.fullTime = true;
                }
                else
                    owningForm.selectedRow.Cells["status"].Value = Employee.fullTime = false;

                if (cbox_dental.Checked == true)
                {
                    if (combo_Dental.Text == "Individual")
                        owningForm.selectedRow.Cells["dentalDeduction"].Value = dental_price.Text.ToString();
                    if (combo_Dental.Text == "Family")
                        owningForm.selectedRow.Cells["dentalDeduction"].Value = dental_price.Text.ToString();
                }
                else
                    owningForm.selectedRow.Cells["dentalDeduction"].Value = 0;
                if (cbox_optical.Checked == true)
                {
                    if (combo_optical.Text == "Individual")
                        owningForm.selectedRow.Cells["opticalDeduction"].Value = optical_price.Text.ToString();
                    if (combo_optical.Text == "Family")
                        owningForm.selectedRow.Cells["opticalDeduction"].Value = optical_price.Text.ToString();
                }
                else
                    owningForm.selectedRow.Cells["opticalDeduction"].Value = 0;
                if (cbox_cafeteria.Checked == true)
                {
                    owningForm.selectedRow.Cells["cafeteriaBenifits"].Value = tbox_cafeteria.Text;
                }
                else
                    owningForm.selectedRow.Cells["cafeteriaBenifits"].Value = 0;
                owningForm.employeeDataGridView.ClearSelection();
                MessageBox.Show("Sucessfully Modified");
                owningForm.employeeDataGridView.Focus();    
            }

            if (this.Mode == "Add")
            {
                double opt=0; 
                double den=0; 
                double caf=0;
                bool check;
                bool status;
                if (radio_check.Checked == true)
                {
                    check = false;
                }
                else
                    check = true;
                if (rbutton_fulltime.Checked == true)
                {
                    check = true;
                }
                else
                    check = false;
                if (rbutton_fulltime.Checked == true)
                {
                    status = true;
                }
                else
                    status = false;
                if (cbox_dental.Checked == true)
                {
                    if (combo_Dental.Text == "Individual")
                        den = Convert.ToDouble(dental_price.Text.ToString());
                    if (combo_Dental.Text == "Family")
                        den = Convert.ToDouble(dental_price.Text.ToString());
                }
                else
                    den = 0;
                if (cbox_optical.Checked == true)
                {
                    if (combo_optical.Text == "Individual")
                        opt = Convert.ToDouble(optical_price.Text.ToString());
                    if (combo_optical.Text == "Family")
                        opt = Convert.ToDouble(optical_price.Text.ToString());
                }
                else
                    opt = 0;
                if (cbox_cafeteria.Checked == true)
                {
                   caf = Convert.ToDouble(tbox_cafeteria.Text);
                }
                owningForm.employeeDataGridView.ClearSelection();
                owningForm.employeeTableAdapter.Insert(Convert.ToInt32(label_employeeID.Text), tbox_lastName.Text, tbox_firstName.Text, tbox_street.Text, tbox_city.Text, tbox_state.Text,
                   tbox_city.Text, Convert.ToDouble(tbox_zipCode.Text), Convert.ToDouble(tbox_pay.Text), Convert.ToDouble(tbox_taxes.Text), tbox_accountNum.Text, tbox_routingNum.Text, check, status, CompanyCombo.Text, PlanCombo.Text,
                   insuranceID_tbox.Text, Convert.ToDouble(Price_Value.Text), DescriptionCombo.Text, caf, opt, den);
                MessageBox.Show("Sucessfully Added");
                owningForm.employeeDataGridView.Focus(); 
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

        /// <summary>
        /// get price from rate settings file
        /// </summary>
        /// <returns></returns>
        private void updateInsurancePrice(string provider, string plan, string description) {
            if (CompanyCombo.Text != "" && PlanCombo.Text != "" && DescriptionCombo.Text != "")
            {
                
                if (provider == "Blue Cross")
                {
                    if (plan == "HMO")
                    {
                        if (description == "Individual")
                            Price_Value.Text = (Properties.InsuranceRates.Default.BlueCross_HMO_I);
                        else if (description == "Family")
                            Price_Value.Text = (Properties.InsuranceRates.Default.BlueCross_HMO_F);
                    }
                    else if (plan == "POS")
                    {
                        if (description == "Individual")
                            Price_Value.Text = (Properties.InsuranceRates.Default.BlueCross_POS_I);
                        else if (description == "Family")
                            Price_Value.Text = (Properties.InsuranceRates.Default.BlueCross_POS_F);
                    }
                    else if (plan == "PPO")
                    {
                        if (description == "Individual")
                            Price_Value.Text = (Properties.InsuranceRates.Default.BlueCross_PPO_I);
                        else if (description == "Family")
                            Price_Value.Text = (Properties.InsuranceRates.Default.BlueCross_PPO_F);
                    }
                }
                else if (provider == "HIP")
                {
                    if (plan == "HMO")
                    {
                        if (description == "Individual")
                            Price_Value.Text = (Properties.InsuranceRates.Default.HIP_HMO_I);
                        else if (description == "Family")
                            Price_Value.Text = (Properties.InsuranceRates.Default.HIP_HMO_F);
                    }
                    else if (plan == "POS")
                    {
                        if (description == "Individual")
                            Price_Value.Text = (Properties.InsuranceRates.Default.HIP_POS_I);
                        else if (description == "Family")
                            Price_Value.Text = (Properties.InsuranceRates.Default.HIP_POS_F);
                    }
                    else if (plan == "PPO")
                    {
                        if (description == "Individual")
                            Price_Value.Text = (Properties.InsuranceRates.Default.HIP_PPO_I);
                        else if (description == "Family")
                            Price_Value.Text = (Properties.InsuranceRates.Default.HIP_PPO_F);
                    }
                }
                else if (provider == "Aetna")
                {
                    if (plan == "HMO")
                    {
                        if (description == "Individual")
                            Price_Value.Text = (Properties.InsuranceRates.Default.Aetna_HMO_I);
                        else if (description == "Family")
                            Price_Value.Text = (Properties.InsuranceRates.Default.Aetna_HMO_F);
                    }
                    else if (plan == "POS")
                    {
                        if (description == "Individual")
                            Price_Value.Text = (Properties.InsuranceRates.Default.Aetna_POS_I);
                        else if (description == "Family")
                            Price_Value.Text = (Properties.InsuranceRates.Default.Aetna_POS_F);
                    }
                    else if (plan == "PPO")
                    {
                        if (description == "Individual")
                            Price_Value.Text = (Properties.InsuranceRates.Default.Aetna_PPO_I);
                        else if (description == "Family")
                            Price_Value.Text = (Properties.InsuranceRates.Default.Aetna_PPO_F);
                    }
                }
            }
            else if (provider == "Medicare" && plan != "")
            {
                if (plan == "A")
                    Price_Value.Text = Properties.InsuranceRates.Default.Medicare_A;
                else if (plan == "B")
                    Price_Value.Text = (Properties.InsuranceRates.Default.Medicare_B);
                else if (plan == "A & B") {
                    Price_Value.Text = (Convert.ToDouble(Properties.InsuranceRates.Default.Medicare_A) + Convert.ToDouble(Properties.InsuranceRates.Default.Medicare_B)).ToString();
                }
            }
            else if (provider == "Medicaid") {
                Price_Value.Text =  "0";
            }
            else
            {
                Price_Value.Text = "-";
            }
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

            updateInsurancePrice(CompanyCombo.Text.ToString(), PlanCombo.Text.ToString(), DescriptionCombo.Text.ToString());

        }

        private void PlanCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = PlanCombo.Text.ToString();
            string[] descriptions = new string[] { "Individual", "Family"};

            if (PlanCombo.Text.ToString() == "HMO" || PlanCombo.Text.ToString() == "POS" || PlanCombo.Text.ToString() == "PPO")
            {
                DescriptionCombo.Text = "Select One...";
                DescriptionCombo.Items.Clear();
                DescriptionCombo.Items.AddRange(descriptions);

                insuranceDescription_label.Visible = true;
                DescriptionCombo.Visible = true;
            }

            updateInsurancePrice(CompanyCombo.Text.ToString(), PlanCombo.Text.ToString(), DescriptionCombo.Text.ToString());

        }

        private void DescriptionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = DescriptionCombo.Text.ToString();
            //get price from text file based on information

            updateInsurancePrice(CompanyCombo.Text.ToString(), PlanCombo.Text.ToString(), DescriptionCombo.Text.ToString());
        }

        private void rbutton_fulltime_CheckedChanged(object sender, EventArgs e)
        {
            if (rbutton_fulltime.Checked) {
                //enable insurance info
                groupBox6.Enabled = true;
                Deductions.Enabled = true;
                ineligible_label.Visible = false;
            }
            else if (radio_parttime.Checked) {
                //disable insurance info
                groupBox6.Enabled = false;
                ineligible_label.Visible = true;

            }
        }

        private void cbox_dental_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_dental.Checked) {
                combo_Dental.Visible = true;
            }
            else if (!cbox_dental.Checked) {
                combo_Dental.Visible = false;
                dental_price.Visible = false;
                dental_price.Text = "0";
            }
            adjustTotalDeductionCost();
        }

        private void cbox_optical_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_optical.Checked) {
                combo_optical.Visible = true;
            }
            else if (!cbox_optical.Checked) {
                combo_optical.Visible = false;
                optical_price.Visible = false;
                optical_price.Text = "0";
            }
            adjustTotalDeductionCost();
        }

        private void cbox_cafeteria_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_cafeteria.Checked) {
                tbox_cafeteria.Visible = true;
                label6.Visible = true;
            }
            if (!cbox_cafeteria.Checked) {
                tbox_cafeteria.Visible = false;
                label6.Visible = false;
                tbox_cafeteria.Text = "0";
            }
            adjustTotalDeductionCost();
        }

        private void combo_Dental_SelectedIndexChanged(object sender, EventArgs e)
        {
            dental_price.Visible = true;

            if (combo_Dental.Text == "Individual") {
                dental_price.Text = Properties.InsuranceRates.Default.Dental_I;
            }
            else if (combo_Dental.Text == "Family") {
                dental_price.Text = Properties.InsuranceRates.Default.Dental_F;
                }
            adjustTotalDeductionCost();
        }

        private void combo_optical_SelectedIndexChanged(object sender, EventArgs e)
        {
            optical_price.Visible = true;

            if (combo_optical.Text == "Individual")
                optical_price.Text = Properties.InsuranceRates.Default.Optical_I;
            else if (combo_optical.Text == "Family")
                optical_price.Text = Properties.InsuranceRates.Default.Optical_F;
            adjustTotalDeductionCost();
        }

        private void tbox_cafeteria_TextChanged(object sender, EventArgs e)
        {
            adjustTotalDeductionCost();
        }

        private void radio_parttime_CheckedChanged(object sender, EventArgs e)
        {
            Deductions.Enabled = false;
            groupBox6.Enabled = false;
            CompanyCombo.Text = " ";
            PlanCombo.Text = " ";
            insuranceID_tbox.Text = " ";
            DescriptionCombo.Text = " ";
            Price_Value.Text = "0";
        }

        private void tbox_hours_worked_TextChanged_1(object sender, EventArgs e)
        {
            if (tbox_hours_worked.Text == "")
            {
                return;
            }
            else if (Convert.ToDouble(tbox_hours_worked.Text.ToString()) >= 20)
            {
                groupBox6.Enabled = true;
                rbutton_fulltime.Checked = true;
                radio_parttime.Checked = false;
                Deductions.Enabled = true;
            }
            else
            {
                groupBox6.Enabled = false;
                rbutton_fulltime.Checked = false;
                radio_parttime.Checked = true;
                Deductions.Enabled = false;
            }
               
        }

        private void tbox_firstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)||e.KeyChar==32)
            {
                e.Handled = true;
            }
        }

        private void tbox_lastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void tbox_city_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbox_zipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void tbox_accountNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void tbox_routingNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void tbox_hours_worked_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void tbox_pay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void tbox_taxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void insuranceID_tbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void tbox_cafeteria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }
        

        
    }
}
