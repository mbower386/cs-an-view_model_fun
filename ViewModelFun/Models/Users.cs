using System;
using System.Collections.Generic;
using ViewModelFun.Models;

namespace ViewModelFun.Models
{
    public class Users
    {
        public List<User> UserList;
        public Users ()
        {
            UserList = new List<User> ();
            UserList.Add (new User ("Jack", "Bauer"));
            UserList.Add (new User ("John", "McClane"));
            UserList.Add (new User ("Frank", "Bullitt"));
            UserList.Add (new User ("Harry", "Callahan"));
            UserList.Add (new User ("Jason", "Bourne"));
            UserList.Add (new User ("James", "Bond"));
        }
    }
}