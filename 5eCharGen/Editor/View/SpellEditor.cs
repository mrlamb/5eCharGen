using _5eCharGen.View;
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
    public partial class SpellEditor : Form
    {
        static readonly SpellEditor instance = new SpellEditor();

        public static SpellEditor Instance
        {
            get { return instance; }
        }

        private SpellEditor()
        {
            InitializeComponent();
            CustomInitialize();
        }

        private void CustomInitialize()
        {
            for (int i = 0; i < 10; i++)
            {
                comboBoxFieldSpellLevel.ComboBox.Items.Add(i.ToString());
            }

            string[] spellSchools = {"Abjuration", "Alteration", "Conjuration", "Divination",
                                        "Evocation", "Illusion", "Necromancy", "Transmutation" };

            foreach (string school in spellSchools)
            {
                comboBoxSpellSchool.ComboBox.Items.Add(school);
            }

            string[] actionDurations = { "bonus action", "action", "reaction", "turn", "minute(s)", "hour(s)" };

            foreach (string time in actionDurations)
            {
                comboBoxCastTime.Items.Add(time);
            }

            UpdateIndex();
        }

        private void UpdateIndex()
        {
            foreach (Spell spell in Data.GetAllSpells())
            {
                comboBoxFieldSpellSelect.ComboBox.Items.Add(spell.Name);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        public void ClearForm()
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextFieldControl || ctrl is TextBox)
                {
                    ctrl.Text = string.Empty;
                }
                else if (ctrl is SpellComponentsControl)
                {
                    SpellComponentsControl inCtrl = (ctrl as SpellComponentsControl);
                    inCtrl.Verbal = false;
                    inCtrl.Somatic = false;
                    inCtrl.Material = false;
                    inCtrl.Text = string.Empty;
                }
                else if (ctrl is ComboBox)
                {
                    (ctrl as ComboBox).SelectedIndex = -1;
                }
                else if (ctrl is ComboBoxFieldControl)
                {
                    (ctrl as ComboBoxFieldControl).ComboBox.SelectedIndex = -1;
                }
            }
        }

        public void LoadSpell(Spell spell)
        {

        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Spell newSpell = new Spell();
            newSpell.Name = textFieldSpellName.Text.Length > 0 ? textFieldSpellName.Text : "Unnamed Spell";
            newSpell.Level = comboBoxFieldSpellLevel.ComboBox.Items[comboBoxFieldSpellLevel.ComboBox.SelectedIndex].ToString(); 
            newSpell.School = comboBoxSpellSchool.ComboBox.Items[comboBoxSpellSchool.ComboBox.SelectedIndex].ToString();
            newSpell.Components["Verbal"] = spellComponentsControl1.Verbal;
            newSpell.Components["Somatic"] = spellComponentsControl1.Somatic;
            newSpell.Components["Material"] = spellComponentsControl1.Material;

            newSpell.MaterialDescription = spellComponentsControl1.Text;

            newSpell.CastTimeFrontPortion = textBoxCastTimeNumber.Text;
            newSpell.CastTimeAction = comboBoxCastTime.Items[comboBoxCastTime.SelectedIndex].ToString();

            newSpell.Duration = textFieldDuration.Text;
            newSpell.Range = textFieldRange.Text;

            newSpell.Description = textBoxDescription.Lines;

            try
            {
                Spell test = Data.GetSpell(newSpell.Name);
                Data.RemoveSpell(newSpell.Name);
            }
            catch (KeyNotFoundException)
            {
                // If KeyNotFound we'll just add our new spell
            }
            finally
            {
                Data.AddSpell(newSpell);
            }

        }
    }
}
