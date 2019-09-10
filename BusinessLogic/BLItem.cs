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
    public class BLItem
    {
        public BLItem()
        {

        }

        public BindingList<ItemModel> BLGetItem()
        {
            DAItem dac = new DAItem();
            DataTable dt = new DataTable();
            dt = dac.GetItem();

            BindingList<ItemModel> list = new BindingList<ItemModel>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ItemModel item = new ItemModel();
                item.itemId = Convert.ToInt32(dt.Rows[i]["ItemId"].ToString());
                item.itemName = dt.Rows[i]["ItemName"].ToString();
                item.itemCode = dt.Rows[i]["ItemCode"].ToString();
                item.measuringUnitName = dt.Rows[i]["MeasuringUnitName"].ToString();
                item.itemDescription = dt.Rows[i]["ItemDescription"].ToString();
               

                list.Add(item);

            }

            return list;
        }
    }
}
