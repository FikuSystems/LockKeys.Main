using System.Drawing.Drawing2D;

namespace lockkeysnetcore
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Welcome_Load(object sender, EventArgs e)
        {
            gradients();
        }
    }
}
