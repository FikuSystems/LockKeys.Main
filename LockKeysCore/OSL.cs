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

namespace LockKeysCore
{
    public partial class OSL : Form
    {
        public OSL()
        {
            InitializeComponent();
        }

        private void OSL_Load(object sender, EventArgs e)
        {
            gradients();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
