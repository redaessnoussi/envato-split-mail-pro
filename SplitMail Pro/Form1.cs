using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace SplitMail_Pro
{
    public partial class Form1 : Form
    {
        private Dictionary<string, HashSet<string>> emailGroups;
        private bool isComboList = false;
        private string comboListDelimiter = ":";

        public Form1()
        {
            InitializeComponent();
            emailGroups = new Dictionary<string, HashSet<string>>();
        }

        private async void btnSplitEmails_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            progressBar.Value = 0;
            await SplitEmailsAsync();
            DisplayEmailGroups();
            progressBar.Visible = false;
        }

        private async Task SplitEmailsAsync()
        {
            emailGroups.Clear();
            string[] emails = txtEmailList.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            await Task.Run(() =>
            {
                for (int i = 0; i < emails.Length; i++)
                {
                    string email = emails[i];
                    if (isComboList)
                    {
                        string[] parts = email.Split(new[] { comboListDelimiter }, 2, StringSplitOptions.None);
                        if (parts.Length > 0)
                        {
                            email = parts[0];
                        }
                    }

                    string[] emailParts = email.Split('@');
                    if (emailParts.Length == 2)
                    {
                        string domain = emailParts[1].ToLower();
                        string esp = GetESP(domain);

                        if (!emailGroups.ContainsKey(esp))
                        {
                            emailGroups[esp] = new HashSet<string>();
                        }
                        emailGroups[esp].Add(email);
                    }

                    if (i % 100 == 0)
                    {
                        int progressPercentage = (int)((float)i / emails.Length * 100);
                        this.Invoke((MethodInvoker)delegate {
                            progressBar.Value = progressPercentage;
                        });
                    }
                }
            });
        }

        private void SplitEmails()
        {
            emailGroups.Clear();
            string[] emails = txtEmailList.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string email in emails)
            {
                string[] emailParts = email.Split('@');
                if (emailParts.Length == 2)
                {
                    string domain = emailParts[1].ToLower();
                    string esp = GetESP(domain);

                    if (!emailGroups.ContainsKey(esp))
                    {
                        emailGroups[esp] = new HashSet<string>();
                    }
                    emailGroups[esp].Add(email);
                }
            }
        }

        private string GetESP(string domain)
        {
            domain = domain.ToLower();
            if (domain.Contains("gmail")) return "Gmail";
            if (domain.Contains("outlook") || domain.Contains("hotmail") || domain.Contains("live") || domain.Contains("msn")) return "Outlook";
            if (domain.Contains("yahoo")) return "Yahoo";
            if (domain.Contains("aol")) return "AOL";
            if (domain.Contains("icloud") || domain.Contains("me.com") || domain.Contains("mac.com")) return "Apple";
            if (domain.Contains("protonmail")) return "ProtonMail";
            if (domain.Contains("zoho")) return "Zoho";
            if (domain.Contains("yandex")) return "Yandex";
            if (domain.Contains("mail.com")) return "Mail.com";
            if (domain.Contains("gmx")) return "GMX";
            if (domain.Contains("tutanota")) return "Tutanota";
            if (domain.Contains("fastmail")) return "FastMail";
            if (domain.Contains("comcast")) return "Comcast";
            if (domain.Contains("verizon")) return "Verizon";
            if (domain.Contains("att")) return "AT&T";
            return "Other";
        }

        private void chkComboList_CheckedChanged(object sender, EventArgs e)
        {
            isComboList = chkComboList.Checked;
            if (isComboList)
            {
                string input = ShowInputDialog("Enter the delimiter for the combo list:", "Combo List Delimiter", ":");
                if (!string.IsNullOrEmpty(input))
                {
                    comboListDelimiter = input;
                }
            }
        }

        private string ShowInputDialog(string prompt, string title, string defaultValue)
        {
            Form inputBox = new Form();
            inputBox.Width = 300;
            inputBox.Height = 150;
            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.Text = title;
            inputBox.StartPosition = FormStartPosition.CenterScreen;

            Label label = new Label() { Left = 20, Top = 20, Text = prompt };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 200, Text = defaultValue };
            Button confirmation = new Button() { Text = "Ok", Left = 20, Width = 100, Top = 80 };

            confirmation.Click += (sender, e) => { inputBox.Close(); };
            inputBox.Controls.Add(label);
            inputBox.Controls.Add(textBox);
            inputBox.Controls.Add(confirmation);

            inputBox.ShowDialog();

            return textBox.Text;
        }

        private void DisplayEmailGroups()
        {
            lstEmailGroups.Items.Clear();
            foreach (var group in emailGroups)
            {
                lstEmailGroups.Items.Add($"{group.Key}: {group.Value.Count} email(s)");
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                Title = "Select a file to import"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtEmailList.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void btnExportSelected_Click(object sender, EventArgs e)
        {
            if (lstEmailGroups.SelectedItem == null) return;

            string selectedESP = lstEmailGroups.SelectedItem.ToString().Split(':')[0];
            ExportEmails(selectedESP);
        }

        private void btnExportAll_Click(object sender, EventArgs e)
        {
            ExportEmails();
        }

        private void ExportEmails(string esp = null)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Zip file (*.zip)|*.zip",
                Title = "Save emails"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var zipArchive = ZipFile.Open(saveFileDialog.FileName, ZipArchiveMode.Create))
                {
                    if (esp != null)
                    {
                        // Export specific ESP
                        if (emailGroups.ContainsKey(esp))
                        {
                            var entry = zipArchive.CreateEntry($"{esp}.txt");
                            using (var writer = new StreamWriter(entry.Open()))
                            {
                                foreach (var email in emailGroups[esp])
                                {
                                    writer.WriteLine(email);
                                }
                            }
                        }
                    }
                    else
                    {
                        // Export all
                        foreach (var group in emailGroups)
                        {
                            var entry = zipArchive.CreateEntry($"{group.Key}.txt");
                            using (var writer = new StreamWriter(entry.Open()))
                            {
                                foreach (var email in group.Value)
                                {
                                    writer.WriteLine(email);
                                }
                            }
                        }
                    }
                }
                MessageBox.Show("Emails exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}