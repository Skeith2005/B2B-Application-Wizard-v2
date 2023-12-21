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
using System.Runtime.CompilerServices;
using System.IO;
using System.Reflection;
using B2B_Application_Wizard_v2;
using System.Diagnostics;
using System.Deployment.Application;
using System.Threading;

namespace B2B_Application_Wizard
{
    public partial class MainWindow : Form
    {
        BindingList<Account> accounts = new BindingList<Account>();
        BindingList<Contact> contacts = new BindingList<Contact>();

        public readonly string appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "B2B Application Wizard");

        public MainWindow()
        {
            InitializeComponent();
            DisplayChangeLog();
            this.AcceptButton = null;
            CheckForFiles();
            CheckForPassword();
            cmbBusinessFocus.DataSource = setFocusList();
            cmbStore.DataSource = setStoreList();
            dgvAccounts.DataSource = accounts;
            dgvContacts.DataSource = contacts;
            cmbBusinessFocus.DisplayMember = "Name";
            cmbBusinessFocus.ValueMember = "Code";
        }

        private void DisplayChangeLog()
        {
            if(!ApplicationDeployment.IsNetworkDeployed)
            {
                return;
            }

            if(!ApplicationDeployment.CurrentDeployment.IsFirstRun)
            {
                return;
            }
            
            MessageBox.Show("New to version " + VersionLabel + ":" + Environment.NewLine + Environment.NewLine + "* Disabled comma usage for all text boxes except Notes to prevent formatting errors.");
        }

        private void CheckForPassword()
        {
            if (!File.Exists(Path.Combine(appDataPath, "password.txt")))
            {
                MessageBox.Show("Password file not detected due to corruption or fresh install. Please enter your B2B Email password.", "Password Error");
                EmailPassword emailPassword = new EmailPassword();
                emailPassword.ShowDialog();
            }
        }
        private void CheckForFiles()
        {
            if(!Directory.Exists(appDataPath))
            {
                Directory.CreateDirectory(appDataPath);
            }

            if (File.Exists(Path.Combine(appDataPath, "contacts.csv")))
            {
                File.Delete(Path.Combine(appDataPath, "contacts.csv"));
            }

            if (File.Exists(Path.Combine(appDataPath, "accounts.csv")))
            {
                File.Delete(Path.Combine(appDataPath, "accounts.csv"));
            }

            if (!File.Exists(Path.Combine(appDataPath, "log.csv")))
            {
                File.Create(Path.Combine(appDataPath, "log.csv")).Dispose();
            }

        }
        private BindingList<string> setStoreList()
        {
            BindingList<string> storeList = new BindingList<string> { "Select One", "Woodcrest", "Wildomar" };
            return storeList;
        }
        private BindingList<Segment> setFocusList()
        {
            BindingList<Segment> FocusList = new BindingList<Segment>
            {

            new Segment { Name = "Select One", Code = "0" },
            new Segment { Name = "Electrical Contractor", Code = "Q" },
            new Segment { Name = "Farm/Agriculture", Code = "P" },
            new Segment { Name = "Healthcare", Code = "O" },
            new Segment { Name = "Landscaping/Irrigation Contractor", Code = "T" },
            new Segment { Name = "Manufacturer", Code = "M"},
            new Segment { Name = "Munipality/Government", Code = "L"},
            new Segment { Name = "Non-profit", Code = "G"},
            new Segment { Name = "Other Business", Code = "N"},
            new Segment { Name = "Other Contractor", Code = "D"},
            new Segment { Name = "Painting Contractor", Code = "R"},
            new Segment { Name = "Plumbing/HVAC Contractor", Code = "S"},
            new Segment { Name = "Property Management", Code = "H"},
            new Segment { Name = "Religious Organization", Code = "E"},
            new Segment { Name = "Restaurant", Code = "J"},
            new Segment { Name = "Retail Business", Code = "F"},
            new Segment { Name = "School/Education", Code = "K"},
            new Segment { Name = "Service Industry", Code = "I"},
            };

            return FocusList;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {


            if (cmbStore.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a store.");
                return;
            }

            if(accounts.Count == 0)
            {
                MessageBox.Show("Accounts list is empty. Please click \"Add\" before submitting.");
                return;
            }

            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to submit?", "Submit?", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    WriteAccountsFile();
                    WriteContactsFile();
                    WriteLogEntry();
                    SendEmail();

                    DialogResult drArchive = MessageBox.Show("Submission successful. This submission will be saved in local cache until the next time the program is run." +
                        Environment.NewLine + "Would you like to save a copy for this submission your records?", "Success!", MessageBoxButtons.YesNo);

                    if (drArchive == DialogResult.Yes)
                    {
                        SaveSubmission();
                    }

                    ClearFields();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Submission failed with the following message: " + ex.Message +  Environment.NewLine + ex.StackTrace + Environment.NewLine + "Contact Josh with this info to debug.");
                return;
            }
        }

        private void SaveSubmission()
        {
            File.Copy(Path.Combine(appDataPath, "accounts.csv"), @"C:\3apps\temp\Account Submission " + DateTime.Now.ToString("MM-dd-yyyy") + ".csv");
            File.Copy(Path.Combine(appDataPath, "contacts.csv"), @"C:\3apps\temp\Contact Submission " + DateTime.Now.ToString("MM-dd-yyyy") + ".csv");
            DialogResult dr = MessageBox.Show("Files copied to Eagle Temp folder. Would you like to open the folder?", "Success!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Process.Start("explorer.exe", @"C:\3apps\temp\");
            }
        }

        private void ClearFields()
        {
            Application.Restart();

        }

        private void SendEmail()
        {
            SmtpClient smtpClient = SetSmtpSettings(GetFrom(cmbStore.Text));
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(GetFrom(cmbStore.Text));
            mail.To.Add(new MailAddress("josh@woodcrestace.com", "B2B Admin"));
            mail.To.Add(new MailAddress("shard26@pandphardware.com", "B2B Admin"));
            mail.Subject = "New B2B Accounts " + DateTime.Now.ToString("MM-dd-yyyy");
            mail.Body = "Attached are the new B2B accounts and contacts for " + cmbStore.Text + " for " + DateTime.Now;
            mail.Attachments.Add(new Attachment(Path.Combine(appDataPath, "accounts.csv")));
            mail.Attachments.Add(new Attachment(Path.Combine(appDataPath, "contacts.csv")));
            smtpClient.Send(mail);

            DialogResult dr = MessageBox.Show("Email sent successfully.");

        }
        private void WriteLogEntry()
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(appDataPath, "log.csv"), true))
            {
                foreach (Account account in accounts)
                {
                    sw.WriteLine($"{account.AccountNumber},{account.CompanyName},{DateTime.Now}");
                }
            }

        }

        private void WriteContactsFile()
        {
            //Rewrite function to use String.Format for each line, then call sw.WriteLine().
            using (StreamWriter sw = new StreamWriter(Path.Combine(appDataPath, "contacts.csv")))
            {
                foreach (Contact contact in contacts)
                {
                    sw.WriteLine($"{contact.AccountNum},,{contact.ContactName},,{contact.ContactNumber},,,,{contact.ContactEmail}");
                }
            }
        }

        private void WriteAccountsFile()
        {

            using (StreamWriter sw = new StreamWriter(Path.Combine(appDataPath, "accounts.csv")))
            {
                foreach (Account account in accounts)
                {

                    //sw.Write(String.Format("{0},", account.AccountNumber));
                    //sw.Write(String.Format("{0},", account.CompanyName));
                    //sw.Write(String.Format("{0},", account.PhoneNumber));
                    //sw.Write(String.Format("{0},", account.FaxNumber));
                    //sw.Write(String.Format("{0},", account.AddressOne));
                    //sw.Write(String.Format("{0},", account.AddressTwo));
                    //sw.Write(String.Format("{0},", account.City));
                    //sw.Write(String.Format("{0},", account.State));
                    //sw.Write(String.Format("{0},", account.ZipCode));
                    //sw.Write(String.Format("{0},", account.PrimaryContact));
                    //sw.Write(String.Format("{0},", account.SegmentCode));
                    //sw.Write(String.Format("{0},", account.TaxExempt));
                    //sw.Write(String.Format("{0},", account.Notes));
                    //sw.Write(String.Format("{0}", account.SortName));
                    //sw.WriteLine();

                    sw.WriteLine($"{account.AccountNumber},{account.CompanyName},{account.PhoneNumber},{account.FaxNumber},{account.AddressOne},{account.AddressTwo},{account.City},{account.State},{account.ZipCode},{account.PrimaryContact},{account.SegmentCode},{account.TaxExempt},{account.Notes},{account.SortName}");

                }
            }
        }

        private string GetFrom(string storeName)
        {
            if (storeName == "Wildomar")
                return "biz@acewildomar.com";

            else if (storeName == "Woodcrest")
                return "biz@aceriverside.com";

            else
                return "error";
        }
        public SmtpClient SetSmtpSettings(string userName)
        {
            SmtpClient smtpClient = new SmtpClient();
            string password = null;

            using (StreamReader sr = new StreamReader(Path.Combine(appDataPath, "password.txt")))
            {
                password = sr.ReadToEnd();
            }

            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(userName, password);
            smtpClient.Port = 587; // You can use Port 25 if 587 is blocked (mine is!)
            smtpClient.Host = "smtp.office365.com";
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;
            return smtpClient;
        }
        public string GetCredentials(string store)
        {
            if (store == "Woodcrest")
                return @"biz@aceriverside.com";
            else if (store == "Wildomar")
                return @"biz@acewildomar.com";
            else
                return "ERROR";
        }
        private void tbxPhoneNumber_Leave(object sender, EventArgs e)
        {
            //Regex nanClean = new Regex(@"{^\d]");
            tbxPhoneNumber.Text = Regex.Replace(tbxPhoneNumber.Text, "[^0-9]", "");
        }
        private void tbxFaxNumber_Leave(object sender, EventArgs e)
        {
            tbxFaxNumber.Text = Regex.Replace(tbxFaxNumber.Text, "[^0-9]", "");
        }
        public static string EscapeCsvField(string field)
        {
            if (field.Contains("\"") || field.Contains(",") || field.Contains("\n"))
            {
                // Escape quotes by doubling them
                field = field.Replace("\"", "\"\"");
                // Enclose in double quotes
                field = $"\"{field}\"";
            }
            return field;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            LogEntry result = null;

            if (cmbBusinessFocus.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a business focus.");
                return;
            }

            if (SearchLog(tbxAccountNum.Text, out result))
            {
                MessageBox.Show($"Account Number {result.AccountNumber} already exists in the log under name {result.CompanyName}, submitted on {result.DateEntered}. Please enter a new account number.");
                return;

            }



            try
            {
                accounts.Add(new Account
                {
                    AccountNumber = tbxAccountNum.Text.ToUpper(),
                    CompanyName = tbxCompanyName.Text.ToUpper(),
                    SortName = tbxCompanyName.Text.ToUpper(),
                    PhoneNumber = tbxPhoneNumber.Text.ToUpper(),
                    FaxNumber = tbxFaxNumber.Text.ToUpper(),
                    AddressOne = tbxAddress1.Text.ToUpper(),
                    AddressTwo = tbxAddress2.Text.ToUpper(),
                    City = tbxAddressCity.Text.ToUpper(),
                    State = tbxAddressState.Text.ToUpper(),
                    ZipCode = tbxAddressZip.Text.ToUpper(),
                    PrimaryContact = tbxPurchContact.Text.ToUpper(),
                    SegmentCode = cmbBusinessFocus.SelectedValue.ToString(),
                    TaxExempt = cbxTaxExempt.Checked ? "Y" : "N",
                    Notes = tbxNotes.Text
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            Reset(this);
        }

        private bool SearchLog(string accountNumber, out LogEntry result)
        {
            using (StreamReader sr = new StreamReader(Path.Combine(appDataPath, "log.csv")))
            {
                string line;
                result = new LogEntry();

                while ((line = sr.ReadLine()) != null)
                {
                    string[] fields = line.Split(',');
                    if (fields[0] == accountNumber)
                    {
                        result = new LogEntry
                        {
                            AccountNumber = fields[0],
                            CompanyName = fields[1],
                            DateEntered = fields[2]
                        };
                        return true;
                    }

                }

                return false;
            }
        }

        private void Reset(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox || c is MaskedTextBox)
                {
                    c.Text = string.Empty;
                }

                cmbBusinessFocus.SelectedIndex = 0;
                cbxTaxExempt.Checked = false;
            }
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxAccountNum.Text))
            {
                MessageBox.Show("Enter account information first, then add contacts.");
                return;
            }

            try
            {

                contacts.Add(new Contact
                {
                    AccountNum = tbxAccountNum.Text.ToUpper(),
                    ContactName = tbxContactName.Text.ToUpper(),
                    ContactNumber = tbxContactPhone.Text.ToUpper(),
                    ContactEmail = tbxContactEmail.Text.ToUpper()
                });
            }

            catch (Exception ex)
            { MessageBox.Show(ex.Message); return; }


            foreach (Control control in grpContacts.Controls)
            {
                if (control is TextBox || control is MaskedTextBox)
                {
                    control.Text = string.Empty;
                }

            }

            dgvContacts.Refresh();
        }

        private void dgvAccounts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAccounts.CurrentRow.DataBoundItem != null)
            {
                if (dgvAccounts.CurrentRow != null)
                {

                    string selectedAccountNumber = ((Account)dgvAccounts.CurrentRow.DataBoundItem).AccountNumber;
                    FilterContacts(selectedAccountNumber);
                }

                else
                    ClearContactFilters();
            }

            else
            {
                MessageBox.Show("No data entered. Please enter account information first.");
                return;
            }

        }

        private void FilterContacts(string accountNumber)
        {
            if (accountNumber != null)
            {
                var filteredContacts = contacts.Where(contact => contact.AccountNum == accountNumber).ToList();
                dgvContacts.DataSource = filteredContacts;
            }
        }

        private void ClearContactFilters()
        {
            dgvContacts.DataSource = contacts;
        }

        private void resetEmailPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmailPassword emailPassword = new EmailPassword();
            emailPassword.ShowDialog();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openProgramDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", appDataPath);
        }

        private void viewLogToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            ViewLog vlWindow = new ViewLog();
            vlWindow.ShowDialog();     

        }

        private void lnkAccounts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvContacts.DataSource = contacts;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("B2B Application Wizard, Version: " + VersionLabel + Environment.NewLine + "Created by Josh Shanabarger" + Environment.NewLine + "For use by Woodcrest Ace Hardware, Inc.");
        }

        private string VersionLabel
        {
            get
            {
                if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                {
                    Version ver = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;
                    return string.Format("{0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision);
                }
                else
                {
                    var ver = Assembly.GetExecutingAssembly().GetName().Version;
                    return string.Format("{0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision);
                }
            }
        }

        private void tbxAlphaNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ',' || e.KeyChar == '"')
            {
                e.Handled = true;
            }
        }
    }

    public class Account
    {
        //Account Number (Must be 5 digits & can't be empty)
        private string _accountNumber;
        public string AccountNumber
        {
            get { return _accountNumber; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Account number can't be empty");
                if (value.Length != 5) 
                    throw new ArgumentException("Account number must be 5 digits long");
                _accountNumber = value;
            }
        }

        //Store Name (chosen from a dropdown menu)
        private string _storeName;
        public string StoreName
        {
            get { return _storeName; }

            set { _storeName = value; }
        }
        
        //Company Name (30 character limit, must not contain commas)
        private string _companyName;
        public string CompanyName
        {
            get { return _companyName; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Account name can't be empty");
                if (value.Length > 30)
                    throw new ArgumentException("Company name too long. Must be 30 characters or less");
                if (value.Contains(','))
                    value.Replace(',', ' ');
                
                _companyName = value;
            }
        }
        
        //Phone Number (12 character limit, must contain only numbers, formatted as ###-###-####)
        private string _phoneNumber;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                // First, remove all non-numeric characters
                string digitsOnly = Regex.Replace(value, @"\D", "");

                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Phone number can't be empty");

                // Check if we have exactly 10 digits (U.S. phone number format)
                if (digitsOnly.Length == 10)
                {
                    // Format the number as ###-###-####
                    _phoneNumber = digitsOnly.Substring(0, 3) + "-" + digitsOnly.Substring(3, 3) + "-" + digitsOnly.Substring(6);

                }
                else
                {
                    throw new ArgumentException("Phone number must be 10 digits long.");
                }
            }
        }

        //Fax Number (12 character limit, must contain only numbers, can't be the same as Phone number, formatted as ###-###-####)
        private string _faxNumber;
        public string FaxNumber
        {
            get { return _faxNumber; }
            set
            {
                // First, remove all non-numeric characters
                string digitsOnly = Regex.Replace(value, @"\D", "");

                if ((digitsOnly == _phoneNumber))
                {
                    throw new ArgumentException("Fax and Phone Numbers must be different.");
                }

                // Check if we have exactly 10 digits (U.S. phone number format)
                if (digitsOnly.Length == 10)
                {
                    // Format the number as ###-###-####
                    _faxNumber = digitsOnly.Substring(0, 3) + "-" + digitsOnly.Substring(3, 3) + "-" + digitsOnly.Substring(6);
                }
            }
        }

        //Address Line 1 (30 character limit, must not contain commas)
        private string _addressOne;
        public string AddressOne
        {
            get { return _addressOne; }
            set
            {
                if (value.Length > 30)
                    throw new ArgumentException("Address Line 1 is too long. Must be 30 characters or less.");
                if (value.Contains(','))
                    value.Replace(",", "");
                
                _addressOne = value;
            }
        }


        //Address Line 2 (30 character limit, must not contain commas
        private string _addressTwo;
        public string AddressTwo
        {
            get { return _addressTwo; }
            set
            {
                if (value.Length > 30)
                    throw new ArgumentException("Address Line 2 is too long. Must be 30 characters or less.");
                if (value.Contains(','))
                    value.Replace(",", "");

                _addressTwo = value;
            }

        }

        private string _city;
        public string City
        {
            get { return _city; }
            set
            {
                if (value.Length > 15)
                    throw new ArgumentException("City is too long. Must be 15 characters or less.");
                if (value.Contains(","))
                    value.Replace(",", "");

                _city = value;
            }
        }

        private string _state;
        public string State
        {
            get { return _state; }
            set
            {
                if (value.Length != 2) throw new ArgumentException("State must be 2 characters.");
                if (value.Length == 0)
                    value = "CA";

                _state = value;
            }
        }

        private string _zipCode;
        public string ZipCode
        {
            get { return _zipCode; }
            set
            {
                if (value.Length > 5) throw new ArgumentException("Zip Code is too long. Must be 5 characters or under");

                _zipCode = value;
            }
        }

        //Contact (20 character limit, must not contain commas, can't contain numbers)
        private string _primaryContact;
        public string PrimaryContact
        {
            get { return _primaryContact; }
            set
            {
                if (value.Length > 20)
                    throw new ArgumentException("Primary contact must be 20 characters or less.");
                if (value.Contains(","))
                    value.Replace(",", "");
                
                _primaryContact = value;
            }

        }

        //Segment Type (1 character limit, inherited from selected Business Focus combo box, cmbBusinessFocus)
        private string _segmentCode;
        public string SegmentCode
        {
            get { return _segmentCode; }
            set
            {
                _segmentCode = value;
            }
        }

        //Notes (5000 character limit, may contain commas. Need to add Escape method to validation)
        private string _notes;
        public string Notes
        {
            get { return _notes.Contains(",") ? $"\"{_notes}\"" : _notes; }
            set
            {
                _notes = value.Replace("\"", string.Empty).Trim();

            }
        }

        //Taxable (1 character limit, must be Y or N)
        private string _taxExempt;
        public string TaxExempt
        {
            get { return _taxExempt; }
            set { _taxExempt = value; }
        }

        private string _sortName;
        public string SortName
        {
            get { return _sortName; }
            set {
                if (_companyName.Length > 10)
                {
                    _sortName = _companyName.Substring(0, 10);
                }
                else
                {
                    _sortName = _companyName;
                }
            }
        }
    }

    public class Contact
    {
        //Contact Name
        private string _contactName;
        public string ContactName
        {
            get { return _contactName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Contact Name can't be empty");
                _contactName = value;
            }
        }

        //Contact Phone Number
        private string _contactNumber;
        public string ContactNumber
        {
            get { return _contactNumber; }
            set
            {
                // First, remove all non-numeric characters
                string digitsOnly = Regex.Replace(value, @"\D", "");

                // Check if we have exactly 10 digits (U.S. phone number format)
                if (digitsOnly.Length == 10)
                {
                    // Format the number as ###-###-####
                    _contactNumber = Regex.Replace(digitsOnly, @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");
                }
                else
                {
                    throw new ArgumentException("Phone number must be 10 digits long.");
                }
            }
        }

        //Contact email address
        private string _contactEmail;
        public string ContactEmail
        {
            get { return _contactEmail; }
            set
            {
                var emailPattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";

                if (string.IsNullOrWhiteSpace(value))
                    _contactEmail = value;

                else if (Regex.IsMatch(value, emailPattern))
                {
                    _contactEmail = value;
                }
                else
                {
                    throw new ArgumentException("Invalid email format. If customer gave incorrect information, leave field blank.");
                }
            }
        }

        private string _accountNum;
        public string AccountNum
        {
            get { return _accountNum; }
            set { _accountNum = value; }
        }
    }
        
    class Segment
    
    {
        public string Code { get; set; }
        public string Name { get; set; }    
    }

    class LogEntry
    {
        private string _accountNum;
        public string AccountNumber
        {
            get { return _accountNum; }
            set { _accountNum = value; }
        }
        private string _companyName;
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        private string _dateEntered;
        public string DateEntered
        {
            get { return _dateEntered; }
            set { _dateEntered = value; }
        }
    }
    
}
