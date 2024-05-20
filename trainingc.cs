using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dipllom_Gencha
{
    //enum RowState
    //{
    //    Existed,
    //    New,
    //    Modified,
    //    ModifiedNew,
    //    Deleted
    //}
    public partial class trainingc : Form
    {
        //DataBase DataBase = new DataBase();
        //int seectedRow;
        public trainingc()
        {
            InitializeComponent();
        }
        //private void CreateColumns()
        //{
        //    dataGridView1.Columns.Add("id_training", "ID");
        //    dataGridView1.Columns.Add("day_of_week", "день недели");
        //    dataGridView1.Columns.Add("type_training", "тип тренировки");
        //   // dataGridView1.Columns.Add("time_training", "время ");
        //    dataGridView1.Columns.Add("place", "место");
        //    dataGridView1.Columns.Add("main_coach", "главный тренер");
        //    dataGridView1.Columns.Add("second_coach", "тренер подготовки");
        //    dataGridView1.Columns.Add("IsNew",String.Empty);
        //}
        //private void ReadSingleRow( DataGridView dgw, IDataRecord record )
        //{
        //    dgw.Rows.Add(record.GetInt32(0),record.GetString(1),record.GetString(2),record.GetDateTime(3),record.GetString(4),record.GetString(5),record.GetString(6),RowState.ModifiedNew);
        ////,record.GetDateTime(3)
        //        }
        //private void RefreshDataGrid( DataGridView dgw )
        //{
        //    dgw.Rows.Clear();
        //    string queryString = $"select * from traning1";
        //    SqlCommand command = new SqlCommand(queryString,DataBase.GetConnection());
        //    DataBase.OpenConnection();
        //    SqlDataReader reader = command.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        ReadSingleRow( dgw,reader);
        //    }
        //    reader.Close();
        //}

        private void trainingAC_Load(object sender, EventArgs e)
        {
            //CreateColumns();
            //RefreshDataGrid(dataGridView1 );

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            coach coach = new coach();
            coach.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
