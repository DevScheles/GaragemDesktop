using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GaragemDesktop.Classes
{
    [DesignerCategory("Code")]
    [DefaultEvent("SelectedIndexChanged")]
    public class RoundComboBox : UserControl
    {
        private ComboBox combo;

        public RoundComboBox()
        {
            this.DoubleBuffered = true;
            this.Size = new Size(250, 40);

            combo = new ComboBox();
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.Font = new Font("Segoe UI", 10f);
            combo.IntegralHeight = false;

            // deixa a seta padrão
            combo.FlatStyle = FlatStyle.Standard;

            combo.BackColor = _backgroundColor;
            combo.ForeColor = _textColor;

            combo.Location = new Point(12, 8);
            combo.Width = this.Width - 24;
            combo.Height = 30;

            this.Controls.Add(combo);

            // 🔥 ESSENCIAL: permite menu "Editar Itens..."
            this.ContextMenuStrip = combo.ContextMenuStrip;

            this.Resize += (s, e) =>
            {
                combo.Width = this.Width - 24;
                combo.Location = new Point(12, (this.Height - combo.Height) / 2);
                Invalidate();
            };
        }

        // ============================
        // PROPRIEDADES VISUAIS
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
                _backgroundColor = Color.FromArgb(255, value.R, value.G, value.B);
                combo.BackColor = _backgroundColor;
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
                combo.ForeColor = value;
                Invalidate();
            }
        }

        // ============================
        // PROPRIEDADES NATIVAS
        // ============================

        [Category("Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ComboBox.ObjectCollection Items => combo.Items;

        [Category("Behavior")]
        public int SelectedIndex
        {
            get => combo.SelectedIndex;
            set => combo.SelectedIndex = value;
        }

        [Category("Behavior")]
        public object SelectedItem
        {
            get => combo.SelectedItem;
            set => combo.SelectedItem = value;
        }

        public event EventHandler SelectedIndexChanged
        {
            add { combo.SelectedIndexChanged += value; }
            remove { combo.SelectedIndexChanged -= value; }
        }

        // ============================
        // DESENHO
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
