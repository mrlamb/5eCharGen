﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5eCharGen.View
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent(); 
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Data.GetAllRaces();
        }
        private void btnMainLoad_Click(object sender, EventArgs e)
        {
            loadCharDialog.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateNewCharacterTab()
        {
            TabPage tabPage = new TabPage();
            tabCharacters.Controls.Add(tabPage);
            tabPage.Text = "Unknown";

            CharacterControl characterControl = new CharacterControl();
            tabPage.Controls.Add(characterControl);
            characterControl.Dock = DockStyle.Fill;
            characterControl.CharacterNameChange += CharacterControl_CharacterNameChange;
            tabPage.Tag = characterControl;
        }

        private void CharacterControl_CharacterNameChange(object sender, EventArgs e)
        {
            foreach(Control control in tabCharacters.Controls)
            {
                if (control.Tag == sender)
                {
                    control.Text = (sender as CharacterControl).CharacterName;
                    break;
                }
            }
        }

        private void newCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewCharacterTab();
        }
    }
}
