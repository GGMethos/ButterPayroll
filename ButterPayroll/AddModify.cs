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
    public partial class AddModify : Form
    {
        public AddModify()
        {
            InitializeComponent();
        }

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
                radio_parttime.Checked = false;
            }
            else
            {
                rbutton_fulltime.Checked = false;
                radio_parttime.Checked = true;
            }
            if (Employee.directDeposit == true)
            {
                radio_check.Checked = false;
                radio_directDeposit.Checked = true;
            }
            else
            {
                radio_check.Checked = true;
                radio_directDeposit.Checked = false;
            }

        }
        private void button_save_Click(object sender, EventArgs e)
        {
            if (this.Mode == "Modify")
            {
                MessageBox.Show("Sucessfully Modified");
            }
            if (this.Mode == "Add")
            {
                MessageBox.Show("Sucessfully Added");
            }
                this.Close();
            
        }

    }
}
