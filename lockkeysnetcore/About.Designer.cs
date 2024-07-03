namespace lockkeysnetcore
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 90, 0);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(626, 54);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(61, 11);
            label2.Name = "label2";
            label2.Size = new Size(505, 30);
            label2.TabIndex = 4;
            label2.Text = "About LockKeys";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(539, 225);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Location = new Point(201, 105);
            label1.Name = "label1";
            label1.Size = new Size(91, 117);
            label1.TabIndex = 6;
            label1.Text = "Current Version:\r\nContributors:\r\nPublisher:\r\nProduct:\r\nCopyright:\r\nDescription:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            label5.Location = new Point(198, 67);
            label5.Name = "label5";
            label5.Size = new Size(212, 30);
            label5.TabIndex = 5;
            label5.Text = "LockKeys (.Net Core)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(298, 105);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 7;
            label6.Text = "1.0.0.0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(298, 120);
            label7.Name = "label7";
            label7.Size = new Size(166, 15);
            label7.TabIndex = 8;
            label7.Text = "FikuSystems (Whole Program)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(298, 135);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 10;
            label8.Text = "FikuSystems";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(298, 150);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 9;
            label9.Text = "LockKeys";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(298, 165);
            label10.Name = "label10";
            label10.Size = new Size(116, 15);
            label10.TabIndex = 12;
            label10.Text = "(c) FikuSystems 2024";
            // 
            // label11
            // 
            label11.Location = new Point(298, 180);
            label11.Name = "label11";
            label11.Size = new Size(316, 42);
            label11.TabIndex = 11;
            label11.Text = "LockKeys is a program that displays the current state of the locking keys of the keyboard on the display.";
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 260);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "About";
            Text = "About LockKeys";
            Load += About_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}