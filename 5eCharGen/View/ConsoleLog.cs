﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5eCharGen.View
{
    public partial class ConsoleLog : Form
    {
        public ConsoleLog()
        {
            InitializeComponent();
        }

        public void Add(string line)
        {
            label1.Text += line;
        }
    }
}
