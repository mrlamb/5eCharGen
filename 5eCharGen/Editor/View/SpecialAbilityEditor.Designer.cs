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
            this.labelDescription = new System.Windows.Forms.Label();
            this.textFieldControlName = new _5eCharGen.View.TextFieldControl();
            this.tabPageAttributes = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.labelInstACSpeed = new System.Windows.Forms.Label();
            this.textFieldControlAC = new _5eCharGen.View.TextFieldControl();
            this.textFieldControlSpeed = new _5eCharGen.View.TextFieldControl();
            this.textFieldControlCHA = new _5eCharGen.View.TextFieldControl();
            this.textFieldControlINT = new _5eCharGen.View.TextFieldControl();
            this.textFieldControlWIS = new _5eCharGen.View.TextFieldControl();
            this.textFieldControlCON = new _5eCharGen.View.TextFieldControl();
            this.textFieldControlDEX = new _5eCharGen.View.TextFieldControl();
            this.textFieldControlSTR = new _5eCharGen.View.TextFieldControl();
            this.tabPageProf = new System.Windows.Forms.TabPage();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonAddNewProf = new System.Windows.Forms.Button();
            this.labelAddProfHelp = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxProfValue = new System.Windows.Forms.ComboBox();
            this.buttonRemoveProfValue = new System.Windows.Forms.Button();
            this.labelAddProfValue = new System.Windows.Forms.Label();
            this.buttonAddProfValue = new System.Windows.Forms.Button();
            this.textBoxProfValue = new System.Windows.Forms.TextBox();
            this.labelAdd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxProfAdded = new System.Windows.Forms.ComboBox();
            this.buttonRemoveProf = new System.Windows.Forms.Button();
            this.buttonAddProf = new System.Windows.Forms.Button();
            this.labelAddProf = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxFieldControlProfName = new _5eCharGen.View.ComboBoxFieldControl();
            this.tabPageSpells = new System.Windows.Forms.TabPage();
            this.buttonRemoveSpell = new System.Windows.Forms.Button();
            this.comboBoxSpellsAdded = new System.Windows.Forms.ComboBox();
            this.buttonAddSpell = new System.Windows.Forms.Button();
            this.comboBoxFieldSpellName = new _5eCharGen.View.ComboBoxFieldControl();
            this.tabPageMisc = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.Summary = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.comboBoxFieldSAName = new _5eCharGen.View.ComboBoxFieldControl();
            this.tabControl1.SuspendLayout();
            this.tabPageBasicStats.SuspendLayout();
            this.tabPageAttributes.SuspendLayout();
            this.tabPageProf.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageSpells.SuspendLayout();
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
            this.tabPageBasicStats.Controls.Add(this.labelDescription);
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
            this.textBoxDescription.Location = new System.Drawing.Point(10, 69);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(409, 76);
            this.textBoxDescription.TabIndex = 2;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(7, 53);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(0, 13);
            this.labelDescription.TabIndex = 1;
            // 
            // textFieldControlName
            // 
            this.textFieldControlName.LabelText = "";
            this.textFieldControlName.Location = new System.Drawing.Point(7, 7);
            this.textFieldControlName.Name = "textFieldControlName";
            this.textFieldControlName.Size = new System.Drawing.Size(208, 39);
            this.textFieldControlName.TabIndex = 0;
            // 
            // tabPageAttributes
            // 
            this.tabPageAttributes.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAttributes.Controls.Add(this.label1);
            this.tabPageAttributes.Controls.Add(this.labelInstACSpeed);
            this.tabPageAttributes.Controls.Add(this.textFieldControlAC);
            this.tabPageAttributes.Controls.Add(this.textFieldControlSpeed);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(125, 5);
            this.label1.MinimumSize = new System.Drawing.Size(0, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 140);
            this.label1.TabIndex = 9;
            // 
            // labelInstACSpeed
            // 
            this.labelInstACSpeed.AutoSize = true;
            this.labelInstACSpeed.Location = new System.Drawing.Point(143, 49);
            this.labelInstACSpeed.MaximumSize = new System.Drawing.Size(200, 0);
            this.labelInstACSpeed.Name = "labelInstACSpeed";
            this.labelInstACSpeed.Size = new System.Drawing.Size(0, 13);
            this.labelInstACSpeed.TabIndex = 8;
            // 
            // textFieldControlAC
            // 
            this.textFieldControlAC.LabelText = "";
            this.textFieldControlAC.Location = new System.Drawing.Point(222, 7);
            this.textFieldControlAC.Name = "textFieldControlAC";
            this.textFieldControlAC.Size = new System.Drawing.Size(77, 39);
            this.textFieldControlAC.TabIndex = 7;
            // 
            // textFieldControlSpeed
            // 
            this.textFieldControlSpeed.LabelText = "";
            this.textFieldControlSpeed.Location = new System.Drawing.Point(137, 7);
            this.textFieldControlSpeed.Name = "textFieldControlSpeed";
            this.textFieldControlSpeed.Size = new System.Drawing.Size(78, 39);
            this.textFieldControlSpeed.TabIndex = 6;
            // 
            // textFieldControlCHA
            // 
            this.textFieldControlCHA.LabelText = "CHA";
            this.textFieldControlCHA.Location = new System.Drawing.Point(77, 99);
            this.textFieldControlCHA.Name = "textFieldControlCHA";
            this.textFieldControlCHA.Size = new System.Drawing.Size(37, 39);
            this.textFieldControlCHA.TabIndex = 5;
            this.textFieldControlCHA.Tag = "Attribute";
            // 
            // textFieldControlINT
            // 
            this.textFieldControlINT.LabelText = "INT";
            this.textFieldControlINT.Location = new System.Drawing.Point(77, 53);
            this.textFieldControlINT.Name = "textFieldControlINT";
            this.textFieldControlINT.Size = new System.Drawing.Size(37, 39);
            this.textFieldControlINT.TabIndex = 4;
            this.textFieldControlINT.Tag = "Attribute";
            // 
            // textFieldControlWIS
            // 
            this.textFieldControlWIS.LabelText = "WIS";
            this.textFieldControlWIS.Location = new System.Drawing.Point(77, 7);
            this.textFieldControlWIS.Name = "textFieldControlWIS";
            this.textFieldControlWIS.Size = new System.Drawing.Size(37, 39);
            this.textFieldControlWIS.TabIndex = 3;
            this.textFieldControlWIS.Tag = "Attribute";
            // 
            // textFieldControlCON
            // 
            this.textFieldControlCON.LabelText = "CON";
            this.textFieldControlCON.Location = new System.Drawing.Point(7, 99);
            this.textFieldControlCON.Name = "textFieldControlCON";
            this.textFieldControlCON.Size = new System.Drawing.Size(37, 39);
            this.textFieldControlCON.TabIndex = 2;
            this.textFieldControlCON.Tag = "Attribute";
            // 
            // textFieldControlDEX
            // 
            this.textFieldControlDEX.LabelText = "DEX";
            this.textFieldControlDEX.Location = new System.Drawing.Point(7, 53);
            this.textFieldControlDEX.Name = "textFieldControlDEX";
            this.textFieldControlDEX.Size = new System.Drawing.Size(37, 39);
            this.textFieldControlDEX.TabIndex = 1;
            this.textFieldControlDEX.Tag = "Attribute";
            // 
            // textFieldControlSTR
            // 
            this.textFieldControlSTR.LabelText = "STR";
            this.textFieldControlSTR.Location = new System.Drawing.Point(7, 7);
            this.textFieldControlSTR.Name = "textFieldControlSTR";
            this.textFieldControlSTR.Size = new System.Drawing.Size(37, 39);
            this.textFieldControlSTR.TabIndex = 0;
            this.textFieldControlSTR.Tag = "Attribute";
            // 
            // tabPageProf
            // 
            this.tabPageProf.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageProf.Controls.Add(this.buttonRefresh);
            this.tabPageProf.Controls.Add(this.buttonAddNewProf);
            this.tabPageProf.Controls.Add(this.labelAddProfHelp);
            this.tabPageProf.Controls.Add(this.groupBox2);
            this.tabPageProf.Controls.Add(this.groupBox1);
            this.tabPageProf.Controls.Add(this.label4);
            this.tabPageProf.Controls.Add(this.comboBoxFieldControlProfName);
            this.tabPageProf.Location = new System.Drawing.Point(4, 25);
            this.tabPageProf.Name = "tabPageProf";
            this.tabPageProf.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProf.Size = new System.Drawing.Size(425, 151);
            this.tabPageProf.TabIndex = 2;
            this.tabPageProf.Text = "Proficiencies";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Image = global::_5eCharGen.Properties.Resources.refresh_16xLG;
            this.buttonRefresh.Location = new System.Drawing.Point(220, 21);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(24, 24);
            this.buttonRefresh.TabIndex = 17;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonAddNewProf
            // 
            this.buttonAddNewProf.Image = global::_5eCharGen.Properties.Resources.AddMark_10580;
            this.buttonAddNewProf.Location = new System.Drawing.Point(190, 21);
            this.buttonAddNewProf.Name = "buttonAddNewProf";
            this.buttonAddNewProf.Size = new System.Drawing.Size(24, 24);
            this.buttonAddNewProf.TabIndex = 16;
            this.buttonAddNewProf.UseVisualStyleBackColor = true;
            this.buttonAddNewProf.Click += new System.EventHandler(this.buttonAddNewProf_Click);
            // 
            // labelAddProfHelp
            // 
            this.labelAddProfHelp.AutoSize = true;
            this.labelAddProfHelp.Location = new System.Drawing.Point(156, 129);
            this.labelAddProfHelp.Name = "labelAddProfHelp";
            this.labelAddProfHelp.Size = new System.Drawing.Size(0, 13);
            this.labelAddProfHelp.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxProfValue);
            this.groupBox2.Controls.Add(this.buttonRemoveProfValue);
            this.groupBox2.Controls.Add(this.labelAddProfValue);
            this.groupBox2.Controls.Add(this.buttonAddProfValue);
            this.groupBox2.Controls.Add(this.textBoxProfValue);
            this.groupBox2.Controls.Add(this.labelAdd);
            this.groupBox2.Location = new System.Drawing.Point(222, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 78);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // comboBoxProfValue
            // 
            this.comboBoxProfValue.FormattingEnabled = true;
            this.comboBoxProfValue.Location = new System.Drawing.Point(6, 49);
            this.comboBoxProfValue.Name = "comboBoxProfValue";
            this.comboBoxProfValue.Size = new System.Drawing.Size(150, 21);
            this.comboBoxProfValue.TabIndex = 7;
            // 
            // buttonRemoveProfValue
            // 
            this.buttonRemoveProfValue.Image = global::_5eCharGen.Properties.Resources.DeleteHS;
            this.buttonRemoveProfValue.Location = new System.Drawing.Point(161, 47);
            this.buttonRemoveProfValue.Name = "buttonRemoveProfValue";
            this.buttonRemoveProfValue.Size = new System.Drawing.Size(30, 23);
            this.buttonRemoveProfValue.TabIndex = 13;
            this.buttonRemoveProfValue.UseVisualStyleBackColor = true;
            this.buttonRemoveProfValue.Click += new System.EventHandler(this.buttonRemoveProfValue_Click);
            // 
            // labelAddProfValue
            // 
            this.labelAddProfValue.AutoSize = true;
            this.labelAddProfValue.Location = new System.Drawing.Point(102, 25);
            this.labelAddProfValue.Name = "labelAddProfValue";
            this.labelAddProfValue.Size = new System.Drawing.Size(0, 13);
            this.labelAddProfValue.TabIndex = 10;
            // 
            // buttonAddProfValue
            // 
            this.buttonAddProfValue.Image = global::_5eCharGen.Properties.Resources.arrow_Down_16xLG;
            this.buttonAddProfValue.Location = new System.Drawing.Point(6, 20);
            this.buttonAddProfValue.Name = "buttonAddProfValue";
            this.buttonAddProfValue.Size = new System.Drawing.Size(30, 23);
            this.buttonAddProfValue.TabIndex = 3;
            this.buttonAddProfValue.UseVisualStyleBackColor = true;
            this.buttonAddProfValue.Click += new System.EventHandler(this.buttonAddProfValue_Click);
            // 
            // textBoxProfValue
            // 
            this.textBoxProfValue.Location = new System.Drawing.Point(68, 22);
            this.textBoxProfValue.Name = "textBoxProfValue";
            this.textBoxProfValue.Size = new System.Drawing.Size(31, 20);
            this.textBoxProfValue.TabIndex = 9;
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Location = new System.Drawing.Point(42, 25);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(0, 13);
            this.labelAdd.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxProfAdded);
            this.groupBox1.Controls.Add(this.buttonRemoveProf);
            this.groupBox1.Controls.Add(this.buttonAddProf);
            this.groupBox1.Controls.Add(this.labelAddProf);
            this.groupBox1.Location = new System.Drawing.Point(3, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 78);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxProfAdded
            // 
            this.comboBoxProfAdded.FormattingEnabled = true;
            this.comboBoxProfAdded.Location = new System.Drawing.Point(6, 52);
            this.comboBoxProfAdded.Name = "comboBoxProfAdded";
            this.comboBoxProfAdded.Size = new System.Drawing.Size(150, 21);
            this.comboBoxProfAdded.TabIndex = 4;
            // 
            // buttonRemoveProf
            // 
            this.buttonRemoveProf.Image = global::_5eCharGen.Properties.Resources.DeleteHS;
            this.buttonRemoveProf.Location = new System.Drawing.Point(162, 52);
            this.buttonRemoveProf.Name = "buttonRemoveProf";
            this.buttonRemoveProf.Size = new System.Drawing.Size(30, 23);
            this.buttonRemoveProf.TabIndex = 12;
            this.buttonRemoveProf.UseVisualStyleBackColor = true;
            this.buttonRemoveProf.Click += new System.EventHandler(this.buttonRemoveProf_Click);
            // 
            // buttonAddProf
            // 
            this.buttonAddProf.Image = global::_5eCharGen.Properties.Resources.arrow_Down_16xLG;
            this.buttonAddProf.Location = new System.Drawing.Point(6, 23);
            this.buttonAddProf.Name = "buttonAddProf";
            this.buttonAddProf.Size = new System.Drawing.Size(30, 23);
            this.buttonAddProf.TabIndex = 2;
            this.buttonAddProf.UseVisualStyleBackColor = true;
            this.buttonAddProf.Click += new System.EventHandler(this.buttonAddProf_Click);
            // 
            // labelAddProf
            // 
            this.labelAddProf.AutoSize = true;
            this.labelAddProf.Location = new System.Drawing.Point(42, 28);
            this.labelAddProf.Name = "labelAddProf";
            this.labelAddProf.Size = new System.Drawing.Size(0, 13);
            this.labelAddProf.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            // 
            // comboBoxFieldControlProfName
            // 
            this.comboBoxFieldControlProfName.LabelText = "";
            this.comboBoxFieldControlProfName.Location = new System.Drawing.Point(7, 7);
            this.comboBoxFieldControlProfName.Name = "comboBoxFieldControlProfName";
            this.comboBoxFieldControlProfName.Size = new System.Drawing.Size(182, 41);
            this.comboBoxFieldControlProfName.TabIndex = 0;
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
            // comboBoxFieldSpellName
            // 
            this.comboBoxFieldSpellName.LabelText = "";
            this.comboBoxFieldSpellName.Location = new System.Drawing.Point(7, 7);
            this.comboBoxFieldSpellName.Name = "comboBoxFieldSpellName";
            this.comboBoxFieldSpellName.Size = new System.Drawing.Size(208, 39);
            this.comboBoxFieldSpellName.TabIndex = 0;
            // 
            // tabPageMisc
            // 
            this.tabPageMisc.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageMisc.Location = new System.Drawing.Point(4, 25);
            this.tabPageMisc.Name = "tabPageMisc";
            this.tabPageMisc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMisc.Size = new System.Drawing.Size(425, 151);
            this.tabPageMisc.TabIndex = 4;
            this.tabPageMisc.Text = "Misc";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(17, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(436, 2);
            this.label9.TabIndex = 18;
            // 
            // Summary
            // 
            this.Summary.AutoSize = true;
            this.Summary.Location = new System.Drawing.Point(239, 34);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(15, 14);
            this.Summary.TabIndex = 19;
            this.Summary.UseVisualStyleBackColor = true;
            this.Summary.CheckedChanged += new System.EventHandler(this.Summary_CheckedChanged);
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
            // comboBoxFieldSAName
            // 
            this.comboBoxFieldSAName.LabelText = "";
            this.comboBoxFieldSAName.Location = new System.Drawing.Point(13, 13);
            this.comboBoxFieldSAName.Name = "comboBoxFieldSAName";
            this.comboBoxFieldSAName.Size = new System.Drawing.Size(219, 39);
            this.comboBoxFieldSAName.TabIndex = 0;
            // 
            // SpecialAbilityEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 261);
            this.Controls.Add(this.Summary);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.comboBoxFieldSAName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SpecialAbilityEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SpecialAbilityEditor";
            this.tabControl1.ResumeLayout(false);
            this.tabPageBasicStats.ResumeLayout(false);
            this.tabPageBasicStats.PerformLayout();
            this.tabPageAttributes.ResumeLayout(false);
            this.tabPageAttributes.PerformLayout();
            this.tabPageProf.ResumeLayout(false);
            this.tabPageProf.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageSpells.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label labelDescription;
        private _5eCharGen.View.TextFieldControl textFieldControlName;
        private System.Windows.Forms.TextBox textBoxProfValue;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.ComboBox comboBoxProfValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelAddProf;
        private System.Windows.Forms.ComboBox comboBoxProfAdded;
        private System.Windows.Forms.Button buttonAddProfValue;
        private System.Windows.Forms.Button buttonAddProf;
        private _5eCharGen.View.ComboBoxFieldControl comboBoxFieldControlProfName;
        private System.Windows.Forms.Label labelAddProfValue;
        private System.Windows.Forms.Label labelAddProfHelp;
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
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Summary;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonAddNewProf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInstACSpeed;
        private _5eCharGen.View.TextFieldControl textFieldControlAC;
        private _5eCharGen.View.TextFieldControl textFieldControlSpeed;
    }
}