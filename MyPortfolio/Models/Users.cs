using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Models
{
    public class Users
    {
        public int id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }
    }
}
