﻿namespace _5eCharGen.View
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
            this.loadCharDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCharacterAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proficiencyEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialAbilityEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spellEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabCharacters = new System.Windows.Forms.TabControl();
            this.raceEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadCharDialog
            // 
            this.loadCharDialog.FileName = "Character File";
            this.loadCharDialog.Filter = "Character Files|*.5e";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(740, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCharacterToolStripMenuItem,
            this.loadCharacterToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveCharacterToolStripMenuItem,
            this.saveCharacterAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.closeCharacterToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newCharacterToolStripMenuItem
            // 
            this.newCharacterToolStripMenuItem.Name = "newCharacterToolStripMenuItem";
            this.newCharacterToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.newCharacterToolStripMenuItem.Text = "&New Character";
            this.newCharacterToolStripMenuItem.Click += new System.EventHandler(this.newCharacterToolStripMenuItem_Click);
            // 
            // loadCharacterToolStripMenuItem
            // 
            this.loadCharacterToolStripMenuItem.Name = "loadCharacterToolStripMenuItem";
            this.loadCharacterToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.loadCharacterToolStripMenuItem.Text = "&Load Character";
            this.loadCharacterToolStripMenuItem.Click += new System.EventHandler(this.loadCharacterToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(171, 6);
            // 
            // saveCharacterToolStripMenuItem
            // 
            this.saveCharacterToolStripMenuItem.Name = "saveCharacterToolStripMenuItem";
            this.saveCharacterToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.saveCharacterToolStripMenuItem.Text = "&Save Character";
            // 
            // saveCharacterAsToolStripMenuItem
            // 
            this.saveCharacterAsToolStripMenuItem.Name = "saveCharacterAsToolStripMenuItem";
            this.saveCharacterAsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.saveCharacterAsToolStripMenuItem.Text = "S&ave Character As..";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(171, 6);
            // 
            // closeCharacterToolStripMenuItem
            // 
            this.closeCharacterToolStripMenuItem.Name = "closeCharacterToolStripMenuItem";
            this.closeCharacterToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.closeCharacterToolStripMenuItem.Text = "&Close Character";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proficiencyEditorToolStripMenuItem,
            this.raceEditorToolStripMenuItem,
            this.specialAbilityEditorToolStripMenuItem,
            this.spellEditorToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // proficiencyEditorToolStripMenuItem
            // 
            this.proficiencyEditorToolStripMenuItem.Name = "proficiencyEditorToolStripMenuItem";
            this.proficiencyEditorToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.proficiencyEditorToolStripMenuItem.Text = "Proficiency Editor";
            this.proficiencyEditorToolStripMenuItem.Click += new System.EventHandler(this.proficiencyEditorToolStripMenuItem_Click);
            // 
            // specialAbilityEditorToolStripMenuItem
            // 
            this.specialAbilityEditorToolStripMenuItem.Name = "specialAbilityEditorToolStripMenuItem";
            this.specialAbilityEditorToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.specialAbilityEditorToolStripMenuItem.Text = "Special Ability Editor";
            this.specialAbilityEditorToolStripMenuItem.Click += new System.EventHandler(this.specialAbilityEditorToolStripMenuItem_Click);
            // 
            // spellEditorToolStripMenuItem
            // 
            this.spellEditorToolStripMenuItem.Name = "spellEditorToolStripMenuItem";
            this.spellEditorToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.spellEditorToolStripMenuItem.Text = "Spell Editor";
            this.spellEditorToolStripMenuItem.Click += new System.EventHandler(this.spellEditorToolStripMenuItem_Click);
            // 
            // tabCharacters
            // 
            this.tabCharacters.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabCharacters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCharacters.Location = new System.Drawing.Point(0, 24);
            this.tabCharacters.Multiline = true;
            this.tabCharacters.Name = "tabCharacters";
            this.tabCharacters.SelectedIndex = 0;
            this.tabCharacters.Size = new System.Drawing.Size(740, 475);
            this.tabCharacters.TabIndex = 3;
            // 
            // raceEditorToolStripMenuItem
            // 
            this.raceEditorToolStripMenuItem.Name = "raceEditorToolStripMenuItem";
            this.raceEditorToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.raceEditorToolStripMenuItem.Text = "Race Editor";
            this.raceEditorToolStripMenuItem.Click += new System.EventHandler(this.raceEditorToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 499);
            this.Controls.Add(this.tabCharacters);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "5e Character Generator";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog loadCharDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCharacterAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem closeCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabCharacters;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spellEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proficiencyEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specialAbilityEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raceEditorToolStripMenuItem;
    }
}

