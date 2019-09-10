using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BLClient
    {

        public BLClient()
        {
            
        }

        public string InsertClientBI(string ClientName, string ClientSurname, string ClientCode, string PhoneNo, string Email, out int insertedId)
        {
            DAClient DAip = new DAClient();
            string info =   DAip.InsertClient(ClientName, ClientSurname, ClientCode, PhoneNo, Email, out insertedId);
            return info;
        }

        public BindingList<ClientModel> GetClientBi(string ClientName, string ClientSurname, string ClientCode, int? ClientId, int? skip_page, int? take_page)
        {
            DAClient dac = new DAClient();
            DataTable dt = new DataTable();
            dt = dac.GetClients(ClientName, ClientSurname, ClientCode, ClientId, skip_page, take_page);

            BindingList<ClientModel> list = new BindingList<ClientModel>();
            for (int i = 0; i<dt.Rows.Count; i++)
            {
                ClientModel client = new ClientModel();
                client.ClientId = Convert.ToInt32(dt.Rows[i]["ClientId"].ToString());
                client.ClientName = dt.Rows[i]["ClientName"].ToString();
                client.ClientSurname = dt.Rows[i]["ClientSurname"].ToString();
                client.ClientCode = dt.Rows[i]["ClientCode"].ToString();
                client.PhoneNo = dt.Rows[i]["PhoneNo"].ToString();
                client.Email = dt.Rows[i]["Email"].ToString();

                list.Add(client);

            }           

            return list;
        }

        public string DeleteClient(int selectedId)
        {
            DAClient dac = new DAClient();
            return dac.DADeleteClient(selectedId);
        }        

        public string BIUpdateClient(string clientName, string clientSurname, string clientCode, string phoneNo, string email, int clientId, bool ok)
        {
            DAClient da = new DAClient();
            string info =  da.DAUpdateClient(clientName, clientSurname, clientCode, phoneNo, email, clientId, ok);
            return info;
        }

        public int BLGetTotalRow(string clientName, string clientSurname, string clientCode)
        {
            DAClient da = new DAClient();
            return da.GetTotalRowClient(clientName, clientSurname, clientCode);
        }
        
    }
}
