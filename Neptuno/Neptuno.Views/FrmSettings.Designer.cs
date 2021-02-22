
namespace Neptuno.Views
{
    partial class FrmSettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDatabase = new System.Windows.Forms.RadioButton();
            this.rbGeneral = new System.Windows.Forms.RadioButton();
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbDatabase = new System.Windows.Forms.GroupBox();
            this.txtDbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtDbUser = new System.Windows.Forms.TextBox();
            this.lblDbUser = new System.Windows.Forms.Label();
            this.txtDbName = new System.Windows.Forms.TextBox();
            this.lblDbName = new System.Windows.Forms.Label();
            this.txtDbPort = new System.Windows.Forms.TextBox();
            this.lblDbPort = new System.Windows.Forms.Label();
            this.txtDbHost = new System.Windows.Forms.TextBox();
            this.lblDbHost = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbGeneral.SuspendLayout();
            this.gbDatabase.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbDatabase);
            this.groupBox1.Controls.Add(this.rbGeneral);
            this.groupBox1.Location = new System.Drawing.Point(20, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(258, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Sections  ";
            // 
            // rbDatabase
            // 
            this.rbDatabase.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbDatabase.Location = new System.Drawing.Point(37, 98);
            this.rbDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.rbDatabase.Name = "rbDatabase";
            this.rbDatabase.Size = new System.Drawing.Size(190, 30);
            this.rbDatabase.TabIndex = 1;
            this.rbDatabase.TabStop = true;
            this.rbDatabase.Text = "Database";
            this.rbDatabase.UseVisualStyleBackColor = true;
            this.rbDatabase.CheckedChanged += new System.EventHandler(this.SectionChanged);
            // 
            // rbGeneral
            // 
            this.rbGeneral.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbGeneral.Location = new System.Drawing.Point(37, 42);
            this.rbGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.rbGeneral.Name = "rbGeneral";
            this.rbGeneral.Size = new System.Drawing.Size(190, 30);
            this.rbGeneral.TabIndex = 0;
            this.rbGeneral.TabStop = true;
            this.rbGeneral.Text = "General";
            this.rbGeneral.UseVisualStyleBackColor = true;
            this.rbGeneral.CheckedChanged += new System.EventHandler(this.SectionChanged);
            // 
            // gbGeneral
            // 
            this.gbGeneral.BackColor = System.Drawing.Color.Transparent;
            this.gbGeneral.Controls.Add(this.cmbLanguage);
            this.gbGeneral.Controls.Add(this.lblLanguage);
            this.gbGeneral.Location = new System.Drawing.Point(309, 15);
            this.gbGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Padding = new System.Windows.Forms.Padding(4);
            this.gbGeneral.Size = new System.Drawing.Size(383, 72);
            this.gbGeneral.TabIndex = 1;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Text = " General  ";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(148, 33);
            this.cmbLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(179, 24);
            this.cmbLanguage.TabIndex = 1;
            // 
            // lblLanguage
            // 
            this.lblLanguage.Location = new System.Drawing.Point(33, 35);
            this.lblLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(107, 21);
            this.lblLanguage.TabIndex = 0;
            this.lblLanguage.Text = "Language:";
            this.lblLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(569, 226);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 28);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(20, 226);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 28);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbDatabase
            // 
            this.gbDatabase.BackColor = System.Drawing.Color.Transparent;
            this.gbDatabase.Controls.Add(this.txtDbPassword);
            this.gbDatabase.Controls.Add(this.lblPassword);
            this.gbDatabase.Controls.Add(this.txtDbUser);
            this.gbDatabase.Controls.Add(this.lblDbUser);
            this.gbDatabase.Controls.Add(this.txtDbName);
            this.gbDatabase.Controls.Add(this.lblDbName);
            this.gbDatabase.Controls.Add(this.txtDbPort);
            this.gbDatabase.Controls.Add(this.lblDbPort);
            this.gbDatabase.Controls.Add(this.txtDbHost);
            this.gbDatabase.Controls.Add(this.lblDbHost);
            this.gbDatabase.Location = new System.Drawing.Point(310, 95);
            this.gbDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatabase.Name = "gbDatabase";
            this.gbDatabase.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatabase.Size = new System.Drawing.Size(383, 118);
            this.gbDatabase.TabIndex = 4;
            this.gbDatabase.TabStop = false;
            this.gbDatabase.Text = " Database  ";
            // 
            // txtDbPassword
            // 
            this.txtDbPassword.Location = new System.Drawing.Point(148, 147);
            this.txtDbPassword.MaxLength = 50;
            this.txtDbPassword.Name = "txtDbPassword";
            this.txtDbPassword.PasswordChar = '*';
            this.txtDbPassword.Size = new System.Drawing.Size(179, 23);
            this.txtDbPassword.TabIndex = 10;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(21, 148);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(107, 21);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDbUser
            // 
            this.txtDbUser.Location = new System.Drawing.Point(148, 118);
            this.txtDbUser.MaxLength = 50;
            this.txtDbUser.Name = "txtDbUser";
            this.txtDbUser.Size = new System.Drawing.Size(179, 23);
            this.txtDbUser.TabIndex = 8;
            // 
            // lblDbUser
            // 
            this.lblDbUser.Location = new System.Drawing.Point(21, 119);
            this.lblDbUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDbUser.Name = "lblDbUser";
            this.lblDbUser.Size = new System.Drawing.Size(107, 21);
            this.lblDbUser.TabIndex = 7;
            this.lblDbUser.Text = "User:";
            this.lblDbUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDbName
            // 
            this.txtDbName.Location = new System.Drawing.Point(148, 89);
            this.txtDbName.MaxLength = 50;
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.Size = new System.Drawing.Size(179, 23);
            this.txtDbName.TabIndex = 6;
            // 
            // lblDbName
            // 
            this.lblDbName.Location = new System.Drawing.Point(21, 90);
            this.lblDbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDbName.Name = "lblDbName";
            this.lblDbName.Size = new System.Drawing.Size(107, 21);
            this.lblDbName.TabIndex = 5;
            this.lblDbName.Text = "Database:";
            this.lblDbName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDbPort
            // 
            this.txtDbPort.Location = new System.Drawing.Point(148, 60);
            this.txtDbPort.MaxLength = 5;
            this.txtDbPort.Name = "txtDbPort";
            this.txtDbPort.Size = new System.Drawing.Size(179, 23);
            this.txtDbPort.TabIndex = 4;
            // 
            // lblDbPort
            // 
            this.lblDbPort.Location = new System.Drawing.Point(21, 61);
            this.lblDbPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDbPort.Name = "lblDbPort";
            this.lblDbPort.Size = new System.Drawing.Size(107, 21);
            this.lblDbPort.TabIndex = 3;
            this.lblDbPort.Text = "Port:";
            this.lblDbPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDbHost
            // 
            this.txtDbHost.Location = new System.Drawing.Point(148, 31);
            this.txtDbHost.MaxLength = 50;
            this.txtDbHost.Name = "txtDbHost";
            this.txtDbHost.Size = new System.Drawing.Size(179, 23);
            this.txtDbHost.TabIndex = 2;
            // 
            // lblDbHost
            // 
            this.lblDbHost.Location = new System.Drawing.Point(21, 32);
            this.lblDbHost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDbHost.Name = "lblDbHost";
            this.lblDbHost.Size = new System.Drawing.Size(107, 21);
            this.lblDbHost.TabIndex = 1;
            this.lblDbHost.Text = "Server:";
            this.lblDbHost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Neptuno.Views.Properties.Resources.background_blue_01;
            this.ClientSize = new System.Drawing.Size(713, 268);
            this.Controls.Add(this.gbDatabase);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbGeneral);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Orbitron", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSettings_FormClosed);
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbGeneral.ResumeLayout(false);
            this.gbDatabase.ResumeLayout(false);
            this.gbDatabase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDatabase;
        private System.Windows.Forms.RadioButton rbGeneral;
        private System.Windows.Forms.GroupBox gbGeneral;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.GroupBox gbDatabase;
        private System.Windows.Forms.TextBox txtDbHost;
        private System.Windows.Forms.Label lblDbHost;
        private System.Windows.Forms.TextBox txtDbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtDbUser;
        private System.Windows.Forms.Label lblDbUser;
        private System.Windows.Forms.TextBox txtDbName;
        private System.Windows.Forms.Label lblDbName;
        private System.Windows.Forms.TextBox txtDbPort;
        private System.Windows.Forms.Label lblDbPort;
    }
}