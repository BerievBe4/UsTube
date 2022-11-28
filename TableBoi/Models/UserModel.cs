using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TableBoi.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string ErrorMessage { get; set; }
    }
}
