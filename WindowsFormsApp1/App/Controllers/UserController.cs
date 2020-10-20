using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.App.Models;

namespace WindowsFormsApp1.App.Controllers
{
    class UserController
    {
        private User user;

        public UserController()
        {
            this.user = new User();
        }

        public void AuthenticateUser(string email, string password)
        {
            this.user.Email = email;
            this.user.Password = password;
            this.user.AuthenticateUser();
        }
    }
}
