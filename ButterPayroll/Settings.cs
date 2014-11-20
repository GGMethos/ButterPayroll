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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        bool changeMade = false;

        private void Settings_Load(object sender, EventArgs e)
        {
            medicareA_tbox.Text = Properties.InsuranceRates.Default.Medicare_A;
            medicareB_tBox.Text = Properties.InsuranceRates.Default.Medicare_B;

            bc_hmo_i.Text = Properties.InsuranceRates.Default.BlueCross_HMO_I;
            bc_hmo_f.Text = Properties.InsuranceRates.Default.BlueCross_HMO_F;
            bc_pos_i.Text = Properties.InsuranceRates.Default.BlueCross_POS_I;
            bc_pos_f.Text = Properties.InsuranceRates.Default.BlueCross_POS_F;
            bc_ppo_i.Text = Properties.InsuranceRates.Default.BlueCross_PPO_I;
            bc_ppo_f.Text = Properties.InsuranceRates.Default.BlueCross_PPO_F;

            hip_hmo_i.Text = Properties.InsuranceRates.Default.HIP_HMO_I;
            hip_hmo_f.Text = Properties.InsuranceRates.Default.HIP_HMO_F;
            hip_pos_i.Text = Properties.InsuranceRates.Default.HIP_POS_I;
            hip_pos_f.Text = Properties.InsuranceRates.Default.HIP_POS_F;
            hip_ppo_i.Text = Properties.InsuranceRates.Default.HIP_PPO_I;
            hip_ppo_f.Text = Properties.InsuranceRates.Default.HIP_PPO_F;

            aet_hmo_i.Text = Properties.InsuranceRates.Default.Aetna_HMO_I;
            aet_hmo_f.Text = Properties.InsuranceRates.Default.Aetna_HMO_F;
            aet_pos_i.Text = Properties.InsuranceRates.Default.Aetna_POS_I;
            aet_pos_f.Text = Properties.InsuranceRates.Default.Aetna_POS_F;
            aet_ppo_i.Text = Properties.InsuranceRates.Default.Aetna_PPO_I;
            aet_ppo_f.Text = Properties.InsuranceRates.Default.Aetna_PPO_F;

            dental_i.Text = Properties.InsuranceRates.Default.Dental_I;
            dental_f.Text = Properties.InsuranceRates.Default.Dental_F;

            optical_i.Text = Properties.InsuranceRates.Default.Optical_I;
            optical_f.Text = Properties.InsuranceRates.Default.Optical_F;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to save these changes?", "Overwrite Data", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes) {
                Properties.InsuranceRates.Default.Medicare_A = medicareA_tbox.Text;
                Properties.InsuranceRates.Default.Medicare_B = medicareB_tBox.Text;

                Properties.InsuranceRates.Default.BlueCross_HMO_I = bc_hmo_i.Text;
                Properties.InsuranceRates.Default.BlueCross_HMO_F = bc_hmo_f.Text;
                Properties.InsuranceRates.Default.BlueCross_POS_I = bc_pos_i.Text;
                Properties.InsuranceRates.Default.BlueCross_POS_F = bc_pos_f.Text;
                Properties.InsuranceRates.Default.BlueCross_PPO_I = bc_ppo_i.Text;
                Properties.InsuranceRates.Default.BlueCross_PPO_F = bc_ppo_f.Text;

                Properties.InsuranceRates.Default.HIP_HMO_I = hip_hmo_i.Text;
                Properties.InsuranceRates.Default.HIP_HMO_F = hip_hmo_f.Text;
                Properties.InsuranceRates.Default.HIP_POS_I = hip_pos_i.Text;
                Properties.InsuranceRates.Default.HIP_POS_F = hip_pos_f.Text;
                Properties.InsuranceRates.Default.HIP_PPO_I = hip_ppo_i.Text;
                Properties.InsuranceRates.Default.HIP_PPO_F = hip_ppo_f.Text;

                Properties.InsuranceRates.Default.Aetna_HMO_I = aet_hmo_i.Text;
                Properties.InsuranceRates.Default.Aetna_HMO_F = aet_hmo_f.Text;
                Properties.InsuranceRates.Default.Aetna_POS_I = aet_pos_i.Text;
                Properties.InsuranceRates.Default.Aetna_POS_F = aet_pos_f.Text;
                Properties.InsuranceRates.Default.Aetna_PPO_I = aet_ppo_i.Text;
                Properties.InsuranceRates.Default.Aetna_PPO_F = aet_ppo_f.Text;

                Properties.InsuranceRates.Default.Dental_I = dental_i.Text;
                Properties.InsuranceRates.Default.Dental_F = dental_f.Text;

                Properties.InsuranceRates.Default.Optical_I = optical_i.Text;
                Properties.InsuranceRates.Default.Optical_F = optical_f.Text;

                Properties.InsuranceRates.Default.Save();

                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void medicareA_tbox_TextChanged(object sender, EventArgs e)
        {

            changeMade = true;
        }

    }
}
