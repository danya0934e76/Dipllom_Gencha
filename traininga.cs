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
    public partial class traininga : Form
    {
        public traininga()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            admin admin = new admin();
            admin.Show();
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

        private void traininga_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomBaseDataSet2.traning1". При необходимости она может быть перемещена или удалена.
            this.traning1TableAdapter1.Fill(this.diplomBaseDataSet2.traning1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomBaseDataSet1.coach". При необходимости она может быть перемещена или удалена.
            this.coachTableAdapter.Fill(this.diplomBaseDataSet1.coach);
            RefreshDataGrid();
        }

        private void dayOfWeek_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataBase DataBase = new DataBase();

            var dayweeka = dayOfWeek.Text;
            var typea = typeTrain.Text;
            var timea = timeTrain.Text;
            var place1a = placeTrain.Text;
            var maina = mainCoach.Text;
            var seconda = secondCoach.Text;

            if (string.IsNullOrWhiteSpace(dayweeka) || string.IsNullOrEmpty(typea) || string.IsNullOrEmpty(timea) || string.IsNullOrEmpty(place1a) || string.IsNullOrEmpty(maina)|| string.IsNullOrEmpty(seconda))
            {
                MessageBox.Show("Заполните все данные ");
                return;
            }

            if (!TimeSpan.TryParse(timea, out var timeParsed))
            {
                MessageBox.Show("неправильно указано время");
                return;
            }

            string add = $"insert into traning1 (day_of_week, type_training,time_training,mesto_tr,main_coach,second_coach) values (@dayweek,@type,@time,@place1,@main,@second)";

            SqlCommand commanda = new SqlCommand(add, DataBase.GetConnection());
            commanda.Parameters.AddWithValue("dayweek", dayweeka);
            commanda.Parameters.AddWithValue("type", typea);
            commanda.Parameters.AddWithValue("time", timeParsed);
            commanda.Parameters.AddWithValue("place1 ", place1a);
            commanda.Parameters.AddWithValue("main", maina);
            commanda.Parameters.AddWithValue("second", seconda);
            DataBase.OpenConnection();
            if (commanda.ExecuteNonQuery() == 1)
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

        private void delete_Click(object sender, EventArgs e)
        {
            DataBase DataBase = new DataBase();
            int userId;
            if (int.TryParse(deleteB.Text, out userId))
            {
                string delete = "Delete from traning1 where id_training = @userId";
                SqlCommand deleteA = new SqlCommand(delete, DataBase.GetConnection());
                deleteA.Parameters.AddWithValue("userId", userId);
                DataBase.OpenConnection();
                int rowsAffected = deleteA.ExecuteNonQuery();
                DataBase.CloseConnection();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Запись удалена");
                    RefreshDataGrid();
                }
                else
                {
                    MessageBox.Show(" Введите существующее id");
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

