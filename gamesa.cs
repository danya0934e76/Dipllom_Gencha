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
    public partial class gamesa : Form
    {
        public gamesa()

        {
            InitializeComponent();
        }

        private void gamesa_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomBaseDataSet4.games". При необходимости она может быть перемещена или удалена.
            this.gamesTableAdapter1.Fill(this.diplomBaseDataSet4.games);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin admin = new admin();
            admin.Show();
            this.Hide();
        }
    }
}
