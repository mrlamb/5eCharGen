using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5eCharGen.View
{
    public partial class TextFieldControl : UserControl
    {
        public TextFieldControl()
        {
            InitializeComponent();
        }

        public string LabelText
        {
            get { return label.Text; }
            set { label.Text = value; }
        }

        public override string Text
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            OnTextChanged(e);
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                OnKeyPress(e);
            }
        }

        public Label Label { get { return label; } }
        public TextBox TextBox { get { return textBox; } }
    }
}
