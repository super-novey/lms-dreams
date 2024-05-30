using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMSDreams.CustomControls
{
    public partial class CustomeTextbox : UserControl
    {
        public CustomeTextbox()
        {
            InitializeComponent();
        }
        bool isFocused = false;
        private string text = "label1";
        private bool pass = false;
        private bool multiline = false;
        private Color backColor = Color.White;
        private Color foreColor = Color.Black;
         

        public string customText
        {
            get { return text; }
            set { 
                text = value;
                this.Invalidate();
            }
        }

        public bool password
        {
            get { return pass; }
            set { 
                pass = value;
                this.Invalidate();
            }
        }

        public bool customMultiline
        {
            get { return multiline; }
            set { multiline = value;
                this.Invalidate();
            }
        }

        public Color customBackColor
        {
            get { return backColor; }
            set
            {
                backColor = value;
                this.Invalidate();
            }
        }

        public Color customForeColor
        {
            get { return foreColor; }
            set
            {
                foreColor = value;
                this.Invalidate();
            }
        }

        private void CustomeTextbox_Load(object sender, EventArgs e)
        {
            if (password == true)
            {
                textBox1.UseSystemPasswordChar = true;
            }    
        }

        private void labelTimer_Tick(object sender, EventArgs e)
        {
            int y = label1.Location.Y;
            if (isFocused == false)
            {
                y -= 2;
                label1.Location = new Point(label1.Location.X, y);
                if (y <= 6)
                {
                    isFocused = true;
                    labelTimer.Stop();
                    label1.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                    y = 0;
                    //label1.ForeColor = customForeColor;

                }
            }
            else
            {
                y += 2;
                label1.Location = new Point(label1.Location.X, y);
                if (y >= 26)
                {
                    isFocused = false;
                    labelTimer.Stop();
                    label1.Font = new Font("Segoe UI", 11);
                    y = 26;
                    //label1.ForeColor = Color.Black;
                }
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                labelTimer.Start();
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                labelTimer.Start();
            }
        }

        private void CustomeTextbox_Paint(object sender, PaintEventArgs e)
        {
            label1.BackColor = customBackColor;
            textBox1.BackColor = Color.White;
            label1.Text = customText;
            if (customMultiline == true)
            {
                textBox1.Multiline = true;
                textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                textBox1.Height = this.Height;
            }
            label1.ForeColor = customForeColor;
        }
        public string TextBox;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox = textBox1.Text;
        }
    }
}
