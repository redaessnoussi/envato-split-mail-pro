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
            this.txtEmailList = new System.Windows.Forms.TextBox();
            this.btnSplitEmails = new System.Windows.Forms.Button();
            this.lstEmailGroups = new System.Windows.Forms.ListBox();
            this.btnExportSelected = new System.Windows.Forms.Button();
            this.btnExportAll = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnImport = new System.Windows.Forms.Button();
            this.chkComboList = new System.Windows.Forms.CheckBox();
            this.grpDelimiter = new System.Windows.Forms.GroupBox();
            this.radSemicolon = new System.Windows.Forms.RadioButton();
            this.radColon = new System.Windows.Forms.RadioButton();
            this.chkRemovePassword = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dgvCSVPreview = new System.Windows.Forms.DataGridView();
            this.cboEmailColumn = new System.Windows.Forms.ComboBox();
            this.lblEmailColumn = new System.Windows.Forms.Label();
            this.grpExportFormat = new System.Windows.Forms.GroupBox();
            this.radExportCSV = new System.Windows.Forms.RadioButton();
            this.radExportTXT = new System.Windows.Forms.RadioButton();
            this.grpDelimiter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSVPreview)).BeginInit();
            this.grpExportFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmailList
            // 
            this.txtEmailList.Location = new System.Drawing.Point(24, 23);
            this.txtEmailList.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmailList.Multiline = true;
            this.txtEmailList.Name = "txtEmailList";
            this.txtEmailList.Size = new System.Drawing.Size(596, 381);
            this.txtEmailList.TabIndex = 0;
            this.txtEmailList.TextChanged += new System.EventHandler(this.txtEmailList_TextChanged);
            // 
            // btnSplitEmails
            // 
            this.btnSplitEmails.Location = new System.Drawing.Point(24, 419);
            this.btnSplitEmails.Margin = new System.Windows.Forms.Padding(6);
            this.btnSplitEmails.Name = "btnSplitEmails";
            this.btnSplitEmails.Size = new System.Drawing.Size(600, 44);
            this.btnSplitEmails.TabIndex = 15;
            this.btnSplitEmails.Text = "Split Emails";
            this.btnSplitEmails.UseVisualStyleBackColor = true;
            this.btnSplitEmails.Click += new System.EventHandler(this.btnSplitEmails_Click);
            // 
            // lstEmailGroups
            // 
            this.lstEmailGroups.FormattingEnabled = true;
            this.lstEmailGroups.ItemHeight = 25;
            this.lstEmailGroups.Location = new System.Drawing.Point(636, 23);
            this.lstEmailGroups.Margin = new System.Windows.Forms.Padding(6);
            this.lstEmailGroups.Name = "lstEmailGroups";
            this.lstEmailGroups.Size = new System.Drawing.Size(596, 379);
            this.lstEmailGroups.TabIndex = 2;
            // 
            // btnExportSelected
            // 
            this.btnExportSelected.Location = new System.Drawing.Point(636, 419);
            this.btnExportSelected.Margin = new System.Windows.Forms.Padding(6);
            this.btnExportSelected.Name = "btnExportSelected";
            this.btnExportSelected.Size = new System.Drawing.Size(290, 44);
            this.btnExportSelected.TabIndex = 3;
            this.btnExportSelected.Text = "Export Selected";
            this.btnExportSelected.UseVisualStyleBackColor = true;
            this.btnExportSelected.Click += new System.EventHandler(this.btnExportSelected_Click);
            // 
            // btnExportAll
            // 
            this.btnExportAll.Location = new System.Drawing.Point(946, 419);
            this.btnExportAll.Margin = new System.Windows.Forms.Padding(6);
            this.btnExportAll.Name = "btnExportAll";
            this.btnExportAll.Size = new System.Drawing.Size(290, 44);
            this.btnExportAll.TabIndex = 4;
            this.btnExportAll.Text = "Export All";
            this.btnExportAll.UseVisualStyleBackColor = true;
            this.btnExportAll.Click += new System.EventHandler(this.btnExportAll_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(24, 475);
            this.progressBar.Margin = new System.Windows.Forms.Padding(6);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1212, 44);
            this.progressBar.TabIndex = 5;
            this.progressBar.Visible = false;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(24, 531);
            this.btnImport.Margin = new System.Windows.Forms.Padding(6);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(290, 44);
            this.btnImport.TabIndex = 6;
            this.btnImport.Text = "Import from File";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // chkComboList
            // 
            this.chkComboList.AutoSize = true;
            this.chkComboList.Location = new System.Drawing.Point(326, 538);
            this.chkComboList.Margin = new System.Windows.Forms.Padding(6);
            this.chkComboList.Name = "chkComboList";
            this.chkComboList.Size = new System.Drawing.Size(152, 29);
            this.chkComboList.TabIndex = 7;
            this.chkComboList.Text = "Combo List";
            this.chkComboList.UseVisualStyleBackColor = true;
            this.chkComboList.CheckedChanged += new System.EventHandler(this.chkComboList_CheckedChanged);
            // 
            // grpDelimiter
            // 
            this.grpDelimiter.Controls.Add(this.radSemicolon);
            this.grpDelimiter.Controls.Add(this.radColon);
            this.grpDelimiter.Location = new System.Drawing.Point(24, 587);
            this.grpDelimiter.Margin = new System.Windows.Forms.Padding(6);
            this.grpDelimiter.Name = "grpDelimiter";
            this.grpDelimiter.Padding = new System.Windows.Forms.Padding(6);
            this.grpDelimiter.Size = new System.Drawing.Size(400, 96);
            this.grpDelimiter.TabIndex = 8;
            this.grpDelimiter.TabStop = false;
            this.grpDelimiter.Text = "Delimiter";
            // 
            // radSemicolon
            // 
            this.radSemicolon.AutoSize = true;
            this.radSemicolon.Location = new System.Drawing.Point(200, 37);
            this.radSemicolon.Margin = new System.Windows.Forms.Padding(6);
            this.radSemicolon.Name = "radSemicolon";
            this.radSemicolon.Size = new System.Drawing.Size(143, 29);
            this.radSemicolon.TabIndex = 1;
            this.radSemicolon.Text = "Semicolon";
            this.radSemicolon.UseVisualStyleBackColor = true;
            // 
            // radColon
            // 
            this.radColon.AutoSize = true;
            this.radColon.Checked = true;
            this.radColon.Location = new System.Drawing.Point(12, 37);
            this.radColon.Margin = new System.Windows.Forms.Padding(6);
            this.radColon.Name = "radColon";
            this.radColon.Size = new System.Drawing.Size(99, 29);
            this.radColon.TabIndex = 0;
            this.radColon.TabStop = true;
            this.radColon.Text = "Colon";
            this.radColon.UseVisualStyleBackColor = true;
            // 
            // chkRemovePassword
            // 
            this.chkRemovePassword.AutoSize = true;
            this.chkRemovePassword.Location = new System.Drawing.Point(436, 623);
            this.chkRemovePassword.Margin = new System.Windows.Forms.Padding(6);
            this.chkRemovePassword.Name = "chkRemovePassword";
            this.chkRemovePassword.Size = new System.Drawing.Size(316, 29);
            this.chkRemovePassword.TabIndex = 9;
            this.chkRemovePassword.Text = "Remove password if present";
            this.chkRemovePassword.UseVisualStyleBackColor = true;
            // 
            // dgvCSVPreview
            // 
            this.dgvCSVPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCSVPreview.Location = new System.Drawing.Point(24, 694);
            this.dgvCSVPreview.Margin = new System.Windows.Forms.Padding(6);
            this.dgvCSVPreview.Name = "dgvCSVPreview";
            this.dgvCSVPreview.RowHeadersWidth = 82;
            this.dgvCSVPreview.Size = new System.Drawing.Size(1212, 288);
            this.dgvCSVPreview.TabIndex = 11;
            // 
            // cboEmailColumn
            // 
            this.cboEmailColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmailColumn.FormattingEnabled = true;
            this.cboEmailColumn.Location = new System.Drawing.Point(960, 531);
            this.cboEmailColumn.Margin = new System.Windows.Forms.Padding(6);
            this.cboEmailColumn.Name = "cboEmailColumn";
            this.cboEmailColumn.Size = new System.Drawing.Size(276, 33);
            this.cboEmailColumn.TabIndex = 12;
            this.cboEmailColumn.Visible = false;
            // 
            // lblEmailColumn
            // 
            this.lblEmailColumn.AutoSize = true;
            this.lblEmailColumn.Location = new System.Drawing.Point(798, 534);
            this.lblEmailColumn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmailColumn.Name = "lblEmailColumn";
            this.lblEmailColumn.Size = new System.Drawing.Size(150, 25);
            this.lblEmailColumn.TabIndex = 13;
            this.lblEmailColumn.Text = "Email Column:";
            this.lblEmailColumn.Visible = false;
            // 
            // grpExportFormat
            // 
            this.grpExportFormat.Controls.Add(this.radExportCSV);
            this.grpExportFormat.Controls.Add(this.radExportTXT);
            this.grpExportFormat.Location = new System.Drawing.Point(758, 587);
            this.grpExportFormat.Name = "grpExportFormat";
            this.grpExportFormat.Size = new System.Drawing.Size(250, 96);
            this.grpExportFormat.TabIndex = 14;
            this.grpExportFormat.TabStop = false;
            this.grpExportFormat.Text = "Export Format";
            // 
            // radExportCSV
            // 
            this.radExportCSV.AutoSize = true;
            this.radExportCSV.Checked = true;
            this.radExportCSV.Location = new System.Drawing.Point(12, 37);
            this.radExportCSV.Name = "radExportCSV";
            this.radExportCSV.Size = new System.Drawing.Size(86, 29);
            this.radExportCSV.TabIndex = 0;
            this.radExportCSV.TabStop = true;
            this.radExportCSV.Text = "CSV";
            this.radExportCSV.UseVisualStyleBackColor = true;
            // 
            // radExportTXT
            // 
            this.radExportTXT.AutoSize = true;
            this.radExportTXT.Location = new System.Drawing.Point(120, 37);
            this.radExportTXT.Name = "radExportTXT";
            this.radExportTXT.Size = new System.Drawing.Size(83, 29);
            this.radExportTXT.TabIndex = 1;
            this.radExportTXT.Text = "TXT";
            this.radExportTXT.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 1006);
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
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "SplitMail Pro";
            this.grpDelimiter.ResumeLayout(false);
            this.grpDelimiter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSVPreview)).EndInit();
            this.grpExportFormat.ResumeLayout(false);
            this.grpExportFormat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmailList;
        private System.Windows.Forms.Button btnSplitEmails;
        private System.Windows.Forms.ListBox lstEmailGroups;
        private System.Windows.Forms.Button btnExportSelected;
        private System.Windows.Forms.Button btnExportAll;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.CheckBox chkComboList;
        private System.Windows.Forms.GroupBox grpDelimiter;
        private System.Windows.Forms.RadioButton radSemicolon;
        private System.Windows.Forms.RadioButton radColon;
        private System.Windows.Forms.CheckBox chkRemovePassword;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridView dgvCSVPreview;
        private System.Windows.Forms.ComboBox cboEmailColumn;
        private System.Windows.Forms.Label lblEmailColumn;
        private System.Windows.Forms.GroupBox grpExportFormat;
        private System.Windows.Forms.RadioButton radExportCSV;
        private System.Windows.Forms.RadioButton radExportTXT;
    }
}