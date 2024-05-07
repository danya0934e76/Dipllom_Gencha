using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Dipllom_Gencha
{
    internal class DataBase
    {
        SqlConnection connection = new SqlConnection(@"Data Source=PKGENCHA\SQLEXPRESS;Initial Catalog=DiplomBase;User ID=sa;Password=sa;Encrypt=False");

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public SqlConnection GetConnection() 
        {
            return connection;
        }



    }
}
