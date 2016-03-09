namespace AnalyseAccessPermission
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filteredLst = new System.Windows.Forms.ListBox();
            this.Users = new System.Windows.Forms.GroupBox();
            this.errorLst = new System.Windows.Forms.ListBox();
            this.debugLst = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lsGroup1 = new System.Windows.Forms.TextBox();
            this.importUsersBtn = new System.Windows.Forms.Button();
            this.lsGroup2 = new System.Windows.Forms.TextBox();
            this.lsGroup3 = new System.Windows.Forms.TextBox();
            this.lsGroup4 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.Users.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filteredLst);
            this.groupBox1.Location = new System.Drawing.Point(12, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Users";
            // 
            // filteredLst
            // 
            this.filteredLst.FormattingEnabled = true;
            this.filteredLst.Location = new System.Drawing.Point(7, 16);
            this.filteredLst.Name = "filteredLst";
            this.filteredLst.Size = new System.Drawing.Size(671, 186);
            this.filteredLst.TabIndex = 1;
            // 
            // Users
            // 
            this.Users.Controls.Add(this.errorLst);
            this.Users.Controls.Add(this.debugLst);
            this.Users.Location = new System.Drawing.Point(12, 364);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(685, 227);
            this.Users.TabIndex = 1;
            this.Users.TabStop = false;
            this.Users.Text = "Status";
            // 
            // errorLst
            // 
            this.errorLst.FormattingEnabled = true;
            this.errorLst.Location = new System.Drawing.Point(346, 20);
            this.errorLst.Name = "errorLst";
            this.errorLst.Size = new System.Drawing.Size(332, 199);
            this.errorLst.TabIndex = 1;
            // 
            // debugLst
            // 
            this.debugLst.FormattingEnabled = true;
            this.debugLst.Location = new System.Drawing.Point(7, 20);
            this.debugLst.Name = "debugLst";
            this.debugLst.Size = new System.Drawing.Size(333, 199);
            this.debugLst.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lsGroup4);
            this.groupBox3.Controls.Add(this.importUsersBtn);
            this.groupBox3.Controls.Add(this.lsGroup3);
            this.groupBox3.Controls.Add(this.lsGroup2);
            this.groupBox3.Controls.Add(this.lsGroup1);
            this.groupBox3.Location = new System.Drawing.Point(12, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(685, 131);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Groups";
            // 
            // lsGroup1
            // 
            this.lsGroup1.Location = new System.Drawing.Point(7, 20);
            this.lsGroup1.Name = "lsGroup1";
            this.lsGroup1.Size = new System.Drawing.Size(514, 20);
            this.lsGroup1.TabIndex = 0;
            // 
            // importUsersBtn
            // 
            this.importUsersBtn.Location = new System.Drawing.Point(527, 20);
            this.importUsersBtn.Name = "importUsersBtn";
            this.importUsersBtn.Size = new System.Drawing.Size(151, 98);
            this.importUsersBtn.TabIndex = 5;
            this.importUsersBtn.Text = "Import and Correlate";
            this.importUsersBtn.UseVisualStyleBackColor = true;
            this.importUsersBtn.Click += new System.EventHandler(this.getgroupsBtn_Click);
            // 
            // lsGroup2
            // 
            this.lsGroup2.Location = new System.Drawing.Point(7, 46);
            this.lsGroup2.Name = "lsGroup2";
            this.lsGroup2.Size = new System.Drawing.Size(514, 20);
            this.lsGroup2.TabIndex = 3;
            // 
            // lsGroup3
            // 
            this.lsGroup3.Location = new System.Drawing.Point(7, 72);
            this.lsGroup3.Name = "lsGroup3";
            this.lsGroup3.Size = new System.Drawing.Size(514, 20);
            this.lsGroup3.TabIndex = 4;
            // 
            // lsGroup4
            // 
            this.lsGroup4.Location = new System.Drawing.Point(7, 98);
            this.lsGroup4.Name = "lsGroup4";
            this.lsGroup4.Size = new System.Drawing.Size(514, 20);
            this.lsGroup4.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 609);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Group Member Analysis (by Patrick Schmid)";
            this.groupBox1.ResumeLayout(false);
            this.Users.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Users;
        private System.Windows.Forms.ListBox debugLst;
        private System.Windows.Forms.ListBox filteredLst;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox lsGroup1;
        private System.Windows.Forms.Button importUsersBtn;
        private System.Windows.Forms.ListBox errorLst;
        private System.Windows.Forms.TextBox lsGroup4;
        private System.Windows.Forms.TextBox lsGroup3;
        private System.Windows.Forms.TextBox lsGroup2;
    }
}

