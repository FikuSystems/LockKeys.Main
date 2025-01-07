namespace LockKeysCore
{
    partial class LockKeyCaps
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            fadeTimer = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Bottom;
            label1.Location = new Point(0, 127);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(187, 35);
            label1.TabIndex = 0;
            label1.Text = "Caps Lock On";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F);
            label2.Location = new Point(9, 81);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 40);
            label2.TabIndex = 1;
            label2.Text = "Caps Lock";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // fadeTimer
            // 
            fadeTimer.Enabled = true;
            fadeTimer.Interval = 1;
            fadeTimer.Tick += FadeTimer_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe MDL2 Assets", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 18);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 48);
            label3.TabIndex = 2;
            label3.Text = "";
            // 
            // LockKeyCaps
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(187, 162);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(187, 162);
            MinimizeBox = false;
            MinimumSize = new Size(187, 162);
            Name = "LockKeyCaps";
            ShowIcon = false;
            ShowInTaskbar = false;
            TopMost = true;
            Load += LockKeyCaps_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Timer fadeTimer;
        public System.Windows.Forms.Label label3;
    }
}