﻿using LockKeysCore;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Forms.PropertyGridInternal;

namespace LockKeysCore
{
    public partial class Form1 : Form
    {
        LockKeyCaps lockkeycaps1 = new LockKeyCaps();
        LockKeyNum lockkeynum1 = new LockKeyNum();
        LockKeyScroll lockkeyscroll1 = new LockKeyScroll();
        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        private bool previousCapsLockState = false;
        private bool previousNumLockState = false;
        private bool previousScrollLockState = false;
        private bool appuseslighttheme = false;

        private int value;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(LockKeysCore.Properties.Settings.Default.FirstTimeStart == false)
            {
                firstTimeStart firsttime = new firstTimeStart();
                firsttime.Show();
            }
            checkBox4.Checked = LockKeysCore.Properties.Settings.Default.StartAtLogon;
            appuseslighttheme = LockKeysCore.Properties.Settings.Default.AppUsesLightTheme;
            if (appuseslighttheme)
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked = true;
            }

            checkBox1.Checked = LockKeysCore.Properties.Settings.Default.ShowCapsLock;
            checkBox2.Checked = LockKeysCore.Properties.Settings.Default.ShowScrollLock;
            checkBox3.Checked = LockKeysCore.Properties.Settings.Default.ShowNumLock;
            value = LockKeysCore.Properties.Settings.Default.DissmissTime;
            textBox1.Text = value.ToString();
            lockkeycaps1.timer1.Interval = value;
            lockkeynum1.timer1.Interval = value;
            lockkeyscroll1.timer1.Interval = value;

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
            if (checkBox1.Checked)
            {
                // Code to show form for Caps Lock On
                lockkeycaps1.Show();
                lockkeycaps1.label1.Text = "On";
                lockkeycaps1.label3.Text = "";
                lockkeycaps1.Opacity = 100;
                lockkeycaps1.currentOpacity = 1.0;
                lockkeycaps1.timer1.Start();
                lockkeycaps1.timer1.Stop();
                lockkeycaps1.timer1.Start();
                lockkeycaps1.fadeTimer.Stop();
            }
        }

        private void ShowCapsLockOffForm()
        {
            if (checkBox1.Checked)
            {
                // Code to show form for Caps Lock Off
                lockkeycaps1.Show();
                lockkeycaps1.label1.Text = "Off";
                lockkeycaps1.label3.Text = "";
                lockkeycaps1.Opacity = 100;
                lockkeycaps1.currentOpacity = 1.0;
                lockkeycaps1.timer1.Start();
                lockkeycaps1.timer1.Stop();
                lockkeycaps1.timer1.Start();
                lockkeycaps1.fadeTimer.Stop();
            }
        }

        private void ShowNumLockForm()
        {
            if (checkBox2.Checked)
            {
                // Code to show form for Num Lock On
                lockkeynum1.Show();
                lockkeynum1.label1.Text = "On";
                lockkeynum1.label3.Text = "";
                lockkeynum1.Opacity = 100;
                lockkeynum1.currentOpacity = 1.0;
                lockkeynum1.timer1.Start();
                lockkeynum1.timer1.Stop();
                lockkeynum1.timer1.Start();
                lockkeynum1.fadeTimer.Stop();
            }
        }

        private void ShowNumLockOffForm()
        {
            if (checkBox2.Checked)
            {
                // Code to show form for Num Lock Off
                lockkeynum1.Show();
                lockkeynum1.label1.Text = "Off";
                lockkeynum1.label3.Text = "";
                lockkeynum1.Opacity = 100;
                lockkeynum1.currentOpacity = 1.0;
                lockkeynum1.timer1.Start();
                lockkeynum1.timer1.Stop();
                lockkeynum1.timer1.Start();
                lockkeynum1.fadeTimer.Stop();
            }
        }

        private void ShowScrollLockForm()
        {
            if (checkBox3.Checked)
            {
                // Code to show form for Scroll Lock On
                lockkeyscroll1.Show();
                lockkeyscroll1.label1.Text = "On";
                lockkeyscroll1.label3.Text = "";
                lockkeyscroll1.Opacity = 100;
                lockkeyscroll1.currentOpacity = 1.0;
                lockkeyscroll1.timer1.Start();
                lockkeyscroll1.timer1.Stop();
                lockkeyscroll1.timer1.Start();
                lockkeyscroll1.fadeTimer.Stop();
            }
        }

        private void ShowScrollLockOffForm()
        {
            if (checkBox3.Checked)
            {
                // Code to show form for Scroll Lock Off
                lockkeyscroll1.Show();
                lockkeyscroll1.label1.Text = "Off";
                lockkeyscroll1.label3.Text = "";
                lockkeyscroll1.Opacity = 100;
                lockkeyscroll1.currentOpacity = 1.0;
                lockkeyscroll1.timer1.Start();
                lockkeyscroll1.timer1.Stop();
                lockkeyscroll1.timer1.Start();
                lockkeyscroll1.fadeTimer.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Periodically update the state of locking keys
            UpdateLockStates();
            if (appuseslighttheme)
            {
                lockkeyscroll1.BackColor = SystemColors.Control;
                lockkeynum1.BackColor = SystemColors.Control;
                lockkeycaps1.BackColor = SystemColors.Control;
                lockkeyscroll1.ForeColor = Color.Black;
                lockkeynum1.ForeColor = Color.Black;
                lockkeycaps1.ForeColor = Color.Black;
            }
            else
            {
                lockkeyscroll1.BackColor = Color.FromArgb(20, 20, 20);
                lockkeynum1.BackColor = Color.FromArgb(20, 20, 20);
                lockkeycaps1.BackColor = Color.FromArgb(20, 20, 20);
                lockkeyscroll1.ForeColor = Color.White;
                lockkeynum1.ForeColor = Color.White;
                lockkeycaps1.ForeColor = Color.White;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.Hide();

            notifyIcon1.ShowBalloonTip(2000, "LockKeys is hidden to tray", "Double click the icon to open LockKeys LockKeysCore.Properties.Settings.", ToolTipIcon.Info);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric characters, backspace, and delete
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Suppress the key press event
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            value = int.Parse(textBox1.Text);
            lockkeycaps1.timer1.Interval = value;
            lockkeynum1.timer1.Interval = value;
            lockkeyscroll1.timer1.Interval = value;

            LockKeysCore.Properties.Settings.Default.DissmissTime = value;
            LockKeysCore.Properties.Settings.Default.Save();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            appuseslighttheme = false;
            LockKeysCore.Properties.Settings.Default.AppUsesLightTheme = appuseslighttheme;
            LockKeysCore.Properties.Settings.Default.Save();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            appuseslighttheme = true;
            LockKeysCore.Properties.Settings.Default.AppUsesLightTheme = appuseslighttheme;
            LockKeysCore.Properties.Settings.Default.Save();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            LockKeysCore.Properties.Settings.Default.ShowCapsLock = checkBox1.Checked;
            LockKeysCore.Properties.Settings.Default.Save();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            LockKeysCore.Properties.Settings.Default.ShowScrollLock = checkBox2.Checked;
            LockKeysCore.Properties.Settings.Default.Save();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            LockKeysCore.Properties.Settings.Default.ShowNumLock = checkBox3.Checked;
            LockKeysCore.Properties.Settings.Default.Save();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            LockKeysCore.Properties.Settings.Default.StartAtLogon = checkBox4.Checked;
            if (LockKeysCore.Properties.Settings.Default.StartAtLogon)
            {
                rkApp.SetValue("LockKeys.exe", Application.ExecutablePath);
            }
            else
            {
                rkApp.SetValue("LockKeys.exe", false);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.Show();
        }
    }
}
