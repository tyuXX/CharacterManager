﻿using CharacterManager.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterManager
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click( object sender, EventArgs e )
        {
            CharControl charControl = new CharControl();
            flowLayoutPanel1.Controls.Add( charControl );
            charControl.Show();
        }
    }
}
