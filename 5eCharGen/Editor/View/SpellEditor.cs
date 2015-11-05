using _5eCharGen.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using _5eCharGen.View.Localization;

namespace _5eCharGen.Editor.View
{
    public partial class SpellEditor : Form
    {
        static readonly SpellEditor instance = new SpellEditor();
        ToolTip tt = new ToolTip();
        public string SpellName
        {
            get { return textFieldSpellName.Text; }
            set { textFieldSpellName.Text = value; }
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

        public string Description
        {
            get { return textBoxDescription.Text; }
            set { textBoxDescription.Text = value; }
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
            for (int i = 0; i < 10; i++)
            {
                comboBoxFieldSpellLevel.ComboBox.Items.Add(i.ToString());
            }

            comboBoxSpellSchool.ComboBox.Items.AddRange(new string[] {
                "Abjuration", "Alteration", "Conjuration", "Divination",
                "Evocation", "Illusion", "Necromancy", "Transmutation"});

            comboBoxCastTime.Items.AddRange(new string[] { "bonus action",
                "reaction", "turn", "minute(s)", "hour(s)" });

            UpdateIndex();
            UpdateStrings();
        }

        private void UpdateStrings()
        {
            tt.SetToolTip(buttonSave, Language.GetLocalizedString("BTN_SAVE"));
            tt.SetToolTip(buttonAddNew, Language.GetLocalizedString("BTN_NEW"));
            tt.SetToolTip(buttonRemove, Language.GetLocalizedString("BTN_REMOVE"));

            textFieldSpellName.LabelText = Language.GetLocalizedString("LABEL_NAME");
            comboBoxFieldSpellLevel.LabelText = Language.GetLocalizedString("LABEL_LEVEL");
            comboBoxSpellSchool.LabelText = Language.GetLocalizedString("LABEL_SCHOOL");
            labelCastTime.Text = Language.GetLocalizedString("LABEL_CAST_TIME");
            textFieldRange.LabelText = Language.GetLocalizedString("LABEL_RANGE");
            textFieldDuration.LabelText = Language.GetLocalizedString("LABEL_DURATION");
            checkBoxRitual.Text = Language.GetLocalizedString("LABEL_RITUAL");
            labelDesc.Text = Language.GetLocalizedString("LABEL_DESCRIPTION");
            comboBoxFieldSpellSelect.LabelText = Language.GetLocalizedString("SELECT_SPELL");

        }

        private void comboBoxFieldSpellSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFieldSpellSelect.ComboBox.SelectedItem != null)
            {
                LoadSpell(comboBoxFieldSpellSelect.ComboBox.SelectedItem.ToString());
            }
        }

        private void UpdateIndex()
        {
            comboBoxFieldSpellSelect.ComboBox.Items.Clear();
            comboBoxFieldSpellSelect.ComboBox.Items.AddRange(Data.GetAllSpells().OrderBy(x => x.Name).ToArray());
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
            if (SpellName.Length == 0)
            {
                MessageBox.Show(Language.GetLocalizedString("INVALID_NAME"));
                return;
            }
            newSpell.Name = SpellName;
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

            Data.AddSpell(newSpell);

            UpdateIndex();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (comboBoxFieldSpellSelect.ComboBox.SelectedItem == null)
                return;

            string spellName = comboBoxFieldSpellSelect.ComboBox.SelectedItem.ToString();
            if (spellName.Length > 0)
            {
                DialogResult dr = MessageBox.Show(string.Format(Language.GetLocalizedString("CONFIRM_REMOVAL"),
                    Language.GetLocalizedString("SPELL"), spellName),
                    Language.GetLocalizedString("CONFIRM"), MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        Data.RemoveSpell(spellName);
                        ClearForm();
                        UpdateIndex();
                        break;
                }
            }
        }
    }
}
