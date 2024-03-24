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
    public partial class LockKeyNum : Form
    {
        private int fadeStep = 10;
        private double currentOpacity = 1.0;
        public LockKeyNum()
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            fadeTimer.Start();
        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            // Decrease opacity by fadeStep
            currentOpacity -= fadeStep / 255.0;

            if (currentOpacity <= 0)
            {
                // If opacity reaches zero, close the form
                fadeTimer.Stop();
                timer1.Stop();

                this.Hide();
                currentOpacity = 1.0;
                this.Opacity = 100;
            }
            else
            {
                // Update the form's opacity
                this.Opacity = currentOpacity;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Start fading out when the form is closing
            fadeTimer.Start();

            // Cancel the default closing action to allow custom fade out
            e.Cancel = true;
        }
    }
}
