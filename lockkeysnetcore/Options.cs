using lockkeysnetcore.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lockkeysnetcore
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }
        private void gradients()
        {
            panel1.Paint += (sender, e) =>
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    panel1.ClientRectangle,
                    Color.FromArgb(255, 102, 0),
                    Color.FromArgb(179, 71, 0),
                    LinearGradientMode.Vertical))
                {
                    e.Graphics.FillRectangle(brush, panel1.ClientRectangle); ;
                }
            };

        }
        private void Settings_Load(object sender, EventArgs e)
        {
            if(Settings.Default.FirstTimeRun == true)
            {
                Settings.Default.FirstTimeRun = false;
                Settings.Default.Save();
                Welcome welcome = new Welcome();
                welcome.Show();
            }
            gradients();
        }
    }
}
