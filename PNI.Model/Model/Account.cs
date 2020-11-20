using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNI.Model.Model
{
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


        public Account()
        {

        }

        public Account(int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;

        }
    }



    

}
