using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B2B_Application_Wizard_v2
{
    public partial class EmailPassword : Form
    {
        public readonly string appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "B2B Application Wizard");

        private readonly string txtFile = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "B2B Application Wizard"), "password.txt");
        public EmailPassword()
        {
            InitializeComponent();
            if (CheckForOldFile())
            {
                File.Delete(txtFile);
            }
        }

        private bool CheckForOldFile()
        {
            if (File.Exists(txtFile)) return true;
            else return false;
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            
            if(tbxPassword.Text == string.Empty)
            {
                MessageBox.Show("Please enter your password in the box.");
                return;
            }

            using (StreamWriter sw = new StreamWriter(txtFile))
            {
                sw.Write(tbxPassword.Text);
                sw.Close();
            }

            this.Close();
        }     
    }
}