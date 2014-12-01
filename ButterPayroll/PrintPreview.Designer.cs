namespace ButterPayroll
{
    partial class PrintPreview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.directDeposit_rtb = new System.Windows.Forms.RichTextBox();
            this.checks_rtb = new System.Windows.Forms.RichTextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Print = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // directDeposit_rtb
            // 
            this.directDeposit_rtb.Location = new System.Drawing.Point(12, 55);
            this.directDeposit_rtb.Name = "directDeposit_rtb";
            this.directDeposit_rtb.Size = new System.Drawing.Size(583, 273);
            this.directDeposit_rtb.TabIndex = 0;
            this.directDeposit_rtb.Text = "";
            // 
            // checks_rtb
            // 
            this.checks_rtb.Location = new System.Drawing.Point(12, 334);
            this.checks_rtb.Name = "checks_rtb";
            this.checks_rtb.Size = new System.Drawing.Size(583, 273);
            this.checks_rtb.TabIndex = 1;
            this.checks_rtb.Text = "";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.Location = new System.Drawing.Point(492, 12);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(103, 37);
            this.button_Cancel.TabIndex = 7;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Print
            // 
            this.button_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Print.Location = new System.Drawing.Point(383, 12);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(103, 37);
            this.button_Print.TabIndex = 8;
            this.button_Print.Text = "Print";
            this.button_Print.UseVisualStyleBackColor = true;
            this.button_Print.Click += new System.EventHandler(this.button_Print_Click);
            // 
            // PrintPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 599);
            this.Controls.Add(this.button_Print);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.checks_rtb);
            this.Controls.Add(this.directDeposit_rtb);
            this.Name = "PrintPreview";
            this.Text = "Print Preview";
            this.Load += new System.EventHandler(this.PrintPreview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.RichTextBox directDeposit_rtb;
        private System.Windows.Forms.RichTextBox checks_rtb;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Print;
    }
}