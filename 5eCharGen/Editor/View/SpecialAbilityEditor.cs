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
        private Lang lang = Lang.GetInstance();
        private ToolTip tt = new ToolTip();

        public SpecialAbilityEditor()
        {
            InitializeComponent();
            UpdateIndex();
            UpdateStrings();
        }

        private void UpdateStrings()
        {
            // Set tooltips
            tt.SetToolTip(buttonAddProf, lang.Get("BTN_ADD_PROF"));
            tt.SetToolTip(buttonAddProfValue, lang.Get("BTN_ADD_PROF_VALUE"));
            tt.SetToolTip(buttonAddNewProf, lang.Get("BTN_ADD_NEW_PROF"));
            tt.SetToolTip(buttonRefresh, lang.Get("BTN_REFRESH"));

            comboBoxFieldSAName.LabelText = lang.Get("SELECT_ABILITY");
            Summary.Text = lang.Get("SHOW_SUMMARY");
            tabPageBasicStats.Text = lang.Get("LABEL_BASICS");
            tabPageAttributes.Text = lang.Get("LABEL_ATTRIBUTES");
            tabPageProf.Text = lang.Get("LABEL_PROFICIENCIES");
            tabPageSpells.Text = lang.Get("LABEL_SPELLS");
            tabPageMisc.Text = lang.Get("LABEL_MISC");
            labelDescription.Text = lang.Get("LABEL_DESCRIPTION");
            labelInstACSpeed.Text = lang.Get("INSTRUCTIONS_INPUT_VALUES");
            textFieldControlSpeed.LabelText = lang.Get("AC_BONUS");
            textFieldControlAC.LabelText = lang.Get("SPEED_BONUS");
            textFieldControlName.LabelText = lang.Get("LABEL_NAME");
            comboBoxFieldControlProfName.LabelText = lang.Get("SELECT_PROFICIENCY");
            comboBoxFieldSpellName.LabelText = lang.Get("SELECT_SPELL");
            labelAddProf.Text = lang.Get("SAE_ADD_PROF");
            labelAdd.Text = lang.Get("SAE_LABEL_ADD");
            labelAddProfValue.Text = lang.Get("SAE_ADD_PROF_HELP");
            labelAddProfValue.Text = lang.Get("SAE_LABEL_ADD_TO_PROF");





        }

        private void UpdateIndex()
        {
            comboBoxFieldSAName.ComboBox.Items.Clear();

            foreach (SpecialAbility sa in Data.GetAllSAs().OrderBy(x => x.Name))
            {
                comboBoxFieldSAName.ComboBox.Items.Add(sa.Name);
            }

            comboBoxFieldSAName.ComboBoxTextChanged +=
                new EventHandler(comboBoxFieldSAName_SelectedIndexChanged);

            comboBoxFieldControlProfName.ComboBox.Items.Clear();
            foreach (Proficiency pf in Data.GetAllProficiencies().OrderBy(x => x.Name))
            {
                comboBoxFieldControlProfName.ComboBox.Items.Add(pf.Name);
            }

            comboBoxFieldSpellName.ComboBox.Items.Clear();
            foreach (Spell spell in Data.GetAllSpells().OrderBy(x => x.Name))
            {
                comboBoxFieldSpellName.ComboBox.Items.Add(spell.Name);
            }
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
                        MessageBox.Show(lang.Get("NO_DUPLICATES"));
                        return;
                    }
                }
                comboBoxProfAdded.Items.Add(comboBoxFieldControlProfName.ComboBox.Text);
                comboBoxProfAdded.SelectedIndex = comboBoxProfAdded.Items.Count - 1;
            }
            else
            {
                MessageBox.Show(lang.Get("SELECT_PROFICIENCY"));
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
                MessageBox.Show(lang.Get("MISSING_STAT_NUMERAL"));
            }
            else if (comboBoxFieldControlProfName.ComboBox.SelectedIndex == -1)
            {
                MessageBox.Show(lang.Get("SELECT_PROFICIENCY"));
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
                    MessageBox.Show(lang.Get("MISSING_STAT_NUMERAL"), lang.Get("INPUT_ERROR"));
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
            if (comboBoxFieldSAName.ComboBox.SelectedItem != null)
            {
                string sa = comboBoxFieldSAName.ComboBox.SelectedItem.ToString();
                DialogResult dr = MessageBox.Show(string.Format(lang.Get("CONFIRM_REMOVAL"),
                    lang.Get("SPECIAL_ABILITY"), sa), lang.Get("CONFIRM"), MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        Data.RemoveSA(sa);
                        goto default;
                    default:
                        ClearForm();
                        UpdateIndex();
                        break;
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textFieldControlName.Text.Length == 0)
            {
                MessageBox.Show(string.Format(lang.Get("INSTRUCTIONS_NAME"), lang.Get("SPECIAL_ABILITY")));
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
                            MessageBox.Show(String.Format(lang.Get("INVALID_ENTRY_UNSUPPORTED"), ctrl.Text));
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
            try
            {
                Data.RemoveSA(sa.Name);
            }
            catch (KeyNotFoundException)
            {
                // If KeyNotFound we'll just add our new spell
            }
            finally
            {
                Data.AddSA(sa);

            }
            ClearForm();
            UpdateIndex();


        }

        private void Summary_CheckedChanged(object sender, EventArgs e)
        {
            if (Summary.Checked)
            {
                this.Height += 200;
            }
            else
            {
                this.Height -= 200;
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
    }
}
