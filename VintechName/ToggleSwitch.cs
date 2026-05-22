using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace VintechName
{
    [Designer(typeof(ToggleSwitchDesigner))]
    public partial class ToggleSwitch : CheckBox
    {
        // Основные цвета (активное состояние)
        private Color onColor = Color.FromArgb(0, 120, 215);      // синий включено
        private Color offColor = Color.FromArgb(200, 200, 200);   // серый выключено
        private Color borderColor = Color.FromArgb(0, 0, 139);    // тёмно-синяя рамка
        private Color thumbColor = Color.White;

        // Серые цвета для отключённого состояния (Disabled)
        private Color disabledOnColor = Color.FromArgb(140, 140, 140);
        private Color disabledOffColor = Color.FromArgb(220, 220, 220);
        private Color disabledBorderColor = Color.FromArgb(180, 180, 180);
        private Color disabledThumbColor = Color.FromArgb(240, 240, 240);

        public ToggleSwitch()
        {
            this.AutoSize = false;

            this.Appearance = Appearance.Button;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;

            this.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.FlatAppearance.CheckedBackColor = Color.Transparent;

            this.BackColor = Color.Transparent;
            this.UseVisualStyleBackColor = false;
            this.TabStop = false;

            // Полностью ручная отрисовка + отключение фокуса
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.ResizeRedraw |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.SupportsTransparentBackColor, true);

            this.SetStyle(ControlStyles.Selectable, false);

            this.MinimumSize = new Size(24, 12);
            this.MaximumSize = new Size(400, 200);
            this.Size = new Size(50, 25);
        }

        protected override Size DefaultSize => new Size(50, 25);

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Size Size
        {
            get => base.Size;
            set
            {
                int w = Math.Max(value.Width, 24);
                int h = Math.Max(value.Height, 12);
                base.Size = new Size(w, h);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            e.Graphics.Clear(this.BackColor);

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            Color trackColor;
            Color borderColorCurrent;
            Color thumbColorCurrent;

            if (this.Enabled)
            {
                // Активное состояние
                trackColor = this.Checked ? onColor : offColor;
                borderColorCurrent = borderColor;
                thumbColorCurrent = thumbColor;
            }
            else
            {
                // Отключённое состояние — всё серое
                trackColor = this.Checked ? disabledOnColor : disabledOffColor;
                borderColorCurrent = disabledBorderColor;
                thumbColorCurrent = disabledThumbColor;
            }

            // Рисуем трек
            using (SolidBrush brush = new SolidBrush(trackColor))
            {
                e.Graphics.FillRoundedRectangle(brush, rect, this.Height / 2);
            }

            // Рисуем обводку
            using (Pen pen = new Pen(borderColorCurrent, 1.5f))
            {
                e.Graphics.DrawRoundedRectangle(pen, rect, this.Height / 2);
            }

            // Рисуем ползунок
            int thumbSize = this.Height - 4;
            int thumbX = this.Checked ? this.Width - thumbSize - 2 : 2;
            int thumbY = 2;

            using (SolidBrush thumbBrush = new SolidBrush(thumbColorCurrent))
            {
                e.Graphics.FillEllipse(thumbBrush, thumbX, thumbY, thumbSize, thumbSize);
            }
        }

        // ====================== Свойства ======================

        [Category("Appearance")]
        [Description("Цвет трека когда включено (активное состояние)")]
        public Color OnColor
        {
            get => onColor;
            set { onColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        [Description("Цвет трека когда выключено (активное состояние)")]
        public Color OffColor
        {
            get => offColor;
            set { offColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        [Description("Цвет границы (активное состояние)")]
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        [Description("Цвет ползунка (активное состояние)")]
        public Color ThumbColor
        {
            get => thumbColor;
            set { thumbColor = value; Invalidate(); }
        }

        // Свойства для отключённого состояния
        [Category("Appearance")]
        [Description("Цвет трека когда включено и отключено")]
        public Color DisabledOnColor
        {
            get => disabledOnColor;
            set { disabledOnColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        [Description("Цвет трека когда выключено и отключено")]
        public Color DisabledOffColor
        {
            get => disabledOffColor;
            set { disabledOffColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        [Description("Цвет ползунка в отключённом состоянии")]
        public Color DisabledThumbColor
        {
            get => disabledThumbColor;
            set { disabledThumbColor = value; Invalidate(); }
        }
    }

    // ====================== Дизайнер ======================
    internal class ToggleSwitchDesigner : ControlDesigner
    {
        public override SelectionRules SelectionRules =>
            SelectionRules.Moveable | SelectionRules.Visible;
    }

    // ====================== GraphicsExtensions ======================
    public static class GraphicsExtensions
    {
        public static void FillRoundedRectangle(this Graphics g, Brush brush, Rectangle rect, int radius)
        {
            using (GraphicsPath path = CreateRoundedRectanglePath(rect, radius))
                g.FillPath(brush, path);
        }

        public static void DrawRoundedRectangle(this Graphics g, Pen pen, Rectangle rect, int radius)
        {
            using (GraphicsPath path = CreateRoundedRectanglePath(rect, radius))
                g.DrawPath(pen, path);
        }

        private static GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = Math.Min(radius * 2, Math.Min(rect.Width, rect.Height));

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}