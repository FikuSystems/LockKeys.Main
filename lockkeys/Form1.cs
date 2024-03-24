using LockKeys;
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
        LockKeyCaps lockkeycaps1 = new LockKeyCaps();
        LockKeyNum lockkeynum1 = new LockKeyNum();
        LockKeyScroll lockkeyscroll1 = new LockKeyScroll();

        private bool previousCapsLockState = false;
        private bool previousNumLockState = false;
        private bool previousScrollLockState = false;

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


            if (capsLockState != previousCapsLockState)
            {
                if (capsLockState)
                {
                    ShowCapsLockForm();
                }
                else
                {
                    ShowCapsLockOffForm();
                }
                previousCapsLockState = capsLockState;
            }

            if (numLockState != previousNumLockState)
            {
                if (numLockState)
                {
                    ShowNumLockForm();
                }
                else
                {
                    ShowNumLockOffForm();
                }
                previousNumLockState = numLockState;
            }

            if (scrollLockState != previousScrollLockState)
            {
                if (scrollLockState)
                {
                    ShowScrollLockForm();
                }
                else
                {
                    ShowScrollLockOffForm();
                }
                previousScrollLockState = scrollLockState;
            }
        }

        private void ShowCapsLockForm()
        {
            // Code to show form for Caps Lock On
            lockkeycaps1.Show();
            lockkeycaps1.label1.Text = "Caps Lock On";
            lockkeycaps1.Opacity = 100;
            lockkeycaps1.timer1.Start();
        }

        private void ShowCapsLockOffForm()
        {
            // Code to show form for Caps Lock Off
            lockkeycaps1.Show();
            lockkeycaps1.label1.Text = "Caps Lock Off";
            lockkeycaps1.Opacity = 100;
            lockkeycaps1.timer1.Start();
        }

        private void ShowNumLockForm()
        {
            // Code to show form for Num Lock On
            lockkeynum1.Show();
            lockkeynum1.label1.Text = "Num Lock On";
            lockkeynum1.Opacity = 100;
            lockkeynum1.timer1.Start();
        }

        private void ShowNumLockOffForm()
        {
            // Code to show form for Num Lock Off
            lockkeynum1.Show();
            lockkeynum1.label1.Text = "Num Lock Off";
            lockkeynum1.Opacity = 100;
            lockkeynum1.timer1.Start();
        }

        private void ShowScrollLockForm()
        {
            // Code to show form for Scroll Lock On
            lockkeyscroll1.Show();
            lockkeyscroll1.label1.Text = "Scroll Lock On";
            lockkeyscroll1.Opacity = 100;
            lockkeyscroll1.timer1.Start();
        }

        private void ShowScrollLockOffForm()
        {
            // Code to show form for Scroll Lock Off
            lockkeyscroll1.Show();
            lockkeyscroll1.label1.Text = "Scroll Lock Off";
            lockkeyscroll1.Opacity = 100;
            lockkeyscroll1.timer1.Start();
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
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;

            notifyIcon1.ShowBalloonTip(2000, "LockKeys is hidden to tray", "Double click the icon to open LockKeys settings.", ToolTipIcon.Info);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
