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
    public partial class FrmMain : FrmBase
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(IConfiguratorHelper config)
        {
            InitializeComponent();

            _config = config;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            HookButtonEvents();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ucSettings_Click(object sender, EventArgs e)
        {
            var form = new FrmSettings(_config);
            form.ShowDialog();
        }

        private void HookButtonEvents()
        {
            btnProfile.MouseEnter += MouseEnter;
            btnProfile.MouseLeave += MouseLeave;

            btnSettings.MouseEnter += MouseEnter;
            btnSettings.MouseLeave += MouseLeave;
        }

        #region Main Menu Events
        private void btnSettings_Click(object sender, EventArgs e)
        {
            var form = new FrmSettings(_config);
            form.ShowDialog();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            //var form = new FrmProfile(_config);
            //form.ShowDialog();
        }
        #endregion
    }
}
