using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public DateTime LastLogin { get; set; }
        public UserModel()
        {

        }
        
    }
}
