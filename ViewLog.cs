using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Runtime.CompilerServices;
using System.IO;
using System.Reflection;
using B2B_Application_Wizard_v2;
using System.Diagnostics;
using B2B_Application_Wizard;
using System.Security.Principal;

namespace B2B_Application_Wizard_v2
{
    public partial class ViewLog : Form
    {
        private readonly string logPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "log.csv");
        //private static readonly BindingList<LogEntry> logEntries = new BindingList<LogEntry>();
        BindingList<LogEntry> logList = new BindingList<LogEntry>();
        public ViewLog()
        {
            InitializeComponent();
            SetBindingList();
        }

        private void SetBindingList()
        {
            BindingList<LogEntry> log = LoadLog();
            dgvLog.DataSource = log;

        }

        private BindingList<LogEntry> LoadLog()
        {

            using (StreamReader sr = new StreamReader(logPath))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    LogEntry entry = new LogEntry();
                    
                    string[] values = line.Split(',');
                    entry.AccountNumber = values[0];
                    entry.CompanyName = values[1];
                    entry.DateEntered = values[2];
                    logList.Add(entry);
                    
                }
            }

            return logList;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string filter = tbxAccountNumberSearch.Text;

            if (tbxAccountNumberSearch.Text.Length != 0)
            {
                tbxCompanySearch.Enabled = false;
            }

            else
            {
                tbxCompanySearch.Enabled = true;
            }

            var filterList = logList.Where(x => x.AccountNumber.Contains(filter)).ToList();
            dgvLog.DataSource = filterList;
        }

        private void tbxCompanySearch_TextChanged(object sender, EventArgs e)
        {
            string filter = tbxCompanySearch.Text;

            if (tbxCompanySearch.Text.Length != 0)
            {
                tbxAccountNumberSearch.Enabled = false;
            }

            else
            {
                tbxAccountNumberSearch.Enabled = true;
            }

            var filterList = logList.Where(x => x.CompanyName.Contains(filter)).ToList();
            dgvLog.DataSource = filterList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvLog.CurrentRow != null)
            {
                // Remove the selected row from the DataGridView
                dgvLog.Rows.RemoveAt(dgvLog.CurrentRow.Index);

                // Save the updated DataTable back to CSV
                SaveLog(logPath);
            }
        }

        public void SaveLog(string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (LogEntry entry in logList)
                {
                    sw.WriteLine($"{entry.AccountNumber},{entry.CompanyName},{DateTime.Now}");
                }
            }
        }
        
        
        
    
    }
}
