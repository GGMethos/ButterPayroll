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
    public partial class CompanyInformation : Form
    {
        public CompanyInformation()
        {
            InitializeComponent();
        }

        private void CompanyInformation_Load(object sender, EventArgs e)
        {
            tbox_Name.Text = Properties.CompanyInfo.Default.Name;
            tbox_street.Text = Properties.CompanyInfo.Default.Street;
            tbox_city.Text=Properties.CompanyInfo.Default.City;
            tbox_state.Text =Properties.CompanyInfo.Default.State;
            tbox_zipCode.Text = Properties.CompanyInfo.Default.ZipCode;
        }

        private void Done_Click(object sender, EventArgs e)
        {
            Properties.CompanyInfo.Default.Name = tbox_Name.Text;
            Properties.CompanyInfo.Default.Street = tbox_street.Text;
            Properties.CompanyInfo.Default.City = tbox_city.Text;
            Properties.CompanyInfo.Default.State = tbox_state.Text;
            Properties.CompanyInfo.Default.ZipCode = tbox_zipCode.Text;

            this.Close();
        }
    }
}
