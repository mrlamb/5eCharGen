using System;
using System.Windows.Forms;

namespace _5eCharGen.View
{
    public partial class AttributeBlock : UserControl
    {
        public AttributeBlock()
        {
            InitializeComponent();
            CustomInitialize();
        }

        private void CustomInitialize()
        {

            foreach (Control ctrl in Controls)
            {
                if (ctrl is NumericUpDown)
                {
                    (ctrl as NumericUpDown).ValueChanged += AttributeBlock_ValueChanged;
                }
            }
        }

        private void AttributeBlock_ValueChanged(object sender, EventArgs e)
        {

        }

        public void UpdateTotals()
        {

        }

        public void UpdateSpinners()
        {

        }
    }
}
