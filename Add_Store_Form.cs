﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioneMagazzino
{
    public partial class Add_Store_Form : Form
    {
        public Add_Store_Form()
        {
            InitializeComponent();
        }

        private void Save_Store(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
