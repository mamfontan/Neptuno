using Neptuno.Views.helpers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Neptuno.Views
{
    public partial class FrmBase : Form
    {
        internal IConfiguratorHelper _config;

        public FrmBase()
        {
            InitializeComponent();
        }

        internal new void MouseEnter(object sender, EventArgs e)
        {
            if (Cursor == Cursors.Default)
                Cursor = Cursors.Hand;

            var btn = sender as Button;
            btn.BackgroundImage = Properties.Resources.background_blue_02;
            btn.BackgroundImageLayout = ImageLayout.Stretch;

            //btn.ForeColor = Color.Silver;
        }

        internal new void MouseLeave(object sender, EventArgs e)
        {
            if (Cursor != Cursors.WaitCursor)
                Cursor = Cursors.Default;

            var btn = sender as Button;
            btn.BackgroundImage = null;

            //btn.ForeColor = Color.Black;
        }
    }
}
