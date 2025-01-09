using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment.Question_02
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public bool AuthenticateUser(string username, string password)
        {
            if (username == "user" && password == "password")
            {
                return true;
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            if (username == "user" && role == "admin")
            {
                return true;
            }
            return false;
        }
    }
}
