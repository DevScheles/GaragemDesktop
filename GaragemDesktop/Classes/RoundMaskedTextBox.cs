using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GaragemDesktop.Classes
{
    [DefaultEvent("TextChanged")]
    public class RoundMaskedTextBox : UserControl
    {
        private MaskedTextBox mask;

        public RoundMaskedTextBox()
        {
            this.DoubleBuffered = true;
            this.Size = new Size(250, 40);

            mask = new MaskedTextBox();
            mask.BorderStyle = BorderStyle.None;
            mask.Font = new Font("Segoe UI", 10f);

            // fundo sempre sólido (evita erro de transparência)
            mask.BackColor = _backgroundColor;
            mask.ForeColor = _textColor;

            mask.Location = new Point(12, 10);
            mask.Width = this.Width - 24;

            this.Controls.Add(mask);

            this.Resize += (s, e) =>
            {
                mask.Width = this.Width - 24;
                mask.Location = new Point(12, (this.Height - mask.Height) / 2);
                Invalidate();
            };
        }

        // ============================
        //      PROPRIEDADES
        // ============================

        private int _borderRadius = 12;
        [Category("Design")]
        public int BorderRadius
        {
            get => _borderRadius;
            set { _borderRadius = value; Invalidate(); }
        }

        private int _borderSize = 2;
        [Category("Design")]
        public int BorderSize
        {
            get => _borderSize;
            set { _borderSize = value; Invalidate(); }
        }

        private Color _borderColor = Color.FromArgb(180, 0, 0);
        [Category("Design")]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        private Color _backgroundColor = Color.FromArgb(30, 30, 30);
        [Category("Design")]
        public Color BackgroundColor
        {
            get => _backgroundColor;
            set
            {
                // sempre força opaco (remove problema do Transparent)
                _backgroundColor = Color.FromArgb(255, value.R, value.G, value.B);
                mask.BackColor = _backgroundColor;
                Invalidate();
            }
        }

        private Color _textColor = Color.White;
        [Category("Design")]
        public Color TextColor
        {
            get => _textColor;
            set
            {
                _textColor = value;
                mask.ForeColor = value;
                Invalidate();
            }
        }

        [Category("Behavior")]
        public string Mask
        {
            get => mask.Mask;
            set => mask.Mask = value;
        }

        [Category("Behavior")]
        public string Texts
        {
            get => mask.Text;
            set => mask.Text = value;
        }

        // ============================
        //      DESENHO
        // ============================

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

            using (GraphicsPath bg = GetPath(rect, BorderRadius))
            using (SolidBrush brush = new SolidBrush(BackgroundColor))
                e.Graphics.FillPath(brush, bg);

            using (GraphicsPath border = GetPath(rect, BorderRadius))
            using (Pen pen = new Pen(BorderColor, BorderSize))
                e.Graphics.DrawPath(pen, border);

            base.OnPaint(e);
        }

        private GraphicsPath GetPath(Rectangle rect, int radius)
        {
            int d = radius * 2;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
