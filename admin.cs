using System;
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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            avtoriz avtoriz = new avtoriz();
            avtoriz.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void admin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomBaseDataSet1.coach". При необходимости она может быть перемещена или удалена.
            this.coachTableAdapter1.Fill(this.diplomBaseDataSet1.coach);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomBaseDataSet1.players". При необходимости она может быть перемещена или удалена.
            this.playersTableAdapter1.Fill(this.diplomBaseDataSet1.players);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomBaseDataSet.players". При необходимости она может быть перемещена или удалена.
            this.playersTableAdapter.Fill(this.diplomBaseDataSet.players);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomBaseDataSet.coach". При необходимости она может быть перемещена или удалена.
            this.coachTableAdapter.Fill(this.diplomBaseDataSet.coach);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            avtoriz avtoriz1 = new avtoriz();
            avtoriz1.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void coachBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void playersBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void coachBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void training_Click(object sender, EventArgs e)
        {
            traininga traininga = new traininga();
            traininga.Show();
            this.Hide();

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            avtoriz avtoriz = new avtoriz();
            avtoriz.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            gamesa gamesa = new gamesa();
            gamesa.Show();
            this.Hide();
        }
    }
}
