using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
