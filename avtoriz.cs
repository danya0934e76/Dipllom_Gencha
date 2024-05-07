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
            var log = login.Text;
            var password = pass.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            string sql = $"select login, password from polzovatel where login ='{log}' and password ='{password}'";

            SqlCommand command = new SqlCommand(sql, DataBase.Getconnection()) ;
        }
    }
}
