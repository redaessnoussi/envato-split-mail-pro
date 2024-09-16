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
            this.SuspendLayout();
            // 
            // txtEmailList
            // 
            this.txtEmailList.Location = new System.Drawing.Point(12, 12);
            this.txtEmailList.Multiline = true;
            this.txtEmailList.Name = "txtEmailList";
            this.txtEmailList.Size = new System.Drawing.Size(300, 200);
            this.txtEmailList.TabIndex = 0;
            // 
            // btnSplitEmails
            // 
            this.btnSplitEmails.Location = new System.Drawing.Point(12, 218);
            this.btnSplitEmails.Name = "btnSplitEmails";
            this.btnSplitEmails.Size = new System.Drawing.Size(300, 23);
            this.btnSplitEmails.TabIndex = 1;
            this.btnSplitEmails.Text = "Split Emails";
            this.btnSplitEmails.UseVisualStyleBackColor = true;
            this.btnSplitEmails.Click += new System.EventHandler(this.btnSplitEmails_Click);
            // 
            // lstEmailGroups
            // 
            this.lstEmailGroups.FormattingEnabled = true;
            this.lstEmailGroups.Location = new System.Drawing.Point(318, 12);
            this.lstEmailGroups.Name = "lstEmailGroups";
            this.lstEmailGroups.Size = new System.Drawing.Size(300, 200);
            this.lstEmailGroups.TabIndex = 2;
            // 
            // btnExportSelected
            // 
            this.btnExportSelected.Location = new System.Drawing.Point(318, 218);
            this.btnExportSelected.Name = "btnExportSelected";
            this.btnExportSelected.Size = new System.Drawing.Size(145, 23);
            this.btnExportSelected.TabIndex = 3;
            this.btnExportSelected.Text = "Export Selected";
            this.btnExportSelected.UseVisualStyleBackColor = true;
            this.btnExportSelected.Click += new System.EventHandler(this.btnExportSelected_Click);
            // 
            // btnExportAll
            // 
            this.btnExportAll.Location = new System.Drawing.Point(473, 218);
            this.btnExportAll.Name = "btnExportAll";
            this.btnExportAll.Size = new System.Drawing.Size(145, 23);
            this.btnExportAll.TabIndex = 4;
            this.btnExportAll.Text = "Export All";
            this.btnExportAll.UseVisualStyleBackColor = true;
            this.btnExportAll.Click += new System.EventHandler(this.btnExportAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 261);
            this.Controls.Add(this.btnExportAll);
            this.Controls.Add(this.btnExportSelected);
            this.Controls.Add(this.lstEmailGroups);
            this.Controls.Add(this.btnSplitEmails);
            this.Controls.Add(this.txtEmailList);
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
    }
}