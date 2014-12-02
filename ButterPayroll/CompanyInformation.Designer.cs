namespace ButterPayroll
{
    partial class CompanyInformation
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
            this.tbox_state = new System.Windows.Forms.ComboBox();
            this.label_state = new System.Windows.Forms.Label();
            this.label_zipCode = new System.Windows.Forms.Label();
            this.tbox_zipCode = new System.Windows.Forms.TextBox();
            this.label_city = new System.Windows.Forms.Label();
            this.tbox_city = new System.Windows.Forms.TextBox();
            this.label_street = new System.Windows.Forms.Label();
            this.tbox_street = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.tbox_Name = new System.Windows.Forms.TextBox();
            this.Done = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbox_state
            // 
            this.tbox_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbox_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_state.FormattingEnabled = true;
            this.tbox_state.Items.AddRange(new object[] {
            "NJ",
            "NY",
            "PA"});
            this.tbox_state.Location = new System.Drawing.Point(151, 157);
            this.tbox_state.Name = "tbox_state";
            this.tbox_state.Size = new System.Drawing.Size(56, 24);
            this.tbox_state.TabIndex = 15;
            // 
            // label_state
            // 
            this.label_state.AutoSize = true;
            this.label_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_state.Location = new System.Drawing.Point(151, 138);
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(39, 16);
            this.label_state.TabIndex = 14;
            this.label_state.Text = "State";
            // 
            // label_zipCode
            // 
            this.label_zipCode.AutoSize = true;
            this.label_zipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_zipCode.Location = new System.Drawing.Point(210, 138);
            this.label_zipCode.Name = "label_zipCode";
            this.label_zipCode.Size = new System.Drawing.Size(63, 16);
            this.label_zipCode.TabIndex = 13;
            this.label_zipCode.Text = "Zip Code";
            // 
            // tbox_zipCode
            // 
            this.tbox_zipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_zipCode.Location = new System.Drawing.Point(213, 157);
            this.tbox_zipCode.Name = "tbox_zipCode";
            this.tbox_zipCode.Size = new System.Drawing.Size(80, 22);
            this.tbox_zipCode.TabIndex = 12;
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_city.Location = new System.Drawing.Point(12, 138);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(30, 16);
            this.label_city.TabIndex = 11;
            this.label_city.Text = "City";
            // 
            // tbox_city
            // 
            this.tbox_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_city.Location = new System.Drawing.Point(12, 157);
            this.tbox_city.Name = "tbox_city";
            this.tbox_city.Size = new System.Drawing.Size(133, 22);
            this.tbox_city.TabIndex = 10;
            // 
            // label_street
            // 
            this.label_street.AutoSize = true;
            this.label_street.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_street.Location = new System.Drawing.Point(12, 77);
            this.label_street.Name = "label_street";
            this.label_street.Size = new System.Drawing.Size(43, 16);
            this.label_street.TabIndex = 9;
            this.label_street.Text = "Street";
            // 
            // tbox_street
            // 
            this.tbox_street.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_street.Location = new System.Drawing.Point(12, 96);
            this.tbox_street.Name = "tbox_street";
            this.tbox_street.Size = new System.Drawing.Size(281, 22);
            this.tbox_street.TabIndex = 8;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(12, 19);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(33, 16);
            this.label_name.TabIndex = 17;
            this.label_name.Text = "First";
            // 
            // tbox_Name
            // 
            this.tbox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Name.Location = new System.Drawing.Point(12, 38);
            this.tbox_Name.Name = "tbox_Name";
            this.tbox_Name.Size = new System.Drawing.Size(281, 22);
            this.tbox_Name.TabIndex = 16;
            // 
            // Done
            // 
            this.Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done.Location = new System.Drawing.Point(81, 199);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(68, 32);
            this.Done.TabIndex = 19;
            this.Done.Text = "Save";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(154, 199);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(68, 32);
            this.button_cancel.TabIndex = 18;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // CompanyInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 253);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.tbox_Name);
            this.Controls.Add(this.tbox_state);
            this.Controls.Add(this.label_state);
            this.Controls.Add(this.label_zipCode);
            this.Controls.Add(this.tbox_zipCode);
            this.Controls.Add(this.label_city);
            this.Controls.Add(this.tbox_city);
            this.Controls.Add(this.label_street);
            this.Controls.Add(this.tbox_street);
            this.Name = "CompanyInformation";
            this.Text = "CompanyInformation";
            this.Load += new System.EventHandler(this.CompanyInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tbox_state;
        private System.Windows.Forms.Label label_state;
        private System.Windows.Forms.Label label_zipCode;
        private System.Windows.Forms.TextBox tbox_zipCode;
        private System.Windows.Forms.Label label_city;
        private System.Windows.Forms.TextBox tbox_city;
        private System.Windows.Forms.Label label_street;
        private System.Windows.Forms.TextBox tbox_street;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox tbox_Name;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Button button_cancel;
    }
}