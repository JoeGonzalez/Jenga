using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jenga.Models
{
    public class Players
    {
        public int Id { get; set; }
        public string Usernames { get; set; }
        public string Passwords { get; set; }
        public Players() { }
        public Players(string usernames, string passwords) 
        {
            Usernames = usernames;
            Passwords = passwords;
        }
    }
}
