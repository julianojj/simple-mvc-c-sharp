using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.App.Services;

namespace WindowsFormsApp1.App.Models
{
    class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        private SqlConnection connection;
        private Bcrypt bcrypt;

        public User()
        {
            this.connection = new Database().GetConnection();
            this.bcrypt = new Bcrypt();
        }

        public void AuthenticateUser()
        {
            try
            {
                string email = this.Email;
                string password = this.Password;

                this.connection.Open();

                SqlCommand command = this.connection.CreateCommand();
                command.CommandText = "SELECT * FROM users WHERE email = @email";
                command.Parameters.AddWithValue("@email", email);

                SqlDataReader data = command.ExecuteReader();

                if (data.HasRows)
                {
                    data.Read();

                    bool hash = bcrypt.Decrypt(password, data["password"].ToString());

                    if (hash)
                    {
                        MessageBox.Show("Logado");
                    } else
                    {
                        MessageBox.Show("Dados inválidos");
                    }

                } else
                {
                    MessageBox.Show("Dados inválidos");
                }

            }
            catch (SqlException err)
            {

                throw err;
            } finally
            {
                this.connection.Close();
            }
        }
    }
}
