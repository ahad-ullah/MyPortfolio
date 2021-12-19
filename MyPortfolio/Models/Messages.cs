using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Models
{
    public class Messages
    {
        public int id { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string message { get; set; }
        public int UserId { get; set; }
        public Users users { get; set; }
    }
}
