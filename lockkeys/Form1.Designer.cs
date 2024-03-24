namespace lockkeys
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblCapsLock = new System.Windows.Forms.Label();
            this.lblNumLock = new System.Windows.Forms.Label();
            this.lblScrollLock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblCapsLock
            // 
            this.lblCapsLock.AutoSize = true;
            this.lblCapsLock.Location = new System.Drawing.Point(13, 13);
            this.lblCapsLock.Name = "lblCapsLock";
            this.lblCapsLock.Size = new System.Drawing.Size(65, 13);
            this.lblCapsLock.TabIndex = 0;
            this.lblCapsLock.Text = "lblCapsLock";
            // 
            // lblNumLock
            // 
            this.lblNumLock.AutoSize = true;
            this.lblNumLock.Location = new System.Drawing.Point(13, 26);
            this.lblNumLock.Name = "lblNumLock";
            this.lblNumLock.Size = new System.Drawing.Size(63, 13);
            this.lblNumLock.TabIndex = 1;
            this.lblNumLock.Text = "lblNumLock";
            // 
            // lblScrollLock
            // 
            this.lblScrollLock.AutoSize = true;
            this.lblScrollLock.Location = new System.Drawing.Point(13, 39);
            this.lblScrollLock.Name = "lblScrollLock";
            this.lblScrollLock.Size = new System.Drawing.Size(67, 13);
            this.lblScrollLock.TabIndex = 2;
            this.lblScrollLock.Text = "lblScrollLock";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 397);
            this.Controls.Add(this.lblScrollLock);
            this.Controls.Add(this.lblNumLock);
            this.Controls.Add(this.lblCapsLock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCapsLock;
        private System.Windows.Forms.Label lblNumLock;
        private System.Windows.Forms.Label lblScrollLock;
        private System.Windows.Forms.Timer timer1;
    }
}

