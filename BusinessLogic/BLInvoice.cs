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
    public class BLInvoice
    {
        public BLInvoice()
        {

        }

        public int BLInsertInvoice(string invoiceNumber, DateTime invoiceDate, string clientFullName, string clientAddress, int userId, string obs)
        {
            DAInvoice da = new DAInvoice();
            return da.InsertInvoice(invoiceNumber, invoiceDate, clientFullName, clientAddress, userId, obs);
        }

        public BindingList<InvoiceModel> BLGetInvoice(int? invoiceId, DateTime startDate, DateTime endDate, string invoiceNumber, string clientFullName)
        {
            DAInvoice dac = new DAInvoice();
            DataTable dt = new DataTable();
            dt = dac.GetInvoice(invoiceId, startDate, endDate, invoiceNumber, clientFullName);

            BindingList<InvoiceModel> list = new BindingList<InvoiceModel>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                InvoiceModel invoice = new InvoiceModel();
                invoice.invoiceId = Convert.ToInt32(dt.Rows[i]["InvoiceId"].ToString());
                invoice.clientId = Convert.ToInt32(dt.Rows[i]["ClientId"].ToString());
                invoice.clientAddressId = Convert.ToInt32(dt.Rows[i]["ClientAddressId"].ToString());
                invoice.invoiceNumber = dt.Rows[i]["InvoiceNumber"].ToString();
                invoice.invoiceDate = Convert.ToDateTime(dt.Rows[i]["InvoiceDate"].ToString());
                invoice.observations = dt.Rows[i]["Observation"].ToString();
                invoice.clientName = dt.Rows[i]["ClientFullName"].ToString();
                invoice.clientAddress = dt.Rows[i]["ClientAddress"].ToString();

                list.Add(invoice);

            }

            return list;
        }

        public void BLDeleteInvoice(int invoiceId)
        {
            DAInvoice da = new DAInvoice();
            da.DeleteInvoice(invoiceId);
        }

        public void BLUpdateInvoice(int invoiceId, string invoiceNumber, DateTime invoiceDate, string observation, string clientName, string clientAddress)
        {
            DAInvoice da = new DAInvoice();
            da.UpdateInvoice(invoiceId, invoiceNumber, invoiceDate, observation, clientName, clientAddress);
        }
    }
}
