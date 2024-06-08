using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dipllom_Gencha
{
    public partial class trainingp : Form
    {
        public trainingp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personal personal = new personal();
            personal.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private BindingSource bindingSource = new BindingSource();
        private void RefreshDataGrid()
        {
            DataBase DataBase = new DataBase();

            string queryString = $"select * from traning1";
            var dataView = new SqlDataAdapter(queryString, DataBase.GetConnection());
            var commandBuilder = new SqlCommandBuilder(dataView);
            var dataTable = new DataTable();
            dataView.Fill(dataTable);
            bindingSource.DataSource = dataTable;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void trainingp_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource;
            RefreshDataGrid();

        }
    }
}
