using _5eCharGen.Model;
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
    public partial class ProficiencyEditor : Form
    {
        Lang lang = Lang.GetInstance();
        public ProficiencyEditor()
        {
            InitializeComponent();            
            UpdateIndex();
            UpdateStrings();
            comboBoxFieldProficiencySelect.ComboBoxTextChanged +=
                new EventHandler(comboBoxFieldProficiencySelect_SelectedIndexChanged);
        }

        private void UpdateStrings()
        {
            comboBoxFieldProficiencySelect.LabelText = lang.Get("SELECT_PROFICIENCY");
            textFieldProfName.LabelText = lang.Get("LABEL_NAME");
            comboBoxProfType.LabelText = lang.Get("LABEL_TYPE");
            comboBoxFieldDerivedStat.LabelText = lang.Get("LABEL_DERIVED_STAT");


        }
        private void comboBoxFieldProficiencySelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFieldProficiencySelect.ComboBox.SelectedItem != null)
            {
                string spellName = comboBoxFieldProficiencySelect.ComboBox.SelectedItem.ToString();
                LoadProficiency(spellName);
            }
        }

        private void LoadProficiency(string name)
        {
            Proficiency pf = Data.GetProficiency(name);
            textFieldProfName.Text = pf.Name;
            comboBoxProfType.ComboBox.SelectedIndex = (int)pf.Type;
            comboBoxFieldDerivedStat.ComboBox.SelectedIndex = ((int)pf.DerivedStat >= 8 &&
                (int)pf.DerivedStat <= 13) ? (int)pf.DerivedStat : -1;
        }

        private void UpdateIndex()
        {
            comboBoxProfType.ComboBox.Items.Clear();

            for (ProfType pt = ProfType.Weapon; pt <= ProfType.Tool; pt++)
            {
                comboBoxProfType.ComboBox.Items.Add(pt);
            }

            comboBoxFieldProficiencySelect.ComboBox.Items.Clear();
            foreach (Proficiency pf in Data.GetAllProficiencies().OrderBy(x => x.Name))
            {
                comboBoxFieldProficiencySelect.ComboBox.Items.Add(pf.Name);
            }

            comboBoxFieldDerivedStat.ComboBox.Items.Clear();
            for (NotationType stat = NotationType.STR; stat <= NotationType.CHA; stat++)
            {
                comboBoxFieldDerivedStat.ComboBox.Items.Add(stat);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Proficiency pf = new Proficiency();
            pf.Name = textFieldProfName.Text;
            pf.Type = (ProfType)comboBoxProfType.ComboBox.SelectedIndex;
            pf.DerivedStat = comboBoxFieldDerivedStat.ComboBox.SelectedIndex != -1 ?
                (NotationType)comboBoxFieldDerivedStat.ComboBox.SelectedIndex : NotationType.PROF;
            try
            {
                Data.RemoveProficiency(pf.Name);
            }
            catch (KeyNotFoundException)
            {
                // If KeyNotFound we'll just add our new spell
            }
            finally
            {
                Data.AddProficiency(pf);

            }
            ClearForm();
            UpdateIndex();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (comboBoxFieldProficiencySelect.ComboBox.SelectedItem != null)
            {
                string pf = comboBoxFieldProficiencySelect.ComboBox.SelectedItem.ToString();
                DialogResult dr = MessageBox.Show(string.Format(lang.Get("CONFIRM_REMOVAL"), lang.Get("PROFICIENCY")
                    , pf), lang.Get("CONFIRM"), MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        Data.RemoveProficiency(pf);
                        goto default;
                    default:
                        ClearForm();
                        UpdateIndex();
                        break;
                }
            }
        }

        private void ClearForm()
        {
            textFieldProfName.Text = string.Empty;
            UpdateIndex();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
