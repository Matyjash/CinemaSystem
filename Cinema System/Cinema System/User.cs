using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema_System
{
    public class User
    {

        public User()
        {
            logged = false;
            privilaged = false;
            login = "";
        }

        public bool logged{ get; set; }

        public bool privilaged { get; set; }

        public string login { get; set; }



    }
}
