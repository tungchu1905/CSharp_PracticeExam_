using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserClass
{
    class User
    {
        string username;
        string email;
        int roleid;

        public User()
        {
            username = "tungcthe141487";
            email = "tungcthe141487";
            roleid = 1;
        }

        public User(string username, string email, int roleid)
        {
            this.username = username;
            this.email = email;
            this.roleid = roleid;
        }

        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public int Roleid { get => roleid; set => roleid = value; }

        public override string ToString()
        {
            return "Username: " +username + " Email: "+email +" RoleID: " + roleid;
        }


        public override bool Equals(object obj)
        {
            User e = (User)obj;
            return e.username == username;
        }
    }
}
