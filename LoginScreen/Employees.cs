using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginScreen
{
    class Employees
    {
        public string userName { get; set; }
        public string password { get; set; }
        public bool isAdmin { get; set; }

        public Employees (string u, string p, bool i)
        {
            userName = u;
            password = p;
            isAdmin = i;
        }

    }
}
