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
    public partial class RaceEditor : Form
    {
        ToolTip tt = new ToolTip();
        public RaceEditor()
        {
            InitializeComponent();
            CustomInitialize();
        }

        private void CustomInitialize()
        {
            UpdateIndex();
            UpdateSharedIndex();
            UpdateStrings();
            Data.AddUpdater(UpdateSharedIndex);
        }

        private void UpdateStrings()
        {
            tt.SetToolTip(btnAdd, Language.GetLocalizedString("BTN_NEW"));
            tt.SetToolTip(btnRemove, Language.GetLocalizedString("BTN_REMOVE"));
            tt.SetToolTip(btnSave, Language.GetLocalizedString("BTN_SAVE"));
            tt.SetToolTip(btnAddSA, Language.GetLocalizedString("BTN_ADD_SA"));
            tt.SetToolTip(btnRemoveSA, Language.GetLocalizedString("BTN_REMOVE_SA"));
            tt.SetToolTip(btnAddLanguage, Language.GetLocalizedString("BTN_ADD_LANGUAGE"));
            tt.SetToolTip(btnRemoveLanguage, Language.GetLocalizedString("BTN_REMOVE_LANGUAGE"));

            cmbSelectRace.LabelText = Language.GetLocalizedString("SELECT_RACE");
            txtName.LabelText = Language.GetLocalizedString("LABEL_NAME");
            chkSubrace.Text = Language.GetLocalizedString("LABEL_SUBRACE_OF");
            txtLanguagesAdd.LabelText = Language.GetLocalizedString("ADD_LANGUAGE");
            lblSpeed.Text = Language.GetLocalizedString("LABEL_SPEED");
            lblDescription.Text = Language.GetLocalizedString("LABEL_DESCRIPTION");
            cmbSAAdd.LabelText = Language.GetLocalizedString("SELECT_ABILITY");

        }

        private void UpdateIndex()
        {
            cmbSelectRace.ComboBox.Items.Clear();
            cmbSelectRace.ComboBox.Items.AddRange(Data.GetAllRaces().OrderBy(x => x.Name).ToArray());

            cmbParentRace.Items.Clear();
            cmbParentRace.Items.AddRange(Data.GetAllRaces().OrderBy(x => x.Name).ToArray());

        }

        private void UpdateSharedIndex()
        {
            cmbSAAdd.ComboBox.Items.Clear();
            cmbSAAdd.ComboBox.Items.AddRange(Data.GetAllSAs().OrderBy(x => x.Name).ToArray());

        }

        private void ClearForm()
        {
            chkSubrace.Checked = false;
            txtLanguagesAdd.Text = string.Empty;
            txtName.Text = string.Empty;
            txtSpeed.Text = string.Empty;
            lstLanguages.Items.Clear();
            cmbParentRace.SelectedIndex = -1;
            cmbParentRace.Text = string.Empty;
            txtDescription.Text = string.Empty;
            cmbSAAdd.ComboBox.SelectedIndex = -1;
            cmbSAAdd.Text = string.Empty;
            lstSA.Items.Clear();
            smallAttBlock1.STR = 0;
            smallAttBlock1.DEX = 0;
            smallAttBlock1.CON = 0;
            smallAttBlock1.INT = 0;
            smallAttBlock1.WIS = 0;
            smallAttBlock1.CHA = 0;
        }

        private void chkSubrace_CheckedChanged(object sender, EventArgs e)
        {
            cmbParentRace.Enabled = (sender as CheckBox).Checked;
            if (!cmbParentRace.Enabled)
            {
                cmbParentRace.SelectedIndex = -1;
                cmbParentRace.Text = string.Empty;
            }
        }

        private void btnAddLanguage_Click(object sender, EventArgs e)
        {
            if (txtLanguagesAdd.Text != null)
            {
                lstLanguages.Items.Add(txtLanguagesAdd.Text);
                txtLanguagesAdd.Text = string.Empty;
            }
        }

        private void txtLanguagesAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Return && txtLanguagesAdd.Text != null)
            {
                lstLanguages.Items.Add(txtLanguagesAdd.Text);
                txtLanguagesAdd.Text = string.Empty;
            }
        }

        private void btnRemoveLanguage_Click(object sender, EventArgs e)
        {
            if (lstLanguages.SelectedItem != null)
            {
                lstLanguages.Items.Remove(lstLanguages.SelectedItem);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearForm();
            UpdateIndex();
        }

        private void btnAddSA_Click(object sender, EventArgs e)
        {
            if (cmbSAAdd.ComboBox.SelectedItem != null)
            {
                lstSA.Items.Add(cmbSAAdd.ComboBox.SelectedItem.ToString());
                cmbSAAdd.ComboBox.SelectedIndex = -1;
                cmbSAAdd.ComboBox.Text = string.Empty;
            }
        }

        private void btnRemoveSA_Click(object sender, EventArgs e)
        {
            if (lstSA.SelectedItem != null)
            {
                lstSA.Items.Remove(lstSA.SelectedItem);
            }
        }
        private void cmbSelectRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectRace.ComboBox.SelectedItem != null)
            {
                LoadRace(cmbSelectRace.ComboBox.SelectedItem.ToString());
            }
        }

        private void LoadRace(string v)
        {
            Race race = Data.GetRace(v);
            txtName.Text = race.Name;
            txtDescription.Text = race.Description;
            txtSpeed.Text = race.Speed.ToString();
            lstLanguages.Items.AddRange(race.Languages.ToArray());
            lstSA.Items.AddRange(race.RacialAbilities.ToArray());
            chkSubrace.Checked = race.Subrace;
            cmbParentRace.SelectedIndex = cmbParentRace.FindStringExact(race.ParentRace);
            smallAttBlock1.STR = race.RacialStatChange["STR"];
            smallAttBlock1.DEX = race.RacialStatChange["DEX"];
            smallAttBlock1.CON = race.RacialStatChange["CON"];
            smallAttBlock1.INT = race.RacialStatChange["INT"];
            smallAttBlock1.WIS = race.RacialStatChange["WIS"];
            smallAttBlock1.CHA = race.RacialStatChange["CHA"];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == null)
            {
                MessageBox.Show(Language.GetLocalizedString("INVALID_NAME"));
                return;
            }

            if (chkSubrace.Checked && cmbParentRace.SelectedItem == null)
            {
                MessageBox.Show(Language.GetLocalizedString("NO_PARENT_RACE_SELECTED"));
                return;
            }

            int speed = 0;
            if (txtSpeed.Text.Length > 0 && !Int32.TryParse(txtSpeed.Text, out speed))
            {
                MessageBox.Show(Language.GetLocalizedString("INVALID_BASE_SPEED"));
            }

            Race newRace = new Race();
            newRace.Name = txtName.Text;
            newRace.Description = txtDescription.Text;
            newRace.Speed = speed;
            foreach (string language in lstLanguages.Items)
            {
                newRace.Languages.Add(language);
            }

            foreach (string specialAbility in lstSA.Items)
            {
                newRace.RacialAbilities.Add(specialAbility);
            }
            newRace.Subrace = chkSubrace.Checked;
            if (chkSubrace.Checked)
            {
                newRace.ParentRace = cmbParentRace.SelectedItem.ToString();
            }
            newRace.RacialStatChange["STR"] = smallAttBlock1.STR;
            newRace.RacialStatChange["DEX"] = smallAttBlock1.DEX;
            newRace.RacialStatChange["CON"] = smallAttBlock1.CON;
            newRace.RacialStatChange["INT"] = smallAttBlock1.INT;
            newRace.RacialStatChange["WIS"] = smallAttBlock1.WIS;
            newRace.RacialStatChange["CHA"] = smallAttBlock1.CHA;

            Data.AddRace(newRace);

            UpdateIndex();
            ClearForm();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cmbSelectRace.ComboBox.SelectedItem == null)
                return;

            DialogResult dr = MessageBox.Show(string.Format(Language.GetLocalizedString("CONFIRM_REMOVAL"),
                Language.GetLocalizedString("RACE"), cmbSelectRace.ComboBox.SelectedItem.ToString())
                , Language.GetLocalizedString("CONFIRM"), MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    Data.RemoveRace(cmbSelectRace.ComboBox.SelectedItem.ToString());
                    ClearForm();
                    UpdateIndex();
                    break;
            }
        }

        private void RaceEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Data.RemoveUpdater(UpdateSharedIndex);
        }
    }
}
