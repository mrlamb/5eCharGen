using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _5eCharGen.Controller;

namespace _5eCharGen.View
{
    public partial class CharacterControl : UserControl
    {
        public CharacterController Character { get; set; }
        public string CharacterName { set; get; }

        public event EventHandler CharacterNameChange;

        public CharacterControl()
        {
            InitializeComponent();
            Character = new CharacterController();
            CustomInitialize();
        }

        public CharacterControl(CharacterController character)
        {
            InitializeComponent();
            Character = character;
            CustomInitialize();
            
        }

        private void CustomInitialize()
        {
            textFieldName.TextChanged += TextFieldName_TextChanged;
            comboBoxFieldRace.ComboBoxTextChanged += new EventHandler(comboBoxFieldRace_SelectedIndexChanged);
            

            foreach(Race race in Data.GetAllRaces())
            {
                comboBoxFieldRace.ComboBox.Items.Add(race);
            }
        }

        private void comboBoxFieldRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            Character.Race = Data.GetRace(comboBoxFieldRace.Text);
        }

        private void TextFieldName_TextChanged(object sender, EventArgs e)
        {
            CharacterName = (sender as TextFieldControl).Text;
            CharacterNameChange(this, e);
        }
    }
}
