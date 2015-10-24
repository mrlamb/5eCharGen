using _5eCharGen.Model;
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
        public ProficiencyEditor()
        {
            InitializeComponent();
            UpdateIndex();
            comboBoxFieldProficiencySelect.ComboBoxTextChanged += 
                new EventHandler(comboBoxFieldProficiencySelect_SelectedIndexChanged);
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
            comboBoxProfType.ComboBox.SelectedIndex = (int) pf.Type;
        }

        private void UpdateIndex()
        {
            comboBoxProfType.ComboBox.Items.Clear();

            for (ProfType pt = ProfType.Weapon; pt <= ProfType.Tool; pt++)
            {
                comboBoxProfType.ComboBox.Items.Add(pt.ToString());
            }

            comboBoxFieldProficiencySelect.ComboBox.Items.Clear();
            foreach (Proficiency pf in Data.GetAllProficiencies().OrderBy(x => x.Name))
            {
                comboBoxFieldProficiencySelect.ComboBox.Items.Add(pf.Name);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Proficiency pf = new Proficiency();
            pf.Name = textFieldProfName.Text;
            pf.Type = (ProfType) comboBoxProfType.ComboBox.SelectedIndex;
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
            string pf = comboBoxFieldProficiencySelect.ComboBox.SelectedItem.ToString();
            if (pf.Length > 0)
            {
                DialogResult dr = MessageBox.Show(string.Format("Are you sure you want to remove the proficiency: {0}"
                    , pf), "Confirm", MessageBoxButtons.YesNo);
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
