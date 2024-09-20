namespace SplitMail_Pro
{
    partial class Form1
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
            this.txtEmailList = new MetroFramework.Controls.MetroTextBox();
            this.btnSplitEmails = new MetroFramework.Controls.MetroButton();
            this.lstEmailGroups = new System.Windows.Forms.ListBox();
            this.btnExportSelected = new MetroFramework.Controls.MetroButton();
            this.btnExportAll = new MetroFramework.Controls.MetroButton();
            this.progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.btnImport = new MetroFramework.Controls.MetroButton();
            this.chkComboList = new MetroFramework.Controls.MetroCheckBox();
            this.grpDelimiter = new System.Windows.Forms.GroupBox();
            this.radSemicolon = new MetroFramework.Controls.MetroRadioButton();
            this.radColon = new MetroFramework.Controls.MetroRadioButton();
            this.chkRemovePassword = new MetroFramework.Controls.MetroCheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dgvCSVPreview = new System.Windows.Forms.DataGridView();
            this.cboEmailColumn = new MetroFramework.Controls.MetroComboBox();
            this.lblEmailColumn = new MetroFramework.Controls.MetroLabel();
            this.grpExportFormat = new System.Windows.Forms.GroupBox();
            this.radExportCSV = new MetroFramework.Controls.MetroRadioButton();
            this.radExportTXT = new MetroFramework.Controls.MetroRadioButton();
            this.grpDelimiter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSVPreview)).BeginInit();
            this.grpExportFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmailList
            // 
            // 
            // 
            // 
            this.txtEmailList.CustomButton.Image = null;
            this.txtEmailList.CustomButton.Location = new System.Drawing.Point(128, 2);
            this.txtEmailList.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailList.CustomButton.Name = "";
            this.txtEmailList.CustomButton.Size = new System.Drawing.Size(167, 167);
            this.txtEmailList.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmailList.CustomButton.TabIndex = 1;
            this.txtEmailList.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmailList.CustomButton.UseSelectable = true;
            this.txtEmailList.CustomButton.Visible = false;
            this.txtEmailList.Lines = new string[0];
            this.txtEmailList.Location = new System.Drawing.Point(12, 59);
            this.txtEmailList.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailList.MaxLength = 32767;
            this.txtEmailList.Multiline = true;
            this.txtEmailList.Name = "txtEmailList";
            this.txtEmailList.PasswordChar = '\0';
            this.txtEmailList.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmailList.SelectedText = "";
            this.txtEmailList.SelectionLength = 0;
            this.txtEmailList.SelectionStart = 0;
            this.txtEmailList.ShortcutsEnabled = true;
            this.txtEmailList.Size = new System.Drawing.Size(298, 172);
            this.txtEmailList.TabIndex = 0;
            this.txtEmailList.UseSelectable = true;
            this.txtEmailList.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmailList.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmailList.TextChanged += new System.EventHandler(this.txtEmailList_TextChanged);
            // 
            // btnSplitEmails
            // 
            this.btnSplitEmails.Location = new System.Drawing.Point(12, 239);
            this.btnSplitEmails.Margin = new System.Windows.Forms.Padding(2);
            this.btnSplitEmails.Name = "btnSplitEmails";
            this.btnSplitEmails.Size = new System.Drawing.Size(300, 23);
            this.btnSplitEmails.TabIndex = 1;
            this.btnSplitEmails.Text = "Split Emails";
            this.btnSplitEmails.UseSelectable = true;
            this.btnSplitEmails.Click += new System.EventHandler(this.btnSplitEmails_Click);
            // 
            // lstEmailGroups
            // 
            this.lstEmailGroups.FormattingEnabled = true;
            this.lstEmailGroups.Location = new System.Drawing.Point(318, 59);
            this.lstEmailGroups.Margin = new System.Windows.Forms.Padding(2);
            this.lstEmailGroups.Name = "lstEmailGroups";
            this.lstEmailGroups.Size = new System.Drawing.Size(300, 173);
            this.lstEmailGroups.TabIndex = 2;
            // 
            // btnExportSelected
            // 
            this.btnExportSelected.Location = new System.Drawing.Point(318, 239);
            this.btnExportSelected.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportSelected.Name = "btnExportSelected";
            this.btnExportSelected.Size = new System.Drawing.Size(145, 23);
            this.btnExportSelected.TabIndex = 3;
            this.btnExportSelected.Text = "Export Selected";
            this.btnExportSelected.UseSelectable = true;
            this.btnExportSelected.Click += new System.EventHandler(this.btnExportSelected_Click);
            // 
            // btnExportAll
            // 
            this.btnExportAll.Location = new System.Drawing.Point(473, 239);
            this.btnExportAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportAll.Name = "btnExportAll";
            this.btnExportAll.Size = new System.Drawing.Size(145, 23);
            this.btnExportAll.TabIndex = 4;
            this.btnExportAll.Text = "Export All";
            this.btnExportAll.UseSelectable = true;
            this.btnExportAll.Click += new System.EventHandler(this.btnExportAll_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 268);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(606, 23);
            this.progressBar.TabIndex = 5;
            this.progressBar.Visible = false;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(12, 297);
            this.btnImport.Margin = new System.Windows.Forms.Padding(2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(145, 23);
            this.btnImport.TabIndex = 6;
            this.btnImport.Text = "Import from File";
            this.btnImport.UseSelectable = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // chkComboList
            // 
            this.chkComboList.AutoSize = true;
            this.chkComboList.Location = new System.Drawing.Point(163, 301);
            this.chkComboList.Margin = new System.Windows.Forms.Padding(2);
            this.chkComboList.Name = "chkComboList";
            this.chkComboList.Size = new System.Drawing.Size(84, 15);
            this.chkComboList.TabIndex = 7;
            this.chkComboList.Text = "Combo List";
            this.chkComboList.UseSelectable = true;
            this.chkComboList.CheckedChanged += new System.EventHandler(this.chkComboList_CheckedChanged);
            // 
            // grpDelimiter
            // 
            this.grpDelimiter.Controls.Add(this.radSemicolon);
            this.grpDelimiter.Controls.Add(this.radColon);
            this.grpDelimiter.Location = new System.Drawing.Point(12, 326);
            this.grpDelimiter.Margin = new System.Windows.Forms.Padding(2);
            this.grpDelimiter.Name = "grpDelimiter";
            this.grpDelimiter.Padding = new System.Windows.Forms.Padding(2);
            this.grpDelimiter.Size = new System.Drawing.Size(200, 50);
            this.grpDelimiter.TabIndex = 8;
            this.grpDelimiter.TabStop = false;
            this.grpDelimiter.Text = "Delimiter";
            // 
            // radSemicolon
            // 
            this.radSemicolon.AutoSize = true;
            this.radSemicolon.Location = new System.Drawing.Point(100, 19);
            this.radSemicolon.Margin = new System.Windows.Forms.Padding(2);
            this.radSemicolon.Name = "radSemicolon";
            this.radSemicolon.Size = new System.Drawing.Size(79, 15);
            this.radSemicolon.TabIndex = 1;
            this.radSemicolon.Text = "Semicolon";
            this.radSemicolon.UseSelectable = true;
            // 
            // radColon
            // 
            this.radColon.AutoSize = true;
            this.radColon.Checked = true;
            this.radColon.Location = new System.Drawing.Point(6, 19);
            this.radColon.Margin = new System.Windows.Forms.Padding(2);
            this.radColon.Name = "radColon";
            this.radColon.Size = new System.Drawing.Size(55, 15);
            this.radColon.TabIndex = 0;
            this.radColon.TabStop = true;
            this.radColon.Text = "Colon";
            this.radColon.UseSelectable = true;
            // 
            // chkRemovePassword
            // 
            this.chkRemovePassword.AutoSize = true;
            this.chkRemovePassword.Location = new System.Drawing.Point(216, 345);
            this.chkRemovePassword.Margin = new System.Windows.Forms.Padding(2);
            this.chkRemovePassword.Name = "chkRemovePassword";
            this.chkRemovePassword.Size = new System.Drawing.Size(171, 15);
            this.chkRemovePassword.TabIndex = 9;
            this.chkRemovePassword.Text = "Remove password if present";
            this.chkRemovePassword.UseSelectable = true;
            // 
            // dgvCSVPreview
            // 
            this.dgvCSVPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCSVPreview.Location = new System.Drawing.Point(12, 380);
            this.dgvCSVPreview.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCSVPreview.Name = "dgvCSVPreview";
            this.dgvCSVPreview.RowHeadersWidth = 82;
            this.dgvCSVPreview.Size = new System.Drawing.Size(606, 201);
            this.dgvCSVPreview.TabIndex = 11;
            // 
            // cboEmailColumn
            // 
            this.cboEmailColumn.FormattingEnabled = true;
            this.cboEmailColumn.ItemHeight = 23;
            this.cboEmailColumn.Location = new System.Drawing.Point(480, 297);
            this.cboEmailColumn.Margin = new System.Windows.Forms.Padding(2);
            this.cboEmailColumn.Name = "cboEmailColumn";
            this.cboEmailColumn.Size = new System.Drawing.Size(138, 29);
            this.cboEmailColumn.TabIndex = 12;
            this.cboEmailColumn.UseSelectable = true;
            this.cboEmailColumn.Visible = false;
            // 
            // lblEmailColumn
            // 
            this.lblEmailColumn.AutoSize = true;
            this.lblEmailColumn.Location = new System.Drawing.Point(382, 301);
            this.lblEmailColumn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailColumn.Name = "lblEmailColumn";
            this.lblEmailColumn.Size = new System.Drawing.Size(94, 19);
            this.lblEmailColumn.TabIndex = 13;
            this.lblEmailColumn.Text = "Email Column:";
            this.lblEmailColumn.Visible = false;
            // 
            // grpExportFormat
            // 
            this.grpExportFormat.Controls.Add(this.radExportCSV);
            this.grpExportFormat.Controls.Add(this.radExportTXT);
            this.grpExportFormat.Location = new System.Drawing.Point(391, 330);
            this.grpExportFormat.Margin = new System.Windows.Forms.Padding(2);
            this.grpExportFormat.Name = "grpExportFormat";
            this.grpExportFormat.Padding = new System.Windows.Forms.Padding(2);
            this.grpExportFormat.Size = new System.Drawing.Size(125, 46);
            this.grpExportFormat.TabIndex = 14;
            this.grpExportFormat.TabStop = false;
            this.grpExportFormat.Text = "Export Format";
            // 
            // radExportCSV
            // 
            this.radExportCSV.AutoSize = true;
            this.radExportCSV.Checked = true;
            this.radExportCSV.Location = new System.Drawing.Point(6, 19);
            this.radExportCSV.Margin = new System.Windows.Forms.Padding(2);
            this.radExportCSV.Name = "radExportCSV";
            this.radExportCSV.Size = new System.Drawing.Size(44, 15);
            this.radExportCSV.TabIndex = 0;
            this.radExportCSV.TabStop = true;
            this.radExportCSV.Text = "CSV";
            this.radExportCSV.UseSelectable = true;
            // 
            // radExportTXT
            // 
            this.radExportTXT.AutoSize = true;
            this.radExportTXT.Location = new System.Drawing.Point(60, 19);
            this.radExportTXT.Margin = new System.Windows.Forms.Padding(2);
            this.radExportTXT.Name = "radExportTXT";
            this.radExportTXT.Size = new System.Drawing.Size(42, 15);
            this.radExportTXT.TabIndex = 1;
            this.radExportTXT.Text = "TXT";
            this.radExportTXT.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 593);
            this.Controls.Add(this.grpExportFormat);
            this.Controls.Add(this.lblEmailColumn);
            this.Controls.Add(this.cboEmailColumn);
            this.Controls.Add(this.dgvCSVPreview);
            this.Controls.Add(this.chkRemovePassword);
            this.Controls.Add(this.grpDelimiter);
            this.Controls.Add(this.chkComboList);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnExportAll);
            this.Controls.Add(this.btnExportSelected);
            this.Controls.Add(this.lstEmailGroups);
            this.Controls.Add(this.btnSplitEmails);
            this.Controls.Add(this.txtEmailList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10, 60, 10, 10);
            this.Text = "Split Mail Pro";
            this.grpDelimiter.ResumeLayout(false);
            this.grpDelimiter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSVPreview)).EndInit();
            this.grpExportFormat.ResumeLayout(false);
            this.grpExportFormat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtEmailList;
        private MetroFramework.Controls.MetroButton btnSplitEmails;
        private System.Windows.Forms.ListBox lstEmailGroups;
        private MetroFramework.Controls.MetroButton btnExportSelected;
        private MetroFramework.Controls.MetroButton btnExportAll;
        private MetroFramework.Controls.MetroProgressBar progressBar;
        private MetroFramework.Controls.MetroButton btnImport;
        private MetroFramework.Controls.MetroCheckBox chkComboList;
        private System.Windows.Forms.GroupBox grpDelimiter;
        private MetroFramework.Controls.MetroRadioButton radSemicolon;
        private MetroFramework.Controls.MetroRadioButton radColon;
        private MetroFramework.Controls.MetroCheckBox chkRemovePassword;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridView dgvCSVPreview;
        private MetroFramework.Controls.MetroComboBox cboEmailColumn;
        private MetroFramework.Controls.MetroLabel lblEmailColumn;
        private System.Windows.Forms.GroupBox grpExportFormat;
        private MetroFramework.Controls.MetroRadioButton radExportCSV;
        private MetroFramework.Controls.MetroRadioButton radExportTXT;
    }
}

