using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class InvoiceModel
    {
        public int invoiceId { get; set; }
        public string invoiceNumber { get; set; }
        public DateTime invoiceDate { get; set; }
        public int clientId { get; set; }
        public string clientName { get; set; }
        public int clientAddressId { get; set; }
        public string clientAddress { get; set; }
        public int userId { get; set; }
        public string observations { get; set; }
        public int status { get; set; }

        public InvoiceModel()
        {

        }
    }
}
