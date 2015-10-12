namespace _5eCharGen
{
    partial class MainWindow
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
            this.btnMainCreateNew = new System.Windows.Forms.Button();
            this.btnMainLoad = new System.Windows.Forms.Button();
            this.loadCharDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnMainCreateNew
            // 
            this.btnMainCreateNew.Location = new System.Drawing.Point(108, 81);
            this.btnMainCreateNew.Name = "btnMainCreateNew";
            this.btnMainCreateNew.Size = new System.Drawing.Size(125, 21);
            this.btnMainCreateNew.TabIndex = 0;
            this.btnMainCreateNew.Text = "Create New Character";
            this.btnMainCreateNew.UseVisualStyleBackColor = true;
            // 
            // btnMainLoad
            // 
            this.btnMainLoad.Location = new System.Drawing.Point(108, 108);
            this.btnMainLoad.Name = "btnMainLoad";
            this.btnMainLoad.Size = new System.Drawing.Size(125, 21);
            this.btnMainLoad.TabIndex = 1;
            this.btnMainLoad.Text = "Load Character";
            this.btnMainLoad.UseVisualStyleBackColor = true;
            this.btnMainLoad.Click += new System.EventHandler(this.btnMainLoad_Click);
            // 
            // loadCharDialog
            // 
            this.loadCharDialog.FileName = "Character File";
            this.loadCharDialog.Filter = "Character Files|*.5e";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 241);
            this.Controls.Add(this.btnMainLoad);
            this.Controls.Add(this.btnMainCreateNew);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "5e Character Generator";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMainCreateNew;
        private System.Windows.Forms.Button btnMainLoad;
        private System.Windows.Forms.OpenFileDialog loadCharDialog;
    }
}

