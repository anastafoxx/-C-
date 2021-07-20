using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window25
{
    class User
    {
        public int id { get; set; }
     /*   public int Id
        {
            get;set;
        } */

        private string login, password;

        public string Login   //аксессор точно такой же, но с большой буквы
        {
            get { return login; }
            set { login = value; }
        }
        public string Password   //аксессор точно такой же, но с большой буквы
        {
            get { return password; }
            set { password = value; }
        }

        public User()
        {
        }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }

        /*public override string ToString()
        {
            return "login is " + login;
        }*/
    }
}
