using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ClientModel
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientSurname { get; set; }
        public string ClientCode { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public int status { get; set; }

        public ClientModel()
        {

        }

    }
}
