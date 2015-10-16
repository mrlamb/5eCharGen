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
    public partial class AttributeBlock : UserControl
    {
        public Character Character { get; set; }
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
            Character.Attributes[(sender as NumericUpDown).Name.Substring((sender as NumericUpDown).Name.Length)] = (int)(sender as NumericUpDown).Value;
        }

        public void UpdateTotals()
        {
            foreach (KeyValuePair<string, int> pair in Character.Attributes)
            {
                // Set the value of each spinner to the base attribute value from Character data
                (Controls[Controls.IndexOfKey("numSelect" + pair.Key)] as NumericUpDown).Value = pair.Value;

                // Calculate the total from character data and update stat total for now just copying from dict
                Controls[Controls.IndexOfKey("lbl" + pair.Key + "Total")].Text = pair.Value.ToString();

            }
        }
    }
}
