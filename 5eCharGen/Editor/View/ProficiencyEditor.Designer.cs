namespace _5eCharGen.Editor.View
{
    partial class ProficiencyEditor
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.comboBoxProfType = new _5eCharGen.View.ComboBoxFieldControl();
            this.textFieldProfName = new _5eCharGen.View.TextFieldControl();
            this.comboBoxFieldProficiencySelect = new _5eCharGen.View.ComboBoxFieldControl();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Image = global::_5eCharGen.Properties.Resources.saveHS;
            this.buttonSave.Location = new System.Drawing.Point(89, 111);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(32, 32);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Image = global::_5eCharGen.Properties.Resources.DeleteHS;
            this.buttonRemove.Location = new System.Drawing.Point(51, 111);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(32, 32);
            this.buttonRemove.TabIndex = 4;
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Image = global::_5eCharGen.Properties.Resources.NewDocumentHS;
            this.buttonNew.Location = new System.Drawing.Point(13, 111);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(32, 32);
            this.buttonNew.TabIndex = 5;
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // comboBoxProfType
            // 
            this.comboBoxProfType.LabelText = "Type";
            this.comboBoxProfType.Location = new System.Drawing.Point(142, 57);
            this.comboBoxProfType.Name = "comboBoxProfType";
            this.comboBoxProfType.Size = new System.Drawing.Size(100, 39);
            this.comboBoxProfType.TabIndex = 2;
            // 
            // textFieldProfName
            // 
            this.textFieldProfName.LabelText = "Name";
            this.textFieldProfName.Location = new System.Drawing.Point(13, 57);
            this.textFieldProfName.Name = "textFieldProfName";
            this.textFieldProfName.Size = new System.Drawing.Size(123, 39);
            this.textFieldProfName.TabIndex = 1;
            // 
            // comboBoxFieldProficiencySelect
            // 
            this.comboBoxFieldProficiencySelect.LabelText = "Select a Proficiency";
            this.comboBoxFieldProficiencySelect.Location = new System.Drawing.Point(12, 12);
            this.comboBoxFieldProficiencySelect.Name = "comboBoxFieldProficiencySelect";
            this.comboBoxFieldProficiencySelect.Size = new System.Drawing.Size(230, 39);
            this.comboBoxFieldProficiencySelect.TabIndex = 0;
            // 
            // ProficiencyEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 165);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxProfType);
            this.Controls.Add(this.textFieldProfName);
            this.Controls.Add(this.comboBoxFieldProficiencySelect);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProficiencyEditor";
            this.ShowIcon = false;
            this.Text = "Proficiencies";
            this.ResumeLayout(false);

        }

        #endregion

        private _5eCharGen.View.ComboBoxFieldControl comboBoxFieldProficiencySelect;
        private _5eCharGen.View.TextFieldControl textFieldProfName;
        private _5eCharGen.View.ComboBoxFieldControl comboBoxProfType;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonNew;
    }
}