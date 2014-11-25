namespace ButterPayroll
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.button_add = new System.Windows.Forms.Button();
            this.button_modify = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.button_generate = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.employeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routingNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directdeposit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cafeteriaBenifits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opticalDeduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dentalDeduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodDataBase = new ButterPayroll.GoodDataBase();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new ButterPayroll.GoodDataBaseTableAdapters.TableAdapterManager();
            this.employeeTableAdapter = new ButterPayroll.GoodDataBaseTableAdapters.Employee1TableAdapter();
            this.employeeTableAdapter1 = new ButterPayroll.GoodDataBaseTableAdapters.EmployeeTableAdapter();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routingNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directDepositDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.additionalInformation = new System.Windows.Forms.RichTextBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insuranceDeductionRatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodDataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(12, 57);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(240, 37);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_modify
            // 
            this.button_modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modify.Location = new System.Drawing.Point(13, 100);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(239, 37);
            this.button_modify.TabIndex = 3;
            this.button_modify.Text = "Modify";
            this.button_modify.UseVisualStyleBackColor = true;
            this.button_modify.Click += new System.EventHandler(this.button_modify_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(12, 143);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(240, 37);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // button_generate
            // 
            this.button_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_generate.Location = new System.Drawing.Point(13, 186);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(239, 37);
            this.button_generate.TabIndex = 5;
            this.button_generate.Text = "Generate";
            this.button_generate.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(705, 408);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(103, 37);
            this.Update.TabIndex = 6;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AllowUserToAddRows = false;
            this.employeeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeDataGridView.AutoGenerateColumns = false;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeId,
            this.lname,
            this.fname,
            this.street,
            this.city,
            this.state,
            this.zip,
            this.hours,
            this.rate,
            this.taxes,
            this.accountNum,
            this.routingNum,
            this.directdeposit,
            this.status,
            this.companyName,
            this.planId,
            this.planName,
            this.description,
            this.cafeteriaBenifits,
            this.opticalDeduction,
            this.dentalDeduction,
            this.cost});
            this.employeeDataGridView.DataSource = this.employee1BindingSource;
            this.employeeDataGridView.Location = new System.Drawing.Point(258, 57);
            this.employeeDataGridView.MultiSelect = false;
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.ReadOnly = true;
            this.employeeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeDataGridView.Size = new System.Drawing.Size(659, 345);
            this.employeeDataGridView.TabIndex = 6;
            this.employeeDataGridView.SelectionChanged += new System.EventHandler(this.employeeDataGridView_SelectionChanged);
            // 
            // employeeId
            // 
            this.employeeId.DataPropertyName = "EmployeeId";
            this.employeeId.HeaderText = "EmployeeId";
            this.employeeId.Name = "employeeId";
            this.employeeId.ReadOnly = true;
            // 
            // lname
            // 
            this.lname.DataPropertyName = "Last Name";
            this.lname.HeaderText = "Last Name";
            this.lname.Name = "lname";
            this.lname.ReadOnly = true;
            // 
            // fname
            // 
            this.fname.DataPropertyName = "First Name";
            this.fname.HeaderText = "First Name";
            this.fname.Name = "fname";
            this.fname.ReadOnly = true;
            // 
            // street
            // 
            this.street.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.street.DataPropertyName = "Street";
            this.street.HeaderText = "Street";
            this.street.Name = "street";
            this.street.ReadOnly = true;
            this.street.Width = 68;
            // 
            // city
            // 
            this.city.DataPropertyName = "City";
            this.city.HeaderText = "City";
            this.city.Name = "city";
            this.city.ReadOnly = true;
            // 
            // state
            // 
            this.state.DataPropertyName = "State";
            this.state.HeaderText = "State";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            // 
            // zip
            // 
            this.zip.DataPropertyName = "Zip";
            this.zip.HeaderText = "Zip";
            this.zip.Name = "zip";
            this.zip.ReadOnly = true;
            // 
            // hours
            // 
            this.hours.DataPropertyName = "Hours";
            this.hours.HeaderText = "Hours";
            this.hours.Name = "hours";
            this.hours.ReadOnly = true;
            // 
            // rate
            // 
            this.rate.DataPropertyName = "Rate";
            this.rate.HeaderText = "Rate";
            this.rate.Name = "rate";
            this.rate.ReadOnly = true;
            // 
            // taxes
            // 
            this.taxes.DataPropertyName = "Taxes";
            this.taxes.HeaderText = "Taxes";
            this.taxes.Name = "taxes";
            this.taxes.ReadOnly = true;
            // 
            // accountNum
            // 
            this.accountNum.DataPropertyName = "Account Number";
            this.accountNum.HeaderText = "Account Number";
            this.accountNum.Name = "accountNum";
            this.accountNum.ReadOnly = true;
            // 
            // routingNum
            // 
            this.routingNum.DataPropertyName = "Routing Number";
            this.routingNum.HeaderText = "Routing Number";
            this.routingNum.Name = "routingNum";
            this.routingNum.ReadOnly = true;
            // 
            // directdeposit
            // 
            this.directdeposit.DataPropertyName = "Direct Deposit";
            this.directdeposit.HeaderText = "Direct Deposit";
            this.directdeposit.Name = "directdeposit";
            this.directdeposit.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "Status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // companyName
            // 
            this.companyName.DataPropertyName = "Company Name";
            this.companyName.HeaderText = "Company Name";
            this.companyName.Name = "companyName";
            this.companyName.ReadOnly = true;
            // 
            // planId
            // 
            this.planId.DataPropertyName = "Plan Id";
            this.planId.HeaderText = "Plan Id";
            this.planId.Name = "planId";
            this.planId.ReadOnly = true;
            // 
            // planName
            // 
            this.planName.DataPropertyName = "Plan Name";
            this.planName.HeaderText = "Plan Name";
            this.planName.Name = "planName";
            this.planName.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "Description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // cafeteriaBenifits
            // 
            this.cafeteriaBenifits.DataPropertyName = "Cafeteria Benifits";
            this.cafeteriaBenifits.HeaderText = "Cafeteria Benifits";
            this.cafeteriaBenifits.Name = "cafeteriaBenifits";
            this.cafeteriaBenifits.ReadOnly = true;
            // 
            // opticalDeduction
            // 
            this.opticalDeduction.DataPropertyName = "Optical Deduction";
            this.opticalDeduction.HeaderText = "Optical Deduction";
            this.opticalDeduction.Name = "opticalDeduction";
            this.opticalDeduction.ReadOnly = true;
            // 
            // dentalDeduction
            // 
            this.dentalDeduction.DataPropertyName = "Dental Deduction";
            this.dentalDeduction.HeaderText = "Dental Deduction";
            this.dentalDeduction.Name = "dentalDeduction";
            this.dentalDeduction.ReadOnly = true;
            // 
            // cost
            // 
            this.cost.DataPropertyName = "Cost";
            this.cost.HeaderText = "Cost";
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            // 
            // employee1BindingSource
            // 
            this.employee1BindingSource.DataMember = "Employee1";
            this.employee1BindingSource.DataSource = this.goodDataBase;
            // 
            // goodDataBase
            // 
            this.goodDataBase.DataSetName = "GoodDataBase";
            this.goodDataBase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(736, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(530, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search By:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Employee Id",
            "First Name",
            "Last Name",
            "State"});
            this.comboBox1.Location = new System.Drawing.Point(609, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.goodDataBase;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Employee1TableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ButterPayroll.GoodDataBaseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // zipDataGridViewTextBoxColumn
            // 
            this.zipDataGridViewTextBoxColumn.DataPropertyName = "Zip";
            this.zipDataGridViewTextBoxColumn.HeaderText = "Zip";
            this.zipDataGridViewTextBoxColumn.Name = "zipDataGridViewTextBoxColumn";
            // 
            // hoursDataGridViewTextBoxColumn
            // 
            this.hoursDataGridViewTextBoxColumn.DataPropertyName = "Hours";
            this.hoursDataGridViewTextBoxColumn.HeaderText = "Hours";
            this.hoursDataGridViewTextBoxColumn.Name = "hoursDataGridViewTextBoxColumn";
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            // 
            // taxesDataGridViewTextBoxColumn
            // 
            this.taxesDataGridViewTextBoxColumn.DataPropertyName = "Taxes";
            this.taxesDataGridViewTextBoxColumn.HeaderText = "Taxes";
            this.taxesDataGridViewTextBoxColumn.Name = "taxesDataGridViewTextBoxColumn";
            // 
            // accountNumberDataGridViewTextBoxColumn
            // 
            this.accountNumberDataGridViewTextBoxColumn.DataPropertyName = "Account Number";
            this.accountNumberDataGridViewTextBoxColumn.HeaderText = "Account Number";
            this.accountNumberDataGridViewTextBoxColumn.Name = "accountNumberDataGridViewTextBoxColumn";
            // 
            // routingNumberDataGridViewTextBoxColumn
            // 
            this.routingNumberDataGridViewTextBoxColumn.DataPropertyName = "Routing Number";
            this.routingNumberDataGridViewTextBoxColumn.HeaderText = "Routing Number";
            this.routingNumberDataGridViewTextBoxColumn.Name = "routingNumberDataGridViewTextBoxColumn";
            // 
            // directDepositDataGridViewCheckBoxColumn
            // 
            this.directDepositDataGridViewCheckBoxColumn.DataPropertyName = "Direct Deposit";
            this.directDepositDataGridViewCheckBoxColumn.HeaderText = "Direct Deposit";
            this.directDepositDataGridViewCheckBoxColumn.Name = "directDepositDataGridViewCheckBoxColumn";
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "Company Name";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "Company Name";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // additionalInformation
            // 
            this.additionalInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.additionalInformation.Location = new System.Drawing.Point(13, 229);
            this.additionalInformation.Name = "additionalInformation";
            this.additionalInformation.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.additionalInformation.Size = new System.Drawing.Size(239, 173);
            this.additionalInformation.TabIndex = 11;
            this.additionalInformation.Text = "Select an employee to view additional information...";
            this.additionalInformation.TextChanged += new System.EventHandler(this.additionalInformation_TextChanged);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insuranceDeductionRatesToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // insuranceDeductionRatesToolStripMenuItem
            // 
            this.insuranceDeductionRatesToolStripMenuItem.Name = "insuranceDeductionRatesToolStripMenuItem";
            this.insuranceDeductionRatesToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.insuranceDeductionRatesToolStripMenuItem.Text = "Insurance/Deduction Rates";
            this.insuranceDeductionRatesToolStripMenuItem.Click += new System.EventHandler(this.insuranceDeductionRatesToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 457);
            this.Controls.Add(this.additionalInformation);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.employeeDataGridView);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.button_modify);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Butter Banking Payroll Systems | Group 3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing_1);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodDataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_modify;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.Button Update;
        private GoodDataBase goodDataBase;
        private GoodDataBaseTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.BindingSource employee1BindingSource;
        public System.Windows.Forms.DataGridView employeeDataGridView;
        public GoodDataBaseTableAdapters.Employee1TableAdapter employeeTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private GoodDataBaseTableAdapters.EmployeeTableAdapter employeeTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routingNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn directDepositDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RichTextBox additionalInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn street;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn zip;
        private System.Windows.Forms.DataGridViewTextBoxColumn hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxes;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn routingNum;
        private System.Windows.Forms.DataGridViewCheckBoxColumn directdeposit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn planId;
        private System.Windows.Forms.DataGridViewTextBoxColumn planName;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn cafeteriaBenifits;
        private System.Windows.Forms.DataGridViewTextBoxColumn opticalDeduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn dentalDeduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insuranceDeductionRatesToolStripMenuItem;

    }
}

