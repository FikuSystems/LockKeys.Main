using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockKeys
{
    public partial class LockKeyCaps : Form
    {
        public LockKeyCaps()
        {
            InitializeComponent();
        }

        private void LockKeyCaps_Load(object sender, EventArgs e)
        {
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
            int xPos = workingArea.Left + (workingArea.Width - this.Width) / 2;
            int yPos = workingArea.Top;
            this.Location = new Point(xPos, yPos);
        }
    }
}
