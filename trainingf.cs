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
    public partial class trainingf : Form
    {
        public trainingf()
        {
            InitializeComponent();
        }

        private void training_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource;
            RefreshDataGrid();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            footb footb = new footb();
            footb.Show();
            this.Hide();
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
    }
}
