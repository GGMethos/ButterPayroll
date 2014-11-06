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
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            //error checking for all boxes
            
        }

    }
}
