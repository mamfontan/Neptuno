using Neptuno.Views.helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neptuno.Views
{
    public partial class FrmLogin : FrmBase
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public FrmLogin(IConfiguratorHelper config)
        {
            InitializeComponent();

            _config = config;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            HookButtonEvents();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var form = new FrmSettings(_config);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var form = new FrmMain(_config);
            form.Show();

            this.Hide();
        }

        private void CheckFormStatus(object sender, EventArgs e)
        {
            btnLogin.Enabled = txtUser.Text.Trim().Length > 0 && txtPassword.Text.Trim().Length > 0;
        }

        private void HookButtonEvents()
        {
            btnLogin.MouseEnter += MouseEnter;
            btnLogin.MouseLeave += MouseLeave;

            btnSettings.MouseEnter += MouseEnter;
            btnSettings.MouseLeave += MouseLeave;
        }
    }
}
