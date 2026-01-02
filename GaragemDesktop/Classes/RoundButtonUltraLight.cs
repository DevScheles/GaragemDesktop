using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GaragemDesktop
{
    public class CleanRoundTextBox : UserControl
    {
        public int BorderRadius { get; set; } = 12;
        public Color BorderColor { get; set; } = Color.FromArgb(80, 80, 80);
        public Color BackgroundColor { get; set; } = Color.FromArgb(30, 30, 30);
        public Color TextColor { get; set; } = Color.White;

        private TextBox txt = new TextBox();

        public CleanRoundTextBox()
        {
            Size = new Size(250, 40);
            BackColor = Color.Transparent;
            Padding = new Padding(10);

            txt.BorderStyle = BorderStyle.None;
            txt.BackColor = BackgroundColor;
            txt.ForeColor = TextColor;
            txt.Font = new Font("Segoe UI", 10f);

            Controls.Add(txt);

            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.UserPaint |
                ControlStyles.ResizeRedraw,
                true
            );
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
         
            using (SolidBrush br = new SolidBrush(BackgroundColor))
            using (Pen pen = new Pen(BorderColor))
            {
              
            }
        }
    }
}
