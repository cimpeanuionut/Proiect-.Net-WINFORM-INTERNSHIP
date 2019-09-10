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
    public class BLInvoiceDetail
    {
        public BLInvoiceDetail()
        {

        }        

        public void BLPrepareInvoiceDetail(BindingList<InvoiceDetailModel> listDetail)
        {
            DAInvoiceDetail da = new DAInvoiceDetail();
            da.PrepareInvoiceDetail(listDetail);            
        }

        public BindingList<InvoiceDetailModel> BLGetInvoiceDetail(int invoiceId, int? invoiceDetailId)
        {
            DAInvoiceDetail dac = new DAInvoiceDetail();
            DataTable dt = new DataTable();
            dt = dac.GetInvoiceDetail(invoiceId, invoiceDetailId);

            BindingList<InvoiceDetailModel> list = new BindingList<InvoiceDetailModel>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                InvoiceDetailModel detail = new InvoiceDetailModel();

                detail.invoiceDetailId = Convert.ToInt32(dt.Rows[i]["InvoiceDetailId"].ToString());
                detail.invoiceId = Convert.ToInt32(dt.Rows[i]["InvoiceId"].ToString());
                detail.itemId = Convert.ToInt32(dt.Rows[i]["itemId"].ToString());
                detail.itemName = dt.Rows[i]["ItemName"].ToString();
                detail.qtty = Convert.ToDecimal(dt.Rows[i]["Qtty"].ToString());
                detail.price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                detail.amount = Convert.ToDecimal(dt.Rows[i]["Amount"].ToString());
                detail.observation = dt.Rows[i]["Observation"].ToString();
                detail.status = 3;
                detail.unique = detail.RandomString(8);

                list.Add(detail);
            }

            return list;
        }   

        
    }
}
