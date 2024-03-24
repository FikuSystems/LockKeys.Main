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

namespace lockkeys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Check and display the initial state of locking keys
            UpdateLockStates();
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
        private void UpdateLockStates()
        {
            // Check the state of Caps Lock
            bool capsLockState = Control.IsKeyLocked(Keys.CapsLock);
            lblCapsLock.Text = "Caps Lock: " + (capsLockState ? "On" : "Off");

            // Check the state of Num Lock
            bool numLockState = Control.IsKeyLocked(Keys.NumLock);
            lblNumLock.Text = "Num Lock: " + (numLockState ? "On" : "Off");

            // Check the state of Scroll Lock
            bool scrollLockState = Control.IsKeyLocked(Keys.Scroll);
            lblScrollLock.Text = "Scroll Lock: " + (scrollLockState ? "On" : "Off");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Periodically update the state of locking keys
            UpdateLockStates();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            lockKeyCaps lockkeycaps = new lockKeyCaps
            notifyIcon1.ShowBalloonTip(2000, "LockKeys is hidden to tray", "Double click the icon to open LockKeys settings.", ToolTipIcon.Info);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
