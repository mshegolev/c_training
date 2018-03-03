using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;



namespace mantis_projects
{
    public class AccountData
    {
        public string username;
        public string password;

        public AccountData(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public AccountData()
        {
            // TODO: Complete member initialization
        }

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
    }
}
