using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

using Neptuno.Views.domain;
using Neptuno.Views.helpers;

namespace Neptuno.Views
{
    public partial class FrmSettings : FrmBase
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        public FrmSettings(IConfiguratorHelper config)
        {
            InitializeComponent();

            _config = config;
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            ConfigurePanels();
            HookButtonEvents();

            LoadLanguageList();
            LoadData();
        }

        private void FrmSettings_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_config != null)
            {
                switch (cmbLanguage.SelectedValue)
                {
                    case (int)LANGUAGE.SPANISH:
                        _config.Language = LANGUAGE.SPANISH;
                        break;
                    case (int)LANGUAGE.ENGLISH:
                        _config.Language = LANGUAGE.ENGLISH;
                        break;
                    case (int)LANGUAGE.FRENCH:
                        _config.Language = LANGUAGE.FRENCH;
                        break;
                }

                _config.DbHost = txtDbHost.Text.Trim();
                _config.DbPort = txtDbPort.Text.Trim();
                _config.DbName = txtDbName.Text.Trim();
                _config.DbUser = txtDbUser.Text.Trim();
                _config.DbPassword = txtDbPassword.Text.Trim();

                _config.SaveConfiguration();

                Close();
            }
        }

        private void SectionChanged(object sender, EventArgs e)
        {
            gbGeneral.Visible = rbGeneral.Checked;
            gbDatabase.Visible = rbDatabase.Checked;
        }

        private void ConfigurePanels()
        {
            rbDatabase.Checked = rbGeneral.Checked = false;

            gbDatabase.Visible = gbGeneral.Visible = false;
            gbGeneral.Location = gbDatabase.Location = new Point(309,15);
            gbGeneral.Size = gbDatabase.Size = new Size(383, 204);
        }

        private void LoadData()
        {
            if (_config == null)
                ClearData();
            else
            {
                txtDbHost.Text = _config.DbHost;
                txtDbPort.Text = _config.DbPort;
                txtDbName.Text = _config.DbName;
                txtDbUser.Text = _config.DbUser;
                txtDbPassword.Text = _config.DbPassword;

                cmbLanguage.SelectedValue = (int)_config.Language;
            }
        }

        public void LoadLanguageList()
        {
            var languageList = new List<KeyValuePair<int, string>>()
            {
                new KeyValuePair<int, string>((int)LANGUAGE.SPANISH, LANGUAGE.SPANISH.ToString()),
                new KeyValuePair<int, string>((int)LANGUAGE.ENGLISH, LANGUAGE.ENGLISH.ToString()),
                new KeyValuePair<int, string>((int)LANGUAGE.FRENCH, LANGUAGE.FRENCH.ToString()),
            };

            cmbLanguage.DataSource = languageList;
            cmbLanguage.DisplayMember = "Value";
            cmbLanguage.ValueMember = "Key";
        }

        private void ClearData()
        {
            txtDbHost.Text = txtDbPort.Text = txtDbName.Text = txtDbUser.Text = txtDbPassword.Text = string.Empty;
        }

        private void HookButtonEvents()
        {
            btnCancel.MouseEnter += MouseEnter;
            btnCancel.MouseLeave += MouseLeave;

            btnSave.MouseEnter += MouseEnter;
            btnSave.MouseLeave += MouseLeave;
        }
    }
}
