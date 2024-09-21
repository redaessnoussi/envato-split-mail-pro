using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework.Components;
using System.Drawing;

namespace SplitMail_Pro
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private Dictionary<string, List<string[]>> emailGroups;
        private string[] csvHeaders;
        private bool isCSV = false;
        private int emailColumnIndex = -1;

        public Form1()
        {
            InitializeComponent();

            // Set the form icon
            this.Icon = Properties.Resources.email_102148; // Replace YourIconName with the actual name of your icon resource

            // Ensure the icon is used in the taskbar
            this.ShowIcon = true;

            // Set Metro style and theme
            this.StyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.StyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            this.StyleManager.Style = MetroFramework.MetroColorStyle.Blue;

            emailGroups = new Dictionary<string, List<string[]>>();

            // Set tooltips
            toolTip.SetToolTip(chkComboList, "A combo list contains both emails and passwords, typically separated by a delimiter (e.g., email@example.com:password123)");

            chkComboList.Checked = false;
            grpDelimiter.Enabled = false;
            chkRemovePassword.Enabled = false;

            cboEmailColumn.SelectedIndexChanged += (sender, e) => {
                if (cboEmailColumn.SelectedIndex != -1)
                {
                    emailColumnIndex = cboEmailColumn.SelectedIndex;
                }
            };

            // Apply custom styling
            ApplyCustomStyling();
        }

        private void ApplyCustomStyling()
        {
            lstEmailGroups.BackColor = MetroFramework.MetroColors.White;
            lstEmailGroups.Font = new Font("Segoe UI", 9F);

            dgvCSVPreview.BackgroundColor = MetroFramework.MetroColors.White;
            dgvCSVPreview.Font = new Font("Segoe UI", 9F);
            dgvCSVPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvCSVPreview.EnableHeadersVisualStyles = false;
            dgvCSVPreview.ColumnHeadersDefaultCellStyle.BackColor = MetroFramework.MetroColors.Silver;
            dgvCSVPreview.ColumnHeadersDefaultCellStyle.ForeColor = MetroFramework.MetroColors.Black;
        }

        private void CustomizeMetroComponents()
        {
            // Customize Metro components here if needed
            btnSplitEmails.UseCustomBackColor = true;
            btnSplitEmails.UseCustomForeColor = true;
            btnSplitEmails.BackColor = MetroFramework.MetroColors.Blue;
            btnSplitEmails.ForeColor = System.Drawing.Color.White;

            // You can add more customizations for other controls here
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
            string[] lines = txtEmailList.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            char delimiter = radColon.Checked ? ':' : ';';

            await Task.Run(() =>
            {
                if (isCSV && lines.Length > 0)
                {
                    csvHeaders = lines[0].Split(',');
                    lines = lines.Skip(1).ToArray(); // Skip header row
                }

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] columns = isCSV ? lines[i].Split(',') : new[] { lines[i] };
                    string email = isCSV && emailColumnIndex >= 0 ? columns[emailColumnIndex] : columns[0];

                    if (chkComboList.Checked)
                    {
                        string[] parts = email.Split(new[] { delimiter }, 2);
                        email = parts[0];
                    }

                    if (chkRemovePassword.Checked)
                    {
                        email = email.Split(new[] { delimiter }, 2)[0];
                    }

                    string[] emailParts = email.Split('@');
                    if (emailParts.Length == 2)
                    {
                        string domain = emailParts[1].ToLower();
                        string esp = GetESP(domain);

                        if (!emailGroups.ContainsKey(esp))
                        {
                            emailGroups[esp] = new List<string[]>();
                        }

                        emailGroups[esp].Add(isCSV ? columns : new[] { email });
                    }

                    if (i % 100 == 0)
                    {
                        int progressPercentage = (int)((float)i / lines.Length * 100);
                        this.Invoke((MethodInvoker)delegate {
                            progressBar.Value = progressPercentage;
                        });
                    }
                }
            });
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
            grpDelimiter.Enabled = chkComboList.Checked;
            chkRemovePassword.Enabled = chkComboList.Checked;
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
                Filter = "CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Select a file to import"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ClearAllData();
                string fileContent = File.ReadAllText(openFileDialog.FileName);
                txtEmailList.Text = fileContent;
                isCSV = Path.GetExtension(openFileDialog.FileName).ToLower() == ".csv";
                if (isCSV)
                {
                    string[] lines = fileContent.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    if (lines.Length > 0)
                    {
                        csvHeaders = lines[0].Split(',');
                        DisplayCSVPreview(fileContent);
                        PopulateEmailColumnDropdown();
                        radExportCSV.Checked = true;
                    }
                    else
                    {
                        MessageBox.Show("The CSV file is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isCSV = false;
                    }
                }
                else
                {
                    dgvCSVPreview.DataSource = null;
                    cboEmailColumn.Visible = false;
                    lblEmailColumn.Visible = false;
                    radExportTXT.Checked = true;
                }
            }
        }

        private void DisplayCSVPreview(string csvContent)
        {
            string[] lines = csvContent.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            if (lines.Length > 0)
            {
                string[] headers = lines[0].Split(',');
                DataTable dt = new DataTable();
                foreach (string header in headers)
                {
                    dt.Columns.Add(header);
                }

                for (int i = 1; i < Math.Min(lines.Length, 11); i++) // Display up to 10 rows
                {
                    dt.Rows.Add(lines[i].Split(','));
                }

                dgvCSVPreview.DataSource = dt;
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
                Filter = "Zip files (*.zip)|*.zip",
                Title = "Save emails",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) // Start in My Documents
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var zipArchive = ZipFile.Open(saveFileDialog.FileName, ZipArchiveMode.Create))
                    {
                        if (esp != null)
                        {
                            ExportESP(zipArchive, esp);
                        }
                        else
                        {
                            foreach (var group in emailGroups)
                            {
                                ExportESP(zipArchive, group.Key);
                            }
                        }
                    }
                    MessageBox.Show("Emails exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("You don't have permission to save in this location. Please choose a different location.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ExportEmails(esp); // Retry export
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while exporting: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExportESP(ZipArchive zipArchive, string esp)
        {
            if (!emailGroups.ContainsKey(esp)) return;

            string extension = radExportCSV.Checked ? "csv" : "txt";
            var entry = zipArchive.CreateEntry($"{esp}.{extension}");

            using (var writer = new StreamWriter(entry.Open()))
            {
                if (radExportCSV.Checked && csvHeaders != null)
                {
                    writer.WriteLine(string.Join(",", csvHeaders));
                }

                foreach (var row in emailGroups[esp])
                {
                    try
                    {
                        if (radExportCSV.Checked)
                        {
                            writer.WriteLine(string.Join(",", row));
                        }
                        else
                        {
                            if (emailColumnIndex >= 0 && emailColumnIndex < row.Length)
                            {
                                writer.WriteLine(row[emailColumnIndex]); // Write only the email for txt files
                            }
                            else
                            {
                                // Fallback to writing the first column if emailColumnIndex is invalid
                                writer.WriteLine(row[0]);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error writing email: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void PopulateEmailColumnDropdown()
        {
            cboEmailColumn.Items.Clear();
            if (csvHeaders != null && csvHeaders.Length > 0)
            {
                foreach (string header in csvHeaders)
                {
                    cboEmailColumn.Items.Add(header);
                }
                int emailIndex = Array.FindIndex(csvHeaders, h => h.ToLower().Contains("email"));
                if (emailIndex != -1)
                {
                    cboEmailColumn.SelectedIndex = emailIndex;
                    emailColumnIndex = emailIndex;
                }
                else
                {
                    cboEmailColumn.SelectedIndex = 0;
                    emailColumnIndex = 0;
                }
                cboEmailColumn.Visible = true;
                lblEmailColumn.Visible = true;
            }
            else
            {
                cboEmailColumn.Visible = false;
                lblEmailColumn.Visible = false;
                emailColumnIndex = 0;
            }
        }        

        private void ClearAllData()
        {
            emailGroups.Clear();
            csvHeaders = null;
            isCSV = false;
            emailColumnIndex = -1;
            dgvCSVPreview.DataSource = null;
            lstEmailGroups.Items.Clear();
        }

        private void txtEmailList_TextChanged(object sender, EventArgs e)
        {
            ClearAllData();
            isCSV = false;
            cboEmailColumn.Visible = false;
            lblEmailColumn.Visible = false;
        }
    }
}