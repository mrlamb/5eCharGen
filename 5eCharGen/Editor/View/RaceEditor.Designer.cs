namespace _5eCharGen.Editor.View
{
    partial class RaceEditor
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
            this.chkSubrace = new System.Windows.Forms.CheckBox();
            this.cmbParentRace = new System.Windows.Forms.ComboBox();
            this.lstLanguages = new System.Windows.Forms.ListBox();
            this.btnRemoveLanguage = new System.Windows.Forms.Button();
            this.btnAddLanguage = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSA = new System.Windows.Forms.ListBox();
            this.btnAddSA = new System.Windows.Forms.Button();
            this.btnRemoveSA = new System.Windows.Forms.Button();
            this.smallAttBlock1 = new _5eCharGen.Editor.View.SmallAttBlock();
            this.cmbSAAdd = new _5eCharGen.View.ComboBoxFieldControl();
            this.txtLanguagesAdd = new _5eCharGen.View.TextFieldControl();
            this.txtName = new _5eCharGen.View.TextFieldControl();
            this.cmbSelectRace = new _5eCharGen.View.ComboBoxFieldControl();
            this.SuspendLayout();
            // 
            // chkSubrace
            // 
            this.chkSubrace.AutoSize = true;
            this.chkSubrace.Location = new System.Drawing.Point(155, 96);
            this.chkSubrace.Name = "chkSubrace";
            this.chkSubrace.Size = new System.Drawing.Size(78, 17);
            this.chkSubrace.TabIndex = 22;
            this.chkSubrace.Text = "Subrace of";
            this.chkSubrace.UseVisualStyleBackColor = true;
            this.chkSubrace.CheckedChanged += new System.EventHandler(this.chkSubrace_CheckedChanged);
            // 
            // cmbParentRace
            // 
            this.cmbParentRace.Enabled = false;
            this.cmbParentRace.FormattingEnabled = true;
            this.cmbParentRace.Location = new System.Drawing.Point(237, 93);
            this.cmbParentRace.Name = "cmbParentRace";
            this.cmbParentRace.Size = new System.Drawing.Size(129, 21);
            this.cmbParentRace.TabIndex = 23;
            // 
            // lstLanguages
            // 
            this.lstLanguages.FormattingEnabled = true;
            this.lstLanguages.Location = new System.Drawing.Point(16, 184);
            this.lstLanguages.Name = "lstLanguages";
            this.lstLanguages.Size = new System.Drawing.Size(129, 43);
            this.lstLanguages.TabIndex = 25;
            this.lstLanguages.TabStop = false;
            // 
            // btnRemoveLanguage
            // 
            this.btnRemoveLanguage.Image = global::_5eCharGen.Properties.Resources.PendingDelete_13298;
            this.btnRemoveLanguage.Location = new System.Drawing.Point(150, 184);
            this.btnRemoveLanguage.Name = "btnRemoveLanguage";
            this.btnRemoveLanguage.Size = new System.Drawing.Size(16, 16);
            this.btnRemoveLanguage.TabIndex = 27;
            this.btnRemoveLanguage.TabStop = false;
            this.btnRemoveLanguage.UseVisualStyleBackColor = true;
            this.btnRemoveLanguage.Click += new System.EventHandler(this.btnRemoveLanguage_Click);
            // 
            // btnAddLanguage
            // 
            this.btnAddLanguage.Image = global::_5eCharGen.Properties.Resources.AddMark_10580;
            this.btnAddLanguage.Location = new System.Drawing.Point(150, 155);
            this.btnAddLanguage.Name = "btnAddLanguage";
            this.btnAddLanguage.Size = new System.Drawing.Size(16, 16);
            this.btnAddLanguage.TabIndex = 26;
            this.btnAddLanguage.TabStop = false;
            this.btnAddLanguage.UseVisualStyleBackColor = true;
            this.btnAddLanguage.Click += new System.EventHandler(this.btnAddLanguage_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::_5eCharGen.Properties.Resources.saveHS;
            this.btnSave.Location = new System.Drawing.Point(313, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 32);
            this.btnSave.TabIndex = 20;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::_5eCharGen.Properties.Resources.DeleteHS;
            this.btnRemove.Location = new System.Drawing.Point(275, 20);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(32, 32);
            this.btnRemove.TabIndex = 19;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::_5eCharGen.Properties.Resources.NewDocumentHS;
            this.btnAdd.Location = new System.Drawing.Point(237, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 32);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(234, 137);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(0, 13);
            this.lblSpeed.TabIndex = 28;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(237, 153);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(30, 20);
            this.txtSpeed.TabIndex = 29;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(16, 251);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(350, 57);
            this.txtDescription.TabIndex = 30;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(16, 234);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 13);
            this.lblDescription.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(16, 58);
            this.label1.MaximumSize = new System.Drawing.Size(0, 2);
            this.label1.MinimumSize = new System.Drawing.Size(600, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 2);
            this.label1.TabIndex = 32;
            // 
            // lstSA
            // 
            this.lstSA.FormattingEnabled = true;
            this.lstSA.Location = new System.Drawing.Point(395, 126);
            this.lstSA.Name = "lstSA";
            this.lstSA.Size = new System.Drawing.Size(201, 43);
            this.lstSA.TabIndex = 34;
            this.lstSA.TabStop = false;
            // 
            // btnAddSA
            // 
            this.btnAddSA.Image = global::_5eCharGen.Properties.Resources.AddMark_10580;
            this.btnAddSA.Location = new System.Drawing.Point(600, 95);
            this.btnAddSA.Name = "btnAddSA";
            this.btnAddSA.Size = new System.Drawing.Size(16, 16);
            this.btnAddSA.TabIndex = 35;
            this.btnAddSA.TabStop = false;
            this.btnAddSA.UseVisualStyleBackColor = true;
            this.btnAddSA.Click += new System.EventHandler(this.btnAddSA_Click);
            // 
            // btnRemoveSA
            // 
            this.btnRemoveSA.Image = global::_5eCharGen.Properties.Resources.PendingDelete_13298;
            this.btnRemoveSA.Location = new System.Drawing.Point(600, 126);
            this.btnRemoveSA.Name = "btnRemoveSA";
            this.btnRemoveSA.Size = new System.Drawing.Size(16, 16);
            this.btnRemoveSA.TabIndex = 36;
            this.btnRemoveSA.TabStop = false;
            this.btnRemoveSA.UseVisualStyleBackColor = true;
            this.btnRemoveSA.Click += new System.EventHandler(this.btnRemoveSA_Click);
            // 
            // smallAttBlock1
            // 
            this.smallAttBlock1.CHA = 0;
            this.smallAttBlock1.CON = 0;
            this.smallAttBlock1.DEX = 0;
            this.smallAttBlock1.INT = 0;
            this.smallAttBlock1.Location = new System.Drawing.Point(395, 175);
            this.smallAttBlock1.Name = "smallAttBlock1";
            this.smallAttBlock1.Size = new System.Drawing.Size(81, 133);
            this.smallAttBlock1.STR = 0;
            this.smallAttBlock1.TabIndex = 37;
            this.smallAttBlock1.WIS = 0;
            // 
            // cmbSAAdd
            // 
            this.cmbSAAdd.LabelText = "";
            this.cmbSAAdd.Location = new System.Drawing.Point(392, 77);
            this.cmbSAAdd.Name = "cmbSAAdd";
            this.cmbSAAdd.Size = new System.Drawing.Size(208, 39);
            this.cmbSAAdd.TabIndex = 33;
            // 
            // txtLanguagesAdd
            // 
            this.txtLanguagesAdd.LabelText = "";
            this.txtLanguagesAdd.Location = new System.Drawing.Point(13, 137);
            this.txtLanguagesAdd.Name = "txtLanguagesAdd";
            this.txtLanguagesAdd.Size = new System.Drawing.Size(135, 39);
            this.txtLanguagesAdd.TabIndex = 24;
            this.txtLanguagesAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLanguagesAdd_KeyPress);
            // 
            // txtName
            // 
            this.txtName.LabelText = "";
            this.txtName.Location = new System.Drawing.Point(13, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(135, 39);
            this.txtName.TabIndex = 21;
            // 
            // cmbSelectRace
            // 
            this.cmbSelectRace.LabelText = "";
            this.cmbSelectRace.Location = new System.Drawing.Point(13, 13);
            this.cmbSelectRace.Name = "cmbSelectRace";
            this.cmbSelectRace.Size = new System.Drawing.Size(208, 42);
            this.cmbSelectRace.TabIndex = 0;
            this.cmbSelectRace.ComboBoxTextChanged += new System.EventHandler(this.cmbSelectRace_SelectedIndexChanged);
            // 
            // RaceEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 320);
            this.Controls.Add(this.smallAttBlock1);
            this.Controls.Add(this.btnRemoveSA);
            this.Controls.Add(this.btnAddSA);
            this.Controls.Add(this.lstSA);
            this.Controls.Add(this.cmbSAAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.btnRemoveLanguage);
            this.Controls.Add(this.btnAddLanguage);
            this.Controls.Add(this.lstLanguages);
            this.Controls.Add(this.txtLanguagesAdd);
            this.Controls.Add(this.cmbParentRace);
            this.Controls.Add(this.chkSubrace);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbSelectRace);
            this.Name = "RaceEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Race Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _5eCharGen.View.ComboBoxFieldControl cmbSelectRace;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private _5eCharGen.View.TextFieldControl txtName;
        private System.Windows.Forms.CheckBox chkSubrace;
        private System.Windows.Forms.ComboBox cmbParentRace;
        private _5eCharGen.View.TextFieldControl txtLanguagesAdd;
        private System.Windows.Forms.ListBox lstLanguages;
        private System.Windows.Forms.Button btnAddLanguage;
        private System.Windows.Forms.Button btnRemoveLanguage;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label1;
        private _5eCharGen.View.ComboBoxFieldControl cmbSAAdd;
        private System.Windows.Forms.ListBox lstSA;
        private System.Windows.Forms.Button btnAddSA;
        private System.Windows.Forms.Button btnRemoveSA;
        private SmallAttBlock smallAttBlock1;
    }
}