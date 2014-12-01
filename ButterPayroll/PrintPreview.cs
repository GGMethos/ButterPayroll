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
    public partial class PrintPreview : Form
    {
        public PrintPreview()
        {
            InitializeComponent();
        }

        private void PrintPreview_Load(object sender, EventArgs e)
        {

        }

        public void setPrintStrings(string directDepost, string checks) {
            directDeposit_rtb.Text = directDepost;
            checks_rtb.Text = checks;
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now Printing");
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
