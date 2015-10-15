using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5eCharGen.View
{
    public partial class CharacterControl : UserControl
    {
        public Character Character { private set; get; }
        public string CharacterName { set; get; }

        public event EventHandler CharacterNameChange;

        public CharacterControl()
        {
            InitializeComponent();
            Character = new Character();
            CustomInitialize();
        }

        public CharacterControl(Character character)
        {
            InitializeComponent();
            Character = character;
            CustomInitialize();
            
        }

        private void CustomInitialize()
        {
            textFieldName.TextChanged += TextFieldName_TextChanged;
            attributeBlock.UpdateTotals(Character);
        }

        private void TextFieldName_TextChanged(object sender, EventArgs e)
        {
            CharacterName = (sender as TextFieldControl).Text;
            CharacterNameChange(this, e);
        }
    }
}
