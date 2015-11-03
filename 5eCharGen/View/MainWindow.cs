using _5eCharGen.Editor.View;
using _5eCharGen.View.Localization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5eCharGen.View
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent(); 
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
        }
       
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateNewCharacterTab()
        {
            TabPage tabPage = new TabPage();
            tabCharacters.Controls.Add(tabPage);
            tabPage.Text = "Unknown";

            CharacterControl characterControl = new CharacterControl();
            tabPage.Controls.Add(characterControl);
            characterControl.Dock = DockStyle.Fill;
            characterControl.CharacterNameChange += CharacterControl_CharacterNameChange;
            tabPage.Tag = characterControl;
        }

        private void CharacterControl_CharacterNameChange(object sender, EventArgs e)
        {
            foreach(Control control in tabCharacters.Controls)
            {
                if (control.Tag == sender)
                {
                    control.Text = (sender as CharacterControl).CharacterName;
                    break;
                }
            }
        }

        private void newCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewCharacterTab();
        }

        private void loadCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadCharDialog.ShowDialog();

            //Create new character control using the overload that takes CharacterController as an argument
            // after creating a new CharacterController and deserializing the loaded file into it.
            // Is how I think it should work
        }

        private void spellEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpellEditor se = SpellEditor.Instance;
            se.Location = Location;
            se.Top += 60;
            se.Show();
          
        }

        private void proficiencyEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProficiencyEditor pe = new ProficiencyEditor();
            pe.Location = Location;
            pe.Top += 60;
            pe.Show();
        }

        private void specialAbilityEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpecialAbilityEditor sae = new SpecialAbilityEditor();
            sae.Location = Location;
            sae.Top += 60;
            sae.Show();
        }
    }
}
