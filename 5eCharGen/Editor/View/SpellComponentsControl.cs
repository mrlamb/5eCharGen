using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5eCharGen.Editor.View
{
    public partial class SpellComponentsControl : UserControl
    {
        public bool Verbal
        {
            get { return checkBoxVerbal.Checked; }
            set { checkBoxVerbal.Checked = value; }
        }

        public bool Somatic
        {
            get { return checkBoxSomatic.Checked; }
            set { checkBoxSomatic.Checked = value; }
        }

        public bool Material
        {
            get { return checkBoxMaterial.Checked;  }
            set { checkBoxMaterial.Checked = value; }
        }

        public override string Text
        {
            get { return textBoxMaterialDesc.Text; }
            set { textBoxMaterialDesc.Text = value; }
        }

        public SpellComponentsControl()
        {
            InitializeComponent();
        }

        private void checkBoxMaterial_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMaterialDesc.Enabled = checkBoxMaterial.Checked ? true : false; 
        }
    }
}
