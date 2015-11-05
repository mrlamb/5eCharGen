namespace _5eCharGen.Editor.View
{
    partial class SpellComponentsControl
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
            this.label = new System.Windows.Forms.Label();
            this.checkBoxVerbal = new System.Windows.Forms.CheckBox();
            this.checkBoxSomatic = new System.Windows.Forms.CheckBox();
            this.checkBoxMaterial = new System.Windows.Forms.CheckBox();
            this.textBoxMaterialDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(4, 4);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 0;
            // 
            // checkBoxVerbal
            // 
            this.checkBoxVerbal.AutoSize = true;
            this.checkBoxVerbal.Location = new System.Drawing.Point(7, 29);
            this.checkBoxVerbal.Name = "checkBoxVerbal";
            this.checkBoxVerbal.Size = new System.Drawing.Size(15, 14);
            this.checkBoxVerbal.TabIndex = 1;
            this.checkBoxVerbal.UseVisualStyleBackColor = true;
            // 
            // checkBoxSomatic
            // 
            this.checkBoxSomatic.AutoSize = true;
            this.checkBoxSomatic.Location = new System.Drawing.Point(7, 53);
            this.checkBoxSomatic.Name = "checkBoxSomatic";
            this.checkBoxSomatic.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSomatic.TabIndex = 2;
            this.checkBoxSomatic.UseVisualStyleBackColor = true;
            // 
            // checkBoxMaterial
            // 
            this.checkBoxMaterial.AutoSize = true;
            this.checkBoxMaterial.Location = new System.Drawing.Point(7, 77);
            this.checkBoxMaterial.Name = "checkBoxMaterial";
            this.checkBoxMaterial.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMaterial.TabIndex = 3;
            this.checkBoxMaterial.UseVisualStyleBackColor = true;
            this.checkBoxMaterial.CheckedChanged += new System.EventHandler(this.checkBoxMaterial_CheckedChanged);
            // 
            // textBoxMaterialDesc
            // 
            this.textBoxMaterialDesc.Enabled = false;
            this.textBoxMaterialDesc.Location = new System.Drawing.Point(7, 119);
            this.textBoxMaterialDesc.Name = "textBoxMaterialDesc";
            this.textBoxMaterialDesc.Size = new System.Drawing.Size(195, 20);
            this.textBoxMaterialDesc.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // SpellComponentsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMaterialDesc);
            this.Controls.Add(this.checkBoxMaterial);
            this.Controls.Add(this.checkBoxSomatic);
            this.Controls.Add(this.checkBoxVerbal);
            this.Controls.Add(this.label);
            this.Name = "SpellComponentsControl";
            this.Size = new System.Drawing.Size(240, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.CheckBox checkBoxVerbal;
        private System.Windows.Forms.CheckBox checkBoxSomatic;
        private System.Windows.Forms.CheckBox checkBoxMaterial;
        private System.Windows.Forms.TextBox textBoxMaterialDesc;
        private System.Windows.Forms.Label label1;
    }
}
