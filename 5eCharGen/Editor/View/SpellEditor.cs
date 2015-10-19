using _5eCharGen.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace _5eCharGen.Editor.View
{
    public partial class SpellEditor : Form
    {
        static readonly SpellEditor instance = new SpellEditor();
        public string SpellName
        {
            get {return textFieldSpellName.Text; }
            set { textFieldSpellName.Text = value;  }
        }

        public int Level
        {
            get { return comboBoxFieldSpellLevel.ComboBox.SelectedIndex > -1 ? comboBoxFieldSpellLevel.ComboBox.SelectedIndex : 0; }
            set { comboBoxFieldSpellLevel.ComboBox.SelectedIndex = value; }
        }

        public int School
        {
            get { return comboBoxSpellSchool.ComboBox.SelectedIndex > -1 ? comboBoxSpellSchool.ComboBox.SelectedIndex : 0; }
            set { comboBoxSpellSchool.ComboBox.SelectedIndex = value; }
        }

        public bool Verbal
        {
            get { return spellComponentsControl1.Verbal; }
            set { spellComponentsControl1.Verbal = value; }
        }

        public bool Somatic
        {
            get { return spellComponentsControl1.Somatic; }
            set { spellComponentsControl1.Somatic = value; }
        }

        public bool Material
        {
            get { return spellComponentsControl1.Material; }
            set { spellComponentsControl1.Material = value; }
        }

        public string MaterialDescription
        {
            get { return spellComponentsControl1.Text; }
            set { spellComponentsControl1.Text = value; }
        }

        public string CastTimeNumber
        {
            get { return textBoxCastTimeNumber.Text; }
            set { textBoxCastTimeNumber.Text = value; }
        }

        public static SpellEditor Instance
        {
            get { return instance; }
        }

        public int CastTimeAction
        {
            get { return comboBoxCastTime.SelectedIndex > -1 ? comboBoxCastTime.SelectedIndex : 0; }
            set { comboBoxCastTime.SelectedIndex = value; }
        }

        public string Range
        {
            get { return textFieldRange.Text; }
            set { textFieldRange.Text = value; }
        }

        public string Duration
        {
            get { return textFieldDuration.Text; }
            set { textFieldDuration.Text = value; }
        }

        public string[] Description
        {
            get { return textBoxDescription.Lines; }
            set { textBoxDescription.Lines = value; }
        }

        public bool Ritual
        {
            get { return checkBoxRitual.Checked; }
            set { checkBoxRitual.Checked = value; }
        }

        private SpellEditor()
        {
            InitializeComponent();
            CustomInitialize();
        }

        private void CustomInitialize()
        {
            comboBoxFieldSpellSelect.ComboBoxTextChanged += new EventHandler(comboBoxFieldSpellSelect_SelectedIndexChanged);

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

        private void comboBoxFieldSpellSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFieldSpellSelect.ComboBox.SelectedItem != null)
            {
                string spellName = comboBoxFieldSpellSelect.ComboBox.SelectedItem != null ? comboBoxFieldSpellSelect.ComboBox.SelectedItem.ToString() : string.Empty;
                LoadSpell(spellName);
            }
        }

        private void UpdateIndex()
        {
            comboBoxFieldSpellSelect.ComboBox.Items.Clear();
            foreach (Spell spell in Data.GetAllSpells().OrderBy(x => x.Name))
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

        public void LoadSpell(String spellName)
        {
            Spell spell = Data.GetSpell(spellName);
            SpellName = spell.Name;
            Level = spell.Level;
            School = spell.School;
            Verbal = spell.Components["Verbal"];
            Somatic = spell.Components["Somatic"];
            Material = spell.Components["Material"];
            MaterialDescription = spell.MaterialDescription;
            CastTimeNumber = spell.CastTimeFrontPortion;
            CastTimeAction = spell.CastTimeAction;
            Duration = spell.Duration;
            Range = spell.Range;
            Description = spell.Description;
            Ritual = spell.Ritual;

        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Spell newSpell = new Spell();
            newSpell.Name = SpellName.Length > 0 ? textFieldSpellName.Text : "Unnamed Spell";
            newSpell.Level = Level > -1 ? Level : 0;
            newSpell.School = School > -1 ? School : 0;
            newSpell.Components["Verbal"] = Verbal;
            newSpell.Components["Somatic"] = Somatic;
            newSpell.Components["Material"] = Material;
            newSpell.MaterialDescription = MaterialDescription;
            newSpell.CastTimeFrontPortion = CastTimeNumber;
            newSpell.CastTimeAction = CastTimeAction;
            newSpell.Duration = Duration;
            newSpell.Range = Range;
            newSpell.Description = Description;
            newSpell.Ritual = Ritual;

            try
            {
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
            UpdateIndex();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            string spellName = comboBoxFieldSpellSelect.ComboBox.SelectedItem.ToString();
            if (spellName.Length > 0)
            {
                DialogResult dr = MessageBox.Show(string.Format("Are you sure you want to remove the spell: {0}", spellName), "Confirm", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        Data.RemoveSpell(spellName);
                        goto default;
                    default:
                        UpdateIndex();
                        break;
                }
            }
        }
    }
}
