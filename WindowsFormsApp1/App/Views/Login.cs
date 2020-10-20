using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.App.Controllers;

namespace WindowsFormsApp1.src.Views
{
    public partial class Login : Form
    {
        private UserController userController;

        public Login()
        {
            InitializeComponent();
            this.userController = new UserController();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string email = InputEmail.Text;
            string password = InputPassword.Text;
            this.userController.AuthenticateUser(email, password);
        }
    }
}
