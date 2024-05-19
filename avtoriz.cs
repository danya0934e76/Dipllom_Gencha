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
    public partial class avtoriz : Form
    {
        public avtoriz()
        {
            InitializeComponent();
           pass.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                pass.UseSystemPasswordChar = false;
            }
            else
            {
                pass.UseSystemPasswordChar = true;
            } 
                
        }

        private void avtoriz_Load(object sender, EventArgs e)
        {

        }

        private void vxod1_Click(object sender, EventArgs e)
        {
            DataBase DataBase = new DataBase();
            var log = login.Text;
            var password = pass.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            string query = $"select login, password, role from polzov where login = '{log}' and password = '{password}'";
            SqlCommand command = new SqlCommand(query, DataBase.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            if (dt.Rows.Count ==1 )
            {
                int role = Convert.ToInt32(dt.Rows[0]["role"]);
                switch (role) 
                {
                    case 1:
                       admin admin = new admin();
                        admin.Show();
                        this.Hide();
                        break;
                        case 2:
                        coach coach = new coach();
                        coach.Show();
                        this.Hide();   
                        break;
                        case 3:
                        footb footb = new footb();  
                        footb.Show(); this.Hide();
                        break;
                        case 4:
                        personal personal = new personal();
                        personal.Show();
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("неизвестная роль ");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Ошибка");
            }

            //SqlDataAdapter adapter = new SqlDataAdapter();
            //DataTable dt = new DataTable();
            //string sql = $"select login, password from polzovatel where login ='{log}' and password ='{password}'";

            //SqlCommand command = new SqlCommand(sql, connection: DataBase.GetConnection());

            //adapter.SelectCommand = command ;
            //adapter.Fill(dt);
            //if (dt.Rows.Count == 1) 
            //{
            //    MessageBox.Show("вход выполнен");
            //    vxod vxod = new vxod();
            //    vxod.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Вход не выполнен, попробуйте еще");
            //}
        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
