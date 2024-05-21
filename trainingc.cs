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
        private BindingSource bindingSource = new BindingSource();

        private void RefreshDataGrid()
        {
            DataBase DataBase = new DataBase();
           
            string queryString = $"select * from traning1"; 
            var dataView = new SqlDataAdapter(queryString,DataBase.GetConnection());
            var commandBuilder = new SqlCommandBuilder(dataView);
            var dataTable = new DataTable();
            dataView.Fill(dataTable);
            bindingSource.DataSource = dataTable;
           
        }

        private void trainingAC_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = bindingSource;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomBaseDataSet1.coach". При необходимости она может быть перемещена или удалена.
            this.coachTableAdapter1.Fill(this.diplomBaseDataSet1.coach);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomBaseDataSet.coach". При необходимости она может быть перемещена или удалена.
            this.coachTableAdapter.Fill(this.diplomBaseDataSet.coach);
            //CreateColumns();
            //RefreshDataGrid(dataGridView1 );
            RefreshDataGrid();

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

        private void button2_Click(object sender, EventArgs e)
        {
            DataBase DataBase = new DataBase();

            var dayweek = dayOfWeek.Text;
            var type = typeTrain.Text;
            var time = timeTrain.Text;
            var place1 = placeTrain.Text;
            var main = mainCoach.Text;
            var second = secondCoach.Text;

            if (string.IsNullOrWhiteSpace(dayweek) || string.IsNullOrEmpty(type) || string.IsNullOrEmpty(time) ||string.IsNullOrEmpty(place1) || string.IsNullOrEmpty(main) ||string.IsNullOrEmpty(second) )
                {
                MessageBox.Show("Заполните все данные ");
                return;
            }

           if( !TimeSpan.TryParse(time,out var timeParsed))
            {
                MessageBox.Show("неправильно указано время");
                return;
            }

            string add = $"insert into traning1 (day_of_week, type_training,time_training,mesto_tr,main_coach,second_coach) values (@dayweek,@type,@time,@place1,@main,@second)";
            
            SqlCommand commanda = new SqlCommand(add, DataBase.GetConnection());
            commanda.Parameters.AddWithValue("dayweek", dayweek);
            commanda.Parameters.AddWithValue("type", type);
            commanda.Parameters.AddWithValue("time", timeParsed);
            commanda.Parameters.AddWithValue("place1 ", place1);
            commanda.Parameters.AddWithValue("main", main);
            commanda.Parameters.AddWithValue("second", second);
            DataBase.OpenConnection();
            if (commanda.ExecuteNonQuery() ==1 )
            {
                MessageBox.Show("Запись добавлена");
                RefreshDataGrid();
            }
            else
            {
                MessageBox.Show("ошибка, повторите ввод");
            } 
                DataBase.CloseConnection();
        }

        private void dayOfWeek_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            DataBase DataBase = new DataBase();
            int userId;
            if (int.TryParse(deleteB.Text, out userId))
            {
                string delete = "Delete from traning1 where id_training = @userId"; 
                SqlCommand deleteC = new SqlCommand(delete, DataBase.GetConnection());
                deleteC.Parameters.AddWithValue("userId", userId);
                DataBase.OpenConnection();
                int rowsAffected = deleteC.ExecuteNonQuery();
                DataBase.CloseConnection();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Запись удалена");
                    RefreshDataGrid();
                }
                else
                {
                    MessageBox.Show("Некоректные данные");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
