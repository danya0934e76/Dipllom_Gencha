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
    public partial class GamesP : Form
    {
        public GamesP()
        {
            InitializeComponent();
        }

        private void GamesP_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomBaseDataSet4.games". При необходимости она может быть перемещена или удалена.
            this.gamesTableAdapter.Fill(this.diplomBaseDataSet4.games);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            personal personal = new personal();
            personal.Show();
            this.Hide();
        }
    }
}
