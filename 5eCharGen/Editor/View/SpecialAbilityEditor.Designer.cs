namespace _5eCharGen.Editor.View
{
    partial class SpecialAbilityEditor
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBasicStats = new System.Windows.Forms.TabPage();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageAttributes = new System.Windows.Forms.TabPage();
            this.tabPageProf = new System.Windows.Forms.TabPage();
            this.buttonRemoveProfValue = new System.Windows.Forms.Button();
            this.buttonRemoveProf = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxProfValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxProfValue = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxProfAdded = new System.Windows.Forms.ComboBox();
            this.buttonAddProfValue = new System.Windows.Forms.Button();
            this.buttonAddProf = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageSpells = new System.Windows.Forms.TabPage();
            this.buttonRemoveSpell = new System.Windows.Forms.Button();
            this.comboBoxSpellsAdded = new System.Windows.Forms.ComboBox();
            this.buttonAddSpell = new System.Windows.Forms.Button();
            this.tabPageMisc = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textFieldControlName = new _5eCharGen.View.TextFieldControl();
            this.textFieldControlCHA = new _5eCharGen.View.TextFieldControl();
            this.textFieldControlINT = new _5eCharGen.View.TextFieldControl();
            this.textFieldControlWIS = new _5eCharGen.View.TextFieldControl();
            this.textFieldControlCON = new _5eCharGen.View.TextFieldControl();
            this.textFieldControlDEX = new _5eCharGen.View.TextFieldControl();
            this.textFieldControlSTR = new _5eCharGen.View.TextFieldControl();
            this.comboBoxFieldControlProfName = new _5eCharGen.View.ComboBoxFieldControl();
            this.comboBoxFieldSpellName = new _5eCharGen.View.ComboBoxFieldControl();
            this.textFieldControlAC = new _5eCharGen.View.TextFieldControl();
            this.textFieldControlSpeed = new _5eCharGen.View.TextFieldControl();
            this.comboBoxFieldSAName = new _5eCharGen.View.ComboBoxFieldControl();
            this.tabControl1.SuspendLayout();
            this.tabPageBasicStats.SuspendLayout();
            this.tabPageAttributes.SuspendLayout();
            this.tabPageProf.SuspendLayout();
            this.tabPageSpells.SuspendLayout();
            this.tabPageMisc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPageBasicStats);
            this.tabControl1.Controls.Add(this.tabPageAttributes);
            this.tabControl1.Controls.Add(this.tabPageProf);
            this.tabControl1.Controls.Add(this.tabPageSpells);
            this.tabControl1.Controls.Add(this.tabPageMisc);
            this.tabControl1.Location = new System.Drawing.Point(13, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(433, 180);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageBasicStats
            // 
            this.tabPageBasicStats.Controls.Add(this.textBoxDescription);
            this.tabPageBasicStats.Controls.Add(this.label1);
            this.tabPageBasicStats.Controls.Add(this.textFieldControlName);
            this.tabPageBasicStats.Location = new System.Drawing.Point(4, 25);
            this.tabPageBasicStats.Name = "tabPageBasicStats";
            this.tabPageBasicStats.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBasicStats.Size = new System.Drawing.Size(425, 151);
            this.tabPageBasicStats.TabIndex = 0;
            this.tabPageBasicStats.Text = "Basics";
            this.tabPageBasicStats.UseVisualStyleBackColor = true;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(7, 69);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(409, 75);
            this.textBoxDescription.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Description";
            // 
            // tabPageAttributes
            // 
            this.tabPageAttributes.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAttributes.Controls.Add(this.textFieldControlCHA);
            this.tabPageAttributes.Controls.Add(this.textFieldControlINT);
            this.tabPageAttributes.Controls.Add(this.textFieldControlWIS);
            this.tabPageAttributes.Controls.Add(this.textFieldControlCON);
            this.tabPageAttributes.Controls.Add(this.textFieldControlDEX);
            this.tabPageAttributes.Controls.Add(this.textFieldControlSTR);
            this.tabPageAttributes.Location = new System.Drawing.Point(4, 25);
            this.tabPageAttributes.Name = "tabPageAttributes";
            this.tabPageAttributes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAttributes.Size = new System.Drawing.Size(425, 151);
            this.tabPageAttributes.TabIndex = 1;
            this.tabPageAttributes.Text = "Attributes";
            // 
            // tabPageProf
            // 
            this.tabPageProf.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageProf.Controls.Add(this.buttonRemoveProfValue);
            this.tabPageProf.Controls.Add(this.buttonRemoveProf);
            this.tabPageProf.Controls.Add(this.label7);
            this.tabPageProf.Controls.Add(this.label6);
            this.tabPageProf.Controls.Add(this.textBoxProfValue);
            this.tabPageProf.Controls.Add(this.label5);
            this.tabPageProf.Controls.Add(this.comboBoxProfValue);
            this.tabPageProf.Controls.Add(this.label4);
            this.tabPageProf.Controls.Add(this.label3);
            this.tabPageProf.Controls.Add(this.comboBoxProfAdded);
            this.tabPageProf.Controls.Add(this.buttonAddProfValue);
            this.tabPageProf.Controls.Add(this.buttonAddProf);
            this.tabPageProf.Controls.Add(this.label2);
            this.tabPageProf.Controls.Add(this.comboBoxFieldControlProfName);
            this.tabPageProf.Location = new System.Drawing.Point(4, 25);
            this.tabPageProf.Name = "tabPageProf";
            this.tabPageProf.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProf.Size = new System.Drawing.Size(425, 151);
            this.tabPageProf.TabIndex = 2;
            this.tabPageProf.Text = "Proficiencies";
            // 
            // buttonRemoveProfValue
            // 
            this.buttonRemoveProfValue.Image = global::_5eCharGen.Properties.Resources.DeleteHS;
            this.buttonRemoveProfValue.Location = new System.Drawing.Point(374, 97);
            this.buttonRemoveProfValue.Name = "buttonRemoveProfValue";
            this.buttonRemoveProfValue.Size = new System.Drawing.Size(30, 23);
            this.buttonRemoveProfValue.TabIndex = 13;
            this.buttonRemoveProfValue.UseVisualStyleBackColor = true;
            this.buttonRemoveProfValue.Click += new System.EventHandler(this.buttonRemoveProfValue_Click);
            // 
            // buttonRemoveProf
            // 
            this.buttonRemoveProf.Image = global::_5eCharGen.Properties.Resources.DeleteHS;
            this.buttonRemoveProf.Location = new System.Drawing.Point(159, 98);
            this.buttonRemoveProf.Name = "buttonRemoveProf";
            this.buttonRemoveProf.Size = new System.Drawing.Size(30, 23);
            this.buttonRemoveProf.TabIndex = 12;
            this.buttonRemoveProf.UseVisualStyleBackColor = true;
            this.buttonRemoveProf.Click += new System.EventHandler(this.buttonRemoveProf_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "*enter a numeric value or a stat such as STR or CON";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "to this proficiency";
            // 
            // textBoxProfValue
            // 
            this.textBoxProfValue.Location = new System.Drawing.Point(285, 71);
            this.textBoxProfValue.Name = "textBoxProfValue";
            this.textBoxProfValue.Size = new System.Drawing.Size(31, 20);
            this.textBoxProfValue.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "add*";
            // 
            // comboBoxProfValue
            // 
            this.comboBoxProfValue.FormattingEnabled = true;
            this.comboBoxProfValue.Location = new System.Drawing.Point(218, 97);
            this.comboBoxProfValue.Name = "comboBoxProfValue";
            this.comboBoxProfValue.Size = new System.Drawing.Size(150, 21);
            this.comboBoxProfValue.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "or";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Add it to this ability";
            // 
            // comboBoxProfAdded
            // 
            this.comboBoxProfAdded.FormattingEnabled = true;
            this.comboBoxProfAdded.Location = new System.Drawing.Point(7, 98);
            this.comboBoxProfAdded.Name = "comboBoxProfAdded";
            this.comboBoxProfAdded.Size = new System.Drawing.Size(150, 21);
            this.comboBoxProfAdded.TabIndex = 4;
            // 
            // buttonAddProfValue
            // 
            this.buttonAddProfValue.Image = global::_5eCharGen.Properties.Resources.arrow_Down_16xLG;
            this.buttonAddProfValue.Location = new System.Drawing.Point(218, 69);
            this.buttonAddProfValue.Name = "buttonAddProfValue";
            this.buttonAddProfValue.Size = new System.Drawing.Size(30, 23);
            this.buttonAddProfValue.TabIndex = 3;
            this.buttonAddProfValue.UseVisualStyleBackColor = true;
            this.buttonAddProfValue.Click += new System.EventHandler(this.buttonAddProfValue_Click);
            // 
            // buttonAddProf
            // 
            this.buttonAddProf.Image = global::_5eCharGen.Properties.Resources.arrow_Down_16xLG;
            this.buttonAddProf.Location = new System.Drawing.Point(159, 69);
            this.buttonAddProf.Name = "buttonAddProf";
            this.buttonAddProf.Size = new System.Drawing.Size(30, 23);
            this.buttonAddProf.TabIndex = 2;
            this.buttonAddProf.UseVisualStyleBackColor = true;
            this.buttonAddProf.Click += new System.EventHandler(this.buttonAddProf_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "then choose to either";
            // 
            // tabPageSpells
            // 
            this.tabPageSpells.Controls.Add(this.buttonRemoveSpell);
            this.tabPageSpells.Controls.Add(this.comboBoxSpellsAdded);
            this.tabPageSpells.Controls.Add(this.buttonAddSpell);
            this.tabPageSpells.Controls.Add(this.comboBoxFieldSpellName);
            this.tabPageSpells.Location = new System.Drawing.Point(4, 25);
            this.tabPageSpells.Name = "tabPageSpells";
            this.tabPageSpells.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSpells.Size = new System.Drawing.Size(425, 151);
            this.tabPageSpells.TabIndex = 3;
            this.tabPageSpells.Text = "Spells";
            this.tabPageSpells.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveSpell
            // 
            this.buttonRemoveSpell.Image = global::_5eCharGen.Properties.Resources.DeleteHS;
            this.buttonRemoveSpell.Location = new System.Drawing.Point(222, 82);
            this.buttonRemoveSpell.Name = "buttonRemoveSpell";
            this.buttonRemoveSpell.Size = new System.Drawing.Size(31, 23);
            this.buttonRemoveSpell.TabIndex = 3;
            this.buttonRemoveSpell.UseVisualStyleBackColor = true;
            this.buttonRemoveSpell.Click += new System.EventHandler(this.buttonRemoveSpell_Click);
            // 
            // comboBoxSpellsAdded
            // 
            this.comboBoxSpellsAdded.FormattingEnabled = true;
            this.comboBoxSpellsAdded.Location = new System.Drawing.Point(7, 82);
            this.comboBoxSpellsAdded.Name = "comboBoxSpellsAdded";
            this.comboBoxSpellsAdded.Size = new System.Drawing.Size(208, 21);
            this.comboBoxSpellsAdded.TabIndex = 2;
            // 
            // buttonAddSpell
            // 
            this.buttonAddSpell.Image = global::_5eCharGen.Properties.Resources.arrow_Down_16xLG;
            this.buttonAddSpell.Location = new System.Drawing.Point(184, 52);
            this.buttonAddSpell.Name = "buttonAddSpell";
            this.buttonAddSpell.Size = new System.Drawing.Size(31, 23);
            this.buttonAddSpell.TabIndex = 1;
            this.buttonAddSpell.UseVisualStyleBackColor = true;
            this.buttonAddSpell.Click += new System.EventHandler(this.buttonAddSpell_Click);
            // 
            // tabPageMisc
            // 
            this.tabPageMisc.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageMisc.Controls.Add(this.label8);
            this.tabPageMisc.Controls.Add(this.textFieldControlAC);
            this.tabPageMisc.Controls.Add(this.textFieldControlSpeed);
            this.tabPageMisc.Location = new System.Drawing.Point(4, 25);
            this.tabPageMisc.Name = "tabPageMisc";
            this.tabPageMisc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMisc.Size = new System.Drawing.Size(425, 151);
            this.tabPageMisc.TabIndex = 4;
            this.tabPageMisc.Text = "Misc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(372, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Valid values include whole numbers or stat indicators such as STR, DEX, etc.";
            // 
            // buttonSave
            // 
            this.buttonSave.Image = global::_5eCharGen.Properties.Resources.saveHS;
            this.buttonSave.Location = new System.Drawing.Point(420, 20);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(32, 32);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Image = global::_5eCharGen.Properties.Resources.DeleteHS;
            this.buttonRemove.Location = new System.Drawing.Point(382, 20);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(32, 32);
            this.buttonRemove.TabIndex = 16;
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Image = global::_5eCharGen.Properties.Resources.NewDocumentHS;
            this.buttonAddNew.Location = new System.Drawing.Point(344, 20);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(32, 32);
            this.buttonAddNew.TabIndex = 15;
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(17, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(436, 2);
            this.label9.TabIndex = 18;
            // 
            // textFieldControlName
            // 
            this.textFieldControlName.LabelText = "Name";
            this.textFieldControlName.Location = new System.Drawing.Point(7, 7);
            this.textFieldControlName.Name = "textFieldControlName";
            this.textFieldControlName.Size = new System.Drawing.Size(208, 39);
            this.textFieldControlName.TabIndex = 0;
            // 
            // textFieldControlCHA
            // 
            this.textFieldControlCHA.LabelText = "CHA";
            this.textFieldControlCHA.Location = new System.Drawing.Point(77, 99);
            this.textFieldControlCHA.Name = "textFieldControlCHA";
            this.textFieldControlCHA.Size = new System.Drawing.Size(37, 39);
            this.textFieldControlCHA.TabIndex = 5;
            // 
            // textFieldControlINT
            // 
            this.textFieldControlINT.LabelText = "INT";
            this.textFieldControlINT.Location = new System.Drawing.Point(77, 53);
            this.textFieldControlINT.Name = "textFieldControlINT";
            this.textFieldControlINT.Size = new System.Drawing.Size(37, 39);
            this.textFieldControlINT.TabIndex = 4;
            // 
            // textFieldControlWIS
            // 
            this.textFieldControlWIS.LabelText = "WIS";
            this.textFieldControlWIS.Location = new System.Drawing.Point(77, 7);
            this.textFieldControlWIS.Name = "textFieldControlWIS";
            this.textFieldControlWIS.Size = new System.Drawing.Size(37, 39);
            this.textFieldControlWIS.TabIndex = 3;
            // 
            // textFieldControlCON
            // 
            this.textFieldControlCON.LabelText = "CON";
            this.textFieldControlCON.Location = new System.Drawing.Point(7, 99);
            this.textFieldControlCON.Name = "textFieldControlCON";
            this.textFieldControlCON.Size = new System.Drawing.Size(37, 39);
            this.textFieldControlCON.TabIndex = 2;
            // 
            // textFieldControlDEX
            // 
            this.textFieldControlDEX.LabelText = "DEX";
            this.textFieldControlDEX.Location = new System.Drawing.Point(7, 53);
            this.textFieldControlDEX.Name = "textFieldControlDEX";
            this.textFieldControlDEX.Size = new System.Drawing.Size(37, 39);
            this.textFieldControlDEX.TabIndex = 1;
            // 
            // textFieldControlSTR
            // 
            this.textFieldControlSTR.LabelText = "STR";
            this.textFieldControlSTR.Location = new System.Drawing.Point(7, 7);
            this.textFieldControlSTR.Name = "textFieldControlSTR";
            this.textFieldControlSTR.Size = new System.Drawing.Size(37, 39);
            this.textFieldControlSTR.TabIndex = 0;
            // 
            // comboBoxFieldControlProfName
            // 
            this.comboBoxFieldControlProfName.LabelText = "Select a proficiency";
            this.comboBoxFieldControlProfName.Location = new System.Drawing.Point(7, 7);
            this.comboBoxFieldControlProfName.Name = "comboBoxFieldControlProfName";
            this.comboBoxFieldControlProfName.Size = new System.Drawing.Size(182, 41);
            this.comboBoxFieldControlProfName.TabIndex = 0;
            this.comboBoxFieldControlProfName.Load += new System.EventHandler(this.comboBoxFieldControlProfName_Load);
            // 
            // comboBoxFieldSpellName
            // 
            this.comboBoxFieldSpellName.LabelText = "Select a spell";
            this.comboBoxFieldSpellName.Location = new System.Drawing.Point(7, 7);
            this.comboBoxFieldSpellName.Name = "comboBoxFieldSpellName";
            this.comboBoxFieldSpellName.Size = new System.Drawing.Size(208, 39);
            this.comboBoxFieldSpellName.TabIndex = 0;
            this.comboBoxFieldSpellName.Load += new System.EventHandler(this.comboBoxFieldSpellName_Load);
            // 
            // textFieldControlAC
            // 
            this.textFieldControlAC.LabelText = "AC Bonus";
            this.textFieldControlAC.Location = new System.Drawing.Point(91, 6);
            this.textFieldControlAC.Name = "textFieldControlAC";
            this.textFieldControlAC.Size = new System.Drawing.Size(77, 39);
            this.textFieldControlAC.TabIndex = 1;
            // 
            // textFieldControlSpeed
            // 
            this.textFieldControlSpeed.LabelText = "Speed Bonus";
            this.textFieldControlSpeed.Location = new System.Drawing.Point(7, 7);
            this.textFieldControlSpeed.Name = "textFieldControlSpeed";
            this.textFieldControlSpeed.Size = new System.Drawing.Size(78, 39);
            this.textFieldControlSpeed.TabIndex = 0;
            // 
            // comboBoxFieldSAName
            // 
            this.comboBoxFieldSAName.LabelText = "Select an ability";
            this.comboBoxFieldSAName.Location = new System.Drawing.Point(13, 13);
            this.comboBoxFieldSAName.Name = "comboBoxFieldSAName";
            this.comboBoxFieldSAName.Size = new System.Drawing.Size(259, 39);
            this.comboBoxFieldSAName.TabIndex = 0;
            // 
            // SpecialAbilityEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 261);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.comboBoxFieldSAName);
            this.Name = "SpecialAbilityEditor";
            this.Text = "SpecialAbilityEditor";
            this.tabControl1.ResumeLayout(false);
            this.tabPageBasicStats.ResumeLayout(false);
            this.tabPageBasicStats.PerformLayout();
            this.tabPageAttributes.ResumeLayout(false);
            this.tabPageProf.ResumeLayout(false);
            this.tabPageProf.PerformLayout();
            this.tabPageSpells.ResumeLayout(false);
            this.tabPageMisc.ResumeLayout(false);
            this.tabPageMisc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private _5eCharGen.View.ComboBoxFieldControl comboBoxFieldSAName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBasicStats;
        private System.Windows.Forms.TabPage tabPageAttributes;
        private System.Windows.Forms.TabPage tabPageProf;
        private System.Windows.Forms.TabPage tabPageSpells;
        private System.Windows.Forms.TabPage tabPageMisc;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label1;
        private _5eCharGen.View.TextFieldControl textFieldControlName;
        private System.Windows.Forms.TextBox textBoxProfValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxProfValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxProfAdded;
        private System.Windows.Forms.Button buttonAddProfValue;
        private System.Windows.Forms.Button buttonAddProf;
        private System.Windows.Forms.Label label2;
        private _5eCharGen.View.ComboBoxFieldControl comboBoxFieldControlProfName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonRemoveProfValue;
        private System.Windows.Forms.Button buttonRemoveProf;
        private _5eCharGen.View.ComboBoxFieldControl comboBoxFieldSpellName;
        private _5eCharGen.View.TextFieldControl textFieldControlCHA;
        private _5eCharGen.View.TextFieldControl textFieldControlINT;
        private _5eCharGen.View.TextFieldControl textFieldControlWIS;
        private _5eCharGen.View.TextFieldControl textFieldControlCON;
        private _5eCharGen.View.TextFieldControl textFieldControlDEX;
        private _5eCharGen.View.TextFieldControl textFieldControlSTR;
        private System.Windows.Forms.Button buttonRemoveSpell;
        private System.Windows.Forms.ComboBox comboBoxSpellsAdded;
        private System.Windows.Forms.Button buttonAddSpell;
        private System.Windows.Forms.Label label8;
        private _5eCharGen.View.TextFieldControl textFieldControlAC;
        private _5eCharGen.View.TextFieldControl textFieldControlSpeed;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Label label9;
    }
}