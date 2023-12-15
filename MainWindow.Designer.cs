namespace B2B_Application_Wizard
{
    partial class MainWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbxCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblFax = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.tbxAddress1 = new System.Windows.Forms.TextBox();
            this.lblPrimaryContact = new System.Windows.Forms.Label();
            this.tbxPurchContact = new System.Windows.Forms.TextBox();
            this.cmbBusinessFocus = new System.Windows.Forms.ComboBox();
            this.lblSegmentCode = new System.Windows.Forms.Label();
            this.cbxTaxExempt = new System.Windows.Forms.CheckBox();
            this.tbxNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.tbxAccountNum = new System.Windows.Forms.TextBox();
            this.lblAccoutNum = new System.Windows.Forms.Label();
            this.cmbStore = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.tbxFaxNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.tbxAddress2 = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.tbxAddressCity = new System.Windows.Forms.TextBox();
            this.tbxAddressState = new System.Windows.Forms.TextBox();
            this.tbxAddressZip = new System.Windows.Forms.TextBox();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.accountNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressOneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressTwoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primaryContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segmentCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxExemptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.accountNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblContactName = new System.Windows.Forms.Label();
            this.lblContactEmail = new System.Windows.Forms.Label();
            this.tbxContactName = new System.Windows.Forms.TextBox();
            this.tbxContactEmail = new System.Windows.Forms.TextBox();
            this.lblDGVContacts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxContactPhone = new System.Windows.Forms.MaskedTextBox();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.grpContacts = new System.Windows.Forms.GroupBox();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetEmailPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProgramDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lnkAccounts = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            this.grpContacts.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSubmit.Location = new System.Drawing.Point(0, 874);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(1820, 42);
            this.btnSubmit.TabIndex = 21;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbxCompanyName
            // 
            this.tbxCompanyName.Location = new System.Drawing.Point(15, 147);
            this.tbxCompanyName.Margin = new System.Windows.Forms.Padding(6);
            this.tbxCompanyName.MaxLength = 30;
            this.tbxCompanyName.Name = "tbxCompanyName";
            this.tbxCompanyName.Size = new System.Drawing.Size(448, 29);
            this.tbxCompanyName.TabIndex = 3;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(10, 118);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(154, 25);
            this.lblCompanyName.TabIndex = 2;
            this.lblCompanyName.Text = "Company Name";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(470, 119);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(85, 25);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone #";
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(631, 119);
            this.lblFax.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(61, 25);
            this.lblFax.TabIndex = 6;
            this.lblFax.Text = "Fax #";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(10, 199);
            this.lblAddress1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(143, 25);
            this.lblAddress1.TabIndex = 7;
            this.lblAddress1.Text = "Address Line 1";
            // 
            // tbxAddress1
            // 
            this.tbxAddress1.Location = new System.Drawing.Point(15, 228);
            this.tbxAddress1.Margin = new System.Windows.Forms.Padding(6);
            this.tbxAddress1.MaxLength = 30;
            this.tbxAddress1.Name = "tbxAddress1";
            this.tbxAddress1.Size = new System.Drawing.Size(768, 29);
            this.tbxAddress1.TabIndex = 6;
            // 
            // lblPrimaryContact
            // 
            this.lblPrimaryContact.AutoSize = true;
            this.lblPrimaryContact.Location = new System.Drawing.Point(395, 345);
            this.lblPrimaryContact.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrimaryContact.Name = "lblPrimaryContact";
            this.lblPrimaryContact.Size = new System.Drawing.Size(151, 25);
            this.lblPrimaryContact.TabIndex = 12;
            this.lblPrimaryContact.Text = "Primary Contact";
            // 
            // tbxPurchContact
            // 
            this.tbxPurchContact.Location = new System.Drawing.Point(400, 374);
            this.tbxPurchContact.Margin = new System.Windows.Forms.Padding(6);
            this.tbxPurchContact.MaxLength = 20;
            this.tbxPurchContact.Name = "tbxPurchContact";
            this.tbxPurchContact.Size = new System.Drawing.Size(384, 29);
            this.tbxPurchContact.TabIndex = 11;
            // 
            // cmbBusinessFocus
            // 
            this.cmbBusinessFocus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusinessFocus.FormattingEnabled = true;
            this.cmbBusinessFocus.Location = new System.Drawing.Point(15, 446);
            this.cmbBusinessFocus.Margin = new System.Windows.Forms.Padding(6);
            this.cmbBusinessFocus.Name = "cmbBusinessFocus";
            this.cmbBusinessFocus.Size = new System.Drawing.Size(292, 32);
            this.cmbBusinessFocus.TabIndex = 13;
            // 
            // lblSegmentCode
            // 
            this.lblSegmentCode.AutoSize = true;
            this.lblSegmentCode.Location = new System.Drawing.Point(10, 420);
            this.lblSegmentCode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSegmentCode.Name = "lblSegmentCode";
            this.lblSegmentCode.Size = new System.Drawing.Size(268, 25);
            this.lblSegmentCode.TabIndex = 17;
            this.lblSegmentCode.Text = "Business Focus (Select One)";
            // 
            // cbxTaxExempt
            // 
            this.cbxTaxExempt.AutoSize = true;
            this.cbxTaxExempt.Location = new System.Drawing.Point(318, 449);
            this.cbxTaxExempt.Margin = new System.Windows.Forms.Padding(6);
            this.cbxTaxExempt.Name = "cbxTaxExempt";
            this.cbxTaxExempt.Size = new System.Drawing.Size(154, 29);
            this.cbxTaxExempt.TabIndex = 14;
            this.cbxTaxExempt.Text = "Tax Exempt?";
            this.cbxTaxExempt.UseVisualStyleBackColor = true;
            // 
            // tbxNotes
            // 
            this.tbxNotes.Location = new System.Drawing.Point(15, 523);
            this.tbxNotes.Margin = new System.Windows.Forms.Padding(6);
            this.tbxNotes.MaxLength = 5000;
            this.tbxNotes.Multiline = true;
            this.tbxNotes.Name = "tbxNotes";
            this.tbxNotes.Size = new System.Drawing.Size(768, 82);
            this.tbxNotes.TabIndex = 15;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(10, 492);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(63, 25);
            this.lblNotes.TabIndex = 21;
            this.lblNotes.Text = "Notes";
            // 
            // tbxAccountNum
            // 
            this.tbxAccountNum.Location = new System.Drawing.Point(140, 57);
            this.tbxAccountNum.Margin = new System.Windows.Forms.Padding(6);
            this.tbxAccountNum.MaxLength = 5;
            this.tbxAccountNum.Name = "tbxAccountNum";
            this.tbxAccountNum.Size = new System.Drawing.Size(180, 29);
            this.tbxAccountNum.TabIndex = 1;
            // 
            // lblAccoutNum
            // 
            this.lblAccoutNum.AutoSize = true;
            this.lblAccoutNum.Location = new System.Drawing.Point(19, 62);
            this.lblAccoutNum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAccoutNum.Name = "lblAccoutNum";
            this.lblAccoutNum.Size = new System.Drawing.Size(106, 25);
            this.lblAccoutNum.TabIndex = 23;
            this.lblAccoutNum.Text = "Account #:";
            // 
            // cmbStore
            // 
            this.cmbStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStore.FormattingEnabled = true;
            this.cmbStore.Location = new System.Drawing.Point(561, 55);
            this.cmbStore.Margin = new System.Windows.Forms.Padding(6);
            this.cmbStore.Name = "cmbStore";
            this.cmbStore.Size = new System.Drawing.Size(218, 32);
            this.cmbStore.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(501, 60);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "Store";
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Location = new System.Drawing.Point(475, 147);
            this.tbxPhoneNumber.Margin = new System.Windows.Forms.Padding(6);
            this.tbxPhoneNumber.Mask = "(999) 000-0000";
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(147, 29);
            this.tbxPhoneNumber.TabIndex = 4;
            // 
            // tbxFaxNumber
            // 
            this.tbxFaxNumber.Location = new System.Drawing.Point(637, 149);
            this.tbxFaxNumber.Margin = new System.Windows.Forms.Padding(6);
            this.tbxFaxNumber.Mask = "(999) 000-0000";
            this.tbxFaxNumber.Name = "tbxFaxNumber";
            this.tbxFaxNumber.Size = new System.Drawing.Size(147, 29);
            this.tbxFaxNumber.TabIndex = 5;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(10, 271);
            this.lblAddress2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(143, 25);
            this.lblAddress2.TabIndex = 33;
            this.lblAddress2.Text = "Address Line 2";
            // 
            // tbxAddress2
            // 
            this.tbxAddress2.Location = new System.Drawing.Point(15, 300);
            this.tbxAddress2.Margin = new System.Windows.Forms.Padding(6);
            this.tbxAddress2.MaxLength = 30;
            this.tbxAddress2.Name = "tbxAddress2";
            this.tbxAddress2.Size = new System.Drawing.Size(768, 29);
            this.tbxAddress2.TabIndex = 7;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(10, 343);
            this.lblCity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(46, 25);
            this.lblCity.TabIndex = 35;
            this.lblCity.Text = "City";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(208, 343);
            this.lblState.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(58, 25);
            this.lblState.TabIndex = 36;
            this.lblState.Text = "State";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(272, 343);
            this.lblZip.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(39, 25);
            this.lblZip.TabIndex = 37;
            this.lblZip.Text = "Zip";
            // 
            // tbxAddressCity
            // 
            this.tbxAddressCity.Location = new System.Drawing.Point(15, 374);
            this.tbxAddressCity.Margin = new System.Windows.Forms.Padding(6);
            this.tbxAddressCity.MaxLength = 15;
            this.tbxAddressCity.Name = "tbxAddressCity";
            this.tbxAddressCity.Size = new System.Drawing.Size(184, 29);
            this.tbxAddressCity.TabIndex = 8;
            // 
            // tbxAddressState
            // 
            this.tbxAddressState.Location = new System.Drawing.Point(213, 374);
            this.tbxAddressState.Margin = new System.Windows.Forms.Padding(6);
            this.tbxAddressState.MaxLength = 2;
            this.tbxAddressState.Name = "tbxAddressState";
            this.tbxAddressState.Size = new System.Drawing.Size(50, 29);
            this.tbxAddressState.TabIndex = 9;
            // 
            // tbxAddressZip
            // 
            this.tbxAddressZip.Location = new System.Drawing.Point(277, 374);
            this.tbxAddressZip.Margin = new System.Windows.Forms.Padding(6);
            this.tbxAddressZip.MaxLength = 10;
            this.tbxAddressZip.Name = "tbxAddressZip";
            this.tbxAddressZip.Size = new System.Drawing.Size(108, 29);
            this.tbxAddressZip.TabIndex = 10;
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAccounts.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountNumberDataGridViewTextBoxColumn,
            this.storeNameDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.faxNumberDataGridViewTextBoxColumn,
            this.addressOneDataGridViewTextBoxColumn,
            this.addressTwoDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.zipCodeDataGridViewTextBoxColumn,
            this.primaryContactDataGridViewTextBoxColumn,
            this.segmentCodeDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.taxExemptDataGridViewTextBoxColumn});
            this.dgvAccounts.DataSource = this.accountBindingSource;
            this.dgvAccounts.Location = new System.Drawing.Point(802, 80);
            this.dgvAccounts.Margin = new System.Windows.Forms.Padding(6);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.RowHeadersVisible = false;
            this.dgvAccounts.RowHeadersWidth = 72;
            this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounts.Size = new System.Drawing.Size(1003, 417);
            this.dgvAccounts.TabIndex = 38;
            this.dgvAccounts.TabStop = false;
            this.dgvAccounts.SelectionChanged += new System.EventHandler(this.dgvAccounts_SelectionChanged);
            // 
            // accountNumberDataGridViewTextBoxColumn
            // 
            this.accountNumberDataGridViewTextBoxColumn.DataPropertyName = "AccountNumber";
            this.accountNumberDataGridViewTextBoxColumn.HeaderText = "Account Number";
            this.accountNumberDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.accountNumberDataGridViewTextBoxColumn.Name = "accountNumberDataGridViewTextBoxColumn";
            this.accountNumberDataGridViewTextBoxColumn.Width = 175;
            // 
            // storeNameDataGridViewTextBoxColumn
            // 
            this.storeNameDataGridViewTextBoxColumn.DataPropertyName = "StoreName";
            this.storeNameDataGridViewTextBoxColumn.HeaderText = "StoreName";
            this.storeNameDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.storeNameDataGridViewTextBoxColumn.Name = "storeNameDataGridViewTextBoxColumn";
            this.storeNameDataGridViewTextBoxColumn.Visible = false;
            this.storeNameDataGridViewTextBoxColumn.Width = 175;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "Account Name";
            this.companyNameDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.Width = 175;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 175;
            // 
            // faxNumberDataGridViewTextBoxColumn
            // 
            this.faxNumberDataGridViewTextBoxColumn.DataPropertyName = "FaxNumber";
            this.faxNumberDataGridViewTextBoxColumn.HeaderText = "Fax Number";
            this.faxNumberDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.faxNumberDataGridViewTextBoxColumn.Name = "faxNumberDataGridViewTextBoxColumn";
            this.faxNumberDataGridViewTextBoxColumn.Width = 175;
            // 
            // addressOneDataGridViewTextBoxColumn
            // 
            this.addressOneDataGridViewTextBoxColumn.DataPropertyName = "AddressOne";
            this.addressOneDataGridViewTextBoxColumn.HeaderText = "Address 1";
            this.addressOneDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.addressOneDataGridViewTextBoxColumn.Name = "addressOneDataGridViewTextBoxColumn";
            this.addressOneDataGridViewTextBoxColumn.Width = 175;
            // 
            // addressTwoDataGridViewTextBoxColumn
            // 
            this.addressTwoDataGridViewTextBoxColumn.DataPropertyName = "AddressTwo";
            this.addressTwoDataGridViewTextBoxColumn.HeaderText = "Address 2";
            this.addressTwoDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.addressTwoDataGridViewTextBoxColumn.Name = "addressTwoDataGridViewTextBoxColumn";
            this.addressTwoDataGridViewTextBoxColumn.Width = 175;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 175;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.Width = 175;
            // 
            // zipCodeDataGridViewTextBoxColumn
            // 
            this.zipCodeDataGridViewTextBoxColumn.DataPropertyName = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.HeaderText = "Zip Code";
            this.zipCodeDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.zipCodeDataGridViewTextBoxColumn.Name = "zipCodeDataGridViewTextBoxColumn";
            this.zipCodeDataGridViewTextBoxColumn.Width = 175;
            // 
            // primaryContactDataGridViewTextBoxColumn
            // 
            this.primaryContactDataGridViewTextBoxColumn.DataPropertyName = "PrimaryContact";
            this.primaryContactDataGridViewTextBoxColumn.HeaderText = "Primary Contact";
            this.primaryContactDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.primaryContactDataGridViewTextBoxColumn.Name = "primaryContactDataGridViewTextBoxColumn";
            this.primaryContactDataGridViewTextBoxColumn.Width = 175;
            // 
            // segmentCodeDataGridViewTextBoxColumn
            // 
            this.segmentCodeDataGridViewTextBoxColumn.DataPropertyName = "SegmentCode";
            this.segmentCodeDataGridViewTextBoxColumn.HeaderText = "Business Focus";
            this.segmentCodeDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.segmentCodeDataGridViewTextBoxColumn.Name = "segmentCodeDataGridViewTextBoxColumn";
            this.segmentCodeDataGridViewTextBoxColumn.Width = 175;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.Visible = false;
            this.notesDataGridViewTextBoxColumn.Width = 175;
            // 
            // taxExemptDataGridViewTextBoxColumn
            // 
            this.taxExemptDataGridViewTextBoxColumn.DataPropertyName = "TaxExempt";
            this.taxExemptDataGridViewTextBoxColumn.HeaderText = "TaxExempt";
            this.taxExemptDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.taxExemptDataGridViewTextBoxColumn.Name = "taxExemptDataGridViewTextBoxColumn";
            this.taxExemptDataGridViewTextBoxColumn.Width = 175;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(B2B_Application_Wizard.Account);
            // 
            // dgvContacts
            // 
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContacts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContacts.AutoGenerateColumns = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContacts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountNumDataGridViewTextBoxColumn,
            this.contactNameDataGridViewTextBoxColumn,
            this.contactNumberDataGridViewTextBoxColumn,
            this.contactEmailDataGridViewTextBoxColumn});
            this.dgvContacts.DataSource = this.contactBindingSource;
            this.dgvContacts.Location = new System.Drawing.Point(802, 547);
            this.dgvContacts.Margin = new System.Windows.Forms.Padding(6);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.RowHeadersVisible = false;
            this.dgvContacts.RowHeadersWidth = 72;
            this.dgvContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContacts.Size = new System.Drawing.Size(1003, 253);
            this.dgvContacts.TabIndex = 39;
            this.dgvContacts.TabStop = false;
            // 
            // accountNumDataGridViewTextBoxColumn
            // 
            this.accountNumDataGridViewTextBoxColumn.DataPropertyName = "AccountNum";
            this.accountNumDataGridViewTextBoxColumn.HeaderText = "Account Number";
            this.accountNumDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.accountNumDataGridViewTextBoxColumn.Name = "accountNumDataGridViewTextBoxColumn";
            this.accountNumDataGridViewTextBoxColumn.Width = 175;
            // 
            // contactNameDataGridViewTextBoxColumn
            // 
            this.contactNameDataGridViewTextBoxColumn.DataPropertyName = "ContactName";
            this.contactNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.contactNameDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.contactNameDataGridViewTextBoxColumn.Name = "contactNameDataGridViewTextBoxColumn";
            this.contactNameDataGridViewTextBoxColumn.Width = 175;
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            this.contactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.contactNumberDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            this.contactNumberDataGridViewTextBoxColumn.Width = 175;
            // 
            // contactEmailDataGridViewTextBoxColumn
            // 
            this.contactEmailDataGridViewTextBoxColumn.DataPropertyName = "ContactEmail";
            this.contactEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.contactEmailDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.contactEmailDataGridViewTextBoxColumn.Name = "contactEmailDataGridViewTextBoxColumn";
            this.contactEmailDataGridViewTextBoxColumn.Width = 175;
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataSource = typeof(B2B_Application_Wizard.Contact);
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Location = new System.Drawing.Point(9, 36);
            this.lblContactName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(64, 25);
            this.lblContactName.TabIndex = 40;
            this.lblContactName.Text = "Name";
            // 
            // lblContactEmail
            // 
            this.lblContactEmail.AutoSize = true;
            this.lblContactEmail.Location = new System.Drawing.Point(403, 36);
            this.lblContactEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblContactEmail.Name = "lblContactEmail";
            this.lblContactEmail.Size = new System.Drawing.Size(60, 25);
            this.lblContactEmail.TabIndex = 41;
            this.lblContactEmail.Text = "Email";
            // 
            // tbxContactName
            // 
            this.tbxContactName.Location = new System.Drawing.Point(9, 67);
            this.tbxContactName.Margin = new System.Windows.Forms.Padding(6);
            this.tbxContactName.MaxLength = 20;
            this.tbxContactName.Name = "tbxContactName";
            this.tbxContactName.Size = new System.Drawing.Size(184, 29);
            this.tbxContactName.TabIndex = 16;
            // 
            // tbxContactEmail
            // 
            this.tbxContactEmail.Location = new System.Drawing.Point(408, 67);
            this.tbxContactEmail.Margin = new System.Windows.Forms.Padding(6);
            this.tbxContactEmail.MaxLength = 76;
            this.tbxContactEmail.Name = "tbxContactEmail";
            this.tbxContactEmail.Size = new System.Drawing.Size(304, 29);
            this.tbxContactEmail.TabIndex = 18;
            // 
            // lblDGVContacts
            // 
            this.lblDGVContacts.AutoSize = true;
            this.lblDGVContacts.Location = new System.Drawing.Point(807, 510);
            this.lblDGVContacts.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDGVContacts.Name = "lblDGVContacts";
            this.lblDGVContacts.Size = new System.Drawing.Size(90, 25);
            this.lblDGVContacts.TabIndex = 53;
            this.lblDGVContacts.Text = "Contacts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 59;
            this.label1.Text = "Phone #";
            // 
            // tbxContactPhone
            // 
            this.tbxContactPhone.Location = new System.Drawing.Point(205, 67);
            this.tbxContactPhone.Margin = new System.Windows.Forms.Padding(6);
            this.tbxContactPhone.Mask = "(999) 000-0000";
            this.tbxContactPhone.Name = "tbxContactPhone";
            this.tbxContactPhone.Size = new System.Drawing.Size(191, 29);
            this.tbxContactPhone.TabIndex = 17;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(289, 825);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(142, 40);
            this.btnAddAccount.TabIndex = 20;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpContacts
            // 
            this.grpContacts.Controls.Add(this.btnAddContact);
            this.grpContacts.Controls.Add(this.tbxContactName);
            this.grpContacts.Controls.Add(this.tbxContactPhone);
            this.grpContacts.Controls.Add(this.label1);
            this.grpContacts.Controls.Add(this.tbxContactEmail);
            this.grpContacts.Controls.Add(this.lblContactName);
            this.grpContacts.Controls.Add(this.lblContactEmail);
            this.grpContacts.Location = new System.Drawing.Point(15, 626);
            this.grpContacts.Name = "grpContacts";
            this.grpContacts.Size = new System.Drawing.Size(731, 182);
            this.grpContacts.TabIndex = 16;
            this.grpContacts.TabStop = false;
            this.grpContacts.Text = "Contacts";
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(255, 113);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(202, 35);
            this.btnAddContact.TabIndex = 19;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.logToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1820, 38);
            this.menuStrip1.TabIndex = 54;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetEmailPasswordToolStripMenuItem,
            this.openProgramDirectoryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // resetEmailPasswordToolStripMenuItem
            // 
            this.resetEmailPasswordToolStripMenuItem.Name = "resetEmailPasswordToolStripMenuItem";
            this.resetEmailPasswordToolStripMenuItem.Size = new System.Drawing.Size(357, 40);
            this.resetEmailPasswordToolStripMenuItem.Text = "Reset Email Password";
            this.resetEmailPasswordToolStripMenuItem.Click += new System.EventHandler(this.resetEmailPasswordToolStripMenuItem_Click);
            // 
            // openProgramDirectoryToolStripMenuItem
            // 
            this.openProgramDirectoryToolStripMenuItem.Name = "openProgramDirectoryToolStripMenuItem";
            this.openProgramDirectoryToolStripMenuItem.Size = new System.Drawing.Size(357, 40);
            this.openProgramDirectoryToolStripMenuItem.Text = "Open Program Directory";
            this.openProgramDirectoryToolStripMenuItem.Click += new System.EventHandler(this.openProgramDirectoryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(357, 40);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewLogToolStripMenuItem});
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(65, 34);
            this.logToolStripMenuItem.Text = "Log";
            // 
            // viewLogToolStripMenuItem
            // 
            this.viewLogToolStripMenuItem.Name = "viewLogToolStripMenuItem";
            this.viewLogToolStripMenuItem.Size = new System.Drawing.Size(215, 40);
            this.viewLogToolStripMenuItem.Text = "View Log";
            this.viewLogToolStripMenuItem.Click += new System.EventHandler(this.viewLogToolStripMenuItem_Click);
            // 
            // lnkAccounts
            // 
            this.lnkAccounts.AutoSize = true;
            this.lnkAccounts.Location = new System.Drawing.Point(807, 49);
            this.lnkAccounts.Name = "lnkAccounts";
            this.lnkAccounts.Size = new System.Drawing.Size(842, 25);
            this.lnkAccounts.TabIndex = 55;
            this.lnkAccounts.TabStop = true;
            this.lnkAccounts.Text = "Accounts (Click on an account to update the Contacts view below. Click this label" +
    " to clear filters.)";
            this.lnkAccounts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAccounts_LinkClicked);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1820, 916);
            this.Controls.Add(this.lnkAccounts);
            this.Controls.Add(this.grpContacts);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.lblDGVContacts);
            this.Controls.Add(this.dgvContacts);
            this.Controls.Add(this.dgvAccounts);
            this.Controls.Add(this.tbxAddressZip);
            this.Controls.Add(this.tbxAddressState);
            this.Controls.Add(this.tbxAddressCity);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.tbxAddress2);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.tbxFaxNumber);
            this.Controls.Add(this.tbxPhoneNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbStore);
            this.Controls.Add(this.lblAccoutNum);
            this.Controls.Add(this.tbxAccountNum);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.tbxNotes);
            this.Controls.Add(this.cbxTaxExempt);
            this.Controls.Add(this.lblSegmentCode);
            this.Controls.Add(this.cmbBusinessFocus);
            this.Controls.Add(this.tbxPurchContact);
            this.Controls.Add(this.lblPrimaryContact);
            this.Controls.Add(this.tbxAddress1);
            this.Controls.Add(this.lblAddress1);
            this.Controls.Add(this.lblFax);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.tbxCompanyName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1844, 980);
            this.Name = "MainWindow";
            this.Text = "B2B Application Wizard v2.4.0.6 (Rev. 12/15/2023)";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            this.grpContacts.ResumeLayout(false);
            this.grpContacts.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbxCompanyName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.TextBox tbxAddress1;
        private System.Windows.Forms.Label lblPrimaryContact;
        private System.Windows.Forms.TextBox tbxPurchContact;
        private System.Windows.Forms.ComboBox cmbBusinessFocus;
        private System.Windows.Forms.Label lblSegmentCode;
        private System.Windows.Forms.CheckBox cbxTaxExempt;
        private System.Windows.Forms.TextBox tbxNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox tbxAccountNum;
        private System.Windows.Forms.Label lblAccoutNum;
        private System.Windows.Forms.ComboBox cmbStore;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox tbxPhoneNumber;
        private System.Windows.Forms.MaskedTextBox tbxFaxNumber;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox tbxAddress2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox tbxAddressCity;
        private System.Windows.Forms.TextBox tbxAddressState;
        private System.Windows.Forms.TextBox tbxAddressZip;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.Label lblContactEmail;
        private System.Windows.Forms.TextBox tbxContactName;
        private System.Windows.Forms.TextBox tbxContactEmail;
        private System.Windows.Forms.Label lblDGVContacts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tbxContactPhone;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.GroupBox grpContacts;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressOneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressTwoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primaryContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn segmentCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxExemptDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetEmailPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProgramDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLogToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lnkAccounts;
    }
}

