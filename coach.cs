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
    public partial class coach : Form
    {
        public coach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            avtoriz avtoriz1 = new avtoriz();
            avtoriz1.Show();
            this.Hide();
        }

        private void playersBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gamesc gamesc = new gamesc();
            gamesc.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void coachBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            trainingc trainingAC = new trainingc();
            trainingAC.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void coachBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void coach_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomBaseDataSet1.coach". При необходимости она может быть перемещена или удалена.
            this.coachTableAdapter1.Fill(this.diplomBaseDataSet1.coach);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomBaseDataSet1.players". При необходимости она может быть перемещена или удалена.
            this.playersTableAdapter1.Fill(this.diplomBaseDataSet1.players);

        }
    }
}
