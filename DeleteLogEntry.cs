using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B2B_Application_Wizard_v2
{
    public partial class DeleteLogEntry : Form
    {
        public DeleteLogEntry()
        {
            //CheckForLog();
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "log.csv")).ToList();
            var lineToDelete = lines.FirstOrDefault(line => line.Split(',')[0].Trim() == tbxAccountNumber.Text);

            if (lineToDelete != null)
            {
                lines.Remove(lineToDelete);
                File.WriteAllLines(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "log.csv"), lines);
                this.Close();
            }
            else
            {
                MessageBox.Show("Account number not found");
                this.Close();
            }
        }

        public static bool CanOpen()
        {
            return File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "log.csv"));
        }
    }
}
