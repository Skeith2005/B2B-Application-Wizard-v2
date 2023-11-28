namespace B2B_Application_Wizard_v2
{
    partial class EmailPassword
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
            this.btnOkay = new System.Windows.Forms.Button();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblPasswordInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOkay
            // 
            this.btnOkay.Location = new System.Drawing.Point(146, 97);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(128, 45);
            this.btnOkay.TabIndex = 0;
            this.btnOkay.Text = "Okay";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(13, 50);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(403, 29);
            this.tbxPassword.TabIndex = 1;
            // 
            // lblPasswordInstructions
            // 
            this.lblPasswordInstructions.AutoSize = true;
            this.lblPasswordInstructions.Location = new System.Drawing.Point(13, 13);
            this.lblPasswordInstructions.Name = "lblPasswordInstructions";
            this.lblPasswordInstructions.Size = new System.Drawing.Size(244, 25);
            this.lblPasswordInstructions.TabIndex = 2;
            this.lblPasswordInstructions.Text = "Enter B2B Email Password";
            // 
            // EmailPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 154);
            this.ControlBox = false;
            this.Controls.Add(this.lblPasswordInstructions);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.btnOkay);
            this.Name = "EmailPassword";
            this.Text = "Enter Email Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblPasswordInstructions;
    }
}