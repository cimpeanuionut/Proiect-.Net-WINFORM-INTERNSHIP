using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class InvoiceDetailModel
    {
        public int invoiceDetailId { get; set; }
        public int invoiceId { get; set; }
        public int itemId { get; set; }
        public string itemName { get; set; }
        public decimal qtty { get; set; }
        public decimal price { get; set; }
        public decimal amount { get; set; }
        public string observation { get; set; }
        public int status { get; set; }
        public string unique { get; set; }
        private Random random = new Random();
        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public InvoiceDetailModel()
        {

        }
        
        
    }
}
