using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NewProject
{
    /// <summary>
    /// Description of Message.
    /// </summary>
    public partial class Message : Form
    {
        public Message()
        {

            InitializeComponent();

        }

        public static GraphicsPath RoundedRect(Rectangle baseRect, int radius)
        {
            var diameter = radius * 2;
            var sz = new Size(diameter, diameter);
            var arc = new Rectangle(baseRect.Location, sz);
            var path = new GraphicsPath();
            // Верхний левый угол
            path.AddArc(arc, 180, 90);
            // Верхний правый угол
            arc.X = baseRect.Right - diameter;
            path.AddArc(arc, 270, 90);
            // Нижний правый угол
            arc.Y = baseRect.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            // Нижний левый угол
            arc.X = baseRect.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();
            return path;
        }
        void Message_Load(object sender, EventArgs e)
        {
            this.Region = new Region(
                RoundedRect(
                    new Rectangle(0, 0, this.Width, this.Height)
                    , 15
                )
            );
            button_Ok.Region = new Region(
                RoundedRect(
                    new Rectangle(0, 0, button_Ok.Width, button_Ok.Height)
                    , 15
                )
            );
        }
        void button_Ok_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
