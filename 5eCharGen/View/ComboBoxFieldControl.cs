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
    public partial class ComboBoxFieldControl : UserControl
    {
        public ComboBoxFieldControl()
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
            get { return comboBox.Text; }
            set { comboBox.Text = value; }
        }

        public event EventHandler ComboBoxTextChanged;

        public Label Label { get { return label; } }
        public ComboBox ComboBox { get { return comboBox; } }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ComboBoxTextChanged != null)
                this.ComboBoxTextChanged(this, e);
        }
    }
}
