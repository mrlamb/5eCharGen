namespace _5eCharGen.View
{
    partial class CharacterControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCharacter = new System.Windows.Forms.TabControl();
            this.tabPageCharacter = new System.Windows.Forms.TabPage();
            this.tabClass = new System.Windows.Forms.TabPage();
            this.tabSkills = new System.Windows.Forms.TabPage();
            this.tabFeats = new System.Windows.Forms.TabPage();
            this.tabSpells = new System.Windows.Forms.TabPage();
            this.tabEquipment = new System.Windows.Forms.TabPage();
            this.textFieldName = new _5eCharGen.View.TextFieldControl();
            this.comboBoxFieldRace = new _5eCharGen.View.ComboBoxFieldControl();
            this.tabCharacter.SuspendLayout();
            this.tabPageCharacter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCharacter
            // 
            this.tabCharacter.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabCharacter.Controls.Add(this.tabPageCharacter);
            this.tabCharacter.Controls.Add(this.tabClass);
            this.tabCharacter.Controls.Add(this.tabSkills);
            this.tabCharacter.Controls.Add(this.tabFeats);
            this.tabCharacter.Controls.Add(this.tabSpells);
            this.tabCharacter.Controls.Add(this.tabEquipment);
            this.tabCharacter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCharacter.Location = new System.Drawing.Point(0, 0);
            this.tabCharacter.Multiline = true;
            this.tabCharacter.Name = "tabCharacter";
            this.tabCharacter.SelectedIndex = 0;
            this.tabCharacter.Size = new System.Drawing.Size(613, 558);
            this.tabCharacter.TabIndex = 1;
            // 
            // tabPageCharacter
            // 
            this.tabPageCharacter.AutoScroll = true;
            this.tabPageCharacter.Controls.Add(this.comboBoxFieldRace);
            this.tabPageCharacter.Controls.Add(this.textFieldName);
            this.tabPageCharacter.Location = new System.Drawing.Point(23, 4);
            this.tabPageCharacter.Name = "tabPageCharacter";
            this.tabPageCharacter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCharacter.Size = new System.Drawing.Size(586, 550);
            this.tabPageCharacter.TabIndex = 0;
            this.tabPageCharacter.Text = "Character";
            this.tabPageCharacter.UseVisualStyleBackColor = true;
            // 
            // tabClass
            // 
            this.tabClass.Location = new System.Drawing.Point(23, 4);
            this.tabClass.Name = "tabClass";
            this.tabClass.Padding = new System.Windows.Forms.Padding(3);
            this.tabClass.Size = new System.Drawing.Size(586, 550);
            this.tabClass.TabIndex = 1;
            this.tabClass.Text = "Class";
            this.tabClass.UseVisualStyleBackColor = true;
            // 
            // tabSkills
            // 
            this.tabSkills.Location = new System.Drawing.Point(23, 4);
            this.tabSkills.Name = "tabSkills";
            this.tabSkills.Size = new System.Drawing.Size(586, 550);
            this.tabSkills.TabIndex = 2;
            this.tabSkills.Text = "Skills";
            this.tabSkills.UseVisualStyleBackColor = true;
            // 
            // tabFeats
            // 
            this.tabFeats.Location = new System.Drawing.Point(23, 4);
            this.tabFeats.Name = "tabFeats";
            this.tabFeats.Size = new System.Drawing.Size(586, 550);
            this.tabFeats.TabIndex = 3;
            this.tabFeats.Text = "Feats";
            this.tabFeats.UseVisualStyleBackColor = true;
            // 
            // tabSpells
            // 
            this.tabSpells.Location = new System.Drawing.Point(23, 4);
            this.tabSpells.Name = "tabSpells";
            this.tabSpells.Size = new System.Drawing.Size(586, 550);
            this.tabSpells.TabIndex = 4;
            this.tabSpells.Text = "Spells";
            this.tabSpells.UseVisualStyleBackColor = true;
            // 
            // tabEquipment
            // 
            this.tabEquipment.Location = new System.Drawing.Point(23, 4);
            this.tabEquipment.Name = "tabEquipment";
            this.tabEquipment.Size = new System.Drawing.Size(586, 550);
            this.tabEquipment.TabIndex = 5;
            this.tabEquipment.Text = "Equipment";
            this.tabEquipment.UseVisualStyleBackColor = true;
            // 
            // textFieldName
            // 
            this.textFieldName.LabelText = "Character Name";
            this.textFieldName.Location = new System.Drawing.Point(7, 7);
            this.textFieldName.Name = "textFieldName";
            this.textFieldName.Size = new System.Drawing.Size(208, 39);
            this.textFieldName.TabIndex = 0;
            // 
            // comboBoxFieldRace
            // 
            this.comboBoxFieldRace.LabelText = "Race";
            this.comboBoxFieldRace.Location = new System.Drawing.Point(221, 7);
            this.comboBoxFieldRace.Name = "comboBoxFieldRace";
            this.comboBoxFieldRace.Size = new System.Drawing.Size(208, 39);
            this.comboBoxFieldRace.TabIndex = 1;
            // 
            // CharacterControl
            // 
            this.Controls.Add(this.tabCharacter);
            this.Name = "CharacterControl";
            this.Size = new System.Drawing.Size(613, 558);
            this.tabCharacter.ResumeLayout(false);
            this.tabPageCharacter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabCharacter;
        private System.Windows.Forms.TabPage tabPageCharacter;
        private System.Windows.Forms.TabPage tabClass;
        private System.Windows.Forms.TabPage tabSkills;
        private System.Windows.Forms.TabPage tabFeats;
        private System.Windows.Forms.TabPage tabSpells;
        private System.Windows.Forms.TabPage tabEquipment;
        private TextFieldControl textFieldName;
        private ComboBoxFieldControl comboBoxFieldRace;
    }
}
