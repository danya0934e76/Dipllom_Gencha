using Dipllom_Gencha.comman;
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
        private static Dictionary<UserRoles,Func<Form>> _actionForms=new Dictionary<UserRoles,Func<Form>>()
        {
            [UserRoles.Admin]= ()=> new admin(),
            [UserRoles.Footb]= ()=> new footb(),
            [UserRoles.Coach]= ()=> new coach(),
            [UserRoles.Personal]= ()=> new personal(),

        };
        
        public avtoriz()
        {
            InitializeComponent();
           pass.UseSystemPasswordChar = true;
           passr.UseSystemPasswordChar = true;
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
            if (string.IsNullOrWhiteSpace(log) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("пароль и логин не должны быть пустыми");
                return;
            }
           

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            string query = $"select login, password, role from polzov where login = @login and password = @password";
            SqlCommand command = new SqlCommand(query, DataBase.GetConnection());
            command.Parameters.AddWithValue("login", log);
            command.Parameters.AddWithValue ("password", password);
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            if (dt.Rows.Count ==1 )
            {
                var role = (UserRoles)Convert.ToInt32(dt.Rows[0]["role"]);
                if (!_actionForms.TryGetValue(role,out var action))
                {
                    MessageBox.Show("неизвестная роль ");
                    return;
                }
                var  form = action();
                form.Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }

        private void registr_Click(object sender, EventArgs e)
        {
            DataBase DataBase = new DataBase();
            var namer = name.Text;
            var secr = second.Text;
            var loginr = logr.Text;
            var passwordr  = passr.Text;
            var roler = roles.Text;

            if (string.IsNullOrWhiteSpace(loginr) || string.IsNullOrWhiteSpace(passwordr) || string.IsNullOrWhiteSpace(namer) || string.IsNullOrWhiteSpace(passwordr)) 
            {
                MessageBox.Show("Заполните все данные");
                return;
            }
            //string registr = $"insert into polzov (name,secname,login,password,role) values ('{namer}','{secr}' ,'{loginr}','{passwordr}','{roler}'";
           string registr = $"insert into polzov (name,secname,login,password,role) values (@name , @secname, @login, @password , @role) ";
            SqlCommand commandr = new SqlCommand(registr, DataBase.GetConnection());
            commandr.Parameters.AddWithValue("name", namer);
            commandr.Parameters.AddWithValue("secname", secr);
            commandr.Parameters.AddWithValue("login", loginr);
            commandr.Parameters.AddWithValue("password", passwordr);
            commandr.Parameters.AddWithValue("role", roler);
            DataBase.OpenConnection();
            if (commandr.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт создан успешно");

            }
            else
            {
                MessageBox.Show("ошибка, попробуйте еще раз") ;
            }
           DataBase.CloseConnection();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (passrch.Checked)
            {
                passr.UseSystemPasswordChar = false;
            }
            else
            {
                passr.UseSystemPasswordChar = true;
            }

        }
    }
}
