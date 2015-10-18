namespace _5eCharGen.Editor.View
{
    partial class SpellEditorIndex
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
            this.comboBoxFieldSpellSelect = new _5eCharGen.View.ComboBoxFieldControl();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxFieldSpellSelect
            // 
            this.comboBoxFieldSpellSelect.LabelText = "Spell";
            this.comboBoxFieldSpellSelect.Location = new System.Drawing.Point(12, 12);
            this.comboBoxFieldSpellSelect.Name = "comboBoxFieldSpellSelect";
            this.comboBoxFieldSpellSelect.Size = new System.Drawing.Size(208, 39);
            this.comboBoxFieldSpellSelect.TabIndex = 0;
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Location = new System.Drawing.Point(12, 57);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(66, 23);
            this.buttonAddNew.TabIndex = 1;
            this.buttonAddNew.Text = "Add New";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(85, 56);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(66, 23);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(13, 87);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // SpellEditorIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 335);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.comboBoxFieldSpellSelect);
            this.Name = "SpellEditorIndex";
            this.Text = "SpellEditorIndex";
            this.ResumeLayout(false);

        }

        #endregion

        private _5eCharGen.View.ComboBoxFieldControl comboBoxFieldSpellSelect;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonSave;
    }
}