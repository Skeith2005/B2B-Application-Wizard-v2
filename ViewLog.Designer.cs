namespace B2B_Application_Wizard_v2
{
    partial class ViewLog
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
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbxAccountNumberSearch = new System.Windows.Forms.TextBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.tbxCompanySearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Location = new System.Drawing.Point(12, 160);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.RowHeadersVisible = false;
            this.dgvLog.RowHeadersWidth = 72;
            this.dgvLog.RowTemplate.Height = 31;
            this.dgvLog.Size = new System.Drawing.Size(871, 605);
            this.dgvLog.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClose.Location = new System.Drawing.Point(0, 771);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(895, 57);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbxAccountNumberSearch
            // 
            this.tbxAccountNumberSearch.Location = new System.Drawing.Point(6, 70);
            this.tbxAccountNumberSearch.MaxLength = 5;
            this.tbxAccountNumberSearch.Name = "tbxAccountNumberSearch";
            this.tbxAccountNumberSearch.Size = new System.Drawing.Size(100, 29);
            this.tbxAccountNumberSearch.TabIndex = 2;
            this.tbxAccountNumberSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(9, 42);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(100, 25);
            this.lblAccountNumber.TabIndex = 3;
            this.lblAccountNumber.Text = "Account #";
            // 
            // grpSearch
            // 
            this.grpSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSearch.Controls.Add(this.tbxCompanySearch);
            this.grpSearch.Controls.Add(this.lblCompanyName);
            this.grpSearch.Controls.Add(this.tbxAccountNumberSearch);
            this.grpSearch.Controls.Add(this.lblAccountNumber);
            this.grpSearch.Location = new System.Drawing.Point(232, 12);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(451, 125);
            this.grpSearch.TabIndex = 4;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Boxes";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(160, 41);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(154, 25);
            this.lblCompanyName.TabIndex = 4;
            this.lblCompanyName.Text = "Company Name";
            // 
            // tbxCompanySearch
            // 
            this.tbxCompanySearch.Location = new System.Drawing.Point(165, 70);
            this.tbxCompanySearch.MaxLength = 30;
            this.tbxCompanySearch.Name = "tbxCompanySearch";
            this.tbxCompanySearch.Size = new System.Drawing.Size(279, 29);
            this.tbxCompanySearch.TabIndex = 5;
            this.tbxCompanySearch.TextChanged += new System.EventHandler(this.tbxCompanySearch_TextChanged);
            // 
            // ViewLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 828);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvLog);
            this.Name = "ViewLog";
            this.Text = "Log Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbxAccountNumberSearch;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox tbxCompanySearch;
    }
}