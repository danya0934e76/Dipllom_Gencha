﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dipllom_Gencha
{
    public partial class coach : Form
    {
        public coach()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            avtoriz avtoriz = new avtoriz();
            avtoriz.Show();
            this.Hide();
        }
    }
}