
namespace Neptuno.Views
{
    partial class FrmMain
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
            this.ucUser = new Neptuno.Views.controls.ucUser();
            this.ucUnit = new Neptuno.Views.controls.ucUnit();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.gnMainContent = new System.Windows.Forms.GroupBox();
            this.toolTip_ES = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_EN = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ucUser
            // 
            this.ucUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ucUser.BackColor = System.Drawing.Color.Transparent;
            this.ucUser.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucUser.Location = new System.Drawing.Point(1, 503);
            this.ucUser.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ucUser.Name = "ucUser";
            this.ucUser.Size = new System.Drawing.Size(261, 49);
            this.ucUser.TabIndex = 4;
            // 
            // ucUnit
            // 
            this.ucUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ucUnit.BackColor = System.Drawing.Color.Transparent;
            this.ucUnit.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucUnit.Location = new System.Drawing.Point(272, 503);
            this.ucUnit.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ucUnit.Name = "ucUnit";
            this.ucUnit.Size = new System.Drawing.Size(261, 49);
            this.ucUnit.TabIndex = 8;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = global::Neptuno.Views.Properties.Resources.settings;
            this.btnSettings.Location = new System.Drawing.Point(670, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(80, 80);
            this.btnSettings.TabIndex = 9;
            this.toolTip_ES.SetToolTip(this.btnSettings, "Configuración");
            this.toolTip_EN.SetToolTip(this.btnSettings, "Settings");
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Image = global::Neptuno.Views.Properties.Resources.profile;
            this.btnProfile.Location = new System.Drawing.Point(584, 12);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(80, 80);
            this.btnProfile.TabIndex = 10;
            this.toolTip_ES.SetToolTip(this.btnProfile, "Perfil");
            this.toolTip_EN.SetToolTip(this.btnProfile, "Profile");
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // gnMainContent
            // 
            this.gnMainContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gnMainContent.BackColor = System.Drawing.Color.Transparent;
            this.gnMainContent.Location = new System.Drawing.Point(8, 98);
            this.gnMainContent.Name = "gnMainContent";
            this.gnMainContent.Size = new System.Drawing.Size(738, 399);
            this.gnMainContent.TabIndex = 11;
            this.gnMainContent.TabStop = false;
            // 
            // toolTip_ES
            // 
            this.toolTip_ES.Active = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 554);
            this.Controls.Add(this.gnMainContent);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.ucUnit);
            this.Controls.Add(this.ucUser);
            this.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "FrmMain";
            this.Text = "Neptuno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private controls.ucUser ucUser;
        private controls.ucUnit ucUnit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.GroupBox gnMainContent;
        private System.Windows.Forms.ToolTip toolTip_ES;
        private System.Windows.Forms.ToolTip toolTip_EN;
    }
}