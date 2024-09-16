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
        private Dictionary<string, List<string>> emailGroups;

        public Form1()
        {
            InitializeComponent();
            emailGroups = new Dictionary<string, List<string>>();
        }

        private void btnSplitEmails_Click(object sender, EventArgs e)
        {
            SplitEmails();
            DisplayEmailGroups();
        }

        private void SplitEmails()
        {
            emailGroups.Clear();
            string[] emails = txtEmailList.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string email in emails)
            {
                string domain = email.Split('@')[1].ToLower();
                string esp = GetESP(domain);

                if (!emailGroups.ContainsKey(esp))
                {
                    emailGroups[esp] = new List<string>();
                }
                emailGroups[esp].Add(email);
            }
        }

        private string GetESP(string domain)
        {
            if (domain.Contains("gmail")) return "Gmail";
            if (domain.Contains("outlook") || domain.Contains("hotmail") || domain.Contains("live")) return "Outlook";
            if (domain.Contains("yahoo")) return "Yahoo";
            if (domain.Contains("aol")) return "AOL";
            return "Other";
        }

        private void DisplayEmailGroups()
        {
            lstEmailGroups.Items.Clear();
            foreach (var group in emailGroups)
            {
                lstEmailGroups.Items.Add($"{group.Key}: {group.Value.Count} email(s)");
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