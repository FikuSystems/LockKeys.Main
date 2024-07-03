using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lockkeysnetcore
{
    public partial class Popup : Form
    {
        public Popup()
        {
            InitializeComponent();
        }

        private void Popup_Load(object sender, EventArgs e)
        {
            Rectangle workingArea = Screen.PrimaryScreen.Bounds;
            int xPos = workingArea.Left + (workingArea.Width - this.Width) / 2;
            int yPos = workingArea.Top + 60;
            this.Location = new Point(xPos, yPos);
        }
    }
}
