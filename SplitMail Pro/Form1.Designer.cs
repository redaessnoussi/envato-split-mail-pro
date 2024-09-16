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
            this.txtEmailList = new System.Windows.Forms.TextBox();
            this.btnSplitEmails = new System.Windows.Forms.Button();
            this.lstEmailGroups = new System.Windows.Forms.ListBox();
            this.btnExportSelected = new System.Windows.Forms.Button();
            this.btnExportAll = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnImport = new System.Windows.Forms.Button();
            this.chkComboList = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtEmailList
            // 
            this.txtEmailList.Location = new System.Drawing.Point(24, 23);
            this.txtEmailList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtEmailList.Multiline = true;
            this.txtEmailList.Name = "txtEmailList";
            this.txtEmailList.Size = new System.Drawing.Size(596, 381);
            this.txtEmailList.TabIndex = 0;
            // 
            // btnSplitEmails
            // 
            this.btnSplitEmails.Location = new System.Drawing.Point(757, 531);
            this.btnSplitEmails.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSplitEmails.Name = "btnSplitEmails";
            this.btnSplitEmails.Size = new System.Drawing.Size(479, 44);
            this.btnSplitEmails.TabIndex = 1;
            this.btnSplitEmails.Text = "Split Emails";
            this.btnSplitEmails.UseVisualStyleBackColor = true;
            this.btnSplitEmails.Click += new System.EventHandler(this.btnSplitEmails_Click);
            // 
            // lstEmailGroups
            // 
            this.lstEmailGroups.FormattingEnabled = true;
            this.lstEmailGroups.ItemHeight = 25;
            this.lstEmailGroups.Location = new System.Drawing.Point(636, 23);
            this.lstEmailGroups.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstEmailGroups.Name = "lstEmailGroups";
            this.lstEmailGroups.Size = new System.Drawing.Size(596, 379);
            this.lstEmailGroups.TabIndex = 2;
            // 
            // btnExportSelected
            // 
            this.btnExportSelected.Location = new System.Drawing.Point(636, 419);
            this.btnExportSelected.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.btnExportAll.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.progressBar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1212, 44);
            this.progressBar.TabIndex = 5;
            this.progressBar.Visible = false;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(24, 419);
            this.btnImport.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.chkComboList.Location = new System.Drawing.Point(163, 280);
            this.chkComboList.Name = "chkComboList";
            this.chkComboList.Size = new System.Drawing.Size(79, 17);
            this.chkComboList.TabIndex = 7;
            this.chkComboList.Text = "Combo List";
            this.chkComboList.UseVisualStyleBackColor = true;
            this.chkComboList.CheckedChanged += new System.EventHandler(this.chkComboList_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 608);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnExportAll);
            this.Controls.Add(this.btnExportSelected);
            this.Controls.Add(this.lstEmailGroups);
            this.Controls.Add(this.btnSplitEmails);
            this.Controls.Add(this.txtEmailList);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "SplitMail Pro";
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

    }
}