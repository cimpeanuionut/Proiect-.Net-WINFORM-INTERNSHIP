using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ClientAddressModel
    {
        public int ClientAddressId { get; set; }
        public int ClientId { get; set; }
        public CityModel City { get; set; }
        public CountyModel County { get; set; }
        public string StreetName { get; set; }
        public string StreetNo { get; set; }
        public int status { get; set; }
        public string unique { get; set; }
        private Random random = new Random();
        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public ClientAddressModel()
        {

        }
    }
}
