using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.App.Models
{
    class Database
    {
        public SqlConnection connection;

        public SqlConnection GetConnection()
        {
            string connectionString = "Server=192.168.0.16;Uid=sa;Pwd=$hQNLz7E!x5&;Database=app";
            return this.connection = new SqlConnection(connectionString);
        }
    }
}
