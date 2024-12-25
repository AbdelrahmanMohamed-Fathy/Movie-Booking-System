using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Movie_Booking_System.Controls
{
    [DefaultEvent("TextChanged")]
    public partial class PlaceHolderTextBox : UserControl
    {
        private string placeHolderText = "PlaceHolder";
        private Color placeHolderTextColor = Color.Silver;
        private Color TextColor;

        [Description("PlaceHolder text")]
        [Category("Appearance")]
        [System.ComponentModel.DefaultValue("PlaceHolder")]
        public string PlaceHolderText
        {
            get { return placeHolderText; }
            set { placeHolderText = value; textBox1.Text = value; }
        }

        [Description("PlaceHolder text color")]
        [Category("Appearance")]
        [System.ComponentModel.DefaultValue("Silver")]
        public Color PlaceHolderTextColor
        {
            get { return placeHolderTextColor; }
            set { placeHolderTextColor = value; textBox1.ForeColor = value; }
        }

        [Category("Appearance")]
        [System.ComponentModel.DefaultValue("")]
        public override string Text
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public PlaceHolderTextBox()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == placeHolderText)
            {
                textBox1.Text = "";
                textBox1.ForeColor = TextColor;
                this.Font = new Font(this.Font, FontStyle.Regular);
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = placeHolderText;
                textBox1.ForeColor = placeHolderTextColor;
                this.Font = new Font(this.Font, FontStyle.Italic);
            }
        }

        private void PlaceHolderTextBox_Load(object sender, EventArgs e)
        {
            TextColor = this.ForeColor;
            textBox1.ForeColor = placeHolderTextColor;
            textBox1.Text = placeHolderText;
        }

        private void PlaceHolderTextBox_FontChanged(object sender, EventArgs e)
        {
            textBox1.Font = this.Font;
            this.Size = textBox1.Size;
            this.MinimumSize = new System.Drawing.Size(0, textBox1.Height);
            this.MaximumSize = new System.Drawing.Size(this.Size.Width*100, textBox1.Height);
        }

        [Browsable(true)]
        [Category("Property Changed")]
        public event EventHandler TextChanged;

        [Browsable(true)]
        [Category("Key")]
        public event KeyPressEventHandler KeyPress;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.TextChanged != null)
                if (textBox1.Text != placeHolderText)
                    this.TextChanged(this, e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.KeyPress != null)
                this.KeyPress(this, e);
        }
    }
}
