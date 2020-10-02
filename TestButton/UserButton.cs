using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestButton
{
    public class UserButton
    {
        private NoFocusCuesButton ButtonTemplate;

        private Color BackColor;
        private Color MouseOverBackColor;
        private Color MouseDownBackColor;
        private Color ForeColor;

        public EventHandler Call;

        public Size Size
        {
            get { return ButtonTemplate.Size; }
            set { ButtonTemplate.Size = value; }
        }

        public Point Location
        {
            get { return ButtonTemplate.Location; }
            set { ButtonTemplate.Location = value; }
        }

        public string Text
        {
            get { return ButtonTemplate.Text; }
            set { ButtonTemplate.Text = value; }
        }

        public Image Image
        {
            get { return ButtonTemplate.Image; }
            set { ButtonTemplate.Image = value; }
        }

        public UserButton(Color ThemeColor)
        {
            BackColor = ThemeColor;
            MouseOverBackColor = ThemeColor;
            MouseDownBackColor = Color.FromArgb(ThemeColor.R + 20, ThemeColor.G + 20, ThemeColor.B + 20);
        }
    }
}
