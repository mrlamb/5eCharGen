using _5eCharGen.View;
using _5eCharGen.View.Localization;
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
    public partial class SpecialAbilityEditor : Form
    {
        private ToolTip tt = new ToolTip();
        private Label lblSummary;

        public SpecialAbilityEditor()
        {
            InitializeComponent();
            UpdateIndex();
            UpdateSharedIndex();
            UpdateStrings();
            Data.AddUpdater(UpdateSharedIndex);

        }

        private void UpdateStrings()
        {
            // Set tooltips
            tt.SetToolTip(buttonAddProf, Language.GetLocalizedString("BTN_ADD_PROF"));
            tt.SetToolTip(buttonAddProfValue, Language.GetLocalizedString("BTN_ADD_PROF_VALUE"));
            tt.SetToolTip(buttonAddNewProf, Language.GetLocalizedString("BTN_ADD_NEW_PROF"));
            tt.SetToolTip(buttonRefresh, Language.GetLocalizedString("BTN_REFRESH"));
            tt.SetToolTip(buttonSave, Language.GetLocalizedString("BTN_SAVE"));
            tt.SetToolTip(buttonAddNew, Language.GetLocalizedString("BTN_NEW"));
            tt.SetToolTip(buttonRemove, Language.GetLocalizedString("BTN_REMOVE"));

            comboBoxFieldSAName.LabelText = Language.GetLocalizedString("SELECT_ABILITY");
            Summary.Text = Language.GetLocalizedString("SHOW_SUMMARY");
            tabPageBasicStats.Text = Language.GetLocalizedString("LABEL_BASICS");
            tabPageAttributes.Text = Language.GetLocalizedString("LABEL_ATTRIBUTES");
            tabPageProf.Text = Language.GetLocalizedString("LABEL_PROFICIENCIES");
            tabPageSpells.Text = Language.GetLocalizedString("LABEL_SPELLS");
            tabPageMisc.Text = Language.GetLocalizedString("LABEL_MISC");
            labelDescription.Text = Language.GetLocalizedString("LABEL_DESCRIPTION");
            labelInstACSpeed.Text = Language.GetLocalizedString("INSTRUCTIONS_INPUT_VALUES");
            textFieldControlAC.LabelText = Language.GetLocalizedString("AC_BONUS");
            textFieldControlSpeed.LabelText = Language.GetLocalizedString("SPEED_BONUS");
            textFieldControlName.LabelText = Language.GetLocalizedString("LABEL_NAME");
            comboBoxFieldControlProfName.LabelText = Language.GetLocalizedString("SELECT_PROFICIENCY");
            comboBoxFieldSpellName.LabelText = Language.GetLocalizedString("SELECT_SPELL");
            labelAddProf.Text = Language.GetLocalizedString("SAE_ADD_PROF");
            labelAdd.Text = Language.GetLocalizedString("SAE_LABEL_ADD");
            labelAddProfValue.Text = Language.GetLocalizedString("SAE_ADD_PROF_HELP");
            labelAddProfValue.Text = Language.GetLocalizedString("SAE_LABEL_ADD_TO_PROF");





        }

        private void UpdateIndex()
        {
            comboBoxFieldSAName.ComboBox.Items.Clear();
            comboBoxFieldSAName.ComboBox.Items.AddRange(Data.GetAllSAs().OrderBy(x => x.Name).ToArray());
        }

        private void UpdateSharedIndex()
        {
            comboBoxFieldControlProfName.ComboBox.Items.Clear();
            comboBoxFieldControlProfName.ComboBox.Items.AddRange
                (Data.GetAllProficiencies().OrderBy(x => x.Name).ToArray());

            comboBoxFieldSpellName.ComboBox.Items.Clear();
            comboBoxFieldSpellName.ComboBox.Items.AddRange(Data.GetAllSpells().OrderBy(x => x.Name).ToArray());
        }

        private void comboBoxFieldSAName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFieldSAName.ComboBox.SelectedItem != null)
            {
                LoadSA(comboBoxFieldSAName.ComboBox.SelectedItem.ToString());
            }
        }

        private void LoadSA(string name)
        {
            SpecialAbility sa = Data.GetSA(name);

            //Basics tab
            textFieldControlName.Text = sa.Name;
            textBoxDescription.Text = sa.Description;

            //Attribute tab
            foreach (Control ctrl in tabPageAttributes.Controls)
            {
                if (ctrl is TextFieldControl)
                {
                    if (sa.AttributeBonus.ContainsKey(ctrl.Name.Substring(ctrl.Name.Length - 3)))
                    {
                        ctrl.Text = sa.AttributeBonus[ctrl.Name.Substring(ctrl.Name.Length - 3)].ToString();
                    }
                    else
                    {
                        (ctrl as TextFieldControl).Text = string.Empty;
                    }
                }
            }

            //Proficiencies tab
            foreach (string pf in sa.ProficienciesAdded)
            {
                comboBoxProfAdded.Items.Add(pf);
            }

            foreach (KeyValuePair<string, string> pair in sa.ProficienciesAltered)
            {
                comboBoxProfValue.Items.Add(String.Format("{0} - {1}", pair.Key, pair.Value));
            }

            //Spells tab
            foreach (string spell in sa.SpellsAdded)
            {
                comboBoxSpellsAdded.Items.Add(spell);
            }

            //Misc tab
            textFieldControlSpeed.Text = sa.SpeedIncrease;
            textFieldControlAC.Text = sa.ACBonus;

        }

        private void buttonAddProf_Click(object sender, EventArgs e)
        {
            if (comboBoxFieldControlProfName.ComboBox.SelectedItem != null)
            {
                foreach (string name in comboBoxProfAdded.Items)
                {
                    if (name.Equals(comboBoxFieldControlProfName.ComboBox.SelectedItem.ToString()))
                    {
                        MessageBox.Show(Language.GetLocalizedString("NO_DUPLICATES"));
                        return;
                    }
                }
                comboBoxProfAdded.Items.Add(comboBoxFieldControlProfName.ComboBox.Text);
                comboBoxProfAdded.SelectedIndex = comboBoxProfAdded.Items.Count - 1;
            }
            else
            {
                MessageBox.Show(Language.GetLocalizedString("SELECT_PROFICIENCY"));
            }
        }

        private void buttonRemoveProf_Click(object sender, EventArgs e)
        {
            if (comboBoxProfAdded.SelectedItem != null)
            {
                comboBoxProfAdded.Items.Remove(comboBoxProfAdded.SelectedItem);
                comboBoxProfAdded.SelectedIndex = -1;
                comboBoxProfAdded.Text = string.Empty;
            }
        }

        private void buttonAddProfValue_Click(object sender, EventArgs e)
        {
            int value;
            NotationType type;
            if (textBoxProfValue.Text.Length == 0)
            {
                MessageBox.Show(Language.GetLocalizedString("MISSING_STAT_NUMERAL"));
            }
            else if (comboBoxFieldControlProfName.ComboBox.SelectedIndex == -1)
            {
                MessageBox.Show(Language.GetLocalizedString("SELECT_PROFICIENCY"));
            }
            else
            {
                if (Int32.TryParse(textBoxProfValue.Text, out value))
                {
                    comboBoxProfValue.Items.Add(String.Format("{0} - {1}",
                        comboBoxFieldControlProfName.ComboBox.Text, textBoxProfValue.Text));
                    comboBoxProfValue.SelectedIndex = comboBoxProfValue.Items.Count - 1;
                }
                else if (Enum.TryParse<NotationType>(textBoxProfValue.Text, out type))
                {
                    comboBoxProfValue.Items.Add(String.Format("{0} - {1}",
                      comboBoxFieldControlProfName.ComboBox.Text, textBoxProfValue.Text));
                    comboBoxProfValue.SelectedIndex = comboBoxProfValue.Items.Count - 1;
                }
                else
                {
                    MessageBox.Show(Language.GetLocalizedString("MISSING_STAT_NUMERAL"), Language.GetLocalizedString("INPUT_ERROR"));
                }
            }
        }

        private void buttonRemoveProfValue_Click(object sender, EventArgs e)
        {
            if (comboBoxProfValue.SelectedItem != null)
            {
                comboBoxProfValue.Items.Remove(comboBoxProfValue.SelectedItem);
                comboBoxProfValue.SelectedIndex = -1;
                comboBoxProfValue.Text = string.Empty;
            }
        }

        private void buttonAddSpell_Click(object sender, EventArgs e)
        {
            if (comboBoxFieldSpellName.ComboBox.SelectedItem != null)
            {
                comboBoxSpellsAdded.Items.Add(comboBoxFieldSpellName.Text);
            }
        }

        private void buttonRemoveSpell_Click(object sender, EventArgs e)
        {
            if (comboBoxSpellsAdded.SelectedItem != null)
            {
                comboBoxSpellsAdded.Items.Remove(comboBoxSpellsAdded.SelectedItem);
                comboBoxSpellsAdded.SelectedIndex = -1;
                comboBoxSpellsAdded.Text = string.Empty;
            }
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            ClearForm();
            UpdateIndex();
        }

        private void ClearForm()
        {
            //Basics tab
            textFieldControlName.Text = string.Empty;
            textBoxDescription.Text = string.Empty;

            // Attributes tab
            foreach (Control ctrl in tabPageAttributes.Controls)
            {
                if (ctrl is TextFieldControl)
                {
                    (ctrl as TextFieldControl).Text = string.Empty;
                }
            }

            // Proficiencies Tab
            comboBoxProfAdded.Items.Clear();
            comboBoxProfValue.Items.Clear();
            textBoxProfValue.Text = string.Empty;

            // Spells tab
            comboBoxSpellsAdded.Items.Clear();

            // Misc tab
            textFieldControlSpeed.Text = string.Empty;
            textFieldControlAC.Text = string.Empty;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (comboBoxFieldSAName.ComboBox.SelectedItem == null)
                return;

            DialogResult dr = MessageBox.Show(string.Format(Language.GetLocalizedString("CONFIRM_REMOVAL"),
                Language.GetLocalizedString("SPECIAL_ABILITY"), comboBoxFieldSAName.ComboBox.SelectedItem.ToString())
                , Language.GetLocalizedString("CONFIRM"), MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    Data.RemoveSA(comboBoxFieldSAName.ComboBox.SelectedItem.ToString());
                    ClearForm();
                    UpdateIndex();
                    break;
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textFieldControlName.Text.Length == 0)
            {
                MessageBox.Show(string.Format(Language.GetLocalizedString("INSTRUCTIONS_NAME"), Language.GetLocalizedString("SPECIAL_ABILITY")));
                return;
            }

            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (Control ctrl in tabPageAttributes.Controls)
            {
                int value;
                if (ctrl is TextFieldControl && ctrl.Tag != null)
                {
                    if (Int32.TryParse((ctrl as TextFieldControl).Text, out value))
                    {
                        dict.Add(ctrl.Name.Substring(ctrl.Name.Length - 3), value);
                    }
                    else
                    {
                        if (ctrl.Text.Length != 0)
                        {
                            MessageBox.Show(String.Format(Language.GetLocalizedString("INVALID_ENTRY_UNSUPPORTED"), ctrl.Text));
                            return;
                        }
                    }
                }
            }


            SpecialAbility sa = new SpecialAbility();
            //Basics tab
            sa.Name = textFieldControlName.Text;
            sa.Description = textBoxDescription.Text;

            //Attributes Tab
            sa.AttributeBonus = dict;

            //Proficiencies Tab
            List<string> profs = new List<String>();
            foreach (object prof in comboBoxProfAdded.Items)
            {
                profs.Add(prof.ToString());
            }
            sa.ProficienciesAdded = profs;


            Dictionary<string, string> profsValue = new Dictionary<string, string>();
            foreach (object prof in comboBoxProfValue.Items)
            {
                profsValue.Add(prof.ToString().Substring(0, prof.ToString().IndexOf('-')),
                    prof.ToString().Substring(prof.ToString().IndexOf('-') + 1));
            }
            sa.ProficienciesAltered = profsValue;

            //Spells tab
            List<string> spells = new List<string>();
            foreach (object spell in comboBoxSpellsAdded.Items)
            {
                spells.Add(spell.ToString());
            }
            sa.SpellsAdded = spells;

            //Misc tab
            sa.SpeedIncrease = textFieldControlSpeed.Text;
            sa.ACBonus = textFieldControlAC.Text;

            //Now....save it.
            Data.AddSA(sa);

            ClearForm();
            UpdateIndex();
            comboBoxFieldSAName.ComboBox.SelectedIndex = comboBoxFieldSAName.ComboBox.FindStringExact(sa.Name);


        }

        private void Summary_CheckedChanged(object sender, EventArgs e)
        {

            if (Summary.Checked)
            {
                this.Height += 200;
                if (lblSummary == null)
                {
                    lblSummary = new Label();
                    lblSummary.Top = this.Height - 200;
                    lblSummary.Left = 23;
                    lblSummary.AutoSize = true;
                    this.Controls.Add(lblSummary);
                }
                if (comboBoxFieldSAName.ComboBox.SelectedItem != null)
                {
                    lblSummary.Text = Data.GetSA(comboBoxFieldSAName.ComboBox.SelectedItem.ToString()).GetSummary();
                }
            }


            else
            {
                this.Height -= 200;
                lblSummary.Text = string.Empty;
            }

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            UpdateIndex();
        }

        private void buttonAddNewProf_Click(object sender, EventArgs e)
        {
            ProficiencyEditor pe = new ProficiencyEditor();
            pe.Show();
        }

        private void SpecialAbilityEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Data.RemoveUpdater(UpdateSharedIndex);
        }
    }
}
