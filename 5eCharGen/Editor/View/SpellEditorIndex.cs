using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5eCharGen.Editor.View
{
    public partial class SpellEditorIndex : Form
    {
        public SpellEditor LinkedEditor { get; set; }

        public SpellEditorIndex()
        {
            InitializeComponent();
        }

        public SpellEditorIndex(SpellEditor se)
        {
            LinkedEditor = se;
            InitializeComponent();
            foreach (Spell spell in Data.GetAllSpells())
            {
                comboBoxFieldSpellSelect.ComboBox.Items.Add(spell.Name);
            }
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            LinkedEditor.ClearForm();
        }
    }
}
