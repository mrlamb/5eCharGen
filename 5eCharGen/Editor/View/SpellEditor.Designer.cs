namespace _5eCharGen.Editor.View
{
    partial class SpellEditor
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCastTime = new System.Windows.Forms.Label();
            this.textBoxCastTimeNumber = new System.Windows.Forms.TextBox();
            this.comboBoxCastTime = new System.Windows.Forms.ComboBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.verticalDivider = new System.Windows.Forms.Label();
            this.comboBoxFieldSpellSelect = new _5eCharGen.View.ComboBoxFieldControl();
            this.textFieldRange = new _5eCharGen.View.TextFieldControl();
            this.textFieldDuration = new _5eCharGen.View.TextFieldControl();
            this.spellComponentsControl1 = new _5eCharGen.Editor.View.SpellComponentsControl();
            this.comboBoxSpellSchool = new _5eCharGen.View.ComboBoxFieldControl();
            this.comboBoxFieldSpellLevel = new _5eCharGen.View.ComboBoxFieldControl();
            this.textFieldSpellName = new _5eCharGen.View.TextFieldControl();
            this.checkBoxRitual = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelCastTime
            // 
            this.labelCastTime.AutoSize = true;
            this.labelCastTime.Location = new System.Drawing.Point(234, 60);
            this.labelCastTime.Name = "labelCastTime";
            this.labelCastTime.Size = new System.Drawing.Size(54, 13);
            this.labelCastTime.TabIndex = 3;
            this.labelCastTime.Text = "Cast Time";
            // 
            // textBoxCastTimeNumber
            // 
            this.textBoxCastTimeNumber.Location = new System.Drawing.Point(237, 77);
            this.textBoxCastTimeNumber.Name = "textBoxCastTimeNumber";
            this.textBoxCastTimeNumber.Size = new System.Drawing.Size(20, 20);
            this.textBoxCastTimeNumber.TabIndex = 5;
            // 
            // comboBoxCastTime
            // 
            this.comboBoxCastTime.FormattingEnabled = true;
            this.comboBoxCastTime.Location = new System.Drawing.Point(263, 76);
            this.comboBoxCastTime.Name = "comboBoxCastTime";
            this.comboBoxCastTime.Size = new System.Drawing.Size(109, 21);
            this.comboBoxCastTime.TabIndex = 6;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(13, 226);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(485, 103);
            this.textBoxDescription.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Description";
            // 
            // buttonSave
            // 
            this.buttonSave.Image = global::_5eCharGen.Properties.Resources.saveHS;
            this.buttonSave.Location = new System.Drawing.Point(603, 55);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(32, 32);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Image = global::_5eCharGen.Properties.Resources.DeleteHS;
            this.buttonRemove.Location = new System.Drawing.Point(565, 55);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(32, 32);
            this.buttonRemove.TabIndex = 13;
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Image = global::_5eCharGen.Properties.Resources.NewDocumentHS;
            this.buttonAddNew.Location = new System.Drawing.Point(527, 55);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(32, 32);
            this.buttonAddNew.TabIndex = 12;
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // verticalDivider
            // 
            this.verticalDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.verticalDivider.Location = new System.Drawing.Point(504, 7);
            this.verticalDivider.Name = "verticalDivider";
            this.verticalDivider.Size = new System.Drawing.Size(2, 340);
            this.verticalDivider.TabIndex = 15;
            // 
            // comboBoxFieldSpellSelect
            // 
            this.comboBoxFieldSpellSelect.LabelText = "Spell";
            this.comboBoxFieldSpellSelect.Location = new System.Drawing.Point(513, 10);
            this.comboBoxFieldSpellSelect.Name = "comboBoxFieldSpellSelect";
            this.comboBoxFieldSpellSelect.Size = new System.Drawing.Size(220, 39);
            this.comboBoxFieldSpellSelect.TabIndex = 11;
            // 
            // textFieldRange
            // 
            this.textFieldRange.LabelText = "Range";
            this.textFieldRange.Location = new System.Drawing.Point(234, 103);
            this.textFieldRange.Name = "textFieldRange";
            this.textFieldRange.Size = new System.Drawing.Size(138, 39);
            this.textFieldRange.TabIndex = 7;
            // 
            // textFieldDuration
            // 
            this.textFieldDuration.LabelText = "Duration";
            this.textFieldDuration.Location = new System.Drawing.Point(234, 148);
            this.textFieldDuration.Name = "textFieldDuration";
            this.textFieldDuration.Size = new System.Drawing.Size(208, 39);
            this.textFieldDuration.TabIndex = 8;
            // 
            // spellComponentsControl1
            // 
            this.spellComponentsControl1.Location = new System.Drawing.Point(12, 60);
            this.spellComponentsControl1.Material = false;
            this.spellComponentsControl1.Name = "spellComponentsControl1";
            this.spellComponentsControl1.Size = new System.Drawing.Size(240, 150);
            this.spellComponentsControl1.Somatic = false;
            this.spellComponentsControl1.TabIndex = 4;
            this.spellComponentsControl1.Verbal = false;
            // 
            // comboBoxSpellSchool
            // 
            this.comboBoxSpellSchool.LabelText = "School";
            this.comboBoxSpellSchool.Location = new System.Drawing.Point(313, 11);
            this.comboBoxSpellSchool.Name = "comboBoxSpellSchool";
            this.comboBoxSpellSchool.Size = new System.Drawing.Size(185, 39);
            this.comboBoxSpellSchool.TabIndex = 2;
            // 
            // comboBoxFieldSpellLevel
            // 
            this.comboBoxFieldSpellLevel.LabelText = "Level";
            this.comboBoxFieldSpellLevel.Location = new System.Drawing.Point(237, 11);
            this.comboBoxFieldSpellLevel.Name = "comboBoxFieldSpellLevel";
            this.comboBoxFieldSpellLevel.Size = new System.Drawing.Size(59, 39);
            this.comboBoxFieldSpellLevel.TabIndex = 1;
            // 
            // textFieldSpellName
            // 
            this.textFieldSpellName.LabelText = "Name";
            this.textFieldSpellName.Location = new System.Drawing.Point(12, 12);
            this.textFieldSpellName.Name = "textFieldSpellName";
            this.textFieldSpellName.Size = new System.Drawing.Size(208, 39);
            this.textFieldSpellName.TabIndex = 0;
            // 
            // checkBoxRitual
            // 
            this.checkBoxRitual.AutoSize = true;
            this.checkBoxRitual.Location = new System.Drawing.Point(389, 125);
            this.checkBoxRitual.Name = "checkBoxRitual";
            this.checkBoxRitual.Size = new System.Drawing.Size(53, 17);
            this.checkBoxRitual.TabIndex = 16;
            this.checkBoxRitual.Text = "Ritual";
            this.checkBoxRitual.UseVisualStyleBackColor = true;
            // 
            // SpellEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 352);
            this.Controls.Add(this.checkBoxRitual);
            this.Controls.Add(this.verticalDivider);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.comboBoxFieldSpellSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textFieldRange);
            this.Controls.Add(this.comboBoxCastTime);
            this.Controls.Add(this.textBoxCastTimeNumber);
            this.Controls.Add(this.labelCastTime);
            this.Controls.Add(this.textFieldDuration);
            this.Controls.Add(this.spellComponentsControl1);
            this.Controls.Add(this.comboBoxSpellSchool);
            this.Controls.Add(this.comboBoxFieldSpellLevel);
            this.Controls.Add(this.textFieldSpellName);
            this.Name = "SpellEditor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SpellEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _5eCharGen.View.TextFieldControl textFieldSpellName;
        private _5eCharGen.View.ComboBoxFieldControl comboBoxFieldSpellLevel;
        private _5eCharGen.View.ComboBoxFieldControl comboBoxSpellSchool;
        private System.Windows.Forms.Label labelCastTime;
        private System.Windows.Forms.TextBox textBoxCastTimeNumber;
        private System.Windows.Forms.ComboBox comboBoxCastTime;
        private _5eCharGen.View.TextFieldControl textFieldRange;
        private SpellComponentsControl spellComponentsControl1;
        private _5eCharGen.View.TextFieldControl textFieldDuration;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAddNew;
        private _5eCharGen.View.ComboBoxFieldControl comboBoxFieldSpellSelect;
        private System.Windows.Forms.Label verticalDivider;
        private System.Windows.Forms.CheckBox checkBoxRitual;
    }
}